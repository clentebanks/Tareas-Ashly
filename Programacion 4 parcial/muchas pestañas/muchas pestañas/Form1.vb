Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lista.Items.Add("1")
        lista.Items.Add("2")
        lista.Items.Add("3")
        lista.Items.Add("4")
        lista.Items.Add("5")
        lista.Items.Add("6")
        lista.Items.Add("7")
        lista.Items.Add("8")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LISTADO.Items.Add(TextBox1.Text)
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LISTADO.Items.RemoveAt(LISTADO.SelectedItem)
        TextBox1.Text = ""
    End Sub
End Class
