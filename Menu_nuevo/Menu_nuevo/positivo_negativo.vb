Public Class positivo_negativo

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1 As Integer
        n1 = TextBox1.Text
        If n1 < 0 Then
            MsgBox("Negativo")
        Else
            MsgBox("Positivo")
        End If
    End Sub
End Class