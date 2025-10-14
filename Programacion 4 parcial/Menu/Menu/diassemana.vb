Public Class diassemana

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n1 As Integer
        n1 = TextBox1.Text
        If n1 = 1 Then
            MsgBox("Lunes")
        ElseIf n1 = 2 Then
            MsgBox("Martes")
        ElseIf n1 = 3 Then
            MsgBox("Miercoles")
        ElseIf n1 = 4 Then
            MsgBox("Jueves")
        ElseIf n1 = 5 Then
            MsgBox("Viernes")
        ElseIf n1 = 6 Then
            MsgBox("Sabado")
        ElseIf n1 = 7 Then
            MsgBox("Domingo")
        Else
            MsgBox("No es un dia de la semana")
        End If
    End Sub
End Class