﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPLNSPiutKaryawan
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.kd_kartu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupnama = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.lookupPeg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.prev_no_inv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.jml_tagihan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtAngka = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.jml_bayar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_buku_besar = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jml_piut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.txtbayar = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.pnl1 = New System.Windows.Forms.Panel
        Me.pnl12 = New System.Windows.Forms.Panel
        Me.txtketerangan = New System.Windows.Forms.TextBox
        Me.lookPelunasan = New DevExpress.XtraEditors.LookUpEdit
        Me.dttgl_inv = New DevExpress.XtraEditors.DateEdit
        Me.txtno_inv = New System.Windows.Forms.TextBox
        Me.pnl11 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.lookupnama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupPeg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAngka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbayar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.pnl12.SuspendLayout()
        CType(Me.lookPelunasan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttgl_inv.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dttgl_inv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl11.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'kd_kartu
        '
        Me.kd_kartu.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kd_kartu.AppearanceHeader.Options.UseFont = True
        Me.kd_kartu.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_kartu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_kartu.Caption = "Nama Karyawan"
        Me.kd_kartu.ColumnEdit = Me.lookupnama
        Me.kd_kartu.FieldName = "kd_kartu"
        Me.kd_kartu.Name = "kd_kartu"
        Me.kd_kartu.OptionsColumn.AllowEdit = False
        Me.kd_kartu.OptionsColumn.ReadOnly = True
        Me.kd_kartu.Visible = True
        Me.kd_kartu.VisibleIndex = 2
        Me.kd_kartu.Width = 170
        '
        'lookupnama
        '
        Me.lookupnama.AutoHeight = False
        Me.lookupnama.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupnama.Name = "lookupnama"
        Me.lookupnama.NullText = "[Nama]"
        '
        'lookupPeg
        '
        Me.lookupPeg.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookupPeg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupPeg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nama", "Nama Karyawan"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_inv", "No. Inv"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("jml_akhir", "Jumlah Tagihan", 20, DevExpress.Utils.FormatType.Numeric, "n2", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.lookupPeg.Name = "lookupPeg"
        Me.lookupPeg.NullText = "[Pilih No. Permohonan]"
        '
        'prev_no_inv
        '
        Me.prev_no_inv.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prev_no_inv.AppearanceHeader.Options.UseFont = True
        Me.prev_no_inv.AppearanceHeader.Options.UseTextOptions = True
        Me.prev_no_inv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.prev_no_inv.Caption = "No. Permohonan"
        Me.prev_no_inv.ColumnEdit = Me.lookupPeg
        Me.prev_no_inv.FieldName = "prev_no_inv"
        Me.prev_no_inv.Name = "prev_no_inv"
        Me.prev_no_inv.Visible = True
        Me.prev_no_inv.VisibleIndex = 1
        Me.prev_no_inv.Width = 125
        '
        'no_seq
        '
        Me.no_seq.AppearanceCell.Options.UseTextOptions = True
        Me.no_seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.no_seq.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.no_seq.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no_seq.AppearanceHeader.Options.UseBackColor = True
        Me.no_seq.AppearanceHeader.Options.UseFont = True
        Me.no_seq.AppearanceHeader.Options.UseTextOptions = True
        Me.no_seq.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.no_seq.Caption = "No."
        Me.no_seq.FieldName = "no_seq"
        Me.no_seq.Name = "no_seq"
        Me.no_seq.OptionsColumn.AllowEdit = False
        Me.no_seq.OptionsColumn.ReadOnly = True
        Me.no_seq.Visible = True
        Me.no_seq.VisibleIndex = 0
        Me.no_seq.Width = 41
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GC)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(-1, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(913, 488)
        Me.pnl.TabIndex = 12
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 159)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupPeg, Me.lookupnama, Me.txtbayar, Me.txtAngka})
        Me.GC.Size = New System.Drawing.Size(913, 329)
        Me.GC.TabIndex = 6
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_seq, Me.prev_no_inv, Me.kd_kartu, Me.jml_tagihan, Me.jml_bayar, Me.keterangan, Me.kd_buku_besar, Me.jml_piut})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.NewItemRowText = "Tambah data baru disini"
        Me.GV.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV.OptionsView.ShowFooter = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.PaintStyleName = "Office2003"
        '
        'jml_tagihan
        '
        Me.jml_tagihan.AppearanceCell.Options.UseTextOptions = True
        Me.jml_tagihan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jml_tagihan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_tagihan.AppearanceHeader.Options.UseFont = True
        Me.jml_tagihan.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_tagihan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_tagihan.Caption = "Sisa Piutang"
        Me.jml_tagihan.ColumnEdit = Me.txtAngka
        Me.jml_tagihan.DisplayFormat.FormatString = "n2"
        Me.jml_tagihan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_tagihan.FieldName = "jml_tagihan"
        Me.jml_tagihan.Name = "jml_tagihan"
        Me.jml_tagihan.OptionsColumn.AllowEdit = False
        Me.jml_tagihan.OptionsColumn.ReadOnly = True
        Me.jml_tagihan.Visible = True
        Me.jml_tagihan.VisibleIndex = 3
        Me.jml_tagihan.Width = 119
        '
        'txtAngka
        '
        Me.txtAngka.AutoHeight = False
        Me.txtAngka.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtAngka.DisplayFormat.FormatString = "n2"
        Me.txtAngka.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtAngka.Mask.EditMask = "n2"
        Me.txtAngka.Mask.UseMaskAsDisplayFormat = True
        Me.txtAngka.Name = "txtAngka"
        '
        'jml_bayar
        '
        Me.jml_bayar.AppearanceCell.Options.UseTextOptions = True
        Me.jml_bayar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jml_bayar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jml_bayar.AppearanceHeader.Options.UseFont = True
        Me.jml_bayar.AppearanceHeader.Options.UseTextOptions = True
        Me.jml_bayar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jml_bayar.Caption = "Jml. Bayar"
        Me.jml_bayar.ColumnEdit = Me.txtAngka
        Me.jml_bayar.DisplayFormat.FormatString = "n2"
        Me.jml_bayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jml_bayar.FieldName = "jml_bayar"
        Me.jml_bayar.Name = "jml_bayar"
        Me.jml_bayar.SummaryItem.DisplayFormat = "{0:n2}"
        Me.jml_bayar.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.jml_bayar.Visible = True
        Me.jml_bayar.VisibleIndex = 4
        Me.jml_bayar.Width = 118
        '
        'keterangan
        '
        Me.keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keterangan.AppearanceHeader.Options.UseFont = True
        Me.keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.FieldName = "keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 5
        Me.keterangan.Width = 195
        '
        'kd_buku_besar
        '
        Me.kd_buku_besar.Caption = "Kode Buku Besar"
        Me.kd_buku_besar.FieldName = "kd_buku_besar"
        Me.kd_buku_besar.Name = "kd_buku_besar"
        '
        'jml_piut
        '
        Me.jml_piut.Caption = "GridColumn1"
        Me.jml_piut.FieldName = "jml_piut"
        Me.jml_piut.Name = "jml_piut"
        '
        'txtbayar
        '
        Me.txtbayar.AutoHeight = False
        Me.txtbayar.DisplayFormat.FormatString = "n2"
        Me.txtbayar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtbayar.Name = "txtbayar"
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlTools.Controls.Add(Me.pnl1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(913, 125)
        Me.pnlTools.TabIndex = 5
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.SystemColors.Control
        Me.pnl1.Controls.Add(Me.pnl12)
        Me.pnl1.Controls.Add(Me.pnl11)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(680, 125)
        Me.pnl1.TabIndex = 0
        '
        'pnl12
        '
        Me.pnl12.Controls.Add(Me.txtketerangan)
        Me.pnl12.Controls.Add(Me.lookPelunasan)
        Me.pnl12.Controls.Add(Me.dttgl_inv)
        Me.pnl12.Controls.Add(Me.txtno_inv)
        Me.pnl12.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl12.Location = New System.Drawing.Point(248, 0)
        Me.pnl12.Name = "pnl12"
        Me.pnl12.Size = New System.Drawing.Size(430, 125)
        Me.pnl12.TabIndex = 3
        '
        'txtketerangan
        '
        Me.txtketerangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtketerangan.Location = New System.Drawing.Point(0, 60)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(430, 58)
        Me.txtketerangan.TabIndex = 3
        '
        'lookPelunasan
        '
        Me.lookPelunasan.Dock = System.Windows.Forms.DockStyle.Top
        Me.lookPelunasan.Location = New System.Drawing.Point(0, 40)
        Me.lookPelunasan.Name = "lookPelunasan"
        Me.lookPelunasan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.lookPelunasan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookPelunasan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Name1")})
        Me.lookPelunasan.Properties.NullText = "[Pilih pelunasan]"
        Me.lookPelunasan.Properties.ShowFooter = False
        Me.lookPelunasan.Properties.ShowHeader = False
        Me.lookPelunasan.Properties.ShowPopupShadow = False
        Me.lookPelunasan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lookPelunasan.Properties.ValidateOnEnterKey = True
        Me.lookPelunasan.Size = New System.Drawing.Size(430, 20)
        Me.lookPelunasan.TabIndex = 1
        '
        'dttgl_inv
        '
        Me.dttgl_inv.Dock = System.Windows.Forms.DockStyle.Top
        Me.dttgl_inv.EditValue = Nothing
        Me.dttgl_inv.EnterMoveNextControl = True
        Me.dttgl_inv.Location = New System.Drawing.Point(0, 20)
        Me.dttgl_inv.Name = "dttgl_inv"
        Me.dttgl_inv.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.dttgl_inv.Properties.Appearance.Options.UseForeColor = True
        Me.dttgl_inv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dttgl_inv.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dttgl_inv.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dttgl_inv.Properties.Mask.EditMask = "d MMMM yyyy"
        Me.dttgl_inv.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dttgl_inv.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dttgl_inv.Size = New System.Drawing.Size(430, 20)
        Me.dttgl_inv.TabIndex = 1
        Me.dttgl_inv.ToolTip = "Format : dd/mm/yyyy"
        '
        'txtno_inv
        '
        Me.txtno_inv.BackColor = System.Drawing.Color.Cornsilk
        Me.txtno_inv.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtno_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno_inv.ForeColor = System.Drawing.Color.Yellow
        Me.txtno_inv.Location = New System.Drawing.Point(0, 0)
        Me.txtno_inv.Name = "txtno_inv"
        Me.txtno_inv.ReadOnly = True
        Me.txtno_inv.Size = New System.Drawing.Size(430, 20)
        Me.txtno_inv.TabIndex = 0
        '
        'pnl11
        '
        Me.pnl11.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnl11.Controls.Add(Me.Label1)
        Me.pnl11.Controls.Add(Me.Label5)
        Me.pnl11.Controls.Add(Me.Label2)
        Me.pnl11.Controls.Add(Me.Label6)
        Me.pnl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl11.Location = New System.Drawing.Point(0, 0)
        Me.pnl11.Name = "pnl11"
        Me.pnl11.Size = New System.Drawing.Size(248, 125)
        Me.pnl11.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(248, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Keterangan :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(248, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pelunasan :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(248, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tanggal :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(248, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nomor  :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlTitle.Size = New System.Drawing.Size(913, 34)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(657, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "PELUNASAN PIUTANG KARYAWAN"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Presentation.My.Resources.Resources.american_miring
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 32)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmPLNSPiutKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 567)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmPLNSPiutKaryawan"
        Me.Text = " "
        CType(Me.lookupnama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupPeg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAngka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        Me.pnl1.ResumeLayout(False)
        Me.pnl12.ResumeLayout(False)
        Me.pnl12.PerformLayout()
        CType(Me.lookPelunasan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttgl_inv.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dttgl_inv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl11.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents kd_kartu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents prev_no_inv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupPeg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents no_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents jml_tagihan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jml_bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents pnl11 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_buku_besar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupnama As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtbayar As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtAngka As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents jml_piut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnl12 As System.Windows.Forms.Panel
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents lookPelunasan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dttgl_inv As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtno_inv As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class