﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiCairDPS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMultiCairDPS))
        Me.RL_nama1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Gc_nabung = New DevExpress.XtraGrid.GridControl
        Me.GV_nabung = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NO_TABUNGAN = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TGL_REGISTRASI = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bunga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NASABAH_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SALDO_AWAL = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SALDO_TRANS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SALDO_AKHIR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_bunga_jln = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cair = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.CE_cair = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        CType(Me.RL_nama1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_nabung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_cair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RL_nama1
        '
        Me.RL_nama1.AutoHeight = False
        Me.RL_nama1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_nama1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.RL_nama1.Name = "RL_nama1"
        Me.RL_nama1.NullText = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1090, 38)
        Me.Panel1.TabIndex = 163
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
        Me.Label1.Text = "          PENCAIRAN DEPOSITO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Gc_nabung
        '
        Me.Gc_nabung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gc_nabung.Location = New System.Drawing.Point(0, 0)
        Me.Gc_nabung.MainView = Me.GV_nabung
        Me.Gc_nabung.Name = "Gc_nabung"
        Me.Gc_nabung.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RL_nama1, Me.CE_cair})
        Me.Gc_nabung.Size = New System.Drawing.Size(1090, 306)
        Me.Gc_nabung.TabIndex = 8
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
        Me.GV_nabung.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.NO_TABUNGAN, Me.TGL_REGISTRASI, Me.bunga, Me.NASABAH_ID, Me.Nama, Me.SALDO_AWAL, Me.SALDO_TRANS, Me.SALDO_AKHIR, Me.rp_bunga_jln, Me.cair})
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
        Me.GV_nabung.ViewCaption = "PENARIKAN TABUNGAN"
        '
        'nomer
        '
        Me.nomer.Caption = "No"
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 66
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
        Me.NO_TABUNGAN.Width = 78
        '
        'TGL_REGISTRASI
        '
        Me.TGL_REGISTRASI.Caption = "TGL PENEMPATAN"
        Me.TGL_REGISTRASI.FieldName = "TGL_REGISTRASI"
        Me.TGL_REGISTRASI.Name = "TGL_REGISTRASI"
        Me.TGL_REGISTRASI.OptionsColumn.AllowEdit = False
        Me.TGL_REGISTRASI.OptionsColumn.ReadOnly = True
        Me.TGL_REGISTRASI.Visible = True
        Me.TGL_REGISTRASI.VisibleIndex = 2
        Me.TGL_REGISTRASI.Width = 67
        '
        'bunga
        '
        Me.bunga.Caption = "Bunga"
        Me.bunga.FieldName = "bunga"
        Me.bunga.Name = "bunga"
        Me.bunga.OptionsColumn.AllowEdit = False
        Me.bunga.OptionsColumn.ReadOnly = True
        Me.bunga.Visible = True
        Me.bunga.VisibleIndex = 3
        Me.bunga.Width = 73
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
        '
        'Nama
        '
        Me.Nama.Caption = "Nama"
        Me.Nama.ColumnEdit = Me.RL_nama1
        Me.Nama.FieldName = "NASABAH_ID"
        Me.Nama.Name = "Nama"
        Me.Nama.OptionsColumn.AllowEdit = False
        Me.Nama.OptionsColumn.ReadOnly = True
        Me.Nama.Visible = True
        Me.Nama.VisibleIndex = 5
        Me.Nama.Width = 147
        '
        'SALDO_AWAL
        '
        Me.SALDO_AWAL.Caption = "SALDO AWAL"
        Me.SALDO_AWAL.DisplayFormat.FormatString = "c2"
        Me.SALDO_AWAL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SALDO_AWAL.FieldName = "SALDO_AWAL"
        Me.SALDO_AWAL.Name = "SALDO_AWAL"
        Me.SALDO_AWAL.OptionsColumn.AllowEdit = False
        Me.SALDO_AWAL.OptionsColumn.ReadOnly = True
        Me.SALDO_AWAL.Visible = True
        Me.SALDO_AWAL.VisibleIndex = 6
        Me.SALDO_AWAL.Width = 95
        '
        'SALDO_TRANS
        '
        Me.SALDO_TRANS.Caption = "TRANSAKSI"
        Me.SALDO_TRANS.DisplayFormat.FormatString = "c2"
        Me.SALDO_TRANS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SALDO_TRANS.FieldName = "SALDO_TRANS"
        Me.SALDO_TRANS.Name = "SALDO_TRANS"
        Me.SALDO_TRANS.Visible = True
        Me.SALDO_TRANS.VisibleIndex = 8
        Me.SALDO_TRANS.Width = 110
        '
        'SALDO_AKHIR
        '
        Me.SALDO_AKHIR.Caption = "SALDO AKHIR"
        Me.SALDO_AKHIR.DisplayFormat.FormatString = "c2"
        Me.SALDO_AKHIR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SALDO_AKHIR.FieldName = "SALDO_AKHIR"
        Me.SALDO_AKHIR.Name = "SALDO_AKHIR"
        Me.SALDO_AKHIR.Visible = True
        Me.SALDO_AKHIR.VisibleIndex = 9
        Me.SALDO_AKHIR.Width = 195
        '
        'rp_bunga_jln
        '
        Me.rp_bunga_jln.Caption = "Bunga Berjalan"
        Me.rp_bunga_jln.DisplayFormat.FormatString = "c2"
        Me.rp_bunga_jln.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rp_bunga_jln.FieldName = "rp_bunga_jln"
        Me.rp_bunga_jln.Name = "rp_bunga_jln"
        Me.rp_bunga_jln.Visible = True
        Me.rp_bunga_jln.VisibleIndex = 7
        Me.rp_bunga_jln.Width = 87
        '
        'cair
        '
        Me.cair.Caption = "Cair"
        Me.cair.ColumnEdit = Me.CE_cair
        Me.cair.FieldName = "cair"
        Me.cair.Name = "cair"
        Me.cair.Visible = True
        Me.cair.VisibleIndex = 10
        Me.cair.Width = 76
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 38)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1090, 306)
        Me.pnl.TabIndex = 164
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Gc_nabung)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1090, 306)
        Me.Panel2.TabIndex = 3
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
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
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'CE_cair
        '
        Me.CE_cair.AutoHeight = False
        Me.CE_cair.Name = "CE_cair"
        Me.CE_cair.ValueChecked = "Y"
        Me.CE_cair.ValueGrayed = "T"
        Me.CE_cair.ValueUnchecked = "T"
        '
        'frmMultiCairDPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 344)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMultiCairDPS"
        Me.Text = "frmMultiCairDPS"
        CType(Me.RL_nama1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gc_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_nabung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_cair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NASABAH_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bunga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Gc_nabung As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_nabung As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NO_TABUNGAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TGL_REGISTRASI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_nama1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SALDO_AWAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SALDO_TRANS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SALDO_AKHIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_bunga_jln As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cair As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CE_cair As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
