Public Class cohete

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vi, g, d, vins As Double
        vi = CDbl(Label6.Text)
        g = CDbl(Label10.Text)
        d = CDbl(Label8.Text)
        vins = (vi) - (g) * d
        Label12.Text = vins.ToString()
    End Sub
End Class