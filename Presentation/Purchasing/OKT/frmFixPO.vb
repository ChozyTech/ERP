﻿Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient

Public Class frmFixPO
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btncetak As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim ds As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, da3, da4, da8 As SqlDataAdapter
    Dim Buildernya, Buildernyb, Buildernyc As New SqlCommandBuilder
    Dim tgl As String
    Dim po As String
    Dim pr As String
    Dim supp As String
    Dim hh As Double
    Dim TemplatePur As String = "TemplatePur"

    Public Sub cetak_click()


        If txtNoPO.Text = "" Then
            MessageBox.Show("PO belum disimpan")
            Exit Sub
        End If
        callReport(App_Path() & "\report\rptPOM.rpt", "", "&no_po=" & Trim(txtNoPO.Text) & " &vnama_report=" & TemplatePur, False, False)
        'callReport(App_Path() & "\report\rptPOM.rpt", "", "no_po=" & Trim(txtNoPO.Text))
        'callReport(App_Path() & "\report\rptPOM.rpt", "", "no_po=" & Trim(txtNoPO.Text) & " &vnama_report=" & TemplatePur, False)
        Dim x As Int16

        If Not ds.Tables("PO") Is Nothing Then ds.Tables("PO").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & txtNoPO.Text & "'", sqlconn))
        da3.Fill(ds, "PO")



        ' If STATE = "EDIT" Then


        row = ds.Tables("PO").Rows(0)
        row.Item("sts_ctk_ulang") = "T"
        row.Item("jml_cetak") = row.Item("jml_cetak") + 1
        row.Item("tgl_cetak") = getTanggal()
        '  End If


        Buildernya = New SqlClient.SqlCommandBuilder(da3)
        da3.UpdateCommand = Buildernya.GetUpdateCommand()
        'da3.InsertCommand = Buildernya.GetInsertCommand()

        da3.Update(ds.Tables("PO"))

        ds.Tables("PO").AcceptChanges()
        If Not ds.Tables("PO") Is Nothing Then ds.Tables("PO").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & txtNoPO.Text & "'", sqlconn))
        da3.Fill(ds, "PO")
        row = ds.Tables("PO").Rows(0)
        If row.Item("sts_ctk_ulang") = "T" Then
            btncetak = False

        Else
            btncetak = True
        End If
        setStatus()


    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = False
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = False
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = False
        End With

    End Sub
    Public Sub add_click()
        STATE = "ADD"
        hh = 0
        View_PR_D()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        btncetak = True
        setStatus()
        Me.Enabled = True
        controlOff(False)
    End Sub

    Private Function NomorPO(ByVal bgtrans As SqlTransaction) As String
        Dim hasil, temp As String
        Dim sqldr As SqlDataReader = New SqlCommand("select max(substring(IsNULL(no_po,'00001'),1,5))+1 from PURC.DBO.PURC_PO", sqlconn, bgtrans).ExecuteReader
        sqldr.Read()
        temp = ""
        If TypeOf sqldr.Item(0) Is DBNull Then
            Dim bln1 As String = Format(Now, "MM")
            Dim th1 As String = Format(Now, "yyyy")
            hasil = "00001" & "/" & "PO" & "/" & th1 & bln1
        Else
            hasil = sqldr.Item(0)
            For i As Int16 = Len(hasil) To 4
                temp = "0" & temp
            Next
            Dim th, bln As String
            bln = Format(Now, "MM")
            th = Format(Now, "yyyy")
            hasil = temp & (hasil) & "/" & "PO" & "/" & th & bln
        End If
        sqldr.Close()
        Return hasil
    End Function

    Private Sub bersih()
        CEPPN.Checked = False
        dtBayar.DateTime = Date.Today
        dtKirim.DateTime = Date.Today
        dtTanggal.DateTime = Date.Today
        LEPR.Text = ""
        LESupllier.Text = ""

        txtkurs.EditValue = ""
        txtKeterangan.Text = ""
        txtTerm.Text = ""
        txtSubTotal.EditValue = vbNullString
        txtJmlDiskon1.EditValue = vbNullString
        txtJmlDiskon.EditValue = vbNullString
        txtJmlPPN.EditValue = vbNullString
        txtJmlTotal.EditValue = vbNullString
        txtNoRef.EditValue = vbNullString
        txtNoPO.EditValue = vbNullString
        txtstatus.EditValue = vbNullString

    End Sub

    Public Sub cancel_click()
        reload_table("XXX")
        bersih()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        btncetak = True
        setStatus()
        controlOff(True)
        Me.Enabled = False
    End Sub

    Private Sub Init_Bayar()
        If Not ds.Tables("View_Valuta") Is Nothing Then ds.Tables("View_Valuta").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data ,Desc_Data from sif.dbo.SIF_Gen_Reff_D WHERE Id_Ref_File='LMBYR'", sqlconn))
        DA.Fill(ds, "View_Valuta")
        RentangBayar.Properties.DataSource = ds.Tables("View_Valuta")
        RentangBayar.Properties.DisplayMember = "Desc_Data"
        RentangBayar.Properties.ValueMember = "Id_Data"
    End Sub

    Sub View_PR_D()
        'da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_pr from PURC.DBO.PURC_CHOICE_SUPP where status='APPROVE'", sqlconn))
        'da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_pr from PURC.DBO.PURC_PR_D where jns_dpm='MATERIAL'", sqlconn))
        If Not ds.Tables("View_PR_D") Is Nothing Then ds.Tables("View_PR_D").Clear()

        If STATE = "ADD" Then
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select DISTINCT PRD.no_pr, PRD.tgl_pr " & _
                                                                        "from PURC.dbo.PURC_PR_D PRD " & _
                                                                        "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr = CSP.no_pr " & _
                                                                        "and PRD.kd_stok=CSP.kd_stok " & _
                                                                        "where not csp.kd_supp_pilih is null and PRD.jns_dpm='MATERIAL' and CSP.rec_stat='APPROVE' " & _
                                                                        "and not EXISTS (select 1 from purc.dbo.purc_po a, purc.dbo.purc_po_d b " & _
                                                                        "where(a.no_po = b.no_po And PRD.no_pr = a.no_pr And PRD.kd_stok = b.kd_stok) " & _
                                                                        "and csp.kd_supp_pilih=a.kd_supplier)", sqlconn))
        ElseIf STATE = "EDIT" Then
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select DISTINCT PRD.no_pr, PRD.tgl_pr " & _
                                                                        "from PURC.dbo.PURC_PR_D PRD " & _
                                                                        "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr = CSP.no_pr and PRD.kd_stok=CSP.kd_stok " & _
                                                                        "left join PURC.dbo.PURC_PO PO on PRD.no_pr=PO.no_pr and CSP.kd_supp_pilih=PO.kd_supplier " & _
                                                                        "where PRD.jns_dpm='MATERIAL' and CSP.no_csp is not NULL and not(PO.no_po is NULL) and CSP.rec_stat='APPROVE' " & _
                                                                        "order by PRD.tgl_pr", sqlconn))
        End If

        DA.Fill(ds, "View_PR_D")
        LEPR.Properties.DataSource = ds.Tables("View_PR_D")
    End Sub

    Sub View_Valuta()
        If Not ds.Tables("valuta") Is Nothing Then ds.Tables("valuta").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.valuta,v.Nama_Valuta  from PURC.dbo.PURC_CHOICE_SUPP a " & _
            "left join PURC.dbo.PURC_CHOICE_SUPP_D b on (a.no_csp=b.no_csp) left join SIF.dbo.SIF_Valuta v on (v.kode_valuta=b.valuta) ", sqlconn))
        DA.Fill(ds, "valuta")
        LEValuta.Properties.DataSource = ds.Tables("valuta")

    End Sub

    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        View_PR_D()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_PO as [Nomor],tgl_PO as [Tanggal], rec_stat as Status from PURC.dbo.PURC_PO where status_po='PERBAIKAN' and isnull(no_posting,'')=''", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not ds.Tables("lookup_PO") Is Nothing Then ds.Tables("lookup_PO").Clear()
        DA.Fill(ds, "lookup_PO")
        frmCari.set_dso(ds.Tables("lookup_PO")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            reload_table(frmCari.row(0))
            btnSave = True
            btnadd = False
            btnEdit = True
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
            RentangBayar.Properties.ReadOnly = False
            CEPPN.Properties.ReadOnly = False
        
        Else
        cancel_click()
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim noPO As String

        If CEPPN.Checked = False Then
            hitung_total()

        End If

        If Not isDelete Then
            If LEPR.EditValue = "" Then
                MsgBox("No PR belum diisi", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                LEPR.Focus()
                Exit Sub
            End If

            If RentangBayar.EditValue = "" Then
                MsgBox("Rentang bayar belum diisi", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                RentangBayar.Focus()
                Exit Sub
            End If

            If LEValuta.EditValue = "" Then
                MsgBox("Valuta Belum Dipilih", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                LEValuta.Focus()
                Exit Sub
            End If

            If LEValuta.EditValue <> "IDR" Then
                If txtkurs.EditValue = "1" Then
                    MsgBox("Kurs Tidak Boleh 1", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                    LEValuta.Focus()
                    Exit Sub
                End If
            End If

            If txtkurs.Text < 1 Then
                MsgBox("Valuta termasuk valuta asing, apakah kurs sudah benar ?", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "PERINGATAN!")
                txtkurs.Focus()
                Exit Sub
            End If

            If STATE = "ADD" Then
                row = ds.Tables("PO").NewRow
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
            ElseIf STATE = "EDIT" Then
                row = ds.Tables("PO").Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
                row.Item("rec_stat") = "ENTRY"

            End If

            Dim jatuh_tempo As Date
            jatuh_tempo = DateAdd(DateInterval.Day, 30, dtTanggal.EditValue)

            row.Item("Kd_Cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
            'txtNoPO.Text = row.Item("no_po")
            row.Item("tipe_trans") = "JPP-KUT-01"
            row.Item("sts_ctk_ulang") = "Y"

            row.Item("tgl_po") = dtTanggal.EditValue
            row.Item("tgl_jth_tempo") = jatuh_tempo
            row.Item("jml_cetak") = 0
            row.Item("no_pr") = LEPR.EditValue
            row.Item("no_ref") = txtNoRef.Text
            row.Item("kd_supplier") = LESupllier.EditValue
            row.Item("kd_valuta") = LEValuta.EditValue
            row.Item("kurs_valuta") = txtkurs.Text
            row.Item("tgl_kirim") = dtKirim.EditValue
            row.Item("jml_rp_trans") = txtkurs.Text * txtSubTotal.Text
            row.Item("jml_val_trans") = txtSubTotal.Text
            row.Item("flag_ppn") = CEPPN.EditValue
            row.Item("jml_ppn") = txtJmlPPN.Text
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("qty_total") = txtJmlTotal.EditValue
            If STATE = "EDIT" Then
                row.Item("rec_stat") = "APPROVE"
            ElseIf STATE = "ADD" Then
                row.Item("rec_stat") = "ENTRY"
            End If

            txtstatus.Text = row.Item("rec_stat")
            row.Item("tgl_bayar") = dtBayar.EditValue
            row.Item("lama_bayar") = RentangBayar.EditValue
            row.Item("term_bayar") = txtTerm.Text
            row.Item("Program_Name") = Me.Name

            If STATE = "ADD" Then
                ds.Tables("PO").Rows.Add(row)
            End If

            For Each rows As DataRow In ds.Tables("POD").Select("qty=0")
                rows.Delete()
            Next

            For Each rows As DataRow In ds.Tables("POD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("no_po") = row.Item("no_po")
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username

                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("tipe_trans") = "JPP-KUT-01"

                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("tgl_kirim") = rows.Item("tgl_kirim")
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                End If

                rows.Item("Program_name") = Me.Name
            Next

            Dim i As Integer = 1

            For Each rows As DataRow In ds.Tables("POD").Rows
                If rows.RowState <> DataRowState.Deleted Then
                    rows.Item("no_seq") = i
                    i += 1
                End If
            Next

            For Each rows As DataRow In ds.Tables("PODAdd").Select("qty=0")
                rows.Delete()
            Next

            For Each rows As DataRow In ds.Tables("PODAdd").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("no_po") = row.Item("no_po")
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username

                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("tipe_trans") = "JPP-KUT-01"
                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("tgl_kirim") = rows.Item("tgl_kirim")
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                End If
                rows.Item("Program_name") = Me.Name
            Next

            Dim j As Integer = GV.RowCount + 1

            For Each rows As DataRow In ds.Tables("PODAdd").Rows
                If rows.RowState <> DataRowState.Deleted Then
                    rows.Item("no_seq") = i
                    j += 1
                End If
            Next
        End If
        Try


            Buildernya = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = Buildernya.GetUpdateCommand()
            da3.InsertCommand = Buildernya.GetInsertCommand()
            da3.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(da4)
            da4.UpdateCommand = Buildernya.GetUpdateCommand()
            da4.InsertCommand = Buildernya.GetInsertCommand()
            da4.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(da8)
            da8.UpdateCommand = Buildernya.GetUpdateCommand()
            da8.InsertCommand = Buildernya.GetInsertCommand()
            da8.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da4.UpdateCommand.Transaction = BTRANS
            da4.InsertCommand.Transaction = BTRANS
            da4.DeleteCommand.Transaction = BTRANS

            da8.UpdateCommand.Transaction = BTRANS
            da8.InsertCommand.Transaction = BTRANS
            da8.DeleteCommand.Transaction = BTRANS

            If STATE = "ADD" Then
                If CEPPN.Checked = True Then
                    row.Item("No_po") = getNoTrans("PO-MP", getTanggal(BTRANS), BTRANS)
                Else
                    row.Item("No_po") = getNoTrans("PO-MNP", getTanggal(BTRANS), BTRANS)
                End If
                txtNoPO.Text = row.Item("No_po")
                noPO = txtNoPO.Text
                For Each rows As DataRow In ds.Tables("POD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_po") = row.Item("No_po")
                    End If
                Next
                For Each rowx As DataRow In ds.Tables("PODAdd").Rows
                    If rowx.RowState = DataRowState.Added Then
                        rowx.Item("No_po") = row.Item("No_po")
                    End If
                Next
            End If


            da3.Update(ds.Tables("PO"))
            da4.Update(ds.Tables("POD"))
            da8.Update(ds.Tables("PODAdd"))

            ds.Tables("PO").AcceptChanges()
            ds.Tables("POD").AcceptChanges()
            ds.Tables("PODAdd").AcceptChanges()

            STATE = "EDIT"


            Dim sqldr As SqlDataReader = New SqlCommand("select max(tgl_kirim) from PURC.DBO.PURC_PO_D where no_po='" & txtNoPO.Text & "'", sqlconn, BTRANS).ExecuteReader
            sqldr.Read()
            If sqldr.HasRows Then tgl = Format(sqldr.Item(0), "dd/MM/yyyy").ToString
            sqldr.Close()
            Dim sqldrs As Integer = New SqlCommand("update PURC.dbo.PURC_PO SET tgl_kirim = CONVERT(DATE,'" & tgl & "',103) WHERE no_po='" & txtNoPO.Text & "'", sqlconn, BTRANS).ExecuteNonQuery
            BTRANS.Commit()
            controlOff(True)
            showMessages("Berhasil disimpan..")
            btnadd = True
            btnEdit = True
            btnSave = False
            btnDelete = False
            btnCancel = False
            setStatus()
        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            ds.Tables("PO").RejectChanges()
            ds.Tables("POD").RejectChanges()
            ds.Tables("PODAdd").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Private Sub controlOff(ByVal stat As Boolean)
        txtNoPO.Properties.ReadOnly = stat
        dtTanggal.Properties.ReadOnly = stat
        txtNoRef.Properties.ReadOnly = stat
        LEPR.Properties.ReadOnly = stat
        LESupllier.Properties.ReadOnly = stat


        dtKirim.Properties.ReadOnly = stat
        txtKeterangan.ReadOnly = stat
        txtstatus.Properties.ReadOnly = stat
        GV.OptionsBehavior.ReadOnly = stat
        gvAdd.OptionsBehavior.ReadOnly = stat
        RentangBayar.Properties.ReadOnly = stat
        dtBayar.Properties.ReadOnly = stat
        txtTerm.ReadOnly = stat
        CheckEdit1.Properties.ReadOnly = stat
        txtJmlDiskon.Properties.ReadOnly = stat
        txtJmlDiskon1.Properties.ReadOnly = stat
        txtSubTotal.Properties.ReadOnly = stat
        CEPPN.Properties.ReadOnly = stat
        txtJmlPPN.Properties.ReadOnly = stat
        txtJmlTotal.Properties.ReadOnly = stat
    End Sub

    Private Sub reload_table(ByVal kode As String)

        If Not ds.Tables("PO") Is Nothing Then ds.Tables("PO").Clear()
        If Not ds.Tables("POD") Is Nothing Then ds.Tables("POD").Clear()
        If Not ds.Tables("PODAdd") Is Nothing Then ds.Tables("PODAdd").Clear()

        GV.Columns("rec_stat").Visible = False
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & kode & "'", sqlconn))
        da3.Fill(ds, "PO")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * ,'' As No ,'' as no_pr,'' as Nama_Barang ,qty*harga as total from PURC.dbo.PURC_PO_D where no_po= '" & kode & "'", sqlconn))
        da4.Fill(ds, "POD")
        GC.DataSource = ds.Tables("POD")
        'AddHandler ds4.Tables("POD").RowDeleted, AddressOf refreshNomer

        da8 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * ,'' As No ,'' as no_pr,'' as Nama_Barang ,qty*harga as total from PURC.dbo.PURC_PO_D where no_po= '" & kode & "' AND flag_bonus = 'B'", sqlconn))
        da8.Fill(ds, "PODAdd")
        gcAdd.DataSource = ds.Tables("PODAdd")
        'AddHandler ds8.Tables("PODAdd").RowDeleted, AddressOf refreshNomerAdd

        'JPP-KUT-01'
        If ds.Tables("PO").Rows.Count > 0 Then
            Dim row As DataRow

            row = ds.Tables("PO").Rows(0)
            If row("sts_ctk_ulang") = "T" Then
                btncetak = False
                setStatus()
            Else
                btncetak = True
                setStatus()

            End If

            txtNoPO.Text = row.Item("no_po").ToString
            pr = row.Item("no_pr").ToString
            supp = row.Item("kd_supplier").ToString
            LEPR.EditValue = pr
            LEValuta.EditValue = row.Item("kd_valuta").ToString
            txtkurs.EditValue = row.Item("kurs_valuta").ToString
            'LESupllier.EditValue = supp
            txtNoRef.Text = row.Item("no_ref").ToString
            dtTanggal.EditValue = row.Item("tgl_po")
            dtKirim.Text = row.Item("tgl_kirim")
            dtBayar.Text = row.Item("tgl_bayar")
            RentangBayar.EditValue = CStr(row.Item("lama_bayar"))
            txtTerm.Text = row.Item("term_bayar").ToString
            txtKeterangan.Text = row.Item("keterangan").ToString
            txtstatus.Text = row.Item("rec_stat").ToString
            CEPPN.EditValue = row.Item("flag_ppn").ToString
            txtJmlPPN.EditValue = row.Item("jml_ppn").ToString
            'CheckEdit1.EditValue = row.Item("flag_diskon").ToString
            'txtJmlDiskon.Text = row.Item("prosen_diskon").ToString
            'txtJmlDiskon1.Text = row.Item("jml_diskon").ToString

            txtSubTotal.EditValue = row.Item("jml_val_trans")
            txtJmlTotal.EditValue = row.Item("qty_total")
            txtTotalRupiah.EditValue = row.Item("qty_total") * row.Item("kurs_valuta").ToString

            For Each rowx As DataRow In ds.Tables("POD").Rows
                rowx("kd_stok_lama") = rowx("kd_stok")
                rowx("qty_lama") = rowx("qty")
                rowx("harga_lama") = rowx("harga")
            Next
        End If

    End Sub

    Private Sub frmPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtKirim.Properties.MinValue = dtTanggal.EditValue
        'Reptglkirim.MinValue = Date.Today
        RepositoryItemDateEdit1.MinValue = Date.Today
        dtTanggal.DateTime = Date.Today
        dtKirim.DateTime = dtTanggal.EditValue
        dtBayar.DateTime = Date.Today

        txtkurs.Text = ""

        connect()

        prn = getParent(Me)


        'View_Valuta()
        'viewBarang()
        'View_PR_D()
        Init_Bayar()

        If Not ds.Tables("VBarangq") Is Nothing Then ds.Tables("VBarangq").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kode_Barang, Nama_Barang, Kd_Satuan FROM SIF.dbo.SIF_Barang", sqlconn))
        DA.Fill(ds, "VBarangq")
        repBrg.DataSource = ds.Tables("VBarangq")

        'dtTanggal.Text = Date.Today
        'V_Supplier()
        If txtNoPO.Text = "" Then
            reload_table("xxx")
            GC.DataSource = ds.Tables("POD")
        End If

    End Sub

    Private Sub viewBarang(ByVal supp As String)
        If Not ds.Tables("VBarang") Is Nothing Then ds.Tables("VBarang").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT a.kd_stok, b.Nama_Barang FROM PURC.dbo.PURC_CHOICE_SUPP a, SIF.dbo.SIF_Barang b WHERE a.kd_stok=b.Kode_Barang AND kd_supp_pilih = '" & supp & "'", sqlconn))
        DA.Fill(ds, "VBarang")
        RepositoryItemLookUpEdit1.DataSource = ds.Tables("VBarang")
        RepositoryItemLookUpEdit1.ValueMember = "kd_stok"
        RepositoryItemLookUpEdit1.DisplayMember = "Nama_Barang"
    End Sub

    Public Sub cariPO(ByVal nocsp As String) ' ============= cretaed by yaya =============
        STATE = "EDIT"
        View_PR_D()
        If Not ds.Tables("_yaya") Is Nothing Then ds.Tables("_yaya").Clear()
        DA = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & nocsp & "'", sqlconn))
        DA.Fill(ds, "_yaya")
        'MsgBox(dss.Tables(0).Rows(0).Item("no_po").ToString)
        If ds.Tables("_yaya").Rows.Count Then
            'txtNoPO.Text = dss.Tables(0).Rows(0).Item("no_po").ToString
            'txtstatus.Text = dss.Tables(0).Rows(0).Item("rec_stat").ToString
            'dtTanggal.Text = dss.Tables(0).Rows(0).Item("tgl_po").ToString
            'LEPR.EditValue = dss.Tables(0).Rows(0).Item("no_pr").ToString
            'LESupllier.EditValue = dss.Tables(0).Rows(0).Item("kd_supplier").ToString
            'LEValuta.EditValue = dss.Tables(0).Rows(0).Item("kd_valuta").ToString
            'txtKeterangan.Text = dss.Tables(0).Rows(0).Item("keterangan").ToString
            row = ds.Tables("_yaya")(0)
            txtNoPO.Text = row.Item("no_po").ToString
            supp = row.Item("kd_supplier").ToString
            LEPR.EditValue = row.Item("no_pr").ToString
            LEValuta.EditValue = row.Item("kd_valuta").ToString
            txtkurs.EditValue = row.Item("kurs_valuta").ToString
            LESupllier.EditValue = supp
            txtNoRef.Text = row.Item("no_ref").ToString
            dtTanggal.Text = row.Item("tgl_po")
            dtKirim.Text = row.Item("tgl_kirim")
            dtBayar.Text = row.Item("tgl_bayar")
            RentangBayar.EditValue = row.Item("lama_bayar")
            txtTerm.Text = row.Item("term_bayar").ToString
            txtKeterangan.Text = row.Item("keterangan").ToString
            txtstatus.Text = row.Item("rec_stat").ToString
            CEPPN.EditValue = row.Item("flag_ppn").ToString
            txtJmlPPN.EditValue = row.Item("jml_ppn").ToString
            'CheckEdit1.EditValue = row.Item("flag_diskon").ToString
            'txtJmlDiskon.Text = row.Item("prosen_diskon").ToString
            'txtJmlDiskon1.Text = row.Item("jml_diskon").ToString
            txtSubTotal.EditValue = row.Item("jml_val_trans")
            txtJmlTotal.EditValue = row.Item("qty_total")

        End If
        If Not ds.Tables("_yaya_d") Is Nothing Then ds.Tables("_yaya_d").Clear()
        DA = New SqlDataAdapter(New SqlCommand("select * from PURC.DBO.PURC_PO_D where no_po='" & nocsp & "'", sqlconn))
        DA.Fill(ds, "_yaya_d")
        GC.DataSource = ds.Tables("_yaya_d")

        controlOff(True)
    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        save_click()
    End Sub

    Private Sub V_Supplier()
        If Not ds.Tables("View_Supplier") Is Nothing Then ds.Tables("View_Supplier").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Supplier,Nama_Supplier from sif.dbo.SIF_Supplier", sqlconn))
        DA.Fill(ds, "View_Supplier")
        LESupllier.Properties.DataSource = ds.Tables("View_Supplier")
    End Sub

    Private Sub V_Supplier2() 'filter berdasarkan PR
        If Not ds.Tables("View_Supplier") Is Nothing Then ds.Tables("View_Supplier").Clear()
        'LESupllier.EditValue = vbNullString
        'da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct Kode_Supplier,Nama_Supplier from sif.dbo.SIF_Supplier s,PURC.DBO.PURC_CHOICE_SUPP csp where kode_supplier=kd_supp_pilih and no_pr='" & LEPR.EditValue & "'and csp.rec_stat ='APPROVE'", sqlconn))

        If STATE = "ADD" Then
            DA = New SqlDataAdapter(New SqlCommand("select DISTINCT sup.Kode_Supplier,sup.Nama_Supplier " & _
                                                    "from SIF.dbo.SIF_Supplier sup, PURC.dbo.PURC_PR_D PRD " & _
                                                    "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr = CSP.no_pr " & _
                                                    "and PRD.kd_stok=CSP.kd_stok " & _
                                                    "where not csp.kd_supp_pilih is null and PRD.jns_dpm='MATERIAL' and CSP.rec_stat='APPROVE' " & _
                                                    "and not EXISTS (select 1 from purc.dbo.purc_po a, purc.dbo.purc_po_d b " & _
                                                    "where(a.no_po = b.no_po And PRD.no_pr = a.no_pr And PRD.kd_stok = b.kd_stok) " & _
                                                    "and csp.kd_supp_pilih=a.kd_supplier) " & _
                                                    "and PRD.no_pr='" & LEPR.EditValue & "'" & _
                                                    "and sup.Kode_Supplier=csp.kd_supp_pilih", sqlconn))
        ElseIf STATE = "EDIT" Then
            DA = New SqlDataAdapter(New SqlCommand("select distinct sup.Kode_Supplier,sup.Nama_Supplier from PURC.dbo.PURC_CHOICE_SUPP csp " & _
                                                    "left join SIF.dbo.SIF_Supplier sup on csp.kd_supp_pilih=sup.Kode_Supplier " & _
                                                    "left join PURC.dbo.PURC_PO po on csp.no_pr = po.no_pr and csp.kd_supp_pilih=po.kd_supplier " & _
                                                    "where csp.no_pr='" & LEPR.EditValue & "' and not(po.no_po is NULL)", sqlconn))
        End If
        DA.Fill(ds, "View_Supplier")
        LESupllier.Properties.DataSource = ds.Tables("View_Supplier")
    End Sub

    Private Sub LEPR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEPR.EditValueChanged
        If STATE = "ADD" Then

            Dim dr As SqlDataReader = New SqlCommand("select distinct c.kd_supp_pilih from PURC.dbo.PURC_CHOICE_SUPP c " & _
                                                     "where c.no_pr='" & LEPR.EditValue & "'" & _
                                                     "and  not EXISTS (select 1 from PURC.dbo.purc_po a, PURC.dbo.PURC_PO_D b where a.no_po = b.no_po  " & _
                                                     "and a.no_pr ='' and kd_supplier=c.kd_supp_pilih and b.kd_stok=c.kd_stok)", sqlconn).ExecuteReader

            '"where csp.no_pr='" & LEPR.EditValue & "' and po.no_po is NULL", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                V_Supplier2()
                LESupllier.EditValue = dr.Item(0)
            Else
                If Not ds.Tables("View_Supplier") Is Nothing Then ds.Tables("View_Supplier").Clear()
                LESupllier.EditValue = vbNullString

            End If

            dr.Close()

            If Not ds.Tables("valuta") Is Nothing Then ds.Tables("valuta").Clear()
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct b.valuta,v.Nama_Valuta  from PURC.dbo.PURC_CHOICE_SUPP a " & _
                "left join PURC.dbo.PURC_CHOICE_SUPP_D b on (a.no_csp=b.no_csp) left join SIF.dbo.SIF_Valuta v on (v.kode_valuta=b.valuta) where a.no_pr= '" & LEPR.EditValue & "' and a.kd_supp_pilih='" & LESupllier.EditValue & "' ", sqlconn))
            DA.Fill(ds, "valuta")
            LEValuta.Properties.DataSource = ds.Tables("valuta")
            LEValuta.Properties.ValueMember = "valuta"
            LEValuta.Properties.DisplayMember = "Nama_Valuta"
            Dim row1 As DataRow
            row1 = ds.Tables("valuta").Rows(0)
            LEValuta.EditValue = row1.Item("valuta")
        ElseIf STATE = "EDIT" Then
            'LEPR.EditValue = pr

            Dim dr As SqlDataReader = New SqlCommand("select distinct csp.kd_supp_pilih,po.kd_valuta from PURC.dbo.PURC_CHOICE_SUPP csp " & _
                                                     "left join SIF.dbo.SIF_Supplier sup on csp.kd_supp_pilih=sup.Kode_Supplier " & _
                                                     "left join PURC.dbo.PURC_PO po on csp.no_pr = po.no_pr and csp.kd_supp_pilih=po.kd_supplier " & _
                                                     "where csp.no_pr='" & LEPR.EditValue & "' and not(po.no_po is NULL)", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                V_Supplier2()
                LESupllier.EditValue = supp

            Else
                If Not ds.Tables("View_Supplier") Is Nothing Then ds.Tables("View_Supplier").Clear()
                LESupllier.EditValue = vbNullString

            End If
            dr.Close()

            LEValuta.Enabled = True
            LEValuta.Properties.ReadOnly = False
            If Not ds.Tables("valuta") Is Nothing Then ds.Tables("valuta").Clear()
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct a.no_pr,b.valuta,v.Nama_Valuta  from " & _
                "PURC.dbo.PURC_CHOICE_SUPP_D b  left join SIF.dbo.SIF_Valuta v on (v.kode_valuta=b.valuta) left join PURC.dbo.PURC_CHOICE_SUPP c on (c.no_csp=b.no_csp) left join PURC.dbo.PURC_PO a on (a.no_pr=c.no_pr) where a.no_pr= '" & LEPR.EditValue & "' and b.kd_supplier='" & LESupllier.EditValue & "'", sqlconn))
            DA.Fill(ds, "valuta")


            Dim rowc As DataRow
            LEValuta.Properties.DataSource = ds.Tables("valuta")
            LEValuta.Properties.ValueMember = "valuta"
            LEValuta.Properties.DisplayMember = "Nama_Valuta"
            rowc = ds.Tables("valuta").Rows(0)
            LEValuta.EditValue = rowc.Item("valuta")
        End If


    End Sub

    Private Sub LESupllier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LESupllier.EditValueChanged

        If LESupllier.Text = "" Then
            If Not ds.Tables("POD") Is Nothing Then ds.Tables("POD").Clear()
            Exit Sub
        End If
        If txtNoPO.Text = "" Then
            ds.Tables("POD").Clear()
            'Dim dr As SqlDataReader = New SqlCommand(" select *,0 as prosen_diskon,0 as jml_diskon  from PURC.dbo.vBarangSuplierTerpilih where kd_supp_pilih='" & LESupllier.EditValue & "' and no_pr='" & LEPR.EditValue & "' and rec_stat='APPROVE'", sqlconn).ExecuteReader
            Dim dr As SqlDataReader = New SqlCommand("select *,0 as prosen_diskon,0 as jml_diskon " & _
                                                    "from  PURC.dbo.vBarangSuplierTerpilih " & _
                                                    "where kd_supp_pilih='" & LESupllier.EditValue & "' " & _
                                                    "and no_pr='" & LEPR.EditValue & "' " & _
                                                    "and rec_stat='APPROVE' " & _
                                                    "and kd_stok in( " & _
                                                    "Select PRD.kd_stok " & _
                                                    "from PURC.dbo.PURC_PR_D PRD " & _
                                                    "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr = CSP.no_pr " & _
                                                    "and PRD.kd_stok=CSP.kd_stok " & _
                                                    "where not csp.kd_supp_pilih is null and PRD.jns_dpm='MATERIAL' and CSP.rec_stat='APPROVE' " & _
                                                    "and not EXISTS (select 1 from purc.dbo.purc_po a, purc.dbo.purc_po_d b " & _
                                                    "where(a.no_po = b.no_po And PRD.no_pr = a.no_pr And PRD.kd_stok = b.kd_stok) " & _
                                                    "and csp.kd_supp_pilih=a.kd_supplier) " & _
                                                    "and PRD.no_pr='" & LEPR.EditValue & "' and csp.kd_supp_pilih='" & LESupllier.EditValue & "') ", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            While dr.Read
                Dim rw As DataRow = ds.Tables("POD").NewRow
                rw.Item("no_pr") = dr.Item("no_pr")
                rw.Item("kd_stok") = dr.Item("kd_stok")
                rw.Item("Nama_Barang") = dr.Item("Nama_Barang")
                rw.Item("kd_satuan") = dr.Item("kd_satuan")
                rw.Item("harga") = dr.Item("harga_baru")
                rw.Item("qty") = dr.Item("qty")
                'rw.Item("flag_diskon") = dr.Item("flag_diskon").ToString
                rw.Item("prosen_diskon") = dr.Item("prosen_diskon")
                'rw.Item("prosen_diskon") = CType(dr.Item("prosen_diskon"), Double).ToString
                rw.Item("jml_diskon") = dr.Item("jml_diskon")
                rw.Item("total") = dr.Item("total")
                rw.Item("keterangan") = dr.Item("Nama_Barang") & " " & dr.Item("Keterangan")
                rw.Item("no_seq") = i
                i += 1
                ds.Tables("POD").Rows.Add(rw)
            End While
            dr.Close()

            If Not ds.Tables("csp") Is Nothing Then ds.Tables("csp").Clear()
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.pnp  from PURC.dbo.PURC_CHOICE_SUPP a " & _
                "left join PURC.dbo.PURC_CHOICE_SUPP_D b on (a.no_csp=b.no_csp) where a.no_pr= '" & LEPR.EditValue & "' and a.kd_supp_pilih = '" & LESupllier.EditValue & "' ", sqlconn))
            DA.Fill(ds, "csp")
            Dim rowc As DataRow
            rowc = ds.Tables("csp").Rows(0)
            ' MsgBox(rowc.Item("pnp").ToString, MsgBoxStyle.Information)
            If rowc.Item("pnp").ToString = "True" Then
                hh = GV.Columns("total").SummaryText / 1.1
                txtSubTotal.EditValue = hh
                CEPPN.Checked = True
                ' If rowc.Item("pnp").ToString = "False" Then
            Else
                hh = GV.Columns("total").SummaryText
                txtSubTotal.EditValue = hh
            End If
            hitung_total()
            View_Valuta()
        End If

    End Sub

    Private Sub CEPPN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPN.CheckedChanged
        If txtSubTotal.Text = "" Or txtSubTotal.Text = "0" Then
            'MsgBox("Sub Total Masih Kosong,Silahkan Lakukan Transaksi ", MsgBoxStyle.Information, "Perhatian")
            Exit Sub
        Else
            hitung_total()
        End If

    End Sub
    Function getTotal() As Double
        Dim ttl As Double

        For Each rw As DataRow In ds.Tables("POD").Rows
            If TypeOf rw.Item("qty") Is DBNull Or rw.Item("qty") = 0 Then
                'MsgBox("QTY Masih Kosong, Harap diisi", MsgBoxStyle.Information)
                rw.Item("qty") = 0
                'Exit Function
            ElseIf TypeOf rw.Item("total") Is DBNull Then
                MsgBox(rw("total").ToString, MsgBoxStyle.OkOnly)
                'Else
                '    ttl += CDbl(rw("total"))
            End If
            If Not ds.Tables("csp") Is Nothing Then ds.Tables("csp").Clear()
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.pnp  from PURC.dbo.PURC_CHOICE_SUPP a " & _
                "left join PURC.dbo.PURC_CHOICE_SUPP_D b on (a.no_csp=b.no_csp) where a.no_pr= '" & LEPR.EditValue & "' and a.kd_supp_pilih = '" & LESupllier.EditValue & "' ", sqlconn))
            DA.Fill(ds, "csp")
            Dim rowc As DataRow
            rowc = ds.Tables("csp").Rows(0)
            ' MsgBox(rowc.Item("pnp").ToString, MsgBoxStyle.Information)
            If rowc.Item("pnp").ToString = "True" Then
                ttl += CDbl(rw("total")) / 1.1
                CEPPN.Checked = True
                ' If rowc.Item("pnp").ToString = "False" Then
            Else
                ttl += CDbl(rw("total"))
            End If

        Next
        Return ttl
    End Function

    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If STATE = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In ds.Tables("POD").Select("NO=" & rw.Item("No_seq"))

                    rwd("NO") = i
                    rwd("No_seq") = i & "." & j
                    j += 1
                Next
                j = 1
                rw("No_seq") = i
                i += 1
            End If
        Next
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data PO ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not ds.Tables("PO") Is Nothing Then delete(ds.Tables("PO").Rows)
            If Not ds.Tables("POD") Is Nothing Then delete(ds.Tables("POD").Rows)


            save_click(True)
            'getTotal()
            cancel_click()
            STATE = ""
        End If
    End Sub

    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar DPM") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Private Sub GV_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GV.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        GV.GetRow(e.RowHandle).item("harga") = 0
        GV.GetRow(e.RowHandle).item("qty") = 1
        GV.GetRow(e.RowHandle).item("prosen_diskon") = 0
        GV.GetRow(e.RowHandle).item("jml_diskon") = 0
        GV.GetRow(e.RowHandle).item("total") = 0
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is kd_stok Then
            Dim rw As DataRow
            rw = ds.Tables("VBarangq").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("kd_satuan") = rw("Kd_Satuan")
        End If
        If STATE = "EDIT" Then
            If e.Column Is tglkirim Then
                If Not RentangBayar.EditValue = "0" Then
                    dtBayar.DateTime = dtKirim.DateTime.AddDays(RentangBayar.EditValue * 7)
                Else
                    dtBayar.EditValue = dtTanggal.EditValue
                End If
            End If
        End If
        Dim hasilX, hasilY As Double
        If e.Column Is harga Or e.Column Is qty Then
            If GV.GetRow(e.RowHandle).item("qty").ToString = "" Then
                GV.SetRowCellValue(e.RowHandle, "qty", 0)
            End If
            Dim subharga As Decimal = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString

            If GV.GetRow(e.RowHandle).item("prosen_diskon") = 0 Then
                GV.GetRow(e.RowHandle).item("jml_diskon") = subharga.ToString * (GV.GetRow(e.RowHandle).item("prosen_diskon") / 100).ToString
                GV.GetRow(e.RowHandle).item("total") = subharga.ToString - GV.GetRow(e.RowHandle).item("jml_diskon").ToString
            Else
                GV.GetRow(e.RowHandle).item("total") = subharga.ToString - GV.GetRow(e.RowHandle).item("jml_diskon").ToString
            End If
        End If

        If e.Column Is prosen_diskon Then
            GV.GetRow(e.RowHandle).item("jml_diskon") = 0
            hasilX = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
            GV.GetRow(e.RowHandle).item("jml_diskon") = hasilX.ToString * (GV.GetRow(e.RowHandle).item("prosen_diskon") / 100).ToString
            GV.GetRow(e.RowHandle).item("total") = hasilX.ToString - GV.GetRow(e.RowHandle).item("jml_diskon").ToString
        End If

        If e.Column Is jml_diskon Then
            GV.GetRow(e.RowHandle).item("prosen_diskon") = 0
            hasilY = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
            GV.GetRow(e.RowHandle).item("total") = hasilY.ToString - GV.GetRow(e.RowHandle).item("jml_diskon").ToString
        End If
        txtSubTotal.EditValue = getTotal()
    End Sub

    Sub Ubah_Diskon()
        If CheckEdit1.Checked = True Then
            CheckEdit1.Text = "DISKON %"
            txtJmlDiskon.Properties.ReadOnly = False
            txtJmlDiskon1.Properties.ReadOnly = True
            txtJmlDiskon.Text = ""
            txtJmlDiskon1.Text = ""
            txtJmlDiskon1.EditValue = 0
            txtJmlDiskon.Focus()

        Else
            CheckEdit1.Text = "DISKON RP"
            txtJmlDiskon.Properties.ReadOnly = True
            txtJmlDiskon1.Properties.ReadOnly = False
            txtJmlDiskon.Text = ""
            txtJmlDiskon.EditValue = 0
            txtJmlDiskon1.Text = ""
            txtJmlDiskon1.Focus()

        End If
    End Sub

    Sub hitung_total()
        If CEPPN.Checked = True Then
            CEPPN.Text = "PPN"

            txtJmlPPN.EditValue = (txtSubTotal.EditValue - txtJmlDiskon1.EditValue) * (10 / 100)
        Else

            CEPPN.Text = "NON PPN"

            txtJmlPPN.EditValue = 0

        End If

        txtJmlTotal.EditValue = Val(Val(txtSubTotal.EditValue - Val(txtJmlDiskon1.EditValue))) + Val(txtJmlPPN.EditValue)
        txtTotalRupiah.EditValue = Val(Val(txtJmlTotal.EditValue) * Val(txtkurs.EditValue))
    End Sub

    Private Sub txtSubTotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubTotal.EditValueChanged
        hitung_total()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        Ubah_Diskon()
    End Sub

    Private Sub txtJmlDiskon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtJmlDiskon1.EditValue = txtSubTotal.EditValue * (txtJmlDiskon.EditValue / 100)
            hitung_total()
        End If
    End Sub

    Private Sub txtJmlDiskon1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlDiskon1.KeyPress
        If e.KeyChar = Chr(13) Then
            txtJmlDiskon1.EditValue = txtSubTotal.EditValue - txtJmlDiskon1.EditValue
            hitung_total()
        End If
    End Sub

    Private Sub dtKirim_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtKirim.EditValueChanged
        dtBayar.DateTime = dtKirim.DateTime.AddDays(RentangBayar.EditValue * 7)
    End Sub

    Private Sub RentangBayar_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentangBayar.EditValueChanged
        If Not RentangBayar.EditValue = "0" Then
            dtBayar.DateTime = dtKirim.DateTime.AddDays(RentangBayar.EditValue * 7)
        Else
            dtBayar.EditValue = dtTanggal.EditValue
        End If
    End Sub

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        Dim vx As GridView = sender
        If vx.FocusedColumn.FieldName = "prosen_diskon" Then
            If e.Value > 100 Then
                e.Valid = False
                e.ErrorText = "Diskon % tidak boleh lebih dari 100"
            End If
        End If
    End Sub

    Private Sub gvAdd_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvAdd.CellValueChanged
        Dim vx As GridView = gvAdd
        If e.Column Is addNama Then
            Dim drx As SqlDataReader = New SqlCommand(" select Kd_Satuan from SIF.dbo.SIF_Barang where Kode_Barang='" & vx.GetRowCellValue(e.RowHandle, "kd_stok").ToString & "'", sqlconn).ExecuteReader
            drx.Read()
            vx.SetRowCellValue(e.RowHandle, "kd_satuan", drx.Item(0))
            drx.Close()
        End If
    End Sub

    Private Sub gvAdd_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvAdd.InitNewRow
        gvAdd.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        If gvAdd.RowCount = 0 Then
            gvAdd.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        Else
            gvAdd.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + gvAdd.RowCount
        End If
        gvAdd.GetRow(e.RowHandle).item("harga") = 0
        gvAdd.GetRow(e.RowHandle).item("qty") = 1
        gvAdd.GetRow(e.RowHandle).item("prosen_diskon") = 0
        gvAdd.GetRow(e.RowHandle).item("jml_diskon") = 0
        gvAdd.GetRow(e.RowHandle).item("total") = 0
        gvAdd.GetRow(e.RowHandle).item("flag_bonus") = "B"
    End Sub

    Private Sub dtTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTanggal.EditValueChanged
        dtKirim.Properties.MinValue = dtTanggal.EditValue
        dtKirim.EditValue = dtTanggal.EditValue
    End Sub

    Private Sub txtAngka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAngka.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
                'Case 32, 8, 46, 40, 41, 43
                '    e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub RepositoryItemLookUpEdit1_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit1.QueryPopUp
        viewBarang(LESupllier.EditValue)
    End Sub

    Private Sub LEValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEValuta.EditValueChanged
        If LEValuta.EditValue = "IDR" Then
            txtkurs.Text = "1"
        Else
            txtkurs.Text = 0
        End If
    End Sub
End Class