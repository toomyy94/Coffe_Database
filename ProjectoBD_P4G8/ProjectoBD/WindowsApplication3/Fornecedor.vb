Public Class CafeFornecedor
    Private _nomeForn As String
    Private _CC_Forn As Integer
    Private _codigo_interno As String
    Private _moradaForn As String
    Private _telefoneForn As Integer
    Private _fax As Integer
    Private _forma_pag As String


    Property NomeFornecedor() As String
        Get
            NomeFornecedor = _nomeForn
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("O nome não pode ser nulo")
                Exit Property
            End If
            _nomeForn = value
        End Set
    End Property


    Property CCFornecedor() As Integer
        Get
            CCFornecedor = _CC_Forn
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                Throw New Exception("Fornecedor tem de ter um CC!")
                Exit Property
            End If
            _CC_Forn = value
        End Set
    End Property

    Property CodigoInt() As String
        Get
            CodigoInt = _codigo_interno
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("Cliente tem de ter um NIF!")
                Exit Property
            End If
            _codigo_interno = value
        End Set
    End Property

    Property MoradaFornecedor() As String
        Get
            MoradaFornecedor = _moradaForn
        End Get
        Set(ByVal value As String)
            _moradaForn = value
        End Set
    End Property

    Property TelefoneFornecedor() As Integer
        Get
            TelefoneFornecedor = _telefoneForn
        End Get
        Set(ByVal value As Integer)
            _telefoneForn = value
        End Set
    End Property

    Property FaxFornecedor() As Integer
        Get
            FaxFornecedor = _fax
        End Get

        Set(ByVal value As Integer)
            _fax = value
        End Set
    End Property

    Property Pag_Fornecedor() As String
        Get
            Pag_Fornecedor = _forma_pag
        End Get
        Set(ByVal value As String)
            _forma_pag = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _nomeForn & "              " & _CC_Forn
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal NomeFornecedor As String, ByVal CCFornecedor As Integer)
        MyBase.New()
        Me.NomeFornecedor = _nomeForn & " "
        Me.CCFornecedor = _CC_Forn
    End Sub

    Public Sub New(ByVal nomeForn As String)
        MyBase.New()
        Me.NomeFornecedor = NomeFornecedor
    End Sub
End Class
