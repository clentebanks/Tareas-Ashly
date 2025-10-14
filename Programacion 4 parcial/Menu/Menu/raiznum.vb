Public Class raiznum

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, raiz As Integer

        n1 = TextBox1.Text
        raiz = n1 ^ (1 / 2)
        MsgBox("La raiz es: " & raiz)

    End Sub
End Class