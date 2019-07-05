Imports System.Data
Imports System.Data.SqlClient
Public Class Proveedores2
    Private Prov_ As ProveedoresClass
    Private Modificar_ As Boolean
    Dim conex As New conexion1
    Private Property Proveedor() As ProveedoresClass
        Get
            Return Prov_

        End Get
        Set(ByVal value As ProveedoresClass)
            Prov_ = value
        End Set
    End Property

    Public Property Modificar() As Boolean
        Get
            Return Modificar_
        End Get
        Set(ByVal value As Boolean)
            Modificar_ = value
        End Set
    End Property
    'constructor para modificar
    Public Sub New(ByVal Prov As ProveedoresClass)
        InitializeComponent()
        Proveedor = Prov
        Modificar = True
    End Sub

    Private Sub Proveedores2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextId.Text = Proveedor.Id
        TextCompania.Text = Proveedor.Compania
        TextCategoria.Text = Proveedor.Categoria
        TextApellido.Text = Proveedor.Apellido
        TextNombre.Text = Proveedor.Nombre
        TextEmail.Text = Proveedor.Email
        TextTelefono.Text = Proveedor.Telefono
        TextDireccion.Text = Proveedor.Direccion
        TextTerminosdepago.Text = Proveedor.Terminosdepago
        TextNotas.Text = Proveedor.Notas

    End Sub
    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim Prov As New ProveedoresClass

        Proveedor.Id = 0
        Proveedor.Categoria = ""
        Proveedor.Compania = ""
        Proveedor.Apellido = ""
        Proveedor.Nombre = ""
        Proveedor.Email = ""
        Proveedor.Telefono = ""
        Proveedor.Direccion = ""
        Proveedor.Terminosdepago = ""
        Proveedor.Notas = ""


        Proveedor = Prov

        Modificar = False
    End Sub
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
        conex.cerrar()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        Dim Proveedor As New ProveedoresClass

        If Modificar = True Then

            Proveedor.Id = TextId.Text
            Proveedor.Compania = TextCompania.Text
            Proveedor.Categoria = TextCategoria.Text
            Proveedor.Apellido = TextApellido.Text
            Proveedor.Nombre = TextNombre.Text
            Proveedor.Email = TextEmail.Text
            Proveedor.Telefono = TextTelefono.Text
            Proveedor.Direccion = TextDireccion.Text
            Proveedor.Terminosdepago = TextTerminosdepago.Text
            Proveedor.Notas = TextNotas.Text


            Proveedor.Modificar(Proveedor)
        Else
            MsgBox("todavia no se pudo agregar !!!")


        End If

        Close()


    End Sub
End Class