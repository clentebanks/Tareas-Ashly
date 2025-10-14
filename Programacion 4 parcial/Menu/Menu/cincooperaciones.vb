Public Class cincooperaciones

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, n2, suma, resta, mul, div, pot As Double
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        suma = n1 + n2
        resta = n1 - n2
        mul = n1 * n2
        div = n1 / n2
        pot = n1 ^ n2
        Label5.Text = suma
        Label7.Text = resta
        Label9.Text = mul
        Label11.Text = div
        Label13.Text = pot
    End Sub
End Class