Public Class arreglocincooper

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n(6) As Double
        n(0) = TextBox1.Text
        n(1) = TextBox2.Text
        n(2) = n(0) + n(1)
        n(3) = n(0) - n(1)
        n(4) = n(0) * n(1)
        n(5) = n(0) / n(1)
        n(6) = n(0) ^ n(1)
        Label9.Text = n(2)
        Label10.Text = n(3)
        Label11.Text = n(4)
        Label12.Text = n(5)
        Label13.Text = n(6)
    End Sub
End Class