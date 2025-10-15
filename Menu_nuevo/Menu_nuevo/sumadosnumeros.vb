Public Class sumadosnumeros

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1, n2, suma As Integer
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        suma = n1 + n2
        MsgBox("El resultado es:" & suma)
    End Sub
End Class