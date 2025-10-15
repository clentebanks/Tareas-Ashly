Public Class promedio

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1, n2, n3, n4 As Integer
        Dim prom As Double
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        n3 = TextBox3.Text
        n4 = TextBox4.Text
        prom = (n1 + n2 + n3 + n4) / 4
        MsgBox("El promedio es de: " & prom)
    End Sub
End Class