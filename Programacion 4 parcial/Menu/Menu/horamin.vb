Public Class horamin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim seg, hrs, min As Double
        seg = TextBox1.Text
        min = seg / 60
        hrs = min / 60
        Label5.Text = min
        Label6.Text = hrs
    End Sub
End Class