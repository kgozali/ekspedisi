﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KIR_Truk
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KIR_Truk))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Location = New System.Drawing.Point(8, 128)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(633, 469)
        Me.GroupControl3.TabIndex = 40
        Me.GroupControl3.Text = "Data KIR "
        '
        'GridControl1
        '
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl1.Location = New System.Drawing.Point(8, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(623, 440)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.ComboBox1)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 64)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(292, 57)
        Me.GroupControl1.TabIndex = 39
        Me.GroupControl1.Text = "Pilih Truk"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(112, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(24, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Kode KIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Nomor KIR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(694, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Tanggal KIR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(621, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Tanggal KIR Berikutnya"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(724, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 18)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Nominal"
        '
        'TextEdit1
        '
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(100, 9)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(174, 20)
        Me.TextEdit1.TabIndex = 3
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(100, 35)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(224, 20)
        Me.TextEdit2.TabIndex = 46
        '
        'TextEdit3
        '
        Me.TextEdit3.EditValue = "0"
        Me.TextEdit3.Location = New System.Drawing.Point(789, 59)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(200, 20)
        Me.TextEdit3.TabIndex = 47
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(789, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 48
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(789, 6)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker2.TabIndex = 49
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(888, 608)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 51
        Me.SimpleButton1.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(781, 608)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 50
        Me.Submit.Text = "Submit"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.PictureBox1)
        Me.GroupControl2.Location = New System.Drawing.Point(648, 128)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(338, 429)
        Me.GroupControl2.TabIndex = 52
        Me.GroupControl2.Text = "Bukti Kir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(328, 400)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextEdit4
        '
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.Location = New System.Drawing.Point(681, 569)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(257, 20)
        Me.TextEdit4.TabIndex = 53
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(944, 560)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(42, 37)
        Me.SimpleButton2.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(648, 572)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Path"
        '
        'ofd
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label8.Location = New System.Drawing.Point(8, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 18)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Nomor Polisi"
        '
        'KIR_Truk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 646)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.TextEdit4)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextEdit3)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "KIR_Truk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KIR"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
