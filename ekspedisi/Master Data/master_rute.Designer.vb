﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class master_rute
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(master_rute))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.id = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.datasiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.mastersiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.addrutebaru = New DevExpress.XtraBars.BarButtonItem()
        Me.edit = New DevExpress.XtraBars.BarButtonItem()
        Me.deldata = New DevExpress.XtraBars.BarButtonItem()
        Me.jumpmenu = New DevExpress.XtraBars.BarButtonItem()
        Me.ubahharga = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.nonaktif = New System.Windows.Forms.RadioButton()
        Me.aktif = New System.Windows.Forms.RadioButton()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Print = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.editing = New DevExpress.XtraEditors.SimpleButton()
        Me.hapus = New DevExpress.XtraEditors.SimpleButton()
        Me.msiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Controls.Add(Me.cari)
        Me.GroupControl1.Location = New System.Drawing.Point(15, 124)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(307, 94)
        Me.GroupControl1.TabIndex = 51
        Me.GroupControl1.Text = "Cari Berdasarkan"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Checked = True
        Me.id.Location = New System.Drawing.Point(6, 31)
        Me.id.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(76, 21)
        Me.id.TabIndex = 1
        Me.id.TabStop = True
        Me.id.Text = "ID Rute"
        Me.id.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(6, 64)
        Me.cari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cari.MenuManager = Me.RibbonControl1
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(295, 22)
        Me.cari.TabIndex = 0
        '
        'RibbonControl1
        '
        Me.RibbonControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonGalleryBarItem1, Me.datasiswa, Me.BarSubItem1, Me.mastersiswa, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.addrutebaru, Me.edit, Me.deldata, Me.jumpmenu, Me.ubahharga})
        Me.RibbonControl1.Location = New System.Drawing.Point(1, -1)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonControl1.MaxItemId = 33
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1184, 104)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'RibbonGalleryBarItem1
        '
        Me.RibbonGalleryBarItem1.Caption = "InplaceGallery1"
        Me.RibbonGalleryBarItem1.Id = 11
        Me.RibbonGalleryBarItem1.Name = "RibbonGalleryBarItem1"
        '
        'datasiswa
        '
        Me.datasiswa.Caption = "Master Data Siswa"
        Me.datasiswa.Glyph = CType(resources.GetObject("datasiswa.Glyph"), System.Drawing.Image)
        Me.datasiswa.Id = 10
        Me.datasiswa.Name = "datasiswa"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "BarSubItem1"
        Me.BarSubItem1.Id = 12
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Master Data Siswa"
        Me.BarButtonItem3.Id = 15
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Master Data Level"
        Me.BarButtonItem5.Id = 17
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'mastersiswa
        '
        Me.mastersiswa.Caption = "Master Data Siswa"
        Me.mastersiswa.Id = 13
        Me.mastersiswa.LargeGlyph = CType(resources.GetObject("mastersiswa.LargeGlyph"), System.Drawing.Image)
        Me.mastersiswa.LargeGlyphDisabled = CType(resources.GetObject("mastersiswa.LargeGlyphDisabled"), System.Drawing.Image)
        Me.mastersiswa.Name = "mastersiswa"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Master Data"
        Me.BarButtonItem4.Id = 16
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Master Data Buku"
        Me.BarButtonItem6.Id = 19
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Master Data Ruang"
        Me.BarButtonItem7.Id = 20
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Master Data Guru"
        Me.BarButtonItem8.Id = 21
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Master Data User"
        Me.BarButtonItem9.Id = 22
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'addrutebaru
        '
        Me.addrutebaru.Caption = "Tambah Data"
        Me.addrutebaru.Glyph = CType(resources.GetObject("addrutebaru.Glyph"), System.Drawing.Image)
        Me.addrutebaru.Id = 23
        Me.addrutebaru.LargeGlyph = CType(resources.GetObject("addrutebaru.LargeGlyph"), System.Drawing.Image)
        Me.addrutebaru.Name = "addrutebaru"
        '
        'edit
        '
        Me.edit.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.edit.Caption = "Edit Data"
        Me.edit.Glyph = CType(resources.GetObject("edit.Glyph"), System.Drawing.Image)
        Me.edit.Id = 27
        Me.edit.LargeGlyph = CType(resources.GetObject("edit.LargeGlyph"), System.Drawing.Image)
        Me.edit.Name = "edit"
        '
        'deldata
        '
        Me.deldata.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.deldata.Caption = "Delete Data"
        Me.deldata.Glyph = CType(resources.GetObject("deldata.Glyph"), System.Drawing.Image)
        Me.deldata.Id = 30
        Me.deldata.LargeGlyph = CType(resources.GetObject("deldata.LargeGlyph"), System.Drawing.Image)
        Me.deldata.Name = "deldata"
        '
        'jumpmenu
        '
        Me.jumpmenu.Caption = "Main Menu"
        Me.jumpmenu.Glyph = CType(resources.GetObject("jumpmenu.Glyph"), System.Drawing.Image)
        Me.jumpmenu.Id = 31
        Me.jumpmenu.LargeGlyph = CType(resources.GetObject("jumpmenu.LargeGlyph"), System.Drawing.Image)
        Me.jumpmenu.Name = "jumpmenu"
        '
        'ubahharga
        '
        Me.ubahharga.Caption = "Perubahan Harga"
        Me.ubahharga.Glyph = CType(resources.GetObject("ubahharga.Glyph"), System.Drawing.Image)
        Me.ubahharga.Id = 32
        Me.ubahharga.LargeGlyph = CType(resources.GetObject("ubahharga.LargeGlyph"), System.Drawing.Image)
        Me.ubahharga.Name = "ubahharga"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.jumpmenu)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.addrutebaru)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.edit)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.deldata)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ubahharga)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.nonaktif)
        Me.GroupControl2.Controls.Add(Me.aktif)
        Me.GroupControl2.Location = New System.Drawing.Point(329, 124)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(175, 94)
        Me.GroupControl2.TabIndex = 53
        Me.GroupControl2.Text = "Sortir"
        '
        'nonaktif
        '
        Me.nonaktif.AutoSize = True
        Me.nonaktif.Location = New System.Drawing.Point(6, 59)
        Me.nonaktif.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nonaktif.Name = "nonaktif"
        Me.nonaktif.Size = New System.Drawing.Size(118, 21)
        Me.nonaktif.TabIndex = 9
        Me.nonaktif.Text = "Rute Non-Aktif"
        Me.nonaktif.UseVisualStyleBackColor = True
        '
        'aktif
        '
        Me.aktif.AutoSize = True
        Me.aktif.Checked = True
        Me.aktif.Location = New System.Drawing.Point(6, 31)
        Me.aktif.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.aktif.Name = "aktif"
        Me.aktif.Size = New System.Drawing.Size(88, 21)
        Me.aktif.TabIndex = 8
        Me.aktif.TabStop = True
        Me.aktif.Text = "Rute Aktif"
        Me.aktif.UseVisualStyleBackColor = True
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(1045, 810)
        Me.cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(117, 33)
        Me.cancel.TabIndex = 56
        Me.cancel.Text = "Cancel"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl2)
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Location = New System.Drawing.Point(15, 225)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1147, 577)
        Me.GroupControl3.TabIndex = 55
        Me.GroupControl3.Text = "Data Rute"
        '
        'GridControl2
        '
        Me.GridControl2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl2.Location = New System.Drawing.Point(6, 30)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl2.MenuManager = Me.RibbonControl1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1135, 542)
        Me.GridControl2.TabIndex = 8
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.MultiSelect = True
        Me.GridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(6, 30)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1135, 542)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Print})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(115, 30)
        '
        'Print
        '
        Me.Print.Image = CType(resources.GetObject("Print.Image"), System.Drawing.Image)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(114, 26)
        Me.Print.Text = "Print"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'editing
        '
        Me.editing.Location = New System.Drawing.Point(15, 810)
        Me.editing.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.editing.Name = "editing"
        Me.editing.Size = New System.Drawing.Size(231, 32)
        Me.editing.TabIndex = 52
        Me.editing.Text = "Edit"
        Me.editing.Visible = False
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(15, 810)
        Me.hapus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(231, 32)
        Me.hapus.TabIndex = 54
        Me.hapus.Text = "Delete"
        Me.hapus.Visible = False
        '
        'msiswa
        '
        Me.msiswa.ActAsDropDown = True
        Me.msiswa.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.msiswa.Caption = "Master Data"
        Me.msiswa.Glyph = CType(resources.GetObject("msiswa.Glyph"), System.Drawing.Image)
        Me.msiswa.Id = 1
        Me.msiswa.LargeGlyph = CType(resources.GetObject("msiswa.LargeGlyph"), System.Drawing.Image)
        Me.msiswa.Name = "msiswa"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.ActAsDropDown = True
        Me.BarButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItem2.Caption = "Master Data"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1081, 182)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(80, 36)
        Me.SimpleButton1.TabIndex = 58
        Me.SimpleButton1.Text = "Print"
        '
        'master_rute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 858)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.editing)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "master_rute"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Rute"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents id As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents datasiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mastersiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents addrutebaru As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents deldata As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents jumpmenu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nonaktif As System.Windows.Forms.RadioButton
    Friend WithEvents aktif As System.Windows.Forms.RadioButton
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents editing As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents hapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents msiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ubahharga As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Print As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
