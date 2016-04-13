<Serializable()> Public Class CafeCliente
    Private _nomeCli As String
    Private _CC_Cliente As Integer
    Private _NIF As Integer
    Private _moradaCli As String
    Private _telefoneCli As Integer


    Property NomeCliente() As String
        Get
            NomeCliente = _nomeCli
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("O nome não pode ser nulo")
                Exit Property
            End If
            _nomeCli = value
        End Set
    End Property


    Property CCCliente() As Integer
        Get
            CCCliente = _CC_Cliente
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                Throw New Exception("Cliente tem de ter um CC!")
                Exit Property
            End If
            _CC_Cliente = value
        End Set
    End Property

    Property NIFCliente() As Integer
        Get
            NIFCliente = _NIF
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                Throw New Exception("Cliente tem de ter um NIF!")
                Exit Property
            End If
            _NIF = value
        End Set
    End Property

    Property MoradaCliente() As String
        Get
            MoradaCliente = _moradaCli
        End Get
        Set(ByVal value As String)
            _moradaCli = value
        End Set
    End Property

    Property TelefoneCliente() As Integer
        Get
            TelefoneCliente = _telefoneCli
        End Get
        Set(ByVal value As Integer)
            _telefoneCli = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _nomeCli & "              " & _CC_Cliente
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal NomeCliente As String, ByVal CCCliente As Integer)
        MyBase.New()
        Me.NomeCliente = _nomeCli & " "
        Me.CCCliente = _CC_Cliente
    End Sub

    Public Sub New(ByVal nomeCli As String)
        MyBase.New()
        Me.NomeCliente = NomeCliente
    End Sub
End Class