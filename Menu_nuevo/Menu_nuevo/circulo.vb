Public Class circulo

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1, area As Double
        n1 = TextBox1.Text
        area = 3.14 * n1 ^ 2
        MsgBox("El area del circulo es: " & area)
    End Sub
End Class