﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_kontak_principle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_kontak_principle))
        Me.email = New DevExpress.XtraEditors.TextEdit()
        Me.tel2 = New DevExpress.XtraEditors.TextEdit()
        Me.tel1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.nama = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.principle = New System.Windows.Forms.ComboBox()
        Me.simpan = New DevExpress.XtraEditors.SimpleButton()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tel2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tel1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(119, 153)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(143, 20)
        Me.email.TabIndex = 6
        '
        'tel2
        '
        Me.tel2.Location = New System.Drawing.Point(119, 129)
        Me.tel2.Name = "tel2"
        Me.tel2.Size = New System.Drawing.Size(165, 20)
        Me.tel2.TabIndex = 5
        '
        'tel1
        '
        Me.tel1.Location = New System.Drawing.Point(119, 105)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(165, 20)
        Me.tel1.TabIndex = 4
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(14, 152)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(43, 18)
        Me.LabelControl8.TabIndex = 54
        Me.LabelControl8.Text = "Email :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(14, 128)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl7.TabIndex = 53
        Me.LabelControl7.Text = "Telepon 2 :"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(14, 104)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl6.TabIndex = 52
        Me.LabelControl6.Text = "Telepon 1 :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 18)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Kode Principle :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(14, 79)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(99, 18)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "Nama Kontak :"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(119, 81)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(143, 20)
        Me.nama.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.principle)
        Me.GroupControl1.Controls.Add(Me.email)
        Me.GroupControl1.Controls.Add(Me.tel2)
        Me.GroupControl1.Controls.Add(Me.tel1)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.nama)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(325, 192)
        Me.GroupControl1.TabIndex = 151
        Me.GroupControl1.Text = "Data"
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(119, 32)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(143, 20)
        Me.id.TabIndex = 57
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(14, 31)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(93, 18)
        Me.LabelControl3.TabIndex = 56
        Me.LabelControl3.Text = "Kode Kontak :"
        '
        'principle
        '
        Me.principle.FormattingEnabled = True
        Me.principle.Location = New System.Drawing.Point(119, 56)
        Me.principle.Name = "principle"
        Me.principle.Size = New System.Drawing.Size(143, 21)
        Me.principle.TabIndex = 55
        '
        'simpan
        '
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.Location = New System.Drawing.Point(131, 210)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(100, 27)
        Me.simpan.TabIndex = 153
        Me.simpan.Text = "Save"
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(237, 210)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 152
        Me.cancel.Text = "Cancel"
        '
        'add_kontak_principle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 249)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "add_kontak_principle"
        Me.Text = "Tambah Kontak Principle"
        CType(Me.email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tel2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tel1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents email As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tel2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tel1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents principle As System.Windows.Forms.ComboBox
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
