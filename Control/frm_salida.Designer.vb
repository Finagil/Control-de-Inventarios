<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_salida
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
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.Label()
        Me.txt_cant = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_unidades = New System.Windows.Forms.TextBox()
        Me.dt_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ArticuloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdsalidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwinvsalidasBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSControl = New Control_de_Inventarios.DSControl()
        Me.VwinvsalidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DescrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdesDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdsalidaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VwinvesalidadetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_unidad = New System.Windows.Forms.ComboBox()
        Me.INVEmedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_articulo = New System.Windows.Forms.ComboBox()
        Me.INVEarticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVE_articulosTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_articulosTableAdapter()
        Me.INVE_medidaTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_medidaTableAdapter()
        Me.Vw_inv_salidasTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.vw_inv_salidasTableAdapter()
        Me.Vw_inve_salidadetalleTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.vw_inve_salidadetalleTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.INVEentradassalidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVE_entradas_salidasTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_entradas_salidasTableAdapter()
        Me.VWINVEexistenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VW_INVE_existenciaTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.VW_INVE_existenciaTableAdapter()
        Me.VwinvesalidadetalleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVEsalidadetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVE_salidadetalleTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_salidadetalleTableAdapter()
        Me.VwinvsalidasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwinvsalidasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VWINVEexistenciaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwinvsalidasBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwinvsalidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwinvesalidadetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.INVEmedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEarticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEentradassalidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWINVEexistenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwinvesalidadetalleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEsalidadetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwinvsalidasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwinvsalidasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VWINVEexistenciaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_guardar
        '
        Me.bt_guardar.Location = New System.Drawing.Point(452, 90)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(75, 23)
        Me.bt_guardar.TabIndex = 26
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(240, 96)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(79, 20)
        Me.txt_precio.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(151, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Precio de Venta"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.AutoSize = True
        Me.txt_cantidad.Location = New System.Drawing.Point(7, 100)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(49, 13)
        Me.txt_cantidad.TabIndex = 21
        Me.txt_cantidad.Text = "Cantidad"
        '
        'txt_cant
        '
        Me.txt_cant.Location = New System.Drawing.Point(56, 96)
        Me.txt_cant.Name = "txt_cant"
        Me.txt_cant.Size = New System.Drawing.Size(79, 20)
        Me.txt_cant.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Unidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Artículo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Unidades Existencia"
        '
        'txt_unidades
        '
        Me.txt_unidades.Location = New System.Drawing.Point(393, 26)
        Me.txt_unidades.Name = "txt_unidades"
        Me.txt_unidades.ReadOnly = True
        Me.txt_unidades.Size = New System.Drawing.Size(79, 20)
        Me.txt_unidades.TabIndex = 27
        '
        'dt_fecha
        '
        Me.dt_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_fecha.Location = New System.Drawing.Point(620, 28)
        Me.dt_fecha.Name = "dt_fecha"
        Me.dt_fecha.Size = New System.Drawing.Size(137, 20)
        Me.dt_fecha.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(577, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Fecha"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArticuloDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.FolioDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.UnidadDataGridViewTextBoxColumn, Me.IdsalidaDataGridViewTextBoxColumn, Me.IdesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VwinvsalidasBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(11, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(746, 150)
        Me.DataGridView1.TabIndex = 31
        '
        'ArticuloDataGridViewTextBoxColumn
        '
        Me.ArticuloDataGridViewTextBoxColumn.DataPropertyName = "articulo"
        Me.ArticuloDataGridViewTextBoxColumn.HeaderText = "ARTICULO"
        Me.ArticuloDataGridViewTextBoxColumn.Name = "ArticuloDataGridViewTextBoxColumn"
        Me.ArticuloDataGridViewTextBoxColumn.ReadOnly = True
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
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "PRECIO"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "FOLIO"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "SERIE"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        Me.SerieDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnidadDataGridViewTextBoxColumn
        '
        Me.UnidadDataGridViewTextBoxColumn.DataPropertyName = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.HeaderText = "unidad"
        Me.UnidadDataGridViewTextBoxColumn.Name = "UnidadDataGridViewTextBoxColumn"
        Me.UnidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnidadDataGridViewTextBoxColumn.Visible = False
        '
        'IdsalidaDataGridViewTextBoxColumn
        '
        Me.IdsalidaDataGridViewTextBoxColumn.DataPropertyName = "id_salida"
        Me.IdsalidaDataGridViewTextBoxColumn.HeaderText = "id_salida"
        Me.IdsalidaDataGridViewTextBoxColumn.Name = "IdsalidaDataGridViewTextBoxColumn"
        Me.IdsalidaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdsalidaDataGridViewTextBoxColumn.Visible = False
        '
        'IdesDataGridViewTextBoxColumn
        '
        Me.IdesDataGridViewTextBoxColumn.DataPropertyName = "id_es"
        Me.IdesDataGridViewTextBoxColumn.HeaderText = "id_es"
        Me.IdesDataGridViewTextBoxColumn.Name = "IdesDataGridViewTextBoxColumn"
        Me.IdesDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdesDataGridViewTextBoxColumn.Visible = False
        '
        'VwinvsalidasBindingSource3
        '
        Me.VwinvsalidasBindingSource3.DataMember = "vw_inv_salidas"
        Me.VwinvsalidasBindingSource3.DataSource = Me.DSControl
        '
        'DSControl
        '
        Me.DSControl.DataSetName = "DSControl"
        Me.DSControl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwinvsalidasBindingSource
        '
        Me.VwinvsalidasBindingSource.DataMember = "vw_inv_salidas"
        Me.VwinvsalidasBindingSource.DataSource = Me.DSControl
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescrDataGridViewTextBoxColumn, Me.Expr1DataGridViewTextBoxColumn, Me.Expr2DataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn1, Me.CostoDataGridViewTextBoxColumn, Me.IdesDataGridViewTextBoxColumn1, Me.IdsalidaDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.VwinvesalidadetalleBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(11, 339)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(745, 150)
        Me.DataGridView2.TabIndex = 32
        '
        'DescrDataGridViewTextBoxColumn
        '
        Me.DescrDataGridViewTextBoxColumn.DataPropertyName = "descr"
        Me.DescrDataGridViewTextBoxColumn.HeaderText = "descr"
        Me.DescrDataGridViewTextBoxColumn.Name = "DescrDataGridViewTextBoxColumn"
        Me.DescrDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescrDataGridViewTextBoxColumn.Visible = False
        '
        'Expr1DataGridViewTextBoxColumn
        '
        Me.Expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.HeaderText = "ALMACEN"
        Me.Expr1DataGridViewTextBoxColumn.Name = "Expr1DataGridViewTextBoxColumn"
        Me.Expr1DataGridViewTextBoxColumn.ReadOnly = True
        Me.Expr1DataGridViewTextBoxColumn.Width = 250
        '
        'Expr2DataGridViewTextBoxColumn
        '
        Me.Expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn.HeaderText = "UNIDAD"
        Me.Expr2DataGridViewTextBoxColumn.Name = "Expr2DataGridViewTextBoxColumn"
        Me.Expr2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn1
        '
        Me.CantidadDataGridViewTextBoxColumn1.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn1.HeaderText = "CANTIDAD"
        Me.CantidadDataGridViewTextBoxColumn1.Name = "CantidadDataGridViewTextBoxColumn1"
        Me.CantidadDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "COSTO"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdesDataGridViewTextBoxColumn1
        '
        Me.IdesDataGridViewTextBoxColumn1.DataPropertyName = "id_es"
        Me.IdesDataGridViewTextBoxColumn1.HeaderText = "id_es"
        Me.IdesDataGridViewTextBoxColumn1.Name = "IdesDataGridViewTextBoxColumn1"
        Me.IdesDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdesDataGridViewTextBoxColumn1.Visible = False
        '
        'IdsalidaDataGridViewTextBoxColumn1
        '
        Me.IdsalidaDataGridViewTextBoxColumn1.DataPropertyName = "id_salida"
        Me.IdsalidaDataGridViewTextBoxColumn1.HeaderText = "id_salida"
        Me.IdsalidaDataGridViewTextBoxColumn1.Name = "IdsalidaDataGridViewTextBoxColumn1"
        Me.IdsalidaDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdsalidaDataGridViewTextBoxColumn1.Visible = False
        '
        'VwinvesalidadetalleBindingSource
        '
        Me.VwinvesalidadetalleBindingSource.DataMember = "vw_inve_salidadetalle"
        Me.VwinvesalidadetalleBindingSource.DataSource = Me.DSControl
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 322)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "DETALLE DE SALIDA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "SALIDAS DE INVENTARIO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_unidad)
        Me.GroupBox1.Controls.Add(Me.cmb_articulo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad)
        Me.GroupBox1.Controls.Add(Me.txt_cant)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_unidades)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_precio)
        Me.GroupBox1.Controls.Add(Me.bt_guardar)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 122)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Salida de Inventario"
        '
        'cmb_unidad
        '
        Me.cmb_unidad.DataSource = Me.INVEmedidaBindingSource
        Me.cmb_unidad.DisplayMember = "descr"
        Me.cmb_unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_unidad.FormattingEnabled = True
        Me.cmb_unidad.Location = New System.Drawing.Point(62, 63)
        Me.cmb_unidad.Name = "cmb_unidad"
        Me.cmb_unidad.Size = New System.Drawing.Size(144, 21)
        Me.cmb_unidad.TabIndex = 28
        Me.cmb_unidad.ValueMember = "id_unidad"
        '
        'INVEmedidaBindingSource
        '
        Me.INVEmedidaBindingSource.DataMember = "INVE_medida"
        Me.INVEmedidaBindingSource.DataSource = Me.DSControl
        '
        'cmb_articulo
        '
        Me.cmb_articulo.DataSource = Me.INVEarticulosBindingSource
        Me.cmb_articulo.DisplayMember = "descr"
        Me.cmb_articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_articulo.FormattingEnabled = True
        Me.cmb_articulo.Location = New System.Drawing.Point(62, 30)
        Me.cmb_articulo.Name = "cmb_articulo"
        Me.cmb_articulo.Size = New System.Drawing.Size(144, 21)
        Me.cmb_articulo.TabIndex = 27
        Me.cmb_articulo.ValueMember = "id_articulo"
        '
        'INVEarticulosBindingSource
        '
        Me.INVEarticulosBindingSource.DataMember = "INVE_articulos"
        Me.INVEarticulosBindingSource.DataSource = Me.DSControl
        '
        'INVE_articulosTableAdapter
        '
        Me.INVE_articulosTableAdapter.ClearBeforeFill = True
        '
        'INVE_medidaTableAdapter
        '
        Me.INVE_medidaTableAdapter.ClearBeforeFill = True
        '
        'Vw_inv_salidasTableAdapter
        '
        Me.Vw_inv_salidasTableAdapter.ClearBeforeFill = True
        '
        'Vw_inve_salidadetalleTableAdapter
        '
        Me.Vw_inve_salidadetalleTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(657, 227)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 36
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
        'VWINVEexistenciaBindingSource
        '
        Me.VWINVEexistenciaBindingSource.DataMember = "VW_INVE_existencia"
        Me.VWINVEexistenciaBindingSource.DataSource = Me.DSControl
        '
        'VW_INVE_existenciaTableAdapter
        '
        Me.VW_INVE_existenciaTableAdapter.ClearBeforeFill = True
        '
        'VwinvesalidadetalleBindingSource1
        '
        Me.VwinvesalidadetalleBindingSource1.DataMember = "vw_inve_salidadetalle"
        Me.VwinvesalidadetalleBindingSource1.DataSource = Me.DSControl
        '
        'INVEsalidadetalleBindingSource
        '
        Me.INVEsalidadetalleBindingSource.DataMember = "INVE_salidadetalle"
        Me.INVEsalidadetalleBindingSource.DataSource = Me.DSControl
        '
        'INVE_salidadetalleTableAdapter
        '
        Me.INVE_salidadetalleTableAdapter.ClearBeforeFill = True
        '
        'VwinvsalidasBindingSource1
        '
        Me.VwinvsalidasBindingSource1.DataMember = "vw_inv_salidas"
        Me.VwinvsalidasBindingSource1.DataSource = Me.DSControl
        '
        'VwinvsalidasBindingSource2
        '
        Me.VwinvsalidasBindingSource2.DataMember = "vw_inv_salidas"
        Me.VwinvsalidasBindingSource2.DataSource = Me.DSControl
        '
        'VWINVEexistenciaBindingSource1
        '
        Me.VWINVEexistenciaBindingSource1.DataMember = "VW_INVE_existencia"
        Me.VWINVEexistenciaBindingSource1.DataSource = Me.DSControl
        '
        'frm_salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 502)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dt_fecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frm_salida"
        Me.Text = "CONTROL DE INVENTARIOS-SALIDAS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwinvsalidasBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwinvsalidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwinvesalidadetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.INVEmedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEarticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEentradassalidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWINVEexistenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwinvesalidadetalleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEsalidadetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwinvsalidasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwinvsalidasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VWINVEexistenciaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_guardar As Button
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cantidad As Label
    Friend WithEvents txt_cant As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_unidades As TextBox
    Friend WithEvents dt_fecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DescrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdesDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdsalidaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_unidad As ComboBox
    Friend WithEvents cmb_articulo As ComboBox
    Friend WithEvents DSControl As DSControl
    Friend WithEvents INVEarticulosBindingSource As BindingSource
    Friend WithEvents INVE_articulosTableAdapter As DSControlTableAdapters.INVE_articulosTableAdapter
    Friend WithEvents INVEmedidaBindingSource As BindingSource
    Friend WithEvents INVE_medidaTableAdapter As DSControlTableAdapters.INVE_medidaTableAdapter
    Friend WithEvents VwinvsalidasBindingSource As BindingSource
    Friend WithEvents Vw_inv_salidasTableAdapter As DSControlTableAdapters.vw_inv_salidasTableAdapter
    Friend WithEvents VwinvesalidadetalleBindingSource As BindingSource
    Friend WithEvents Vw_inve_salidadetalleTableAdapter As DSControlTableAdapters.vw_inve_salidadetalleTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents INVEentradassalidasBindingSource As BindingSource
    Friend WithEvents INVE_entradas_salidasTableAdapter As DSControlTableAdapters.INVE_entradas_salidasTableAdapter
    Friend WithEvents VWINVEexistenciaBindingSource As BindingSource
    Friend WithEvents VW_INVE_existenciaTableAdapter As DSControlTableAdapters.VW_INVE_existenciaTableAdapter
    Friend WithEvents VwinvesalidadetalleBindingSource1 As BindingSource
    Friend WithEvents INVEsalidadetalleBindingSource As BindingSource
    Friend WithEvents INVE_salidadetalleTableAdapter As DSControlTableAdapters.INVE_salidadetalleTableAdapter
    Friend WithEvents VwinvsalidasBindingSource2 As BindingSource
    Friend WithEvents VwinvsalidasBindingSource1 As BindingSource
    Friend WithEvents VWINVEexistenciaBindingSource1 As BindingSource
    Friend WithEvents VwinvsalidasBindingSource3 As BindingSource
    Friend WithEvents ArticuloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdsalidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
