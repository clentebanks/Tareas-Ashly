Public Class pulgacm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pulg, cm As Double
        pulg = TextBox1.Text
        cm = pulg * 2.5
        MsgBox("El resoultado en Centimetros es: " & cm)
    End Sub
End Class