﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi_DO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaksi_DO))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.kodetrans = New System.Windows.Forms.TextBox()
        Me.idbooking = New DevExpress.XtraEditors.ButtonEdit()
        Me.nomerdo = New System.Windows.Forms.TextBox()
        Me.tanggalterkirim = New System.Windows.Forms.DateTimePicker()
        Me.tanggaljatuhtempo = New System.Windows.Forms.DateTimePicker()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.datasetdo = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.namabarang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.kgsatuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.berat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemButtonEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.tgldo = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.idbooking.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetdo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(69, 17)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(126, 23)
        Me.LabelControl1.TabIndex = 33
        Me.LabelControl1.Text = "Kode Transaksi"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(83, 47)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(114, 23)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Kode Booking"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(869, 47)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 23)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Nomer DO"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(84, 106)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(116, 23)
        Me.LabelControl4.TabIndex = 36
        Me.LabelControl4.Text = "Tanggal Kirim"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(14, 138)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(190, 23)
        Me.LabelControl6.TabIndex = 38
        Me.LabelControl6.Text = "Tanggal Jatuh Tempo "
        '
        'kodetrans
        '
        Me.kodetrans.Enabled = False
        Me.kodetrans.Location = New System.Drawing.Point(204, 14)
        Me.kodetrans.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.kodetrans.Name = "kodetrans"
        Me.kodetrans.Size = New System.Drawing.Size(136, 23)
        Me.kodetrans.TabIndex = 1
        '
        'idbooking
        '
        Me.idbooking.Location = New System.Drawing.Point(204, 44)
        Me.idbooking.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.idbooking.Name = "idbooking"
        Me.idbooking.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.idbooking.Properties.ReadOnly = True
        Me.idbooking.Size = New System.Drawing.Size(192, 22)
        Me.idbooking.TabIndex = 2
        '
        'nomerdo
        '
        Me.nomerdo.Location = New System.Drawing.Point(969, 43)
        Me.nomerdo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nomerdo.Name = "nomerdo"
        Me.nomerdo.Size = New System.Drawing.Size(192, 23)
        Me.nomerdo.TabIndex = 7
        '
        'tanggalterkirim
        '
        Me.tanggalterkirim.CustomFormat = "ddMMyyyy"
        Me.tanggalterkirim.Enabled = False
        Me.tanggalterkirim.Location = New System.Drawing.Point(204, 106)
        Me.tanggalterkirim.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tanggalterkirim.Name = "tanggalterkirim"
        Me.tanggalterkirim.Size = New System.Drawing.Size(233, 23)
        Me.tanggalterkirim.TabIndex = 4
        '
        'tanggaljatuhtempo
        '
        Me.tanggaljatuhtempo.Location = New System.Drawing.Point(204, 138)
        Me.tanggaljatuhtempo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tanggaljatuhtempo.Name = "tanggaljatuhtempo"
        Me.tanggaljatuhtempo.Size = New System.Drawing.Size(233, 23)
        Me.tanggaljatuhtempo.TabIndex = 5
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1030, 785)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(138, 33)
        Me.SimpleButton1.TabIndex = 11
        Me.SimpleButton1.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(885, 785)
        Me.Submit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(138, 33)
        Me.Submit.TabIndex = 10
        Me.Submit.Text = "Submit"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Location = New System.Drawing.Point(447, 190)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(721, 585)
        Me.GroupControl3.TabIndex = 148
        Me.GroupControl3.Text = "Data Transaksi"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.datasetdo
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(2, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.RepositoryItemButtonEdit2, Me.RepositoryItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(717, 559)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'datasetdo
        '
        Me.datasetdo.DataSetName = "datasetdo"
        Me.datasetdo.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "namabarang"
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "berat"
        Me.DataColumn2.DataType = GetType(Double)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "kgsatuan"
        Me.DataColumn3.DataType = GetType(Double)
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "satuan"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.satuan, Me.namabarang, Me.kgsatuan, Me.berat})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.berat, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'satuan
        '
        Me.satuan.Caption = "Satuan"
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.OptionsColumn.ReadOnly = True
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 2
        Me.satuan.Width = 139
        '
        'namabarang
        '
        Me.namabarang.Caption = "Nama Barang"
        Me.namabarang.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.namabarang.FieldName = "namabarang"
        Me.namabarang.Name = "namabarang"
        Me.namabarang.Visible = True
        Me.namabarang.VisibleIndex = 0
        Me.namabarang.Width = 292
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'kgsatuan
        '
        Me.kgsatuan.Caption = "Jumlah Satuan"
        Me.kgsatuan.DisplayFormat.FormatString = "{0:n0}"
        Me.kgsatuan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.kgsatuan.FieldName = "kgsatuan"
        Me.kgsatuan.Name = "kgsatuan"
        Me.kgsatuan.Visible = True
        Me.kgsatuan.VisibleIndex = 1
        Me.kgsatuan.Width = 126
        '
        'berat
        '
        Me.berat.Caption = "Berat (Kg)"
        Me.berat.DisplayFormat.FormatString = "{0:n2}"
        Me.berat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.berat.FieldName = "berat"
        Me.berat.Name = "berat"
        Me.berat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "berat", "TOTAL {0:n2} Kilogram")})
        Me.berat.Visible = True
        Me.berat.VisibleIndex = 3
        Me.berat.Width = 139
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'RepositoryItemButtonEdit2
        '
        Me.RepositoryItemButtonEdit2.AutoHeight = False
        Me.RepositoryItemButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit2.Name = "RepositoryItemButtonEdit2"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(841, 17)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(125, 23)
        Me.LabelControl7.TabIndex = 149
        Me.LabelControl7.Text = "Nama Principle"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(969, 14)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 23)
        Me.TextBox2.TabIndex = 6
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(741, 785)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(138, 33)
        Me.SimpleButton3.TabIndex = 9
        Me.SimpleButton3.Text = "Submit and Print"
        '
        'tgldo
        '
        Me.tgldo.CustomFormat = "ddMMyyyy"
        Me.tgldo.Location = New System.Drawing.Point(204, 76)
        Me.tgldo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tgldo.Name = "tgldo"
        Me.tgldo.Size = New System.Drawing.Size(233, 23)
        Me.tgldo.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(94, 79)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(100, 23)
        Me.LabelControl5.TabIndex = 155
        Me.LabelControl5.Text = "Tanggal DO"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.PictureEdit1)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 190)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(428, 585)
        Me.GroupControl1.TabIndex = 156
        Me.GroupControl1.Text = "Scan DO"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.Location = New System.Drawing.Point(2, 24)
        Me.PictureEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit1.Size = New System.Drawing.Size(424, 559)
        Me.PictureEdit1.TabIndex = 0
        '
        'transaksi_DO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 833)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.tgldo)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.tanggaljatuhtempo)
        Me.Controls.Add(Me.tanggalterkirim)
        Me.Controls.Add(Me.nomerdo)
        Me.Controls.Add(Me.idbooking)
        Me.Controls.Add(Me.kodetrans)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "transaksi_DO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery Order"
        CType(Me.idbooking.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetdo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kodetrans As System.Windows.Forms.TextBox
    Friend WithEvents idbooking As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents nomerdo As System.Windows.Forms.TextBox
    Friend WithEvents tanggalterkirim As System.Windows.Forms.DateTimePicker
    Friend WithEvents tanggaljatuhtempo As System.Windows.Forms.DateTimePicker
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tgldo As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents datasetdo As DataSet
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents DataColumn3 As DataColumn
    Friend WithEvents namabarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kgsatuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents berat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DataColumn4 As DataColumn
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
End Class
