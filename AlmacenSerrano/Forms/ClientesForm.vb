Imports System.Data
Imports System.Data.SqlClient

Public Class ClientesForm
    Private clie_ As Clientes
    Private esNuevo_ As Boolean


    Public Property esNuevo() As Integer
        Get
            Return esNuevo_
        End Get
        Set(ByVal value As Integer)
            esNuevo_ = value
        End Set
    End Property

    Public Property cli() As Clientes
        Get
            Return clie_
        End Get
        Set(ByVal value As Clientes)
            clie_ = value
        End Set
    End Property

    Public Sub New(ByVal clie As Clientes)
        InitializeComponent()
        cli = clie
        esNuevo = False
    End Sub

    Public Sub New()
        InitializeComponent()

        Dim clie As New Clientes

        clie.Id = 0
        clie.Apellido = ""
        clie.Nombre = ""
        clie.Email = ""
        clie.Telefono = ""
        clie.Dirección = ""
        clie.Negocio = ""

        cli = clie
        esNuevo = True

    End Sub


    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtId.Text = cli.Id
        TxtApellido.Text = cli.Apellido
        TxtNombre.Text = cli.Nombre
        TxtEmail.Text = cli.Email
        TxtTelefono.Text = cli.Telefono
        TxtDirección.Text = cli.Dirección
        TxtNegocio.Text = cli.Negocio

    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        Dim cli As New Clientes

        cli.Id = TxtId.Text
        cli.Apellido = TxtApellido.Text
        cli.Nombre = TxtNombre.Text
        cli.Email = TxtEmail.Text
        cli.Telefono = TxtTelefono.Text
        cli.Dirección = TxtDirección.Text
        cli.Negocio = TxtNegocio.Text

        If esNuevo Then
            cli.Agregar(cli)
        Else
            cli.Modificar(cli)
        End If

        Close()
    End Sub

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Close()

    End Sub
End Class