﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frCtkMassGudangIn
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frCtkMassGudangIn))
        Me.LookupBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.CE_ctk_ulang = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.tglsampai = New DevExpress.XtraEditors.DateEdit
        Me.tglDari = New DevExpress.XtraEditors.DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.GcPrintQC = New DevExpress.XtraGrid.GridControl
        Me.GvPrintQC = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_order = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_qc_pass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_qc_unpass = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cetak_ke = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cetak_ulang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Last_Created_By = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.pnl = New System.Windows.Forms.Panel
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CE_ctk_ulang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcPrintQC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvPrintQC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'LookupBarang
        '
        Me.LookupBarang.AutoHeight = False
        Me.LookupBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LookupBarang.Name = "LookupBarang"
        Me.LookupBarang.NullText = ""
        '
        'CE_ctk_ulang
        '
        Me.CE_ctk_ulang.AutoHeight = False
        Me.CE_ctk_ulang.Name = "CE_ctk_ulang"
        Me.CE_ctk_ulang.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CE_ctk_ulang.ValueChecked = "Y"
        Me.CE_ctk_ulang.ValueGrayed = "T"
        Me.CE_ctk_ulang.ValueUnchecked = "T"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "s/d"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdClear)
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(792, 42)
        Me.Panel3.TabIndex = 5
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(666, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 42)
        Me.cmdClear.TabIndex = 37
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(617, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 42)
        Me.cmdRefresh.TabIndex = 33
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.tglsampai)
        Me.Panel6.Controls.Add(Me.tglDari)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(121, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(496, 42)
        Me.Panel6.TabIndex = 32
        '
        'tglsampai
        '
        Me.tglsampai.EditValue = Nothing
        Me.tglsampai.Location = New System.Drawing.Point(169, 12)
        Me.tglsampai.Name = "tglsampai"
        Me.tglsampai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglsampai.Properties.Appearance.Options.UseFont = True
        Me.tglsampai.Properties.Appearance.Options.UseTextOptions = True
        Me.tglsampai.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglsampai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglsampai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglsampai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglsampai.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglsampai.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglsampai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglsampai.Size = New System.Drawing.Size(116, 20)
        Me.tglsampai.TabIndex = 25
        '
        'tglDari
        '
        Me.tglDari.EditValue = Nothing
        Me.tglDari.Location = New System.Drawing.Point(6, 12)
        Me.tglDari.Name = "tglDari"
        Me.tglDari.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglDari.Properties.Appearance.Options.UseFont = True
        Me.tglDari.Properties.Appearance.Options.UseTextOptions = True
        Me.tglDari.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglDari.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglDari.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.tglDari.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tglDari.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglDari.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglDari.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglDari.Size = New System.Drawing.Size(125, 20)
        Me.tglDari.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 42)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Filter Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "error.ico")
        Me.img.Images.SetKeyName(1, "insert.ico")
        Me.img.Images.SetKeyName(2, "edit2.ico")
        Me.img.Images.SetKeyName(3, "ok.ico")
        Me.img.Images.SetKeyName(4, "save.ico")
        Me.img.Images.SetKeyName(5, "reload.ico")
        Me.img.Images.SetKeyName(6, "gohome.ico")
        Me.img.Images.SetKeyName(7, "remove.ico")
        Me.img.Images.SetKeyName(8, "clean.ico")
        Me.img.Images.SetKeyName(9, "forward.ico")
        Me.img.Images.SetKeyName(10, "printer.ico")
        Me.img.Images.SetKeyName(11, "chart.ico")
        Me.img.Images.SetKeyName(12, "sale.ico")
        Me.img.Images.SetKeyName(13, "users.ico")
        Me.img.Images.SetKeyName(14, "cut.ico")
        Me.img.Images.SetKeyName(15, "log_out.png")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblJudul)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 37)
        Me.Panel2.TabIndex = 4
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(488, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = "CETAK ULANG PENERIMAAN BARANG MASUK"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.Component = Me.GcPrintQC
        '
        '
        '
        Me.PrintableComponentLink1.ImageCollection.ImageStream = CType(resources.GetObject("PrintableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.PrintableComponentLink1.Margins = New System.Drawing.Printing.Margins(70, 50, 50, 50)
        Me.PrintableComponentLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"", "MONITORING INSPEKSI BARANG MASUK", ""}, New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near), Nothing)
        Me.PrintableComponentLink1.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        Me.PrintableComponentLink1.PrintingSystemBase = Me.PrintingSystem1
        '
        'GcPrintQC
        '
        Me.GcPrintQC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcPrintQC.Location = New System.Drawing.Point(0, 79)
        Me.GcPrintQC.LookAndFeel.SkinName = "The Asphalt World"
        Me.GcPrintQC.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GcPrintQC.MainView = Me.GvPrintQC
        Me.GcPrintQC.Name = "GcPrintQC"
        Me.GcPrintQC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookupBarang, Me.CE_ctk_ulang})
        Me.GcPrintQC.Size = New System.Drawing.Size(792, 290)
        Me.GcPrintQC.TabIndex = 7
        Me.GcPrintQC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvPrintQC})
        '
        'GvPrintQC
        '
        Me.GvPrintQC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.tgl_trans, Me.no_trans, Me.no_ref, Me.kd_stok, Me.kd_satuan, Me.qty_order, Me.qty_qc_pass, Me.qty_hold, Me.qty_qc_unpass, Me.cetak_ke, Me.cetak_ulang, Me.Last_Created_By, Me.GridColumn1})
        Me.GvPrintQC.GridControl = Me.GcPrintQC
        Me.GvPrintQC.Name = "GvPrintQC"
        Me.GvPrintQC.OptionsView.EnableAppearanceEvenRow = True
        Me.GvPrintQC.OptionsView.EnableAppearanceOddRow = True
        Me.GvPrintQC.OptionsView.ShowFooter = True
        Me.GvPrintQC.OptionsView.ShowViewCaption = True
        Me.GvPrintQC.ViewCaption = "CETAK ULANG PENERIMAAN BARANG MASUK"
        '
        'nomer
        '
        Me.nomer.AppearanceHeader.Options.UseTextOptions = True
        Me.nomer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nomer.Caption = "No."
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        Me.nomer.OptionsColumn.AllowEdit = False
        Me.nomer.OptionsColumn.ReadOnly = True
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 55
        '
        'tgl_trans
        '
        Me.tgl_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tgl_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_trans.Caption = "Tgl Trans"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.OptionsColumn.AllowEdit = False
        Me.tgl_trans.OptionsColumn.ReadOnly = True
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 139
        '
        'no_trans
        '
        Me.no_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.no_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_trans.Caption = "Nomor Gudang In"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.OptionsColumn.AllowEdit = False
        Me.no_trans.OptionsColumn.ReadOnly = True
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 2
        Me.no_trans.Width = 136
        '
        'no_ref
        '
        Me.no_ref.AppearanceHeader.Options.UseTextOptions = True
        Me.no_ref.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_ref.Caption = "Referensi"
        Me.no_ref.FieldName = "no_qc"
        Me.no_ref.Name = "no_ref"
        Me.no_ref.OptionsColumn.AllowEdit = False
        Me.no_ref.OptionsColumn.ReadOnly = True
        Me.no_ref.Visible = True
        Me.no_ref.VisibleIndex = 4
        Me.no_ref.Width = 113
        '
        'kd_stok
        '
        Me.kd_stok.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.LookupBarang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.AllowEdit = False
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Width = 241
        '
        'kd_satuan
        '
        Me.kd_satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_satuan.Caption = "Satuan"
        Me.kd_satuan.FieldName = "kd_satuan"
        Me.kd_satuan.Name = "kd_satuan"
        Me.kd_satuan.OptionsColumn.AllowEdit = False
        Me.kd_satuan.OptionsColumn.ReadOnly = True
        Me.kd_satuan.Width = 51
        '
        'qty_order
        '
        Me.qty_order.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_order.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_order.Caption = "Order"
        Me.qty_order.DisplayFormat.FormatString = "N2"
        Me.qty_order.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_order.FieldName = "qty_order"
        Me.qty_order.Name = "qty_order"
        Me.qty_order.OptionsColumn.AllowEdit = False
        Me.qty_order.OptionsColumn.ReadOnly = True
        Me.qty_order.SummaryItem.DisplayFormat = "{0:n2}"
        Me.qty_order.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_order.Width = 74
        '
        'qty_qc_pass
        '
        Me.qty_qc_pass.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_qc_pass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_qc_pass.Caption = "Qty Good"
        Me.qty_qc_pass.DisplayFormat.FormatString = "N2"
        Me.qty_qc_pass.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_qc_pass.FieldName = "qty_qc_pass"
        Me.qty_qc_pass.Name = "qty_qc_pass"
        Me.qty_qc_pass.OptionsColumn.AllowEdit = False
        Me.qty_qc_pass.OptionsColumn.ReadOnly = True
        Me.qty_qc_pass.SummaryItem.DisplayFormat = "{0:n2}"
        Me.qty_qc_pass.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_qc_pass.Width = 89
        '
        'qty_hold
        '
        Me.qty_hold.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_hold.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_hold.Caption = "Qty Hold"
        Me.qty_hold.DisplayFormat.FormatString = "N2"
        Me.qty_hold.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_hold.FieldName = "hold"
        Me.qty_hold.Name = "qty_hold"
        Me.qty_hold.OptionsColumn.AllowEdit = False
        Me.qty_hold.OptionsColumn.ReadOnly = True
        Me.qty_hold.SummaryItem.DisplayFormat = "{0:n2}"
        Me.qty_hold.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_hold.Width = 74
        '
        'qty_qc_unpass
        '
        Me.qty_qc_unpass.AppearanceHeader.Options.UseTextOptions = True
        Me.qty_qc_unpass.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.qty_qc_unpass.Caption = "Qty Tolak"
        Me.qty_qc_unpass.DisplayFormat.FormatString = "N2"
        Me.qty_qc_unpass.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qty_qc_unpass.FieldName = "qty_qc_unpass"
        Me.qty_qc_unpass.Name = "qty_qc_unpass"
        Me.qty_qc_unpass.OptionsColumn.AllowEdit = False
        Me.qty_qc_unpass.OptionsColumn.ReadOnly = True
        Me.qty_qc_unpass.SummaryItem.DisplayFormat = "{0:n2}"
        Me.qty_qc_unpass.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.qty_qc_unpass.Width = 73
        '
        'cetak_ke
        '
        Me.cetak_ke.Caption = "Jml Cetak"
        Me.cetak_ke.FieldName = "cetak_ke"
        Me.cetak_ke.Name = "cetak_ke"
        Me.cetak_ke.OptionsColumn.AllowEdit = False
        Me.cetak_ke.OptionsColumn.ReadOnly = True
        Me.cetak_ke.Visible = True
        Me.cetak_ke.VisibleIndex = 5
        Me.cetak_ke.Width = 82
        '
        'cetak_ulang
        '
        Me.cetak_ulang.Caption = "Cetak Ulang"
        Me.cetak_ulang.ColumnEdit = Me.CE_ctk_ulang
        Me.cetak_ulang.FieldName = "cetak_ulang"
        Me.cetak_ulang.Name = "cetak_ulang"
        Me.cetak_ulang.Visible = True
        Me.cetak_ulang.VisibleIndex = 6
        Me.cetak_ulang.Width = 94
        '
        'Last_Created_By
        '
        Me.Last_Created_By.AppearanceHeader.Options.UseTextOptions = True
        Me.Last_Created_By.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Last_Created_By.Caption = "Petugas Penerimaan"
        Me.Last_Created_By.FieldName = "Last_Created_By"
        Me.Last_Created_By.Name = "Last_Created_By"
        Me.Last_Created_By.OptionsColumn.AllowEdit = False
        Me.Last_Created_By.Visible = True
        Me.Last_Created_By.VisibleIndex = 3
        Me.Last_Created_By.Width = 152
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "JenisBM"
        Me.GridColumn1.FieldName = "nama_qc"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1})
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcPrintQC)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(792, 369)
        Me.pnl.TabIndex = 5
        '
        'frCtkMassGudangIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 369)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frCtkMassGudangIn"
        Me.Text = "frCetakUlangQC"
        CType(Me.LookupBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CE_ctk_ulang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.tglsampai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglsampai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglDari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintableComponentLink1.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcPrintQC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvPrintQC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Last_Created_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents tglsampai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglDari As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CE_ctk_ulang As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents GcPrintQC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvPrintQC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookupBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_pass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_qc_unpass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cetak_ke As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cetak_ulang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
