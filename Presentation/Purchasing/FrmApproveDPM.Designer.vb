﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmApproveDPM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmApproveDPM))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GcApprvDPM = New DevExpress.XtraGrid.GridControl
        Me.GVApprvDPM = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.tipe_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Departemen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupDivisi = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.No_DPM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Tgl_DPM = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RBrecstat = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.ket_approve = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GCInfo = New DevExpress.XtraGrid.GridControl
        Me.GVInfo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GcApprvDPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVApprvDPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GCInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(859, 512)
        Me.pnl.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GcApprvDPM)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(859, 365)
        Me.Panel3.TabIndex = 139
        '
        'GcApprvDPM
        '
        Me.GcApprvDPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcApprvDPM.Location = New System.Drawing.Point(0, 0)
        Me.GcApprvDPM.MainView = Me.GVApprvDPM
        Me.GcApprvDPM.Name = "GcApprvDPM"
        Me.GcApprvDPM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupDivisi, Me.RBrecstat})
        Me.GcApprvDPM.Size = New System.Drawing.Size(859, 365)
        Me.GcApprvDPM.TabIndex = 137
        Me.GcApprvDPM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVApprvDPM})
        '
        'GVApprvDPM
        '
        Me.GVApprvDPM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tipe_trans, Me.Departemen, Me.No_DPM, Me.Tgl_DPM, Me.Keterangan, Me.rec_stat, Me.ket_approve})
        Me.GVApprvDPM.GridControl = Me.GcApprvDPM
        Me.GVApprvDPM.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVApprvDPM.Name = "GVApprvDPM"
        Me.GVApprvDPM.OptionsView.EnableAppearanceEvenRow = True
        Me.GVApprvDPM.OptionsView.EnableAppearanceOddRow = True
        Me.GVApprvDPM.OptionsView.RowAutoHeight = True
        Me.GVApprvDPM.OptionsView.ShowFooter = True
        Me.GVApprvDPM.OptionsView.ShowGroupPanel = False
        Me.GVApprvDPM.PaintStyleName = "Office2003"
        Me.GVApprvDPM.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'tipe_trans
        '
        Me.tipe_trans.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipe_trans.AppearanceHeader.Options.UseFont = True
        Me.tipe_trans.AppearanceHeader.Options.UseTextOptions = True
        Me.tipe_trans.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tipe_trans.Caption = "Jenis DPM"
        Me.tipe_trans.FieldName = "tipe_trans"
        Me.tipe_trans.Name = "tipe_trans"
        Me.tipe_trans.OptionsColumn.AllowEdit = False
        Me.tipe_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.tipe_trans.Visible = True
        Me.tipe_trans.VisibleIndex = 0
        Me.tipe_trans.Width = 71
        '
        'Departemen
        '
        Me.Departemen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departemen.AppearanceHeader.Options.UseFont = True
        Me.Departemen.AppearanceHeader.Options.UseTextOptions = True
        Me.Departemen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Departemen.Caption = "Divisi"
        Me.Departemen.ColumnEdit = Me.lookupDivisi
        Me.Departemen.FieldName = "Departemen"
        Me.Departemen.Name = "Departemen"
        Me.Departemen.OptionsColumn.AllowEdit = False
        Me.Departemen.Visible = True
        Me.Departemen.VisibleIndex = 1
        Me.Departemen.Width = 136
        '
        'lookupDivisi
        '
        Me.lookupDivisi.AutoHeight = False
        Me.lookupDivisi.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupDivisi.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Divisi")})
        Me.lookupDivisi.Name = "lookupDivisi"
        Me.lookupDivisi.NullText = "Klik disini"
        '
        'No_DPM
        '
        Me.No_DPM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_DPM.AppearanceHeader.Options.UseFont = True
        Me.No_DPM.AppearanceHeader.Options.UseTextOptions = True
        Me.No_DPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.No_DPM.Caption = "No DPM"
        Me.No_DPM.FieldName = "No_DPM"
        Me.No_DPM.Name = "No_DPM"
        Me.No_DPM.OptionsColumn.AllowEdit = False
        Me.No_DPM.Visible = True
        Me.No_DPM.VisibleIndex = 2
        Me.No_DPM.Width = 63
        '
        'Tgl_DPM
        '
        Me.Tgl_DPM.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tgl_DPM.AppearanceHeader.Options.UseFont = True
        Me.Tgl_DPM.AppearanceHeader.Options.UseTextOptions = True
        Me.Tgl_DPM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Tgl_DPM.Caption = "Tanggal"
        Me.Tgl_DPM.FieldName = "Tgl_DPM"
        Me.Tgl_DPM.Name = "Tgl_DPM"
        Me.Tgl_DPM.OptionsColumn.AllowEdit = False
        Me.Tgl_DPM.Visible = True
        Me.Tgl_DPM.VisibleIndex = 3
        Me.Tgl_DPM.Width = 64
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Keterangan.AppearanceHeader.Options.UseFont = True
        Me.Keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.OptionsColumn.AllowEdit = False
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 4
        Me.Keterangan.Width = 96
        '
        'rec_stat
        '
        Me.rec_stat.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rec_stat.AppearanceHeader.Options.UseFont = True
        Me.rec_stat.AppearanceHeader.Options.UseTextOptions = True
        Me.rec_stat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.rec_stat.Caption = "Approval"
        Me.rec_stat.ColumnEdit = Me.RBrecstat
        Me.rec_stat.FieldName = "rec_stat"
        Me.rec_stat.Name = "rec_stat"
        Me.rec_stat.Visible = True
        Me.rec_stat.VisibleIndex = 5
        Me.rec_stat.Width = 83
        '
        'RBrecstat
        '
        Me.RBrecstat.AutoHeight = False
        Me.RBrecstat.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RBrecstat.Items.AddRange(New Object() {"APPROVE", "REJECT", "PERBAIKAN"})
        Me.RBrecstat.Name = "RBrecstat"
        '
        'ket_approve
        '
        Me.ket_approve.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ket_approve.AppearanceHeader.Options.UseFont = True
        Me.ket_approve.AppearanceHeader.Options.UseTextOptions = True
        Me.ket_approve.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ket_approve.Caption = "Alasan Reject"
        Me.ket_approve.FieldName = "ket_approve"
        Me.ket_approve.MinWidth = 100
        Me.ket_approve.Name = "ket_approve"
        Me.ket_approve.Visible = True
        Me.ket_approve.VisibleIndex = 6
        Me.ket_approve.Width = 242
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(859, 34)
        Me.Panel1.TabIndex = 137
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 32)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(44, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "FORM APPROVAL DPM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.GCInfo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 399)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(859, 113)
        Me.Panel2.TabIndex = 138
        '
        'GCInfo
        '
        Me.GCInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCInfo.Location = New System.Drawing.Point(0, 0)
        Me.GCInfo.MainView = Me.GVInfo
        Me.GCInfo.Name = "GCInfo"
        Me.GCInfo.Size = New System.Drawing.Size(859, 113)
        Me.GCInfo.TabIndex = 0
        Me.GCInfo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVInfo})
        '
        'GVInfo
        '
        Me.GVInfo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GVInfo.GridControl = Me.GCInfo
        Me.GVInfo.Name = "GVInfo"
        Me.GVInfo.OptionsView.ShowGroupPanel = False
        Me.GVInfo.OptionsView.ShowViewCaption = True
        Me.GVInfo.ViewCaption = "Info Detail DPM"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "No"
        Me.GridColumn1.FieldName = "No_Seq"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 37
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Barang"
        Me.GridColumn2.FieldName = "Nama_Barang"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 255
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Spek"
        Me.GridColumn3.FieldName = "spek_brg"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 194
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Satuan"
        Me.GridColumn4.FieldName = "Satuan"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 67
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Jumlah"
        Me.GridColumn5.FieldName = "Qty"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 77
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Keterangan"
        Me.GridColumn6.FieldName = "Keterangan"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 103
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Tanggal Perlu"
        Me.GridColumn7.FieldName = "Tgl_Diperlukan"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 105
        '
        'FrmApproveDPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 512)
        Me.Controls.Add(Me.pnl)
        Me.Name = "FrmApproveDPM"
        Me.Text = "FORM APPROVAL DPM"
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GcApprvDPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVApprvDPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupDivisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RBrecstat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.GCInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GcApprvDPM As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVApprvDPM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tipe_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Departemen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupDivisi As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents No_DPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tgl_DPM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RBrecstat As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ket_approve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GVInfo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCInfo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
End Class