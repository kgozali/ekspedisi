﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class karyawan_piutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(karyawan_piutang))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.tes = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.datakaryawan = New DevExpress.XtraGrid.GridControl()
        Me.viewdatakaryawan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.datasupir = New DevExpress.XtraGrid.GridControl()
        Me.viewdatasupir = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.nama = New System.Windows.Forms.RadioButton()
        Me.id = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.tes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tes.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.datakaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewdatakaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.datasupir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewdatasupir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.tes)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 94)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(760, 422)
        Me.GroupControl3.TabIndex = 43
        Me.GroupControl3.Text = "Data Karayawan"
        '
        'tes
        '
        Me.tes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tes.Location = New System.Drawing.Point(2, 21)
        Me.tes.Name = "tes"
        Me.tes.SelectedTabPage = Me.XtraTabPage1
        Me.tes.Size = New System.Drawing.Size(756, 399)
        Me.tes.TabIndex = 0
        Me.tes.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.datakaryawan)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(750, 371)
        Me.XtraTabPage1.Text = "Karyawan"
        '
        'datakaryawan
        '
        Me.datakaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datakaryawan.Location = New System.Drawing.Point(0, 0)
        Me.datakaryawan.MainView = Me.viewdatakaryawan
        Me.datakaryawan.Name = "datakaryawan"
        Me.datakaryawan.Size = New System.Drawing.Size(750, 371)
        Me.datakaryawan.TabIndex = 1
        Me.datakaryawan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewdatakaryawan})
        '
        'viewdatakaryawan
        '
        Me.viewdatakaryawan.GridControl = Me.datakaryawan
        Me.viewdatakaryawan.Name = "viewdatakaryawan"
        Me.viewdatakaryawan.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.viewdatakaryawan.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.viewdatakaryawan.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.viewdatakaryawan.OptionsBehavior.Editable = False
        Me.viewdatakaryawan.OptionsSelection.EnableAppearanceFocusedCell = False
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.datasupir)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(750, 371)
        Me.XtraTabPage2.Text = "Supir"
        '
        'datasupir
        '
        Me.datasupir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datasupir.Location = New System.Drawing.Point(0, 0)
        Me.datasupir.MainView = Me.viewdatasupir
        Me.datasupir.Name = "datasupir"
        Me.datasupir.Size = New System.Drawing.Size(750, 371)
        Me.datasupir.TabIndex = 2
        Me.datasupir.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewdatasupir})
        '
        'viewdatasupir
        '
        Me.viewdatasupir.GridControl = Me.datasupir
        Me.viewdatasupir.Name = "viewdatasupir"
        Me.viewdatasupir.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.viewdatasupir.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.viewdatasupir.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.viewdatasupir.OptionsBehavior.Editable = False
        Me.viewdatasupir.OptionsSelection.EnableAppearanceFocusedCell = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.nama)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Controls.Add(Me.cari)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(263, 76)
        Me.GroupControl1.TabIndex = 42
        Me.GroupControl1.Text = "Cari Berdasarkan"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Checked = True
        Me.nama.Location = New System.Drawing.Point(98, 24)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(103, 17)
        Me.nama.TabIndex = 2
        Me.nama.TabStop = True
        Me.nama.Text = "Nama Karyawan"
        Me.nama.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(5, 24)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(87, 17)
        Me.id.TabIndex = 1
        Me.id.Text = "ID Karyawan"
        Me.id.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(5, 51)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(253, 20)
        Me.cari.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(672, 522)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 145
        Me.SimpleButton1.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(566, 522)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 144
        Me.Submit.Text = "Submit"
        '
        'karyawan_piutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 557)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "karyawan_piutang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Karyawaan"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.tes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tes.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.datakaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewdatakaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.datasupir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewdatasupir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nama As System.Windows.Forms.RadioButton
    Friend WithEvents id As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tes As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents datakaryawan As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewdatakaryawan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents datasupir As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewdatasupir As DevExpress.XtraGrid.Views.Grid.GridView
End Class
