Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SumaDosNumerosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SumaDosNumerosToolStripMenuItem.Click
        Dim sumadosnumeros As New sumadosnumeros()
        sumadosnumeros.MdiParent = Me
        sumadosnumeros.Show()
    End Sub

    Private Sub CincoOperacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CincoOperacionesToolStripMenuItem.Click
        Dim cincooper As New cincooper()
        cincooper.MdiParent = Me
        cincooper.Show()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub AreaDeUnRectanguloToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AreaDeUnRectanguloToolStripMenuItem.Click
        Dim arearec As New arearec()
        arearec.MdiParent = Me
        arearec.Show()
    End Sub

    Private Sub AreaDeUnTrianguloToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AreaDeUnTrianguloToolStripMenuItem.Click
        Dim areatriangulo As New areatriangulo()
        areatriangulo.MdiParent = Me
        areatriangulo.Show()
    End Sub

    Private Sub PorcentajeHombreYMujerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PorcentajeHombreYMujerToolStripMenuItem.Click
        Dim pormujyhom As New pormujyhom()
        pormujyhom.MdiParent = Me
        pormujyhom.Show()
    End Sub

    Private Sub PromedioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PromedioToolStripMenuItem.Click
        Dim promedio As New promedio()
        promedio.MdiParent = Me
        promedio.Show()
    End Sub

    Private Sub PromedioConIfToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PromedioConIfToolStripMenuItem.Click
        Dim promedioif As New promedioif()
        promedioif.MdiParent = Me
        promedioif.Show()
    End Sub

    Private Sub DiasDeLaSemanaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DiasDeLaSemanaToolStripMenuItem.Click
        Dim dias As New dias()
        dias.MdiParent = Me
        dias.Show()
    End Sub

    Private Sub EdadMayorOMenorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EdadMayorOMenorToolStripMenuItem.Click
        Dim mayoromenor As New mayoromenor()
        mayoromenor.MdiParent = Me
        mayoromenor.Show()
    End Sub

    Private Sub AlmacenamintoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlmacenamintoToolStripMenuItem.Click
        Dim almacenamiento As New almacenamiento()
        almacenamiento.MdiParent = Me
        almacenamiento.Show()
    End Sub

    Private Sub TablasDeMultiplicarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TablasDeMultiplicarToolStripMenuItem.Click
        Dim tablas As New tablas()
        tablas.MdiParent = Me
        tablas.Show()
    End Sub

    Private Sub HorasYMinutosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HorasYMinutosToolStripMenuItem.Click
        Dim horasymin As New horasymin()
        horasymin.MdiParent = Me
        horasymin.Show()
    End Sub

    Private Sub CoheteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CoheteToolStripMenuItem.Click
        Dim cohete As New cohete()
        cohete.MdiParent = Me
        cohete.Show()
    End Sub

    Private Sub PositivoONegativoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PositivoONegativoToolStripMenuItem.Click
        Dim positivo_negativo As New positivo_negativo()
        positivo_negativo.MdiParent = Me
        positivo_negativo.Show()
    End Sub

    Private Sub ParOImparToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ParOImparToolStripMenuItem.Click
        Dim parimpar As New parimpar()
        parimpar.MdiParent = Me
        parimpar.Show()
    End Sub

    Private Sub MultiplosDe5Entre1100ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MultiplosDe5Entre1100ToolStripMenuItem.Click
        Dim multiploscinco As New multiploscinco()
        multiploscinco.MdiParent = Me
        multiploscinco.Show()
    End Sub

    Private Sub SumaDeLosNumerosDel110ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SumaDeLosNumerosDel110ToolStripMenuItem.Click
        Dim sumanums As New sumanums()
        sumanums.MdiParent = Me
        sumanums.Show()
    End Sub

    Private Sub NumeroMayorA100ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NumeroMayorA100ToolStripMenuItem.Click
        Dim numayor As New numayor()
        numayor.MdiParent = Me
        numayor.Show()
    End Sub

    Private Sub AreaDeUnCirculoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AreaDeUnCirculoToolStripMenuItem.Click
        Dim circulo As New circulo()
        circulo.MdiParent = Me
        circulo.Show()
    End Sub

    Private Sub MetrosACentimetrosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MetrosACentimetrosToolStripMenuItem.Click
        Dim macm As New macm()
        macm.MdiParent = Me
        macm.Show()
    End Sub

    Private Sub PulgadasACentimetrosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PulgadasACentimetrosToolStripMenuItem.Click
        Dim pulgacm As New pulgacm()
        pulgacm.MdiParent = Me
        pulgacm.Show()
    End Sub

    Private Sub RaizDeUnNumeroToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RaizDeUnNumeroToolStripMenuItem.Click
        Dim raiz As New raiz()
        raiz.MdiParent = Me
        raiz.Show()
    End Sub

    Private Sub DescuentoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DescuentoToolStripMenuItem.Click
        Dim descuento As New descuento()
        descuento.MdiParent = Me
        descuento.Show()
    End Sub

    Private Sub ArregloUnoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArregloUnoToolStripMenuItem.Click
        Dim arreglosum As New arreglosum()
        arreglosum.MdiParent = Me
        arreglosum.Show()
    End Sub

    Private Sub ArregloCincoOperacionesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ArregloCincoOperacionesToolStripMenuItem.Click
        Dim arreglocincooper As New arreglocincooper()
        arreglocincooper.MdiParent = Me
        arreglocincooper.Show()
    End Sub
End Class
