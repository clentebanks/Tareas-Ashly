Public Class numayor

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim n1 As Integer
        n1 = TextBox1.Text
        If n1 >= 100 Then
            MsgBox("El numero ingresado es valido")
        Else
            MsgBox("El numero ingresado es menor a 100, porfavor ingresar otro numero")
        End If
    End Sub
End Class