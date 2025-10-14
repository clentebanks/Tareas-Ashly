Public Class areacirculo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, area As Double
        n1 = TextBox1.Text
        area = 3.14 * n1 ^ 2
        MsgBox("El area del circulo es: " & area)
    End Sub
End Class