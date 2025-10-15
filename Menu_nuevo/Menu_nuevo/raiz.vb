Public Class raiz

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1, raiz As Integer
        n1 = TextBox1.Text
        raiz = n1 ^ (1 / 2)
        MsgBox("La raiz es: " & raiz)
    End Sub
End Class