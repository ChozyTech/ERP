﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdTranQic
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdTranQic))
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kode_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkkdbarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.tipe_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Merk_Kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gc_jml_prod = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stok_min = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.lktipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lkkain = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lkukuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Nama_Jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txt_no_hsl = New System.Windows.Forms.TextBox
        Me.lkkegiatan = New DevExpress.XtraEditors.LookUpEdit
        Me.lkrph = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txttanggal = New System.Windows.Forms.TextBox
        Me.txtjdwl = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.jdwlkerja = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.pnl = New System.Windows.Forms.Panel
        Me.clmStatus = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkkdbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lktipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkkain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkukuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.lkkegiatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkrph.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView2
        '
        Me.GridView2.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView2.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView2.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.Empty.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView2.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView2.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView2.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GridView2.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView2.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GridView2.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GridView2.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView2.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.GroupRow.Options.UseFont = True
        Me.GridView2.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GridView2.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView2.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView2.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView2.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView2.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GridView2.Appearance.Preview.Options.UseBackColor = True
        Me.GridView2.Appearance.Preview.Options.UseForeColor = True
        Me.GridView2.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.Row.Options.UseBackColor = True
        Me.GridView2.Appearance.Row.Options.UseForeColor = True
        Me.GridView2.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GridView2.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GridView2.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kode_Barang, Me.tipe_stok, Me.Merk_Kain, Me.Nama_Ukuran, Me.gc_jml_prod, Me.jumlah, Me.stok_min})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView2.OptionsView.EnableAppearanceOddRow = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.PaintStyleName = "Skin"
        '
        'Kode_Barang
        '
        Me.Kode_Barang.AppearanceHeader.Options.UseTextOptions = True
        Me.Kode_Barang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Kode_Barang.Caption = "Nama Barang"
        Me.Kode_Barang.ColumnEdit = Me.lkkdbarang
        Me.Kode_Barang.FieldName = "kd_barang"
        Me.Kode_Barang.Name = "Kode_Barang"
        Me.Kode_Barang.OptionsColumn.AllowEdit = False
        Me.Kode_Barang.Visible = True
        Me.Kode_Barang.VisibleIndex = 0
        '
        'lkkdbarang
        '
        Me.lkkdbarang.AutoHeight = False
        Me.lkkdbarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkkdbarang.DisplayMember = "Nama_Barang"
        Me.lkkdbarang.Name = "lkkdbarang"
        Me.lkkdbarang.NullText = ""
        '
        'tipe_stok
        '
        Me.tipe_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_stok.Caption = "Tipe"
        Me.tipe_stok.FieldName = "Nama_Tipe"
        Me.tipe_stok.Name = "tipe_stok"
        Me.tipe_stok.OptionsColumn.AllowEdit = False
        Me.tipe_stok.Visible = True
        Me.tipe_stok.VisibleIndex = 1
        '
        'Merk_Kain
        '
        Me.Merk_Kain.AppearanceHeader.Options.UseTextOptions = True
        Me.Merk_Kain.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Merk_Kain.Caption = "Kain"
        Me.Merk_Kain.FieldName = "Merk_Kain"
        Me.Merk_Kain.Name = "Merk_Kain"
        Me.Merk_Kain.OptionsColumn.AllowEdit = False
        Me.Merk_Kain.Visible = True
        Me.Merk_Kain.VisibleIndex = 2
        '
        'Nama_Ukuran
        '
        Me.Nama_Ukuran.AppearanceHeader.Options.UseTextOptions = True
        Me.Nama_Ukuran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nama_Ukuran.Caption = "Ukuran"
        Me.Nama_Ukuran.FieldName = "Nama_Ukuran"
        Me.Nama_Ukuran.Name = "Nama_Ukuran"
        Me.Nama_Ukuran.OptionsColumn.AllowEdit = False
        Me.Nama_Ukuran.Visible = True
        Me.Nama_Ukuran.VisibleIndex = 3
        '
        'gc_jml_prod
        '
        Me.gc_jml_prod.AppearanceHeader.Options.UseTextOptions = True
        Me.gc_jml_prod.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gc_jml_prod.Caption = "Jumlah Produksi"
        Me.gc_jml_prod.FieldName = "jml_prod"
        Me.gc_jml_prod.Name = "gc_jml_prod"
        Me.gc_jml_prod.OptionsColumn.AllowEdit = False
        Me.gc_jml_prod.Visible = True
        Me.gc_jml_prod.VisibleIndex = 4
        '
        'jumlah
        '
        Me.jumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah.Caption = "Sisa Produksi"
        Me.jumlah.FieldName = "jml_prod_sisa"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.OptionsColumn.AllowEdit = False
        Me.jumlah.SummaryItem.FieldName = "jumlah"
        Me.jumlah.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jumlah.Visible = True
        Me.jumlah.VisibleIndex = 5
        '
        'stok_min
        '
        Me.stok_min.AppearanceHeader.Options.UseTextOptions = True
        Me.stok_min.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.stok_min.Caption = "Jumlah QIC"
        Me.stok_min.FieldName = "jml_qic"
        Me.stok_min.Name = "stok_min"
        Me.stok_min.SummaryItem.FieldName = "stok_min"
        Me.stok_min.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.stok_min.Visible = True
        Me.stok_min.VisibleIndex = 6
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(0, 101)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lkkdbarang, Me.lktipe, Me.lkkain, Me.lkukuran})
        Me.GridControl1.Size = New System.Drawing.Size(800, 284)
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2, Me.GridView1})
        '
        'lktipe
        '
        Me.lktipe.AutoHeight = False
        Me.lktipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lktipe.Name = "lktipe"
        Me.lktipe.NullText = ""
        '
        'lkkain
        '
        Me.lkkain.AutoHeight = False
        Me.lkkain.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkkain.Name = "lkkain"
        Me.lkkain.NullText = ""
        '
        'lkukuran
        '
        Me.lkukuran.AutoHeight = False
        Me.lkukuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkukuran.Name = "lkukuran"
        Me.lkukuran.NullText = ""
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nama_Jenis})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.PaintStyleName = "Skin"
        '
        'Nama_Jenis
        '
        Me.Nama_Jenis.Caption = "Jenis Barang"
        Me.Nama_Jenis.FieldName = "Nama_Jenis"
        Me.Nama_Jenis.Name = "Nama_Jenis"
        Me.Nama_Jenis.Visible = True
        Me.Nama_Jenis.VisibleIndex = 0
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Maroon
        Me.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.PictureBox1)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(800, 31)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(312, 29)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "QUALITY CONTROL"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTools.Controls.Add(Me.Panel1)
        Me.pnlTools.Controls.Add(Me.Panel2)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 31)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(800, 70)
        Me.pnlTools.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 70)
        Me.Panel1.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txt_no_hsl)
        Me.Panel5.Controls.Add(Me.lkkegiatan)
        Me.Panel5.Controls.Add(Me.lkrph)
        Me.Panel5.Location = New System.Drawing.Point(156, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(216, 67)
        Me.Panel5.TabIndex = 1
        '
        'txt_no_hsl
        '
        Me.txt_no_hsl.BackColor = System.Drawing.Color.Gainsboro
        Me.txt_no_hsl.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_no_hsl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no_hsl.Location = New System.Drawing.Point(0, 40)
        Me.txt_no_hsl.Name = "txt_no_hsl"
        Me.txt_no_hsl.ReadOnly = True
        Me.txt_no_hsl.Size = New System.Drawing.Size(216, 20)
        Me.txt_no_hsl.TabIndex = 25
        '
        'lkkegiatan
        '
        Me.lkkegiatan.Dock = System.Windows.Forms.DockStyle.Top
        Me.lkkegiatan.Location = New System.Drawing.Point(0, 20)
        Me.lkkegiatan.Name = "lkkegiatan"
        Me.lkkegiatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkkegiatan.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.lkkegiatan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("desc_data", "Nama")})
        Me.lkkegiatan.Properties.NullText = "[Pilih Kegiatan]"
        Me.lkkegiatan.Properties.ShowHeader = False
        Me.lkkegiatan.Size = New System.Drawing.Size(216, 20)
        Me.lkkegiatan.TabIndex = 24
        '
        'lkrph
        '
        Me.lkrph.Dock = System.Windows.Forms.DockStyle.Top
        Me.lkrph.Location = New System.Drawing.Point(0, 0)
        Me.lkrph.Name = "lkrph"
        Me.lkrph.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkrph.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_rph", "no_rph")})
        Me.lkrph.Properties.NullText = "[Pilih No. RPH]"
        Me.lkrph.Properties.ShowHeader = False
        Me.lkrph.Size = New System.Drawing.Size(216, 20)
        Me.lkrph.TabIndex = 16
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(156, 70)
        Me.Panel6.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "No Realisasi Prodksi : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "* Area Kegiatan : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label3
        '
        Me.label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(0, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(156, 20)
        Me.label3.TabIndex = 6
        Me.label3.Text = "* No RPH : "
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(381, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 67)
        Me.Panel2.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txttanggal)
        Me.Panel4.Controls.Add(Me.txtjdwl)
        Me.Panel4.Location = New System.Drawing.Point(141, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(235, 64)
        Me.Panel4.TabIndex = 1
        '
        'txttanggal
        '
        Me.txttanggal.BackColor = System.Drawing.Color.Gainsboro
        Me.txttanggal.Dock = System.Windows.Forms.DockStyle.Top
        Me.txttanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttanggal.Location = New System.Drawing.Point(0, 20)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.ReadOnly = True
        Me.txttanggal.Size = New System.Drawing.Size(235, 20)
        Me.txttanggal.TabIndex = 17
        '
        'txtjdwl
        '
        Me.txtjdwl.BackColor = System.Drawing.Color.Gainsboro
        Me.txtjdwl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtjdwl.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtjdwl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjdwl.Location = New System.Drawing.Point(0, 0)
        Me.txtjdwl.Name = "txtjdwl"
        Me.txtjdwl.ReadOnly = True
        Me.txtjdwl.Size = New System.Drawing.Size(235, 20)
        Me.txtjdwl.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.jdwlkerja)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(135, 67)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tanggal : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'jdwlkerja
        '
        Me.jdwlkerja.Dock = System.Windows.Forms.DockStyle.Top
        Me.jdwlkerja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jdwlkerja.ForeColor = System.Drawing.Color.White
        Me.jdwlkerja.Location = New System.Drawing.Point(0, 0)
        Me.jdwlkerja.Name = "jdwlkerja"
        Me.jdwlkerja.Size = New System.Drawing.Size(135, 20)
        Me.jdwlkerja.TabIndex = 2
        Me.jdwlkerja.Text = "Jadwal Kerja : "
        Me.jdwlkerja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(331, 328)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(250, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(169, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(88, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.GridControl1)
        Me.pnl.Controls.Add(Me.Button4)
        Me.pnl.Controls.Add(Me.Button3)
        Me.pnl.Controls.Add(Me.Button2)
        Me.pnl.Controls.Add(Me.Button1)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(800, 385)
        Me.pnl.TabIndex = 2
        '
        'clmStatus
        '
        Me.clmStatus.Caption = "Status"
        Me.clmStatus.FieldName = "rec_stat"
        Me.clmStatus.Name = "clmStatus"
        Me.clmStatus.Visible = True
        Me.clmStatus.VisibleIndex = 4
        Me.clmStatus.Width = 70
        '
        'frmProdTranQic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 386)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmProdTranQic"
        Me.Text = "frmProdTranQic"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkkdbarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lktipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkkain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkukuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.lkkegiatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkrph.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtjdwl As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents jdwlkerja As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents clmStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkrph As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kode_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkkdbarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents tipe_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lktipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Merk_Kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkkain As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Nama_Ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkukuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stok_min As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Nama_Jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lkkegiatan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents gc_jml_prod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_no_hsl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class