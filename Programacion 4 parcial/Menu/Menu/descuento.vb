Public Class descuento

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1, total As Double
        n1 = TextBox1.Text
        If n1 >= 3000 Then
            total = n1 * 0.65
            Label6.Text = "L." & n1
            Label7.Text = "35%"
            Label8.Text = "L." & total
        Else
            total = n1 * 0.9
            Label6.Text = "L." & n1
            Label7.Text = "10%"
            Label8.Text = "L." & total
        End If
    End Sub
End Class