Public Class arearectangulo

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim base, altura, res As Double
        base = TextBox1.Text
        altura = TextBox2.Text
        res = base * altura
        MsgBox("El area es: " & res)
    End Sub
End Class