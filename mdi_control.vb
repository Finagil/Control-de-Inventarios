Public Class mdi_control
    Private Sub GarantiasEjercidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GarantiasEjercidasToolStripMenuItem.Click
        Dim f As New frm_articulos
        f.Show()
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        Dim f As New frm_altas
        f.Show()
    End Sub

    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        Dim f As New frm_salida
        f.Show()
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim f As New frm_articulos
        f.Show()
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Dim f As New frm_rpt
        f.WindowState = FormWindowState.Maximized
        f.Show()
    End Sub
End Class