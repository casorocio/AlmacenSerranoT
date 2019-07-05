Imports System.Data
Imports System.Data.SqlClient
Public Class ProveedorServicio2
    Private ProvS_ As ProveedorServicioClass
    Private EsNuevo_ As Boolean
    Dim conex As New Conexion
    Private Property ProveedorServicio() As ProveedorServicioClass
        Get
            Return ProvS_

        End Get
        Set(ByVal value As ProveedorServicioClass)
            ProvS_ = value
        End Set
    End Property

    Public Property EsNuevo() As Boolean
        Get
            Return EsNuevo_
        End Get
        Set(ByVal value As Boolean)
            EsNuevo_ = value
        End Set
    End Property
    'constructor para modificar
    Public Sub New(ByVal ProvS As ProveedorServicioClass)
        InitializeComponent()
        ProveedorServicio = ProvS
        EsNuevo_ = False
    End Sub

    Private Sub ProveedorServicio2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextId.Text = ProveedorServicio.Id
        TextCompania.Text = ProveedorServicio.Compania
        TextTipo.Text = ProveedorServicio.Tipo
        TextApellido.Text = ProveedorServicio.Apellido
        TextNombre.Text = ProveedorServicio.Nombre
        TextEmail.Text = ProveedorServicio.Email
        TextTelefono.Text = ProveedorServicio.Telefono
        TextDireccion.Text = ProveedorServicio.Direccion
        TextTipodepago.Text = ProveedorServicio.Tipodepago
        TextNota.Text = ProveedorServicio.Nota

    End Sub
    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim ProvS As New ProveedorServicioClass

        ProveedorServicio.Id = 0
        ProveedorServicio.Tipo = ""
        ProveedorServicio.Compania = ""
        ProveedorServicio.Apellido = ""
        ProveedorServicio.Nombre = ""
        ProveedorServicio.Email = ""
        ProveedorServicio.Telefono = ""
        ProveedorServicio.Direccion = ""
        ProveedorServicio.Tipodepago = ""
        ProveedorServicio.Nota = ""



        ProveedorServicio = ProvS

        EsNuevo = True
    End Sub
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
        conex.cerrar()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        Dim ProveedorServicio As New ProveedorServicioClass



        ProveedorServicio.Id = TextId.Text
        ProveedorServicio.Compania = TextCompania.Text
        ProveedorServicio.Tipo = TextTipo.Text
        ProveedorServicio.Apellido = TextApellido.Text
        ProveedorServicio.Nombre = TextNombre.Text
        ProveedorServicio.Email = TextEmail.Text
        ProveedorServicio.Telefono = TextTelefono.Text
        ProveedorServicio.Direccion = TextDireccion.Text
        ProveedorServicio.Tipodepago = TextTipodepago.Text
        ProveedorServicio.Nota = TextNota.Text
        If EsNuevo Then
            ProveedorServicio.Agregar(ProveedorServicio)
        Else
            ProveedorServicio.Modificar(ProveedorServicio)
            'MsgBox("todavia no se pudo agregar !!!")


        End If

        Close()


    End Sub
End Class