Public Class frm_altas
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSControl1.vw_inv_articulo_existencias' Puede moverla o quitarla según sea necesario.
        Me.Vw_inv_articulo_existenciasTableAdapter.Fill(Me.DSControl1.vw_inv_articulo_existencias)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.vw_inv_articulo_existencias' Puede moverla o quitarla según sea necesario.
        ' Me.Vw_inv_articulo_existenciasTableAdapter.Fill(Me.DSControl.vw_inv_articulo_existencias)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.VW_INV_ALTAS' Puede moverla o quitarla según sea necesario.
        Me.VW_INV_ALTASTableAdapter.Fill(Me.DSControl.VW_INV_ALTAS)
        'TODO: esta línea de código carga datos en la tabla 'DSControl._INVE_entradas_salidas' Puede moverla o quitarla según sea necesario.
        ' Me.INVE_entradas_salidasTableAdapter.Fill(Me.DSControl._INVE_entradas_salidas)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.INVE_almacenes' Puede moverla o quitarla según sea necesario.
        Me.INVE_almacenesTableAdapter.Fill(Me.DSControl.INVE_almacenes)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.INVE_medida' Puede moverla o quitarla según sea necesario.
        Me.INVE_medidaTableAdapter.Fill(Me.DSControl.INVE_medida)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.INVE_articulos' Puede moverla o quitarla según sea necesario.
        Me.INVE_articulosTableAdapter.Fill(Me.DSControl.INVE_articulos)



    End Sub



    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Dim cantidad As Decimal = CDec(Val(txt_cant.Text))
        Dim costo As Decimal = CDec(Val(txt_costo.Text))
        Me.INVE_entradas_salidasTableAdapter.InsertEntradas(cantidad, cmb_articulo.SelectedValue, dt_fecha.Text, cmb_unidad.SelectedValue, costo, cmb_almacen.SelectedValue, True)
        MessageBox.Show("Entrada del artículo Guardado", "CONTROL DE INVENTARIOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.VW_INV_ALTASTableAdapter.Fill(Me.DSControl.VW_INV_ALTAS)
        Me.Vw_inv_articulo_existenciasTableAdapter.Fill(Me.DSControl1.vw_inv_articulo_existencias)
    End Sub

    Private Sub cmb_almacen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_almacen.SelectedIndexChanged

    End Sub

    Private Sub cmb_almacen_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_almacen.SelectedValueChanged

    End Sub

    Private Sub cmb_articulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_articulo.SelectedIndexChanged

    End Sub

    Private Sub cmb_articulo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_articulo.SelectedValueChanged
        If cmb_articulo.SelectedValue > 0 Then
            'txt_unidades.Text = Me.INVE_entradas_salidasTableAdapter.CANTIDAD(cmb_almacen.SelectedValue, cmb_articulo.SelectedValue)
        End If
    End Sub

    Private Sub dt_fecha_ValueChanged(sender As Object, e As EventArgs) Handles dt_fecha.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class
