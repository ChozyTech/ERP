﻿Imports System.Data.SqlClient
Public Class frmReportNeracaSaldo
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain

    Dim dsLookUPValuta, dsLookUpRek, dsSal, dsThn, dsBln, dsLookUp As New DataSet
    Dim daLookUPValuta, daLookUpRek, daSal, daThn, daBln, daLookUp As SqlDataAdapter

    Dim VarTahun As String
    Dim VarBulan As String

    Dim err As String
    Dim isOK As Boolean = True

    Private Sub frmReportNeracaSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True

        lookUpLoad()
        loadLookUp()
    End Sub


    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"
    End Sub

    Sub lookUpLoad()

        daSal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select A.kartu, A.bln_buku, A.thn_buku, A.kd_buku_besar, b.nm_buku_besar, A.kd_buku_pusat, c.nm_buku_pusat, A.status, a.jml_val_debet, a.jml_val_kredit from FIN.dbo.FIN_NERACA_SALDO A , SIF.dbo.SIF_buku_besar B, SIF.dbo.SIF_buku_pusat C where(a.kd_buku_besar = b.kd_buku_besar) and a.kd_buku_pusat = C.kd_buku_pusat ", sqlconn))
        daSal.Fill(dsSal, "_saldo")
        LookUpSaldo.Properties.DataSource = dsSal.Tables("_saldo")
        LookUpSaldo.Properties.ValueMember = "XXX"
        LookUpSaldo.Properties.DisplayMember = "XXX"
    End Sub

    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        CetakLaporan(VarTahun, VarBulan, "false")
    End Sub

    Sub CetakLaporan(Optional ByVal tahun As String = "", Optional ByVal bulan As String = "", Optional ByVal Boll As String = "")

        Try
            ErrorProvider1.Clear()
            If lookupBulanAwal.EditValue = vbNullString Then
                ErrorProvider1.SetError(lookupBulanAwal, "Periode Tidak Boleh Kosong")
            ElseIf lookupBulanAwal.EditValue <> vbNullString Then
                callReport(App_Path() & "\report\CRNRS.rpt", "", "&bulan=" & bulan & "&tahun=" & tahun, Boll)
                'callReport(App_Path() & "\report\CRGL1.rpt", "","", False)
            Else
                callReport(App_Path() & "\report\CRNRS.rpt", "", "", True)
                'MsgBox("Kesalahan dalam mengisi filter laporan :" & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")

            End If
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        CetakLaporan(VarTahun, VarBulan, "true")
    End Sub
    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
    End Sub

    Sub bersih()
        lookupBulanAwal.EditValue = vbNullString
    End Sub

    Private Sub lookupBulanAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookupBulanAwal.EditValueChanged
        VarTahun = Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4)
        VarBulan = Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2)
    End Sub
End Class