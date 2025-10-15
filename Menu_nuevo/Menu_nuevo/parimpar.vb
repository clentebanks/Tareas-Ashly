Public Class parimpar

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1 As Integer
        n1 = TextBox1.Text
        If n1 Mod 2 = 0 Then
            MsgBox("El numero es par")
        Else
            MsgBox("El numero es impar")
        End If
    End Sub
End Class