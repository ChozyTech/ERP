﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nabung
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nabung))
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Gc_nabung = New DevExpress.XtraGrid.GridControl
        Me.GV_nabung = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.URUTAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_TABUNGAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TGL_TRANS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KODE_TRANS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_kdTrans = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.NASABAH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RLnama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.SALDO_AWAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SALDO_TRANS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SALDO_AKHIR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.tx_noTbg = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tx_saldo1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.tx_id = New System.Windows.Forms.TextBox
        Me.tx_nama = New System.Windows.Forms.TextBox
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.TE_Setor = New DevExpress.XtraEditors.TextEdit
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_kdTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_Setor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(33, 44)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(75, 13)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "NIP Pegawai :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(33, 20)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(41, 13)
        Me.Label34.TabIndex = 35
        Me.Label34.Text = "Nama :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(33, 102)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(50, 13)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Setoran :"
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(798, 327)
        Me.pnl.TabIndex = 160
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Gc_nabung)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(798, 198)
        Me.Panel2.TabIndex = 3
        '
        'Gc_nabung
        '
        Me.Gc_nabung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gc_nabung.Location = New System.Drawing.Point(0, 0)
        Me.Gc_nabung.MainView = Me.GV_nabung
        Me.Gc_nabung.Name = "Gc_nabung"
        Me.Gc_nabung.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RLnama, Me.RL_kdTrans})
        Me.Gc_nabung.Size = New System.Drawing.Size(798, 198)
        Me.Gc_nabung.TabIndex = 7
        Me.Gc_nabung.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_nabung})
        '
        'GV_nabung
        '
        Me.GV_nabung.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_nabung.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_nabung.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.Empty.Options.UseBackColor = True
        Me.GV_nabung.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GV_nabung.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GV_nabung.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GV_nabung.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_nabung.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_nabung.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_nabung.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_nabung.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GV_nabung.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_nabung.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_nabung.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.OddRow.Options.UseBorderColor = True
        Me.GV_nabung.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV_nabung.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_nabung.Appearance.Preview.Options.UseFont = True
        Me.GV_nabung.Appearance.Preview.Options.UseForeColor = True
        Me.GV_nabung.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_nabung.Appearance.Row.Options.UseBackColor = True
        Me.GV_nabung.Appearance.Row.Options.UseForeColor = True
        Me.GV_nabung.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_nabung.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_nabung.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_nabung.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GV_nabung.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_nabung.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_nabung.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_nabung.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_nabung.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_nabung.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.URUTAN, Me.NO_TABUNGAN, Me.TGL_TRANS, Me.KODE_TRANS, Me.NASABAH_ID, Me.Nama, Me.SALDO_AWAL, Me.SALDO_TRANS, Me.SALDO_AKHIR})
        Me.GV_nabung.GridControl = Me.Gc_nabung
        Me.GV_nabung.Name = "GV_nabung"
        Me.GV_nabung.OptionsCustomization.AllowColumnMoving = False
        Me.GV_nabung.OptionsCustomization.AllowFilter = False
        Me.GV_nabung.OptionsCustomization.AllowGroup = False
        Me.GV_nabung.OptionsNavigation.EnterMoveNextColumn = True
        Me.GV_nabung.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_nabung.OptionsView.EnableAppearanceOddRow = True
        Me.GV_nabung.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV_nabung.OptionsView.RowAutoHeight = True
        Me.GV_nabung.OptionsView.ShowFooter = True
        Me.GV_nabung.OptionsView.ShowGroupPanel = False
        Me.GV_nabung.OptionsView.ShowViewCaption = True
        Me.GV_nabung.ViewCaption = "SETORAN TABUNGAN"
        '
        'URUTAN
        '
        Me.URUTAN.Caption = "No"
        Me.URUTAN.FieldName = "URUTAN"
        Me.URUTAN.Name = "URUTAN"
        Me.URUTAN.Visible = True
        Me.URUTAN.VisibleIndex = 0
        Me.URUTAN.Width = 56
        '
        'NO_TABUNGAN
        '
        Me.NO_TABUNGAN.Caption = "No Tabungan"
        Me.NO_TABUNGAN.FieldName = "NO_TABUNGAN"
        Me.NO_TABUNGAN.Name = "NO_TABUNGAN"
        Me.NO_TABUNGAN.OptionsColumn.AllowEdit = False
        Me.NO_TABUNGAN.OptionsColumn.ReadOnly = True
        Me.NO_TABUNGAN.Visible = True
        Me.NO_TABUNGAN.VisibleIndex = 1
        Me.NO_TABUNGAN.Width = 81
        '
        'TGL_TRANS
        '
        Me.TGL_TRANS.Caption = "TGL TRANS"
        Me.TGL_TRANS.FieldName = "TGL_TRANS"
        Me.TGL_TRANS.Name = "TGL_TRANS"
        Me.TGL_TRANS.OptionsColumn.AllowEdit = False
        Me.TGL_TRANS.OptionsColumn.ReadOnly = True
        Me.TGL_TRANS.Visible = True
        Me.TGL_TRANS.VisibleIndex = 2
        Me.TGL_TRANS.Width = 55
        '
        'KODE_TRANS
        '
        Me.KODE_TRANS.Caption = "KODE TRANS"
        Me.KODE_TRANS.ColumnEdit = Me.RL_kdTrans
        Me.KODE_TRANS.FieldName = "KODE_TRANS"
        Me.KODE_TRANS.Name = "KODE_TRANS"
        Me.KODE_TRANS.OptionsColumn.AllowEdit = False
        Me.KODE_TRANS.OptionsColumn.ReadOnly = True
        Me.KODE_TRANS.Visible = True
        Me.KODE_TRANS.VisibleIndex = 3
        Me.KODE_TRANS.Width = 71
        '
        'RL_kdTrans
        '
        Me.RL_kdTrans.AutoHeight = False
        Me.RL_kdTrans.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_kdTrans.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESKRIPSI_TRANS", "Transaksi")})
        Me.RL_kdTrans.Name = "RL_kdTrans"
        Me.RL_kdTrans.NullText = ""
        '
        'NASABAH_ID
        '
        Me.NASABAH_ID.Caption = "ID Nasabah"
        Me.NASABAH_ID.FieldName = "NASABAH_ID"
        Me.NASABAH_ID.Name = "NASABAH_ID"
        Me.NASABAH_ID.OptionsColumn.AllowEdit = False
        Me.NASABAH_ID.OptionsColumn.ReadOnly = True
        Me.NASABAH_ID.Visible = True
        Me.NASABAH_ID.VisibleIndex = 4
        Me.NASABAH_ID.Width = 60
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.ColumnEdit = Me.RLnama
        Me.Nama.FieldName = "NASABAH_ID"
        Me.Nama.Name = "Nama"
        Me.Nama.OptionsColumn.AllowEdit = False
        Me.Nama.OptionsColumn.ReadOnly = True
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 5
        Me.Nama.Width = 202
        '
        'RLnama
        '
        Me.RLnama.AutoHeight = False
        Me.RLnama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RLnama.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RLnama.Name = "RLnama"
        Me.RLnama.NullText = ""
        '
        'SALDO_AWAL
        '
        Me.SALDO_AWAL.Caption = "SALDO AWAL"
        Me.SALDO_AWAL.FieldName = "SALDO_AWAL"
        Me.SALDO_AWAL.Name = "SALDO_AWAL"
        Me.SALDO_AWAL.OptionsColumn.AllowEdit = False
        Me.SALDO_AWAL.OptionsColumn.ReadOnly = True
        Me.SALDO_AWAL.Visible = True
        Me.SALDO_AWAL.VisibleIndex = 6
        Me.SALDO_AWAL.Width = 92
        '
        'SALDO_TRANS
        '
        Me.SALDO_TRANS.Caption = "TRANSAKSI"
        Me.SALDO_TRANS.FieldName = "SALDO_TRANS"
        Me.SALDO_TRANS.Name = "SALDO_TRANS"
        Me.SALDO_TRANS.Visible = True
        Me.SALDO_TRANS.VisibleIndex = 7
        Me.SALDO_TRANS.Width = 70
        '
        'SALDO_AKHIR
        '
        Me.SALDO_AKHIR.Caption = "SALDO AKHIR"
        Me.SALDO_AKHIR.FieldName = "SALDO_AKHIR"
        Me.SALDO_AKHIR.Name = "SALDO_AKHIR"
        Me.SALDO_AKHIR.Visible = True
        Me.SALDO_AKHIR.VisibleIndex = 8
        Me.SALDO_AKHIR.Width = 90
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel5.Controls.Add(Me.TE_Setor)
        Me.Panel5.Controls.Add(Me.tx_noTbg)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.tx_saldo1)
        Me.Panel5.Controls.Add(Me.Label33)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.tx_id)
        Me.Panel5.Controls.Add(Me.tx_nama)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(798, 129)
        Me.Panel5.TabIndex = 2
        '
        'tx_noTbg
        '
        Me.tx_noTbg.Location = New System.Drawing.Point(390, 43)
        Me.tx_noTbg.Name = "tx_noTbg"
        Me.tx_noTbg.Size = New System.Drawing.Size(100, 20)
        Me.tx_noTbg.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Saldo Tabungan :"
        '
        'tx_saldo1
        '
        Me.tx_saldo1.Location = New System.Drawing.Point(131, 67)
        Me.tx_saldo1.Name = "tx_saldo1"
        Me.tx_saldo1.Size = New System.Drawing.Size(112, 20)
        Me.tx_saldo1.TabIndex = 53
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(307, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "No Tabungan :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tx_id
        '
        Me.tx_id.Location = New System.Drawing.Point(131, 41)
        Me.tx_id.Name = "tx_id"
        Me.tx_id.Size = New System.Drawing.Size(144, 20)
        Me.tx_id.TabIndex = 1
        '
        'tx_nama
        '
        Me.tx_nama.Location = New System.Drawing.Point(131, 15)
        Me.tx_nama.Name = "tx_nama"
        Me.tx_nama.Size = New System.Drawing.Size(170, 20)
        Me.tx_nama.TabIndex = 0
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(633, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          SETORAN TABUNGAN ANGGOTA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 38)
        Me.Panel1.TabIndex = 159
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'TE_Setor
        '
        Me.TE_Setor.Location = New System.Drawing.Point(131, 99)
        Me.TE_Setor.Name = "TE_Setor"
        Me.TE_Setor.Properties.DisplayFormat.FormatString = "n2"
        Me.TE_Setor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_Setor.Properties.EditFormat.FormatString = "n2"
        Me.TE_Setor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_Setor.Properties.Mask.EditMask = "n2"
        Me.TE_Setor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TE_Setor.Size = New System.Drawing.Size(112, 20)
        Me.TE_Setor.TabIndex = 218
        '
        'nabung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 365)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "nabung"
        Me.Text = "a"
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_kdTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RLnama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_Setor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tx_id As System.Windows.Forms.TextBox
    Friend WithEvents tx_nama As System.Windows.Forms.TextBox
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tx_noTbg As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tx_saldo1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Gc_nabung As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_nabung As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NO_TABUNGAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TGL_TRANS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KODE_TRANS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NASABAH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RLnama As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SALDO_AWAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SALDO_TRANS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents URUTAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SALDO_AKHIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_kdTrans As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TE_Setor As DevExpress.XtraEditors.TextEdit
End Class