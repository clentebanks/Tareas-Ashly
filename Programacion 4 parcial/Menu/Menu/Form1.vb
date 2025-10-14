Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim sumadosnumeros As New sumadosnumeros()
        sumadosnumeros.MdiParent = Me
        sumadosnumeros.Show()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim cincooperaciones As New cincooperaciones()
        cincooperaciones.MdiParent = Me
        cincooperaciones.Show()
    End Sub

    Private Sub AreaDeRectanguloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaDeRectanguloToolStripMenuItem.Click
        Dim arearectangulo As New arearectangulo()
        arearectangulo.MdiParent = Me
        arearectangulo.Show()
    End Sub

    Private Sub AreaDeTrianguloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaDeTrianguloToolStripMenuItem.Click
        Dim areatriangulo As New areatriangulo()
        areatriangulo.MdiParent = Me
        areatriangulo.Show()
    End Sub

    Private Sub PorcentajeHombreYMujerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorcentajeHombreYMujerToolStripMenuItem.Click
        Dim porcentajemujyvar As New porcentajemujyvar()
        porcentajemujyvar.MdiParent = Me
        porcentajemujyvar.Show()
    End Sub

    Private Sub PromedioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromedioToolStripMenuItem.Click
        Dim promedio As New promedio()
        promedio.MdiParent = Me
        promedio.Show()
    End Sub

    Private Sub PromedioConIfToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromedioConIfToolStripMenuItem.Click
        Dim promedioif As New promedioif()
        promedioif.MdiParent = Me
        promedioif.Show()
    End Sub

    Private Sub DiasDeLaSemanaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiasDeLaSemanaToolStripMenuItem.Click
        Dim diassemana As New diassemana()
        diassemana.MdiParent = Me
        diassemana.Show()
    End Sub

    Private Sub EdadMayorOMenorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EdadMayorOMenorToolStripMenuItem.Click
        Dim edadmayormenor As New edadmayormenor()
        edadmayormenor.MdiParent = Me
        edadmayormenor.Show()
    End Sub

    Private Sub AlmacenamentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlmacenamentoToolStripMenuItem.Click
        Dim almacenamiento As New almacenamiento()
        almacenamiento.MdiParent = Me
        almacenamiento.Show()
    End Sub

    Private Sub TablasDeMultiplicarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TablasDeMultiplicarToolStripMenuItem.Click
        Dim tablasmul As New tablasmul()
        tablasmul.MdiParent = Me
        tablasmul.Show()
    End Sub

    Private Sub HorasYMinutosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorasYMinutosToolStripMenuItem.Click
        Dim horamin As New horamin()
        horamin.MdiParent = Me
        horamin.Show()
    End Sub

    Private Sub CoheteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoheteToolStripMenuItem.Click
        Dim cohete As New cohete()
        cohete.MdiParent = Me
        cohete.Show()
    End Sub

    Private Sub PositivoONegativoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PositivoONegativoToolStripMenuItem.Click
        Dim positivonegativo As New positivonegativo()
        positivonegativo.MdiParent = Me
        positivonegativo.Show()
    End Sub

    Private Sub ParOImparToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParOImparToolStripMenuItem.Click
        Dim parimpar As New parimpar()
        parimpar.MdiParent = Me
        parimpar.Show()
    End Sub

    Private Sub MultiplosDe5Entre110ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MultiplosDe5Entre110ToolStripMenuItem.Click
        Dim multiplos As New multiplos()
        multiplos.MdiParent = Me
        multiplos.Show()
    End Sub

    Private Sub SumaDeLosNumerosDel110ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SumaDeLosNumerosDel110ToolStripMenuItem.Click
        Dim sumanums As New sumanums()
        sumanums.MdiParent = Me
        sumanums.Show()
    End Sub

    Private Sub Numero100ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Numero100ToolStripMenuItem.Click
        Dim numenor As New numenor()
        numenor.MdiParent = Me
        numenor.Show()
    End Sub

    Private Sub AreaDeUnCirculoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaDeUnCirculoToolStripMenuItem.Click
        Dim areacirculo As New areacirculo()
        areacirculo.MdiParent = Me
        areacirculo.Show()
    End Sub

    Private Sub MetrosACentimetrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetrosACentimetrosToolStripMenuItem.Click
        Dim macm As New macm()
        macm.MdiParent = Me
        macm.Show()
    End Sub

    Private Sub PulgadasACentimetrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PulgadasACentimetrosToolStripMenuItem.Click
        Dim pulgacm As New pulgacm()
        pulgacm.MdiParent = Me
        pulgacm.Show()
    End Sub

    Private Sub RaizDeUnNumeroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RaizDeUnNumeroToolStripMenuItem.Click
        Dim raiznum As New raiznum()
        raiznum.MdiParent = Me
        raiznum.Show()
    End Sub

    Private Sub DescuentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescuentoToolStripMenuItem.Click
        Dim descuento As New descuento()
        descuento.MdiParent = Me
        descuento.Show()
    End Sub

    Private Sub Arreglo1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Arreglo1ToolStripMenuItem.Click
        Dim arreglo As New arreglo()
        arreglo.MdiParent = Me
        arreglo.Show()
    End Sub

    Private Sub ArregloDosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArregloDosToolStripMenuItem.Click
        Dim arreglodos As New arreglodos()
        arreglodos.MdiParent = Me
        arreglodos.Show()
    End Sub
End Class
