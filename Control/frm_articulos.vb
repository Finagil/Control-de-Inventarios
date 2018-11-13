Public Class frm_articulos
    Private Sub frm_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DSControl.INVE_articulos' Puede moverla o quitarla según sea necesario.
        Me.INVE_articulosTableAdapter.Fill(Me.DSControl.INVE_articulos)
        'TODO: esta línea de código carga datos en la tabla 'DSControl.INVE_almacenes' Puede moverla o quitarla según sea necesario.
        Me.INVE_almacenesTableAdapter.Fill(Me.DSControl.INVE_almacenes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.INVE_articulosTableAdapter.InsertQuery(txt_nombre.Text, txt_clave.Text)
        MessageBox.Show("Producto Guardado", "CONTROL DE INVENTARIOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.INVE_articulosTableAdapter.Fill(Me.DSControl.INVE_articulos)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.INVE_articulosTableAdapter.Updatearticulo(txt_nombre.Text, txt_clave.Text, Me.INVEarticulosBindingSource1.Current("id_articulo"))
        MessageBox.Show("Producto Modificado", "CONTROL DE INVENTARIOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.INVE_articulosTableAdapter.Fill(Me.DSControl.INVE_articulos)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.INVE_articulosTableAdapter.DeleteQueryarticulo(Me.INVEarticulosBindingSource1.Current("id_articulo"))
        MessageBox.Show("Producto Eliminado", "CONTROL DE INVENTARIOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Me.INVE_articulosTableAdapter.Fill(Me.DSControl.INVE_articulos)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.SelectedValue = 0
        txt_clave.Text = ""
        txt_nombre.Text = ""

    End Sub
End Class