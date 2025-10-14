Public Class tablasmul

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n, t, val As Integer
        Dim res As String = ""
        t = TextBox1.Text
        n = 1
        While n <= 10
            val = n * t
            res &= t & " x " & n & " = " & val & Environment.NewLine
            n += 1
        End While
        Label4.Text = res
    End Sub
End Class