﻿'======================================================================
'= Dikerjakan oleh Arif Febriyanto                                  =
'= Project: Dinasty group american pillow @2011                       =
'= Boleh di Copy Paste asal jgn lupa Uang Rokok Surya 16 hehehhee...  =
'======================================================================

Imports System.Data.SqlClient

Public Class frmBOMSERVICE
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain
    '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dso1, ds_cari, ds1 As New DataSet
    Dim Bulder As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DALOOKUP, DALOOKUP2, Da1 As SqlClient.SqlDataAdapter

    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub



    'Public Sub edit_klik()
    '    dSO = New DataSet
    '    DA = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_bom", sqlconn))
    '    DA.Fill(dSO, "_bom")
    '    frmCari.set_dso(dSO.Tables("_bom"))
    '    frmCari.ShowDialog()
    '    If Not frmCari.row Is Nothing Then
    '        txbKdBOM.Text = frmCari.row("kode_BOM").ToString
    '        txbNamaBOM.Text = frmCari.row("nama_BOM").ToString
    '        txbNoDocBOM.Text = frmCari.row("no_dokumen_BOM").ToString
    '        txbJenisBOM.Text = frmCari.row("jenis_BOM").ToString
    '        rtbKet.Text = frmCari.row("Keterangan").ToString
    '        cbStatus.Text = IIf(frmCari.row("Rec_Stat").ToString = "Y", "AKTIF", "NonAKTIF")
    '    End If
    '    'utk master detail
    '    dso1 = New DataSet
    '    DALOOKUP2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_bom_d where kode_BOM='" & txbKdBOM.Text & "'", sqlconn))
    '    DALOOKUP2.Fill(dso1, "_bom_d")
    '    GcMstBOM_d.DataSource = dso1.Tables("_bom_d")
    'End Sub

    'Public Sub hapus_record()

    'End Sub

    'Public Sub simpan_klik()

    'End Sub

    Private Sub frmBOMSERVICE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        connect()
        prn = getParent(Me)
        Load_Look()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.BOM_SERVICE where 1=0", sqlconn))
        DA.Fill(dSO, "_bom")

        DA2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.BOM_SERVICE_D where 1=0", sqlconn))
        DA2.Fill(dso1, "_bom_d")
        GridControl1.DataSource = dso1.Tables("_bom_d")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang Kd_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RepositoryItemLookUpEdit1.DataSource = ds_cari.Tables("_lookup1")
        RepositoryItemLookUpEdit1.ValueMember = "Kd_Barang"
        RepositoryItemLookUpEdit1.DisplayMember = "Nama_Barang"
    End Sub

    Public Sub cancel_click()
        STATE = ""

    End Sub
    'Public Sub simpan()
    '    Dim BTRANS As SqlTransaction

    '    Bulder = New SqlClient.SqlCommandBuilder(DA)
    '    DA.UpdateCommand = Bulder.GetUpdateCommand()
    '    DA.InsertCommand = Bulder.GetInsertCommand()
    '    DA.DeleteCommand = Bulder.GetDeleteCommand()

    '    Bulder = New SqlClient.SqlCommandBuilder(DA2)
    '    DA2.UpdateCommand = Bulder.GetUpdateCommand()
    '    DA2.InsertCommand = Bulder.GetInsertCommand()
    '    DA2.DeleteCommand = Bulder.GetDeleteCommand()

    '    BTRANS = sqlconn.BeginTransaction("1")
    '    DA.UpdateCommand.Transaction = BTRANS
    '    DA.InsertCommand.Transaction = BTRANS
    '    DA.DeleteCommand.Transaction = BTRANS

    '    DA2.UpdateCommand.Transaction = BTRANS
    '    DA2.InsertCommand.Transaction = BTRANS
    '    DA2.DeleteCommand.Transaction = BTRANS

    '    'STATE = "ADD"
    '    If STATE = "ADD" Then
    '        row = dSO.Tables("_bom").NewRow
    '        row.Item("Last_Create_Date") = Now
    '        row.Item("Last_Created_By") = username
    '    ElseIf STATE = "EDIT" Then
    '        row = dSO.Tables("_bom").Rows(0)
    '        row.Item("Last_Update_Date") = Now
    '        row.Item("Last_Updated_By") = username
    '    End If
    '    row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener

    '    row.Item("kode_BOM") = txbKdBOM.Text
    '    row.Item("Nama_BOM") = txbNamaBOM.Text
    '    row.Item("no_dokumen_BOM") = txbNoDocBOM.Text
    '    row.Item("jenis_bom") = txbJenisBOM.Text
    '    row.Item("Keterangan") = rtbKet.Text
    '    row.Item("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
    '    row.Item("Program_Name") = Me.Name

    '    If STATE = "ADD" Then
    '        dSO.Tables("_bom").Rows.Add(row)
    '    End If
    '    For Each rows As DataRow In dso1.Tables("_bom_d").Rows
    '        If rows.RowState = DataRowState.Added Then
    '            rows.Item("kode_BOM") = row.Item("kode_BOM")
    '            rows.Item("Last_Create_Date") = Now
    '            rows.Item("Last_Created_By") = username
    '            rows.Item("kd_Cabang") = "1"
    '        Else
    '            rows.Item("Last_Update_Date") = Now
    '            rows.Item("Last_Updated_By") = username
    '        End If
    '        rows.Item("Program_name") = Me.Name

    '    Next

    '    Try

    '        DA.Update(dSO.Tables("_bom"))
    '        DA2.Update(dso1.Tables("_bom_d"))

    '        dSO.Tables("_bom").AcceptChanges()
    '        dso1.Tables("_bom_d").AcceptChanges()
    '        STATE = "EDIT"
    '        BTRANS.Commit()
    '        showMessages("Berhasil disimpan..")
    '    Catch e As Exception
    '        BTRANS.Rollback()
    '        dSO.Tables("_bom").RejectChanges() ' untuk membatalkan row yg diupdate/insert
    '        MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
    '    End Try
    'End Sub
    Public Sub save_click()

    End Sub
    Sub Load_Look()
        If Not ds1.Tables("JnsKain") Is Nothing Then ds1.Tables("JnsKain").Clear()
        Da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Brg jenis_kain,Nama_Jenis from sif.dbo.SIF_Jenis_Barang", sqlconn))
        Da1.Fill(ds1, "JnsKain")
        LookUpEditJnsBRG.Properties.DataSource = ds1.Tables("JnsKain")
        LookUpEditJnsBRG.Properties.DisplayMember = "Nama_Jenis"
        LookUpEditJnsBRG.Properties.ValueMember = "jenis_kain"

        If Not ds1.Tables("Merk") Is Nothing Then ds1.Tables("Merk").Clear()
        Da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kain merk,Merk_Kain from sif.dbo.SIF_Kain", sqlconn))
        Da1.Fill(ds1, "Merk")
        LookUpEditMerk.Properties.DataSource = ds1.Tables("Merk")
        LookUpEditMerk.Properties.DisplayMember = "Merk_Kain"
        LookUpEditMerk.Properties.ValueMember = "merk"






    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'End With
        STATE = "ADD" '<-- set state= add


    End Sub

    'Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MsgBox("Isian pada TextBox tersebut akan dibersihkan??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    bersihkan()
    'End Sub

    'Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    'End Sub

    'Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan_klik()
    '    bersihkan()
    'End Sub

    'Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    bersihkan()
    '    STATE = "EDIT"
    '    edit_klik()
    'End Sub

    'Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    bersihkan()
    '    STATE = "ADD"
    'End Sub

    'Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

    Public Sub btnstart()
        btAdd.Enabled = True
        btEdit.Enabled = True
        btSave.Enabled = False
        btnDel.Enabled = False
    End Sub

    'Public Sub bersihkan()
    '    txbJenisBOM.Text = ""
    '    txbKdBOM.Text = ""
    '    txbNamaBOM.Text = ""
    '    txbNoDocBOM.Text = ""
    '    GcMstBOM_d.DataSource = Nothing
    'End Sub

    'Public Sub enabel()
    '    txbKdBOM.Enabled = True
    '    txbJenisBOM.Enabled = True
    '    txbNamaBOM.Enabled = True
    '    txbNoDocBOM.Enabled = True
    '    btSave.Enabled = True
    'End Sub

    'Public Sub disabel()
    '    txbKdBOM.Enabled = False
    '    txbJenisBOM.Enabled = False
    '    txbNamaBOM.Enabled = False
    '    txbNoDocBOM.Enabled = False
    'End Sub

    'Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
    '    enabel()
    '    btnDel.Enabled = True
    '    edit_klik()

    'End Sub

    'Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    '    If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

    'Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
    '    If MsgBox("Form akan di bersihkan dan mulai dari awal lagi??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    bersihkan()
    'End Sub

    'Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    'End Sub
End Class