﻿Imports MySql.Data.MySqlClient
Public Class edit_barang
    Dim cbprinciple As New DataTable
    Private Sub edit_barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbprinciple = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle` from mprinciple")
        principle.DataSource = cbprinciple
        principle.DisplayMember = "Nama Principle"
        principle.ValueMember = "Kode Principle"

        id.Text = list_edit_barang.GridView1.GetRowCellValue(list_edit_barang.GridView1.FocusedRowHandle, "Kode Barang").ToString()
        nama.Text = list_edit_barang.GridView1.GetRowCellValue(list_edit_barang.GridView1.FocusedRowHandle, "Nama Barang").ToString()
        principle.Text = list_edit_barang.GridView1.GetRowCellValue(list_edit_barang.GridView1.FocusedRowHandle.ToString, "Nama Principle").ToString()
        RichTextBox1.Text = list_edit_barang.GridView1.GetRowCellValue(list_edit_barang.GridView1.FocusedRowHandle.ToString, "Keterangan").ToString()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case MsgBox("Apakah anda yakin menghapus data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim ccccc As String = "update mbarang set nama_barang='" & nama.Text & "',id_principle='" & principle.SelectedValue.ToString & "',keterangan='" & RichTextBox1.Text & "' where id_barang='" & id.Text.ToString & "'"
                InsertInto(ccccc)
                MessageBox.Show("File Updated")
                connect.Close()
                list_edit_barang.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub
End Class