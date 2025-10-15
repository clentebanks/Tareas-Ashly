Public Class horasymin

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim seg, hrs, min As Double
        seg = TextBox1.Text
        min = seg / 60
        hrs = min / 60
        Label6.Text = min
        Label5.Text = hrs
    End Sub
End Class