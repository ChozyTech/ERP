﻿'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2015                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting

Public Class frmMon_all_Dps
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Private subReport, subReport2 As String
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_tbh, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, tempo, pokok, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    Public drl As DataRelation


    Public Sub add_click()
       
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'bersihkan()
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


    Public Sub cancel_click()
        LoadStruktur()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub
    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dSO.Tables("_krd").Rows
            row.Item("nm") = GV_RLSKRD.GetRowCellDisplayText(i - 1, "NASABAH_ID")
            row.Item("nomer") = i : i += 1


        Next
    End Sub

    'Private Sub isinama()
    '    For rw As Integer = 0 To GV_RLSKRD.RowCount - 1

    '    Next
    'End Sub
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

    Public Sub LoadStruktur()
        If Not dSO1.Tables("_dtl") Is Nothing Then dSO1.Tables("_dtl").Clear()
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        Dim sql As String
        Dim sqltgl As String = ""

        If cb_all.CheckState = CheckState.Checked Then
            sqltgl = ""

        Else
            If LUE_stat.EditValue = vbNullString And LUE_Nama.EditValue = vbNullString And tglDari.EditValue = vbNullString And tglDari.EditValue = vbNullString And tgl_periode.EditValue = vbNullString Then
                sqltgl = "" ' AND STATUS_AKTIF='" & LUE_stat.EditValue & " '

            ElseIf LUE_stat.EditValue = vbNullString And LUE_Nama.EditValue <> vbNullString Then
                sqltgl = " AND NASABAH_ID = '" & LUE_Nama.EditValue & "' "
            ElseIf LUE_stat.EditValue <> vbNullString And LUE_Nama.EditValue = vbNullString Then
                sqltgl = " AND STATUS_AKTIF='" & LUE_stat.EditValue & "' "
            ElseIf tglDari.EditValue <> vbNullString And tglDari.EditValue <> vbNullString And LUE_stat.EditValue = vbNullString And LUE_Nama.EditValue = vbNullString Then
                sqltgl = " AND TGL_REGISTRASI between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
            ElseIf LUE_stat.EditValue <> vbNullString And LUE_Nama.EditValue <> vbNullString And tglDari.EditValue <> vbNullString And tglDari.EditValue <> vbNullString Then
                sqltgl = " AND STATUS_AKTIF='" & LUE_stat.EditValue & " ' AND NASABAH_ID = '" & LUE_Nama.EditValue & "' and TGL_REGISTRASI between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"

            End If
        End If

        


        sql = "select *,0 as nomer,'' as nm from tabung where JENIS_TABUNGAN='005' AND STATUS_AKTIF='AKTIF' " & sqltgl
        If tgl_periode.EditValue <> vbNullString And LUE_stat.EditValue = vbNullString And LUE_Nama.EditValue = vbNullString And tglDari.EditValue = vbNullString And tglDari.EditValue = vbNullString Then
            sql = "select *,0 as nomer,'' as nm from tabung where jenis_tabungan='005' AND NO_TABUNGAN not in " & _
                " (select NO_TABUNGAN from tabtrans where KODE_TRANS='02' and tgl_trans <= convert(date,'" & tgl_periode.Text & "',103))"
        End If

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql, sqlconn))
        'Clipboard.SetText(sql & " and " & sqltgl)
        DA.Fill(dSO, "_krd")

        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from kredit", sqlconn))
        'DA.Fill(dSO, "_krd")
        'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabtrans ", sqlconn))
        'DA2.Fill(dSO, "_dtl")

        'drl = dSO.Relations.Add("Detail", dSO.Tables("_krd").Columns("no_trans"), dSO.Tables("_dtl").Columns("no_trans"), False)
        GcINV_Ret.DataSource = dSO.Tables("_krd")
        'GcINV_Ret.LevelTree.Nodes.Add("Detail", gv_tbh_krd)

        'GcINV_Ret.DataSource = dSO.Tables("_krd")
        isinomer()

    End Sub

    Public Sub cetak_click()
        GcINV_Ret.Refresh()
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Sub print_gc1(ByVal xGc As Object, ByVal xreportHeader As String)
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)
        ph.Header.Content.Add("                                                                         " & umum.Perusahaan & vbCrLf & xreportHeader)
        ph.Header.Content.Add("")
        ph.Header.Content.Add(getTanggal.ToShortDateString)
        ph.Header.LineAlignment = BrickAlignment.Near
        ph.Footer.Content.Add("")
        ph.Footer.Content.Add("Lembar : [Page # of Pages #]")
        ph.Header.Font = New Font("Tahoma", 10, FontStyle.Bold)

        link.Component = xGc
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 40
        link.Margins.Top = 105
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.Landscape = True
        link.CreateDocument()
        link.ShowPreview()

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub
    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        'If STATE = "ADD" Then

        'If STATE = "EDIT" Then
        row = dSO.Tables("_krd").Rows(0)
        row.Item("Last_Update") = getTanggal()
        row.Item("Last_Update_By") = username
        'ElseIf STATE = "CETAK" Then
        '    row.Item("cetak_ke") = row.Item("cetak_ke") + 1
        'End If

        'row.Item("SALDO_AKHIR") = tx_saldo2.Text
        'row.Item("JENIS_TABUNGAN") = LUE_jnsTab.EditValue
        'row.Item("NO_TABUNGAN") = id_anggota + LUE_jnsTab.EditValue
        'row.Item("TGL_REGISTRASI") = dtp_tgl.Text
        'row.Item("SALDO_AWAL") = tx1_setoran.Text
        'row.Item("SALDO_AKHIR") = tx1_setoran.Text
        ''row.Item("JML_DENDA") = t_admin.Text
        'row.Item("STATUS_AKTIF") = "PENGAJUAN"
        'row.Item("jns_bayar") = cb_byr.Text
        'row.Item("approve1_by") = "OutStanding"
        'row.Item("stat_approve") = 0
        'row.Item("stat_cair") = 0
        'row.Item("KETERANGAN") = tx1_ket.Text

        'dSO.Tables("_krd").Rows.Add(row)

        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            'Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            'DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            'DA2.InsertCommand = Buildernya.GetInsertCommand()
            'DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            'DA2.UpdateCommand.Transaction = BTRANS
            'DA2.InsertCommand.Transaction = BTRANS
            'DA2.DeleteCommand.Transaction = BTRANS

            'Dim sqlcmd1 As New SqlCommand("update tabung set SALDO_AKHIR=@nilai where NO_TABUNGAN='" & tx_noTbg.Text & "'", sqlconn, BTRANS)
            'sqlcmd1.Parameters.AddWithValue("@nilai", row1.Item("SALDO_AKHIR"))
            'sqlcmd1.ExecuteNonQuery()
            'For Each row As DataRow In dSO.Tables("_krd").Rows
            '    If row.RowState = DataRowState.Modified Then
            '        Dim sqlcmd1 As New SqlCommand("update KOPKAR.dbo.anggota set Nama='" & row.Item("nm") & "' where nasabah_id='" & row.Item("nasabah_id") & "'", sqlconn, BTRANS)
            '        sqlcmd1.ExecuteNonQuery()
            '    End If
            'Next

            DA.Update(dSO.Tables("_krd"))
            'DA2.Update(dSO1.Tables("_krd"))
           
            'STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            btnSave = False
            setStatus()
            'cancel_click()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub

    Private Sub frmMonDepst_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'LoadStruktur()
        cb_all.CheckState = CheckState.Checked
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RLnama.DataSource = ds_cari.Tables("_lookup1")
        RLnama.ValueMember = "nasabah_id"
        RLnama.DisplayMember = "Nama"

        DA_gdg2 = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota where Rec_Stat=1", sqlconn))
        DA_gdg2.Fill(ds_gdg2, "_bilyet")
        LUE_Nama.Properties.DataSource = ds_gdg2.Tables("_bilyet")
        LUE_Nama.Properties.ValueMember = "nasabah_id"
        LUE_Nama.Properties.DisplayMember = "Nama"


        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select kd_status_agenda,keterangan from m_agenda", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup2")
        RL_stat.DataSource = ds_cari1.Tables("_lookup2")
        RL_stat.ValueMember = "kd_status_agenda"
        RL_stat.DisplayMember = "keterangan"


        DA_gdg1 = New SqlDataAdapter(New SqlCommand("select kode from m_status_tabungan", sqlconn))
        DA_gdg1.Fill(ds_gdg1, "_stat")
        LUE_stat.Properties.DataSource = ds_gdg1.Tables("_stat")
        LUE_stat.Properties.ValueMember = "kode"
        LUE_stat.Properties.DisplayMember = "kode"

    End Sub


    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadStruktur()
        btnSave = True
        setStatus()
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        cetak_click()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        LUE_Nama.EditValue = vbNullString
        LUE_stat.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
        tgl_periode.EditValue = vbNullString

    End Sub

    'Private Sub GV_RLSKRD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV_RLSKRD.KeyDown
    '    If e.KeyCode = Keys.Enter Then

    '    End If
    'End Sub

    Private Sub GV_RLSKRD_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_RLSKRD.CellValueChanged
        If e.Column Is nm Then
            Dim sqlcmd1 As New SqlCommand("update KOPKAR.dbo.anggota set Nama='" & GV_RLSKRD.GetRowCellValue(e.RowHandle, "nm").ToString & "' where nasabah_id='" & GV_RLSKRD.GetRowCellValue(e.RowHandle, "NASABAH_ID").ToString & "'", sqlconn)
            sqlcmd1.ExecuteNonQuery()
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportFooterArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportFooterArea
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Arial", 10, FontStyle.Regular)
        e.Graph.BackColor = Color.White
        Dim reportFooter1 As String = "Dibuat Oleh,      "
        Dim reportFooter2 As String = "  "
        Dim reportFooter3 As String = "(  " & namauser & ")"
        Dim reportFooter44 As String = "Diperiksa Oleh,"
        Dim reportFooter66 As String = "( " & kbgSP & " )"
        Dim reportFooter4 As String = "Diketahui Oleh,"
        Dim reportFooter6 As String = "(_______________________)"
        Dim reportFooter7 As String = "Total SALDO PENEMPATAN"
        Dim reportFooter8 As String = "Total Bilyet"
        'Dim reportFooter11 As String = "Total Net Bunga"
        Dim reportFooter9 As String = GV_RLSKRD.Columns("SALDO_AWAL").SummaryText
        Dim reportFooter10 As String = GV_RLSKRD.Columns("SALDO_AWAL").SummaryText
        'Dim reportFooter12 As String = GV_RLSKRD.Columns("rp_bg_net").SummaryText
        'Dim reportFooter13 As String = ":"
        Dim rec1 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 150, 100, 300, 120)
        Dim rec2 As RectangleF = New RectangleF(10, 100, 10, 125)
        Dim rec44 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 2) - 150, 100, 300, 120)
        Dim rec66 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 2) - 150, 200, 300, 20)
        Dim rec3 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 150, 200, 300, 20)
        Dim rec4 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 3) - 150, 100, 300, 120)
        Dim rec6 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 3) - 150, 200, 300, 20)

        Dim rec13 As RectangleF = New RectangleF(155, 10, 10, 20)
        Dim rec14 As RectangleF = New RectangleF(155, 30, 10, 20)
        Dim rec15 As RectangleF = New RectangleF(155, 50, 10, 20)
        e.Graph.DrawString(reportFooter1, Color.Black, rec1, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter2, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter6, Color.Black, rec6, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter44, Color.Black, rec44, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter66, Color.Black, rec66, DevExpress.XtraPrinting.BorderSide.None)
        'e.Graph.DrawString(reportFooter11, Color.Black, rec11, DevExpress.XtraPrinting.BorderSide.None)
        'e.Graph.DrawString(reportFooter9, Color.Black, rec9, DevExpress.XtraPrinting.BorderSide.None)
        'e.Graph.DrawString(reportFooter10, Color.Black, rec10, DevExpress.XtraPrinting.BorderSide.None)
        'e.Graph.DrawString(reportFooter12, Color.Black, rec12, DevExpress.XtraPrinting.BorderSide.None)
        'e.Graph.DrawString(reportFooter13, Color.Black, rec13, DevExpress.XtraPrinting.BorderSide.None)
        'e.Graph.DrawString(reportFooter13, Color.Black, rec14, DevExpress.XtraPrinting.BorderSide.None)
        'e.Graph.DrawString(reportFooter13, Color.Black, rec15, DevExpress.XtraPrinting.BorderSide.None)
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "LAPORAN SELURUH DEPOSITO"
        'Dim reportHeader1 As String = "Per Tanggal "
        If tglDari.EditValue = tglsampai.EditValue Then
            subReport = "Per Tanggal " & Format(tglDari.EditValue, "d MMMM yyyy").ToString
        Else
            subReport = "Per Tanggal " & Format(tglDari.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(tglsampai.EditValue, "d MMMM yyyy").ToString
        End If

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        'Dim rec3 As RectangleF = New RectangleF(0, 70, CSng(e.Graph.MeasureString(reportHeader1).Width) + 10, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
        'e.Graph.DrawString(reportHeader1, Color.Black, rec3, BorderSide.None)
    End Sub

End Class