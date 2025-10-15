Public Class areatriangulo

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim base, altura, area As Double
        base = TextBox1.Text
        altura = TextBox2.Text
        area = (base * altura) / 2
        MsgBox("El area es: " & area)
    End Sub
End Class