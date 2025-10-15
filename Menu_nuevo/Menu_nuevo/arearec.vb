Public Class arearec

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim base, altura, res As Double
        base = TextBox2.Text
        altura = TextBox1.Text
        res = base * altura
        MsgBox("El area es: " & res)
    End Sub
End Class