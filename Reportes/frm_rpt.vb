Public Class frm_rpt
    Private Sub frm_inv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSControl.INVE_articulos' Puede moverla o quitarla según sea necesario.
        Me.INVE_articulosTableAdapter.Fill(Me.DSControl.INVE_articulos)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.Vw_INVE_acumulados' Puede moverla o quitarla según sea necesario.
        '  Me.Vw_INVE_acumuladosTableAdapter.Fill(Me.DSControl.Vw_INVE_acumulados)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.INVE_control' Puede moverla o quitarla según sea necesario.
        '  Me.INVE_controlTableAdapter.Fill(Me.DSControl.INVE_control)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Vw_INVE_acumuladosTableAdapter.Fill(Me.DSControl.Vw_INVE_acumulados, ComboBox1.SelectedValue)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.INVE_control' Puede moverla o quitarla según sea necesario.
        '  Me.INVE_controlTableAdapter.Fill(Me.DSControl.INVE_control)

        Dim rpt As New rpt_inv()
        rpt.SetDataSource(DSControl)
        crv.ReportSource = rpt
    End Sub
End Class