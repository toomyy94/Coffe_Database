Public Class CafeProduto
    Private _prodID As Integer
    Private _nomeProd As String
    Private _familia As String
    Private _preco As Decimal
    Private _prod_numFunc As Integer
    Private _prod_nºencomenda As Integer

    Property ProdID() As Integer
        Get
            ProdID = _prodID
        End Get

        Set(value As Integer)
            If value = 0 Then
                Throw New Exception("ID do produto não pode ser 0")
                Exit Property
            End If
            _prodID = value
        End Set
    End Property
    Property NomeProduto() As String
        Get
            NomeProduto = _nomeProd
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("O nome não pode ser nulo")
                Exit Property
            End If
            _nomeProd = value
        End Set
    End Property


    Property FamiliaProduto() As String
        Get
            FamiliaProduto = _familia
        End Get

        Set(ByVal value As String)
            _familia = value
        End Set
    End Property

    Property PrecoProduto() As Decimal
        Get
            PrecoProduto = _preco
        End Get
        Set(ByVal value As Decimal)
            _preco = value
        End Set
    End Property

    Property ProdNumFunc() As Integer
        Get
            ProdNumFunc = _prod_numFunc
        End Get
        Set(ByVal value As Integer)
            _prod_numFunc = value
        End Set
    End Property

    Property ProdNumEnc() As Integer
        Get
            ProdNumEnc = _prod_nºencomenda
        End Get
        Set(ByVal value As Integer)
            _prod_nºencomenda = value
        End Set
    End Property


    Overrides Function ToString() As String
        Return _nomeProd & "   " & _prodID
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal NomeProduto As String, ByVal ProdID As Integer)
        MyBase.New()
        Me.NomeProduto = _nomeProd & " "
        Me.ProdID = _prodID
    End Sub

    Public Sub New(ByVal nomeProd As String)
        MyBase.New()
        Me.NomeProduto = NomeProduto
    End Sub
End Class
