<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_articulos
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
        Me.DSControl = New Control_de_Inventarios.DSControl()
        Me.INVEalmacenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVE_almacenesTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_almacenesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.INVEarticulosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.INVEarticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVE_articulosTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_articulosTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DSControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEalmacenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEarticulosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEarticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DSControl
        '
        Me.DSControl.DataSetName = "DSControl"
        Me.DSControl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Clave:"
        '
        'txt_clave
        '
        Me.txt_clave.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVEarticulosBindingSource1, "clave", True))
        Me.txt_clave.Location = New System.Drawing.Point(137, 29)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(162, 20)
        Me.txt_clave.TabIndex = 18
        '
        'INVEarticulosBindingSource1
        '
        Me.INVEarticulosBindingSource1.DataMember = "INVE_articulos"
        Me.INVEarticulosBindingSource1.DataSource = Me.DSControl
        '
        'txt_nombre
        '
        Me.txt_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVEarticulosBindingSource1, "descr", True))
        Me.txt_nombre.Location = New System.Drawing.Point(137, 73)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(344, 20)
        Me.txt_nombre.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Descripción"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(265, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 20)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Productos"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(362, 202)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 20)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(462, 202)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(81, 20)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.INVEarticulosBindingSource1
        Me.ComboBox1.DisplayMember = "clave"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(28, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(371, 21)
        Me.ComboBox1.TabIndex = 26
        Me.ComboBox1.ValueMember = "id_articulo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_clave)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 142)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Producto"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(137, 99)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(81, 20)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Nuevo"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frm_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 235)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frm_articulos"
        Me.Text = "CONTROL DE INVENTARIOS-ARTICULOS"
        CType(Me.DSControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEalmacenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEarticulosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEarticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DSControl As DSControl
    Friend WithEvents INVEalmacenesBindingSource As BindingSource
    Friend WithEvents INVE_almacenesTableAdapter As DSControlTableAdapters.INVE_almacenesTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents INVEarticulosBindingSource As BindingSource
    Friend WithEvents INVE_articulosTableAdapter As DSControlTableAdapters.INVE_articulosTableAdapter
    Friend WithEvents INVEarticulosBindingSource1 As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
End Class
