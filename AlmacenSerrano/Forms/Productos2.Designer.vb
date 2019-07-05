<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos2
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextId = New System.Windows.Forms.TextBox
        Me.TextProducto = New System.Windows.Forms.TextBox
        Me.TextDescripcion = New System.Windows.Forms.TextBox
        Me.TextCantidad = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextPrecioCompra = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextPrecioVenta = New System.Windows.Forms.TextBox
        Me.TextPrecioxmayor = New System.Windows.Forms.TextBox
        Me.TextIva = New System.Windows.Forms.TextBox
        Me.TextCantMinInv = New System.Windows.Forms.TextBox
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.ComboIdCategoria = New System.Windows.Forms.ComboBox
        Me.ComboIdProveedor = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Categoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad"
        '
        'TextId
        '
        Me.TextId.Location = New System.Drawing.Point(92, 30)
        Me.TextId.Name = "TextId"
        Me.TextId.Size = New System.Drawing.Size(100, 20)
        Me.TextId.TabIndex = 6
        '
        'TextProducto
        '
        Me.TextProducto.Location = New System.Drawing.Point(92, 81)
        Me.TextProducto.Name = "TextProducto"
        Me.TextProducto.Size = New System.Drawing.Size(100, 20)
        Me.TextProducto.TabIndex = 8
        '
        'TextDescripcion
        '
        Me.TextDescripcion.Location = New System.Drawing.Point(92, 110)
        Me.TextDescripcion.Name = "TextDescripcion"
        Me.TextDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.TextDescripcion.TabIndex = 9
        '
        'TextCantidad
        '
        Me.TextCantidad.Location = New System.Drawing.Point(92, 138)
        Me.TextCantidad.Name = "TextCantidad"
        Me.TextCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TextCantidad.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(258, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Precio Compra"
        '
        'TextPrecioCompra
        '
        Me.TextPrecioCompra.Location = New System.Drawing.Point(368, 30)
        Me.TextPrecioCompra.Name = "TextPrecioCompra"
        Me.TextPrecioCompra.Size = New System.Drawing.Size(100, 20)
        Me.TextPrecioCompra.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(258, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Precio Venta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(258, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Precio x mayor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(258, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Iva"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(258, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Cant. Minima Invent."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(258, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "ID Proveedor"
        '
        'TextPrecioVenta
        '
        Me.TextPrecioVenta.Location = New System.Drawing.Point(368, 55)
        Me.TextPrecioVenta.Name = "TextPrecioVenta"
        Me.TextPrecioVenta.Size = New System.Drawing.Size(100, 20)
        Me.TextPrecioVenta.TabIndex = 19
        '
        'TextPrecioxmayor
        '
        Me.TextPrecioxmayor.Location = New System.Drawing.Point(368, 83)
        Me.TextPrecioxmayor.Name = "TextPrecioxmayor"
        Me.TextPrecioxmayor.Size = New System.Drawing.Size(100, 20)
        Me.TextPrecioxmayor.TabIndex = 20
        '
        'TextIva
        '
        Me.TextIva.Location = New System.Drawing.Point(368, 110)
        Me.TextIva.Name = "TextIva"
        Me.TextIva.Size = New System.Drawing.Size(100, 20)
        Me.TextIva.TabIndex = 21
        '
        'TextCantMinInv
        '
        Me.TextCantMinInv.Location = New System.Drawing.Point(368, 138)
        Me.TextCantMinInv.Name = "TextCantMinInv"
        Me.TextCantMinInv.Size = New System.Drawing.Size(100, 20)
        Me.TextCantMinInv.TabIndex = 22
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(15, 266)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 24
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.SandyBrown
        Me.Cancelar.Location = New System.Drawing.Point(386, 266)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 25
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'ComboIdCategoria
        '
        Me.ComboIdCategoria.FormattingEnabled = True
        Me.ComboIdCategoria.Location = New System.Drawing.Point(92, 55)
        Me.ComboIdCategoria.Name = "ComboIdCategoria"
        Me.ComboIdCategoria.Size = New System.Drawing.Size(121, 21)
        Me.ComboIdCategoria.TabIndex = 26
        '
        'ComboIdProveedor
        '
        Me.ComboIdProveedor.FormattingEnabled = True
        Me.ComboIdProveedor.Location = New System.Drawing.Point(347, 164)
        Me.ComboIdProveedor.Name = "ComboIdProveedor"
        Me.ComboIdProveedor.Size = New System.Drawing.Size(121, 21)
        Me.ComboIdProveedor.TabIndex = 27
        '
        'Productos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(473, 327)
        Me.Controls.Add(Me.ComboIdProveedor)
        Me.Controls.Add(Me.ComboIdCategoria)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.TextCantMinInv)
        Me.Controls.Add(Me.TextIva)
        Me.Controls.Add(Me.TextPrecioxmayor)
        Me.Controls.Add(Me.TextPrecioVenta)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextPrecioCompra)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextCantidad)
        Me.Controls.Add(Me.TextDescripcion)
        Me.Controls.Add(Me.TextProducto)
        Me.Controls.Add(Me.TextId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Productos2"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextId As System.Windows.Forms.TextBox
    Friend WithEvents TextProducto As System.Windows.Forms.TextBox
    Friend WithEvents TextDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TextCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextPrecioCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextPrecioVenta As System.Windows.Forms.TextBox
    Friend WithEvents TextPrecioxmayor As System.Windows.Forms.TextBox
    Friend WithEvents TextIva As System.Windows.Forms.TextBox
    Friend WithEvents TextCantMinInv As System.Windows.Forms.TextBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents ComboIdCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents ComboIdProveedor As System.Windows.Forms.ComboBox

End Class
