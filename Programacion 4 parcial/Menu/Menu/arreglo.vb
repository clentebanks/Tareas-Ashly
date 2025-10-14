Public Class arreglo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n(2) As Integer
        n(0) = TextBox1.Text
        n(1) = TextBox2.Text
        n(2) = n(0) + n(1)
        MsgBox("La respuesta es: " & n(2))
    End Sub
End Class