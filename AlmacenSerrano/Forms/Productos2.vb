
Imports System.Data
Imports System.Data.SqlClient
Public Class Productos2
    Private prod_ As ProductosClass
    Private Modificar_ As Boolean
    Dim conex As New conexion1
    Private Property producto() As ProductosClass
        Get
            Return prod_

        End Get
        Set(ByVal value As ProductosClass)
            prod_ = value
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
    Public Sub New(ByVal prod As ProductosClass)
        InitializeComponent()
        producto = prod
        Modificar = True
    End Sub

    Dim categoria As New CategoriasClass

    Private Sub Productos2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextId.Text = producto.Id
        TextCantidad.Text = producto.Cantidad
        categoria.CargarCombo(ComboIdCategoria)
        ComboIdCategoria.SelectedValue = producto.Idcategoria
        TextProducto.Text = producto.Producto
        TextDescripcion.Text = producto.Descripcion
        TextPrecioVenta.Text = producto.Preciounitventa
        'TextPrecioCompra = producto.Preciounitcompra
        TextPrecioxmayor.Text = producto.Preciounitmay
        TextIva.Text = producto.Iva
        TextCantMinInv.Text = producto.Cantmininv
        

    End Sub
    'constructor para agregar
    Public Sub New()
        InitializeComponent()

        Dim Prod As New ProductosClass

        producto.Id = 0
        producto.Idcategoria = 0
        producto.Producto = ""
        producto.Descripcion = ""
        producto.Cantidad = 0
        producto.Preciounitcompra = 0
        producto.Preciounitventa = 0
        producto.Preciounitmay = 0
        producto.Iva = 0
        producto.Cantmininv = 0
        producto.Idproveedor = 0

 

        producto = Prod

        Modificar = False
    End Sub
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
        conex.cerrar()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        Dim Producto As New ProductosClass

        If Modificar = True Then

            producto.Id = TextId.Text
            producto.Producto = TextProducto.Text
            producto.Descripcion = TextDescripcion.Text
            producto.Cantidad = TextCantidad.Text
            producto.Preciounitcompra = TextPrecioCompra.Text
            producto.Preciounitventa = TextPrecioVenta.Text
            producto.Preciounitmay = TextPrecioxmayor.Text
            producto.Iva = TextIva.Text
            producto.Cantmininv = TextCantMinInv.Text



            Producto.Modificar(Producto)
        Else
            MsgBox("todavia no se pudo agregar !!!")


        End If

        Close()


    End Sub
End Class
