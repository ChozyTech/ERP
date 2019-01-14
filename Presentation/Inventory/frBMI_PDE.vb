﻿'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frBMI_PDE
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Private thn As String = getTanggal.Year
    Private bln As String = getTanggal.Month
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, notrans As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, dso2, ds_cari, ds_cari1 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DA3, DALOOKUP, DALOOKUP1 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    'Public Sub btnstart()
    '    btnTambah.Enabled = True
    '    btnUbah.Enabled = True
    '    btnSimpan.Enabled = False
    '    btnHapus.Enabled = False
    'End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub save_click()
        If LookupGudang.EditValue = vbNullString Then
            MsgBox("Gudang Tujuan belum di Set!", MsgBoxStyle.Critical, " Lengkapi data sebelum menyimpan!")
            Exit Sub
        End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub cancel_click()
        LoadStruktur("XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        bersihkan()
    End Sub
    Public Sub edit_click()
        'enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.DBO.INV_GUDANG_IN where substring((no_trans),8,3)='BMI'", sqlconn)) '
        If Not dSO.Tables("lookup_bmi") Is Nothing Then dSO.Tables("lookup_bmi").Clear()
        DA.Fill(dSO, "lookup_bmi")
        frmCari.set_dso(dSO.Tables("lookup_bmi")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            LoadStruktur(frmCari.row(1))
            STATE = "EDIT"
            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True

        Else
            cancel_click()
            STATE = ""
        End If
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction


        'STATE = "ADD"
        If STATE = "ADD" Then
            row = dSO.Tables("_bmi").NewRow
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_bmi").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener

        row.Item("no_trans") = getNoTrans("BMI", getTanggal())
        row.Item("tipe_trans") = "JPP-KUT-02"
        row.Item("tgl_trans") = getTanggal()
        row.Item("jml_rp_trans") = GvBKI_d.Columns(4).SummaryItem.SummaryValue
        'row.Item("no_spm") = LookupSPM.Text
        row.Item("kode_gudang") = LookupGudang.EditValue
        'row.Item("Rec_Stat") = IIf(cbStat.Text = "AKTIF", "Y", "T")
        row.Item("blthn") = blthn()
        row.Item("Program_Name") = Me.Name
        'txbNoTrans.Text = row.Item("no_trans")
        If STATE = "ADD" Then
            dSO.Tables("_bmi").Rows.Add(row)
        End If
        For Each row1 As DataRow In dSO1.Tables("_bmi_d").Rows
            If row1.RowState = DataRowState.Added Then
                row1.Item("no_trans") = row.Item("no_trans")
                row1.Item("tipe_trans") = row.Item("tipe_trans")
                row1.Item("Last_Create_Date") = getTanggal()
                row1.Item("Last_Created_By") = username
                row1.Item("kd_Cabang") = kdcabang
            Else
                row1.Item("Last_Update_Date") = getTanggal()
                row1.Item("Last_Updated_By") = username
            End If
            row1.Item("Program_name") = Me.Name

        Next
        'txbNoTrans.Text = row.Item("no_trans")



        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            DA2.InsertCommand = Buildernya.GetInsertCommand()
            DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            If STATE = "ADD" Then
                row.Item("no_trans") = getNoTrans("BMI", getTanggal(BTRANS), BTRANS)
                notrans = row.Item("no_trans")
                For Each row1 As DataRow In dSO1.Tables("_bmi_d").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If


            DA.Update(dSO.Tables("_bmi"))
            DA2.Update(dSO1.Tables("_bmi_d"))
            'sp1
            For Each row1 As DataRow In dSO1.Tables("_bmi_d").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
                    setor_prosedur(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row("kode_gudang").ToString, row1("qty_in"), BTRANS)
                End If
            Next
            ' ## sp 2
            For Each row1 As DataRow In dSO1.Tables("_bmi_d").Rows
                If STATE = "ADD" Then
                    'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
                    setor_prosedur2(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_in"), row1("rp_trans"), BTRANS)
                End If
            Next

            'dSO.Tables("_bmi").AcceptChanges()
            'dSO1.Tables("_bmi_d").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_bmi").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\BMI.rpt", "", "notrans_bmi=" & notrans)
    End Sub

    Public Sub hapus_record()

    End Sub

    Public Sub setor_prosedur(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kode_gudangx As String, ByVal qty_inx As Integer, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang_in"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 30).Value = kode_gudangx
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Int).Value = qty_inx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub setor_prosedur2(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal qty_inx As Integer, ByVal rpnilai As Decimal, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_in"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@onstok_in", SqlDbType.Int).Value = qty_inx
        sqlCmd.Parameters.Add("@vnilai", SqlDbType.Decimal, 30).Value = rpnilai
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Function blthn(Optional ByVal btrans As Object = Nothing) As String
        Dim hasil As String
        Dim sqlblth As SqlDataReader
        If btrans Is Nothing Then
            'blthn=082011
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
            '##blthn=201108
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6) as blthn", sqlconn, btrans).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function

    Private Sub frBMI_PDE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'disabel()
        connect()

        GvBKI_d.Columns("rp_trans").Visible = False
        prn = getParent(Me)
        'btnhide()
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'btnSimpan.Hide()
        'btnExit.Hide()

        LoadStruktur("xxxx")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RepLookupBarang.DataSource = ds_cari.Tables("_lookup1")
        RepLookupBarang.ValueMember = "Kode_Barang"
        RepLookupBarang.DisplayMember = "Nama_Barang"


        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup2")
        LookupGudang.Properties.DataSource = ds_cari1.Tables("_lookup2")
        LookupGudang.Properties.ValueMember = "Kode_Gudang"
        LookupGudang.Properties.DisplayMember = "Nama_Gudang"
    End Sub
    Private Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_bmi") Is Nothing Then dSO.Tables("_bmi").Clear()
        If Not dSO1.Tables("_bmi_d") Is Nothing Then dSO1.Tables("_bmi_d").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_IN where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_bmi")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_GUDANG_IN_D where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_bmi_d")
        GcBKI_d.DataSource = dSO1.Tables("_bmi_d")

        If dSO.Tables("_bmi").Rows.Count > 0 Then
            Dim rw As DataRow = dSO.Tables("_bmi").Rows(0)
            notrans = rw("no_trans").ToString
            'dtpTgl.EditValue = rw("tgl_trans").ToString
            LookupGudang.EditValue = rw("kode_gudang").ToString
            'TxbReff.Text = rw("no_spm").ToString
        End If
    End Sub


    Private Sub txbKdBrg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbKdBrg.KeyPress
        Dim ok As Boolean = False
        'Dim dtrow() As DataRow
        If e.KeyChar = Chr(13) Then

            'Dim sqlread As SqlDataReader = New SqlCommand("select hpp.kd_bom as kode_barang,sum(hpp.nilai_biaya) as harga,brg.Kd_Satuan,brg.rek_persediaan,brg.rek_biaya,0 as qty_in  from   PROD.dbo.PROD_hpp_bahan as hpp join SIF.dbo.SIF_Barang as brg on hpp.kd_bom=brg.Kode_Barang  where brg.Kode_Barang ='" & TxbBarcode.Text & "' group by hpp.kd_bom,brg.Kode_Barang,brg.Kd_Satuan,brg.rek_persediaan,brg.rek_biaya", sqlconn).ExecuteReader
            Dim sqlread As SqlDataReader = New SqlCommand("select brg.Kode_Barang,brg.Kd_Satuan,brg.rek_persediaan,brg.rek_biaya,0 as qty_in,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.Kode_Barang ='" & txbKdBrg.Text & "'", sqlconn).ExecuteReader
            If sqlread.Read Then
                Dim dtrow() As DataRow = dSO1.Tables("_bmi_d").Select("kd_stok='" & txbKdBrg.Text & "'")
                'lblNmBrg.ForeColor = Color.Yellow
                'lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                If dtrow.Count = 0 Then
                    Dim rw As DataRow = dSO1.Tables("_bmi_d").NewRow
                    rw.Item("no_seq") = x : x += 1
                    rw.Item("kd_stok") = sqlread.Item("Kode_Barang")
                    rw.Item("kd_satuan") = sqlread.Item("Kd_Satuan")
                    rw.Item("kd_buku_besar") = sqlread.Item("rek_persediaan")
                    rw.Item("kd_buku_biaya") = sqlread.Item("rek_biaya")
                    rw.Item("qty_in") = sqlread.Item("qty_in") + 1
                    rw.Item("harga") = sqlread.Item("harga")
                    rw.Item("rp_trans") = rw("harga") * rw("qty_in")
                    dSO1.Tables("_bmi_d").Rows.Add(rw)
                Else
                    For i As Int16 = 0 To dtrow.Count - 1
                        Application.DoEvents()
                        'lblStatus.Text = "OK"
                        'lblNmBrg.Text = dtrow(i)("kd_stok").ToString
                        txbKdBrg.SelectAll()
                        'If dtrow(i)("qty_ord") > dtrow(i)("qty_in") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                        'If dtrow.Count > 0 Then
                        dtrow(i)("qty_in") = dtrow(i)("qty_in") + 1
                        dtrow(i)("rp_trans") = dtrow(i)("qty_in") * dtrow(i)("harga")

                        'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
                        ok = True
                        'BindingContext(GcBKI_d.DataSource).Position = getPosisi(dtrow(i))
                        tunda()
                        txbKdBrg.Text = ""
                        'lblNmBrg.Text = ""
                        'lblStatus.Text = ""
                        txbKdBrg.Focus()
                        'MsgBox("barang ada")
                        'Exit Sub
                        'End If
                    Next
                End If

                'BindingContext(GcBKI_d.DataSource).Position = getPosisi(rw(i))
                'tunda()
                txbKdBrg.Text = ""
                'lblNmBrg.Text = ""
                'lblStatus.Text = ""
                txbKdBrg.Focus()
                sqlread.Close()
                'Next

            Else
                'lblNmBrg.ForeColor = Color.Magenta
                'lblStatus.ForeColor = Color.Magenta

                MsgBox("Item tidak ada dalam Daftar", MsgBoxStyle.Critical, "KOSONG")
                'lblStatus.Text = "KOSONG"
                tunda()
                txbKdBrg.Text = ""
                'lblNmBrg.Text = ""
                'lblStatus.Text = ""
                txbKdBrg.Focus()

                'MsgBox("barang tidak ada")
                'ElseIf Not ok Then
                '    lblNmBrg.Text = "Barang sudah terdaftar semua"
                '    lblStatus.Text = "STOP!"
            End If
            txbKdBrg.SelectAll()
        End If
    End Sub
    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(700)
    End Sub
    Function getPosisi(ByVal dr As DataRow) As Integer
        Dim i As Int16 = 0
        For Each rw As DataRow In dSO1.Tables("_bmid").Rows
            If dr Is rw Then
                Return i
            Else
                i += 1
            End If

        Next
    End Function

    Public Sub bersihkan()
        'txbNoTrans.Text = ""
        'txbNmTrima.Text = ""
        'dtpTgl.EditValue = vbNullString
        'LookupSPM.EditValue = vbNullString
        LookupGudang.EditValue = vbNullString
        dSO1.Clear()
    End Sub

End Class