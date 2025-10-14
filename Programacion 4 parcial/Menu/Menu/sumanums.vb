Public Class sumanums

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim num As Integer
        Dim suma As Integer = 1
        Label2.Text = "Respuesta a la suma:" & vbCrLf
        For num = 1 To 10
            suma += num
            Label2.Text &= (suma - num) & " + " & num & " = " & suma & vbCrLf
        Next
    End Sub
End Class