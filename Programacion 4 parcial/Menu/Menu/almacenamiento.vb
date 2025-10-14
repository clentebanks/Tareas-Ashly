Public Class almacenamiento

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1, B, KB, MB, TB As Double
        n1 = TextBox1.Text
        MB = n1 * 1024
        KB = MB * 1024
        B = KB * 1024
        TB = n1 / 1024
        Label4.Text = MB
        Label6.Text = KB
        Label8.Text = B
        Label10.Text = TB
    End Sub
End Class