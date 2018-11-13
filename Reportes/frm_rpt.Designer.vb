<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rpt
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VwINVEacumuladosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSControl = New Control_de_Inventarios.DSControl()
        Me.INVEcontrolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.INVE_controlTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_controlTableAdapter()
        Me.Vw_INVE_acumuladosTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.Vw_INVE_acumuladosTableAdapter()
        Me.INVEarticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVE_articulosTableAdapter = New Control_de_Inventarios.DSControlTableAdapters.INVE_articulosTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.VwINVEacumuladosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEcontrolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVEarticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.INVEarticulosBindingSource
        Me.ComboBox1.DisplayMember = "descr"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(116, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(204, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "id_articulo"
        '
        'VwINVEacumuladosBindingSource
        '
        Me.VwINVEacumuladosBindingSource.DataMember = "Vw_INVE_acumulados"
        Me.VwINVEacumuladosBindingSource.DataSource = Me.DSControl
        '
        'DSControl
        '
        Me.DSControl.DataSetName = "DSControl"
        Me.DSControl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INVEcontrolBindingSource
        '
        Me.INVEcontrolBindingSource.DataMember = "INVE_control"
        Me.INVEcontrolBindingSource.DataSource = Me.DSControl
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Location = New System.Drawing.Point(45, 65)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(1032, 684)
        Me.crv.TabIndex = 1
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'INVE_controlTableAdapter
        '
        Me.INVE_controlTableAdapter.ClearBeforeFill = True
        '
        'Vw_INVE_acumuladosTableAdapter
        '
        Me.Vw_INVE_acumuladosTableAdapter.ClearBeforeFill = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Artículo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(354, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_rpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 610)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frm_rpt"
        Me.Text = "frm_inv"
        CType(Me.VwINVEacumuladosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEcontrolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVEarticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DSControl As DSControl
    Friend WithEvents INVEcontrolBindingSource As BindingSource
    Friend WithEvents INVE_controlTableAdapter As DSControlTableAdapters.INVE_controlTableAdapter
    Friend WithEvents VwINVEacumuladosBindingSource As BindingSource
    Friend WithEvents Vw_INVE_acumuladosTableAdapter As DSControlTableAdapters.Vw_INVE_acumuladosTableAdapter
    Friend WithEvents INVEarticulosBindingSource As BindingSource
    Friend WithEvents INVE_articulosTableAdapter As DSControlTableAdapters.INVE_articulosTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
