<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesForm
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
        Me.TxtId = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Apellido = New System.Windows.Forms.Label
        Me.TxtNegocio = New System.Windows.Forms.TextBox
        Me.TxtDirección = New System.Windows.Forms.TextBox
        Me.TxtTelefono = New System.Windows.Forms.TextBox
        Me.TxtEmail = New System.Windows.Forms.TextBox
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.TxtApellido = New System.Windows.Forms.TextBox
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Id:"
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(76, 25)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(57, 20)
        Me.TxtId.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Negocio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nombre:"
        '
        'Apellido
        '
        Me.Apellido.AutoSize = True
        Me.Apellido.Location = New System.Drawing.Point(26, 70)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(47, 13)
        Me.Apellido.TabIndex = 22
        Me.Apellido.Text = "Apellido:"
        '
        'TxtNegocio
        '
        Me.TxtNegocio.Location = New System.Drawing.Point(76, 222)
        Me.TxtNegocio.Name = "TxtNegocio"
        Me.TxtNegocio.Size = New System.Drawing.Size(216, 20)
        Me.TxtNegocio.TabIndex = 21
        '
        'TxtDirección
        '
        Me.TxtDirección.Location = New System.Drawing.Point(76, 145)
        Me.TxtDirección.Name = "TxtDirección"
        Me.TxtDirección.Size = New System.Drawing.Size(216, 20)
        Me.TxtDirección.TabIndex = 20
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(76, 106)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelefono.TabIndex = 19
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(76, 182)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(216, 20)
        Me.TxtEmail.TabIndex = 18
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(283, 67)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 17
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(76, 67)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(151, 20)
        Me.TxtApellido.TabIndex = 16
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(91, 266)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 32)
        Me.Aceptar.TabIndex = 30
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.Color.SandyBrown
        Me.Cancelar.Location = New System.Drawing.Point(245, 266)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 32)
        Me.Cancelar.TabIndex = 31
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'ClientesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(391, 314)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Apellido)
        Me.Controls.Add(Me.TxtNegocio)
        Me.Controls.Add(Me.TxtDirección)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtApellido)
        Me.Name = "ClientesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientesForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Apellido As System.Windows.Forms.Label
    Friend WithEvents TxtNegocio As System.Windows.Forms.TextBox
    Friend WithEvents TxtDirección As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
End Class
