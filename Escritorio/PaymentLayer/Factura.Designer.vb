<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guardar = New System.Windows.Forms.Button()
        Me._comentario = New System.Windows.Forms.TextBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me._total = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me._iva = New System.Windows.Forms.TextBox()
        Me.label8 = New System.Windows.Forms.Label()
        Me._subtotal = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me._vencimiento = New System.Windows.Forms.DateTimePicker()
        Me._emision = New System.Windows.Forms.DateTimePicker()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me._detalles = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me._correo = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me._direccion = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me._cliente = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me._ruc = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me._numero = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me._detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(15, 398)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 67
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        '_comentario
        '
        Me._comentario.Location = New System.Drawing.Point(86, 266)
        Me._comentario.Multiline = True
        Me._comentario.Name = "_comentario"
        Me._comentario.Size = New System.Drawing.Size(423, 68)
        Me._comentario.TabIndex = 66
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(20, 269)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(60, 13)
        Me.label10.TabIndex = 65
        Me.label10.Text = "Comentario"
        '
        '_total
        '
        Me._total.Location = New System.Drawing.Point(605, 318)
        Me._total.Name = "_total"
        Me._total.ReadOnly = True
        Me._total.Size = New System.Drawing.Size(100, 20)
        Me._total.TabIndex = 64
        Me._total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(545, 321)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(31, 13)
        Me.label9.TabIndex = 63
        Me.label9.Text = "Total"
        '
        '_iva
        '
        Me._iva.Location = New System.Drawing.Point(605, 292)
        Me._iva.Name = "_iva"
        Me._iva.ReadOnly = True
        Me._iva.Size = New System.Drawing.Size(100, 20)
        Me._iva.TabIndex = 62
        Me._iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(545, 295)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(24, 13)
        Me.label8.TabIndex = 61
        Me.label8.Text = "IVA"
        '
        '_subtotal
        '
        Me._subtotal.Location = New System.Drawing.Point(605, 266)
        Me._subtotal.Name = "_subtotal"
        Me._subtotal.ReadOnly = True
        Me._subtotal.Size = New System.Drawing.Size(100, 20)
        Me._subtotal.TabIndex = 60
        Me._subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(545, 269)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(46, 13)
        Me.label7.TabIndex = 59
        Me.label7.Text = "Subtotal"
        '
        '_vencimiento
        '
        Me._vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me._vencimiento.Location = New System.Drawing.Point(605, 63)
        Me._vencimiento.Name = "_vencimiento"
        Me._vencimiento.Size = New System.Drawing.Size(100, 20)
        Me._vencimiento.TabIndex = 58
        '
        '_emision
        '
        Me._emision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me._emision.Location = New System.Drawing.Point(605, 37)
        Me._emision.Name = "_emision"
        Me._emision.Size = New System.Drawing.Size(100, 20)
        Me._emision.TabIndex = 57
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(534, 66)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(65, 13)
        Me.label6.TabIndex = 56
        Me.label6.Text = "Vencimiento"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(535, 40)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(43, 13)
        Me.label5.TabIndex = 55
        Me.label5.Text = "Emisión"
        '
        '_detalles
        '
        Me._detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me._detalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me._detalles.Location = New System.Drawing.Point(23, 132)
        Me._detalles.Name = "_detalles"
        Me._detalles.Size = New System.Drawing.Size(682, 119)
        Me._detalles.TabIndex = 54
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Descripción"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "N2"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N2"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "Precio Unitario"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        '_correo
        '
        Me._correo.Location = New System.Drawing.Point(80, 89)
        Me._correo.Name = "_correo"
        Me._correo.Size = New System.Drawing.Size(369, 20)
        Me._correo.TabIndex = 53
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(20, 92)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(38, 13)
        Me.label4.TabIndex = 52
        Me.label4.Text = "Correo"
        '
        '_direccion
        '
        Me._direccion.Location = New System.Drawing.Point(80, 63)
        Me._direccion.Name = "_direccion"
        Me._direccion.Size = New System.Drawing.Size(369, 20)
        Me._direccion.TabIndex = 51
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(20, 66)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(52, 13)
        Me.label3.TabIndex = 50
        Me.label3.Text = "Dirección"
        '
        '_cliente
        '
        Me._cliente.Location = New System.Drawing.Point(80, 37)
        Me._cliente.Name = "_cliente"
        Me._cliente.Size = New System.Drawing.Size(369, 20)
        Me._cliente.TabIndex = 49
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(20, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(39, 13)
        Me.label2.TabIndex = 48
        Me.label2.Text = "Cliente"
        '
        '_ruc
        '
        Me._ruc.Location = New System.Drawing.Point(80, 11)
        Me._ruc.Name = "_ruc"
        Me._ruc.Size = New System.Drawing.Size(100, 20)
        Me._ruc.TabIndex = 47
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(20, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(30, 13)
        Me.label1.TabIndex = 46
        Me.label1.Text = "RUC"
        '
        '_numero
        '
        Me._numero.Location = New System.Drawing.Point(605, 11)
        Me._numero.Name = "_numero"
        Me._numero.ReadOnly = True
        Me._numero.Size = New System.Drawing.Size(100, 20)
        Me._numero.TabIndex = 69
        Me._numero.Text = "153546"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(535, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Número"
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 433)
        Me.Controls.Add(Me._numero)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me._comentario)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me._total)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me._iva)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me._subtotal)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me._vencimiento)
        Me.Controls.Add(Me._emision)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me._detalles)
        Me.Controls.Add(Me._correo)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me._direccion)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me._cliente)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me._ruc)
        Me.Controls.Add(Me.label1)
        Me.Name = "Factura"
        Me.Text = "Factura"
        CType(Me._detalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Guardar As Button
    Private WithEvents _comentario As TextBox
    Private WithEvents label10 As Label
    Private WithEvents _total As TextBox
    Private WithEvents label9 As Label
    Private WithEvents _iva As TextBox
    Private WithEvents label8 As Label
    Private WithEvents _subtotal As TextBox
    Private WithEvents label7 As Label
    Private WithEvents _vencimiento As DateTimePicker
    Private WithEvents _emision As DateTimePicker
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents _detalles As DataGridView
    Private WithEvents _correo As TextBox
    Private WithEvents label4 As Label
    Private WithEvents _direccion As TextBox
    Private WithEvents label3 As Label
    Private WithEvents _cliente As TextBox
    Private WithEvents label2 As Label
    Private WithEvents _ruc As TextBox
    Private WithEvents label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Private WithEvents _numero As TextBox
    Private WithEvents Label11 As Label
End Class
