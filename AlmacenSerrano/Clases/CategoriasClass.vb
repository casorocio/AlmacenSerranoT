Imports System.Data
Imports System.Data.SqlClient
Public Class CategoriasClass
    Inherits Conexion1
    Dim Id_ As Integer
    Dim Tipo_ As String

    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return Tipo_
        End Get
        Set(ByVal value As String)
            Tipo_ = value
        End Set
    End Property

End Class
