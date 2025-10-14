Public Class macm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m, cm As Double
        m = TextBox1.Text
        cm = m * 100
        MsgBox("La respuesta en Centimetros es: " & cm)
    End Sub
End Class