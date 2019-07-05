Imports System.Data
Imports System.Data.SqlClient
Public Class Categorias2

    Private Cat_ As CategoriasClass
    Private Modificar_ As Boolean
    Dim conex As New Conexion
    Private Property Categoria() As CategoriasClass
        Get
            Return Cat_

        End Get
        Set(ByVal value As CategoriasClass)
            Cat_ = value
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
    Public Sub New(ByVal Cat As CategoriasClass)
        InitializeComponent()
        Categoria = Cat
        Modificar = True
    End Sub

    Private Sub Categorias2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextId.Text = Categoria.Id
        TextTipo.Text = Categoria.Tipo


    End Sub
    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim Cat As New CategoriasClass

        Categoria.Id = 0
        Categoria.Tipo = ""


        Categoria = Cat

        Modificar = False
    End Sub
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
        conex.cerrar()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        Dim Categoria As New CategoriasClass

        If Modificar = True Then

            Categoria.Id = TextId.Text
            Categoria.Tipo = TextTipo.Text

            Categoria.Modificar(Categoria)
        Else
            MsgBox("todavia no se pudo agregar !!!")


        End If

        Close()


    End Sub
End Class