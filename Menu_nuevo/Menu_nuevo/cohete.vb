Public Class cohete

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim vi, g, t, vins As Double
        vi = Label8.Text
        g = Label12.Text
        t = Label10.Text
        vins = vi - (g * t)
        Label14.Text = vins.ToString()
    End Sub
End Class