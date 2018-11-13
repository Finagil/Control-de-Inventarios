<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_altas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmb_articulo = New System.Windows.Forms.ComboBox()
        Me.INVEarticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSControl = New Control_de_Inventarios.DSControl()
        Me.DSControlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVE_articulosTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_articulosTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_unidad = New System.Windows.Forms.ComboBox()
        Me.INVEmedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVEarticulosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVE_medidaTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_medidaTableAdapter()
        Me.txt_cant = New System.Windows.Forms.TextBox()
        Me.txt_cantidad = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_costo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_almacen = New System.Windows.Forms.ComboBox()
        Me.INVEalmacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVE_almacenesTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_almacenesTableAdapter()
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.INVEentradassalidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVE_entradas_salidasTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_entradas_salidasTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALMACEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VWINVALTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VW_INV_ALTASTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.VW_INV_ALTASTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VwinvarticuloexistenciasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_inv_articulo_existenciasTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.vw_inv_articulo_existenciasTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlmacenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwinvarticuloexistenciasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSControl1 = New Control_de_Inventarios.DSControl()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.INVEarticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSControlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEmedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEarticulosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEalmacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEentradassalidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWINVALTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VwinvarticuloexistenciasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwinvarticuloexistenciasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_articulo
        '
        Me.cmb_articulo.DataSource = Me.INVEarticulosBindingSource
        Me.cmb_articulo.DisplayMember = "clave"
        Me.cmb_articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_articulo.FormattingEnabled = True
        Me.cmb_articulo.Location = New System.Drawing.Point(60, 56)
        Me.cmb_articulo.Name = "cmb_articulo"
        Me.cmb_articulo.Size = New System.Drawing.Size(162, 21)
        Me.cmb_articulo.TabIndex = 0
        Me.cmb_articulo.ValueMember = "id_articulo"
        '
        'INVEarticulosBindingSource
        '
        Me.INVEarticulosBindingSource.DataMember = "INVE_articulos"
        Me.INVEarticulosBindingSource.DataSource = Me.DSControl
        '
        'DSControl
        '
        Me.DSControl.DataSetName = "DSControl"
        Me.DSControl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DSControlBindingSource
        '
        Me.DSControlBindingSource.DataSource = Me.DSControl
        Me.DSControlBindingSource.Position = 0
        '
        'INVE_articulosTableAdapter
        '
        Me.INVE_articulosTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Artículo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Unidad"
        '
        'cmb_unidad
        '
        Me.cmb_unidad.DataSource = Me.INVEmedidaBindingSource
        Me.cmb_unidad.DisplayMember = "descr"
        Me.cmb_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_unidad.FormattingEnabled = True
        Me.cmb_unidad.Location = New System.Drawing.Point(60, 93)
        Me.cmb_unidad.Name = "cmb_unidad"
        Me.cmb_unidad.Size = New System.Drawing.Size(85, 21)
        Me.cmb_unidad.TabIndex = 3
        Me.cmb_unidad.ValueMember = "id_unidad"
        '
        'INVEmedidaBindingSource
        '
        Me.INVEmedidaBindingSource.DataMember = "INVE_medida"
        Me.INVEmedidaBindingSource.DataSource = Me.DSControl
        '
        'INVEarticulosBindingSource1
        '
        Me.INVEarticulosBindingSource1.DataMember = "INVE_articulos"
        Me.INVEarticulosBindingSource1.DataSource = Me.DSControlBindingSource
        '
        'INVE_medidaTableAdapter
        '
        Me.INVE_medidaTableAdapter.ClearBeforeFill = True
        '
        'txt_cant
        '
        Me.txt_cant.Location = New System.Drawing.Point(61, 124)
        Me.txt_cant.Name = "txt_cant"
        Me.txt_cant.Size = New System.Drawing.Size(79, 20)
        Me.txt_cant.TabIndex = 8
        '
        'txt_cantidad
        '
        Me.txt_cantidad.AutoSize = True
        Me.txt_cantidad.Location = New System.Drawing.Point(6, 124)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(49, 13)
        Me.txt_cantidad.TabIndex = 9
        Me.txt_cantidad.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(163, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Costo"
        '
        'txt_costo
        '
        Me.txt_costo.Location = New System.Drawing.Point(203, 121)
        Me.txt_costo.Name = "txt_costo"
        Me.txt_costo.Size = New System.Drawing.Size(79, 20)
        Me.txt_costo.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Almacen"
        '
        'cmb_almacen
        '
        Me.cmb_almacen.DataSource = Me.INVEalmacenesBindingSource
        Me.cmb_almacen.DisplayMember = "descr"
        Me.cmb_almacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_almacen.FormattingEnabled = True
        Me.cmb_almacen.Location = New System.Drawing.Point(60, 24)
        Me.cmb_almacen.Name = "cmb_almacen"
        Me.cmb_almacen.Size = New System.Drawing.Size(162, 21)
        Me.cmb_almacen.TabIndex = 13
        Me.cmb_almacen.ValueMember = "id_almacen"
        '
        'INVEalmacenesBindingSource
        '
        Me.INVEalmacenesBindingSource.DataMember = "INVE_almacenes"
        Me.INVEalmacenesBindingSource.DataSource = Me.DSControl
        '
        'INVE_almacenesTableAdapter
        '
        Me.INVE_almacenesTableAdapter.ClearBeforeFill = True
        '
        'bt_guardar
        '
        Me.bt_guardar.Location = New System.Drawing.Point(207, 164)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bt_guardar.TabIndex = 15
        Me.bt_guardar.Text = "Agregar"
        Me.bt_guardar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'INVEentradassalidasBindingSource
        '
        Me.INVEentradassalidasBindingSource.DataMember = "INVE_entradas/salidas"
        Me.INVEentradassalidasBindingSource.DataSource = Me.DSControl
        '
        'INVE_entradas_salidasTableAdapter
        '
        Me.INVE_entradas_salidasTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Fecha"
        '
        'dt_fecha
        '
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha.Location = New System.Drawing.Point(378, 13)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(108, 20)
        Me.dt_fecha.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArticuloDataGridViewTextBoxColumn, Me.ALMACEN, Me.CantidadDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.IdesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VWINVALTASBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(549, 222)
        Me.DataGridView1.TabIndex = 31
        '
        'ArticuloDataGridViewTextBoxColumn
        '
        Me.ArticuloDataGridViewTextBoxColumn.DataPropertyName = "articulo"
        Me.ArticuloDataGridViewTextBoxColumn.HeaderText = "ARTICULO"
        Me.ArticuloDataGridViewTextBoxColumn.Name = "ArticuloDataGridViewTextBoxColumn"
        Me.ArticuloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ALMACEN
        '
        Me.ALMACEN.DataPropertyName = "ALMACEN"
        Me.ALMACEN.HeaderText = "ALMACEN"
        Me.ALMACEN.Name = "ALMACEN"
        Me.ALMACEN.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "CANTIDAD"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "COSTO"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdesDataGridViewTextBoxColumn
        '
        Me.IdesDataGridViewTextBoxColumn.DataPropertyName = "id_es"
        Me.IdesDataGridViewTextBoxColumn.HeaderText = "id_es"
        Me.IdesDataGridViewTextBoxColumn.Name = "IdesDataGridViewTextBoxColumn"
        Me.IdesDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdesDataGridViewTextBoxColumn.Visible = False
        '
        'VWINVALTASBindingSource
        '
        Me.VWINVALTASBindingSource.DataMember = "VW_INV_ALTAS"
        Me.VWINVALTASBindingSource.DataSource = Me.DSControl
        '
        'VW_INV_ALTASTableAdapter
        '
        Me.VW_INV_ALTASTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmb_almacen)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_articulo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmb_unidad)
        Me.GroupBox1.Controls.Add(Me.bt_guardar)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad)
        Me.GroupBox1.Controls.Add(Me.txt_costo)
        Me.GroupBox1.Controls.Add(Me.txt_cant)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 193)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alta de Productos"
        '
        'VwinvarticuloexistenciasBindingSource
        '
        Me.VwinvarticuloexistenciasBindingSource.DataMember = "vw_inv_articulo_existencias"
        Me.VwinvarticuloexistenciasBindingSource.DataSource = Me.DSControl
        '
        'Vw_inv_articulo_existenciasTableAdapter
        '
        Me.Vw_inv_articulo_existenciasTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductoDataGridViewTextBoxColumn, Me.AlmacenDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.VwinvarticuloexistenciasBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(583, 237)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(360, 222)
        Me.DataGridView2.TabIndex = 33
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "ARTICULO"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        '
        'AlmacenDataGridViewTextBoxColumn
        '
        Me.AlmacenDataGridViewTextBoxColumn.DataPropertyName = "almacen"
        Me.AlmacenDataGridViewTextBoxColumn.HeaderText = "ALMACEN"
        Me.AlmacenDataGridViewTextBoxColumn.Name = "AlmacenDataGridViewTextBoxColumn"
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "EXISTENCIA"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        '
        'VwinvarticuloexistenciasBindingSource1
        '
        Me.VwinvarticuloexistenciasBindingSource1.DataMember = "vw_inv_articulo_existencias"
        Me.VwinvarticuloexistenciasBindingSource1.DataSource = Me.DSControl1
        '
        'DSControl1
        '
        Me.DSControl1.DataSetName = "DSControl"
        Me.DSControl1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(580, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "EXISTENCIAS TOTALES"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "REGISTRO DE ENTRADAS"
        '
        'frm_altas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 472)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dt_fecha)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frm_altas"
        Me.Text = "CONTROL DE INVENTARIO-ALTAS"
        CType(Me.INVEarticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSControlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEmedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEarticulosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEalmacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEentradassalidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWINVALTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VwinvarticuloexistenciasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwinvarticuloexistenciasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_articulo As ComboBox
    Friend WithEvents DSControlBindingSource As BindingSource
    Friend WithEvents DSControl As DSControl
    Friend WithEvents INVEarticulosBindingSource As BindingSource
    Friend WithEvents INVE_articulosTableAdapter As DSControlTableAdapters.INVE_articulosTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_unidad As ComboBox
    Friend WithEvents INVEarticulosBindingSource1 As BindingSource
    Friend WithEvents INVEmedidaBindingSource As BindingSource
    Friend WithEvents INVE_medidaTableAdapter As DSControlTableAdapters.INVE_medidaTableAdapter
    Friend WithEvents txt_cant As TextBox
    Friend WithEvents txt_cantidad As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_costo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_almacen As ComboBox
    Friend WithEvents INVEalmacenesBindingSource As BindingSource
    Friend WithEvents INVE_almacenesTableAdapter As DSControlTableAdapters.INVE_almacenesTableAdapter
    Friend WithEvents bt_guardar As Button
    Friend WithEvents INVEentradassalidasBindingSource As BindingSource
    Friend WithEvents INVE_entradas_salidasTableAdapter As DSControlTableAdapters.INVE_entradas_salidasTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents dt_fecha As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VWINVALTASBindingSource As BindingSource
    Friend WithEvents VW_INV_ALTASTableAdapter As DSControlTableAdapters.VW_INV_ALTASTableAdapter
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ALMACEN As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VwinvarticuloexistenciasBindingSource As BindingSource
    Friend WithEvents Vw_inv_articulo_existenciasTableAdapter As DSControlTableAdapters.vw_inv_articulo_existenciasTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DSControl1 As DSControl
    Friend WithEvents VwinvarticuloexistenciasBindingSource1 As BindingSource
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlmacenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
End Class
