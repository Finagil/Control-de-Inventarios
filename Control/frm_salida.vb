Public Class frm_salida
    Dim id_salida As Integer
    Dim cantidad_detalle As Decimal = 0
    Private Sub frm_salida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSControl.INVE_salidadetalle' Puede moverla o quitarla según sea necesario.
        Me.INVE_salidadetalleTableAdapter.Fill(Me.DSControl.INVE_salidadetalle)
        'TODO: esta línea de código carga datos en la tabla 'DSControl._INVE_entradas_salidas' Puede moverla o quitarla según sea necesario.
        Me.INVE_entradas_salidasTableAdapter.Fill(Me.DSControl._INVE_entradas_salidas)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.vw_inv_salidas' Puede moverla o quitarla según sea necesario.
        Me.Vw_inv_salidasTableAdapter.Fill(Me.DSControl.vw_inv_salidas)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.INVE_medida' Puede moverla o quitarla según sea necesario.
        Me.INVE_medidaTableAdapter.Fill(Me.DSControl.INVE_medida)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.INVE_articulos' Puede moverla o quitarla según sea necesario.
        Me.INVE_articulosTableAdapter.Fill(Me.DSControl.INVE_articulos)

    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click

        Dim cantidad As Decimal = CDec(Val(txt_cant.Text))
        Dim precio As Decimal = CDec(Val(txt_precio.Text))

        'asegurar que haya existencias del ARTICULO
        id_salida = Me.INVE_entradas_salidasTableAdapter.id_salida() + 1
        If txt_unidades.Text > 0 Then

            'comprobar que la cantidad solicitada no sea mayor a lo existente
            Dim IDARTICULO As Integer = cmb_articulo.SelectedValue
            If cantidad > Me.INVE_entradas_salidasTableAdapter.existencia(IDARTICULO) Then
                MessageBox.Show("Cantidad no puede ser mayor a la existencia", "CONTROL DE INVENTARIOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else

                'PRIMERAS ENTRADAS PRIMERAS SALIDAS

                'TRAER LAS EXISTENCIAS DE LAS EMTRADAS DEL ARTICULO 
                'DAMOS DE ALTA LA SALIDA GENERAL 
                Dim cantidad1 As Decimal = cantidad * -1
                Me.INVE_entradas_salidasTableAdapter.InsertQuerySalida(cantidad1, cmb_articulo.SelectedValue, dt_fecha.Text, precio, cmb_unidad.SelectedValue, False, id_salida)


                'GENERAMOS REGISTRO DE SALIDA DETALLE

                Do While cantidad > 0


                    '    Me.INVE_entradas_salidasTableAdapter.FillByEXISTENCIA(DSControl._INVE_entradas_salidas, cmb_articulo.SelectedValue)
                    Me.VW_INVE_existenciaTableAdapter.Fill(Me.DSControl.VW_INVE_existencia, cmb_articulo.SelectedValue)
                    'If Me.DSControl._INVE_entradas_salidas.Count > 0 Then
                    ' Dim ID_ES1 As Integer = Me.Controls.Find("ID_ES", T)
                    ' End If
                    ' For i As Integer = 1 To 28
                    'rsi = CType(Me.Controls.Find("RS_" & i, True)(0), RadioButton)

                    '  For Each row As DataRow In INVE_entradas_salidas1TableAdapter.GetEXISTENCIAS(cmb_articulo.SelectedValue)
                    Dim ID_ES As Integer
                    Dim exis As Double
                    Dim COST As Double

                    ID_ES = Me.VWINVEexistenciaBindingSource1.Current("ID_ES")
                    exis = Me.VWINVEexistenciaBindingSource1.Current("existencia")
                    COST = Me.INVE_entradas_salidasTableAdapter.COSTO(ID_ES)
                    'verificar que la existencia sea >= a la cantidad de salida


                    If cantidad >= exis Then
                        cantidad_detalle = exis
                    Else
                        cantidad_detalle = cantidad
                    End If



                    'DAMOS DE ALTA LA SALIDA en detallesalida
                    Me.INVE_salidadetalleTableAdapter.InsertQuery(id_salida, ID_ES, cantidad_detalle, COST)

                    'MODIFICAMOS EXISTENCIA DE ARTICULO

                    'cantidad = cantidad - exis
                    'Me.INVE_entradas_salidasTableAdapter.UpdateEXISTENCIA(exis - cantidad_detalle, ID_ES)

                    'End If
                    '  Next

                    cantidad = cantidad - cantidad_detalle

                Loop




                'cantidad = cantidad * -1
                'Me.INVE_entradas_salidasTableAdapter.InsertQuerySalida(cantidad, cmb_articulo.SelectedValue, dt_fecha.Text, precio, cmb_unidad.SelectedValue, cmb_almacen.SelectedValue, False)
                'MessageBox.Show("Salida del artículo Guardado", "CONTROL DE INVENTARIOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

        End If
        Me.Vw_inv_salidasTableAdapter.Fill(Me.DSControl.vw_inv_salidas)

    End Sub

    Private Sub cmb_articulo_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        '  Dim idsalida As Integer
        '  idsalida = VwinvsalidasBindingSource3.Current("id_salida")
        ' TextBox2.Text = idsalida
        Me.Vw_inve_salidadetalleTableAdapter.Fillbysalida(Me.DSControl.vw_inve_salidadetalle, VwinvsalidasBindingSource3.Current("id_salida"))
    End Sub



    Private Sub cmb_articulo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_articulo.SelectedValueChanged
        If cmb_articulo.SelectedValue > 0 Then
            txt_unidades.Text = Me.INVE_entradas_salidasTableAdapter.existencia(cmb_articulo.SelectedValue)
            '  Me.INVE_entradas_salidasTableAdapter.FillByEXISTENCIA(DSControl._INVE_entradas_salidas, cmb_articulo.SelectedValue)

        End If
    End Sub
End Class