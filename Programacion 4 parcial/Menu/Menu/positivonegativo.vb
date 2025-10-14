Public Class positivonegativo

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim num As Integer
        If Not Integer.TryParse(TextBox1.Text, num) Then
            MsgBox("Por favor ingrese un número válido")
            Exit Sub
        End If
        If num < 0 Then
            MsgBox("Negativo")
        Else
            MsgBox("Positivo")
        End If
    End Sub
End Class