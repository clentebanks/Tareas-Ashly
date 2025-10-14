Imports System.Data.OleDb
Public Class Form1
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\BD\baseimagenes.accdb")

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.Open()
            MessageBox.Show("Conexion exitosa")
            mostrardatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub mostrardatos()
        Dim sql As String = "SELECT *FROM imagenes"
        Dim cmd As New OleDbCommand(sql, con)
        Dim adp As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable

        adp.Fill(dt)
        dgvimagenes.DataSource = dt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dialog As New OpenFileDialog
        dialog.Filter = "imagenes |*.jpg"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.ImageLocation = dialog.Filename
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txttitulo.Text <> "" And Not PictureBox1 Is Nothing Then
            Dim ms As New IO.MemoryStream
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            Dim i() As Byte = ms.GetBuffer

            Dim sql As String = "INSERT INTO imagenes VALUES(@titulo,@imagen)"
            Dim cmd As New OleDbCommand(sql, con)
            cmd.Parameters.Add(New OleDbParameter("@titulo", txttitulo))
            cmd.Parameters.Add(New OleDbParameter("@imagen", i))
        End If

    End Sub
End Class
