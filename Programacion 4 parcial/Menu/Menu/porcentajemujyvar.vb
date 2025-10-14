Public Class porcentajemujyvar

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim muj, var, pormuj, porvar, total As Decimal
        muj = TextBox2.Text
        total = TextBox1.Text
        var = TextBox3.Text
        porvar = var * 100 / total
        Label6.Text = porvar
        pormuj = muj * 100 / total
        Label8.Text = pormuj
    End Sub
End Class