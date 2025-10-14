Public Class promedioif

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1, n2, n3, n4, prom As Integer
        n1 = TextBox1.Text
        n2 = TextBox2.Text
        n3 = TextBox3.Text
        n4 = TextBox4.Text
        prom = (n1 + n2 + n3 + n4) / 4
        Label7.Text = prom
        If prom >= 70 Then
            Label9.Text = "APROBO"
        Else
            Label9.Text = "REPROBO"
        End If
    End Sub
End Class