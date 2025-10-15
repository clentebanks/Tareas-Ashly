Public Class multiploscinco

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim num As Integer
        num = 5
        Label2.Text = "Múltiplos de 5:" & vbCrLf
        While num <= 100
            Label2.Text &= num & vbCrLf
            num += 5
        End While
    End Sub
End Class