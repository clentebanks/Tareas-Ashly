Public Class edadmayormenor

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1 As Integer
        n1 = TextBox1.Text
        If n1 >= 18 Then
            MsgBox("Es mayor")
        Else
            MsgBox("Es menor")
        End If
    End Sub
End Class