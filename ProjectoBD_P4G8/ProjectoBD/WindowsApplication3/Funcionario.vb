<Serializable()> Public Class CafeFuncionario
    Private _nomeFunc As String
    Private _CCFunc As Integer
    Private _numFunc As Integer
    Private _moradaFunc As String
    Private _telefoneFunc As Integer
    Private _salario As Decimal
    Private _SuperFunc As Integer
    Private _turnoFunc As String


    Property NomeFuncionario() As String
        Get
            NomeFuncionario = _nomeFunc
        End Get
        Set(ByVal value As String)
            If value Is Nothing Or value = "" Then
                Throw New Exception("O nome não pode ser nulo")
                Exit Property
            End If
            _nomeFunc = value
        End Set
    End Property


    Property CCFuncionario() As Integer
        Get
            CCFuncionario = _CCFunc
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                Throw New Exception("Funcionário tem de ter um CC")
                Exit Property
            End If
            _CCFunc = value
        End Set
    End Property

    Property NumFuncionario() As Integer
        Get
            NumFuncionario = _numFunc
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                Throw New Exception("Funcionário tem de ter um número")
                Exit Property
            End If
            _numFunc = value
        End Set
    End Property

    Property MoradaFuncionario() As String
        Get
            MoradaFuncionario = _moradaFunc
        End Get
        Set(ByVal value As String)
            _moradaFunc = value
        End Set
    End Property

    Property TelefoneFuncionario() As Integer
        Get
            TelefoneFuncionario = _telefoneFunc
        End Get
        Set(ByVal value As Integer)
            _telefoneFunc = value
        End Set
    End Property

    Property SalarioFuncionario() As Decimal
        Get
            SalarioFuncionario = _salario
        End Get
        Set(ByVal value As Decimal)
            If value = 0 Then
                Throw New Exception("Salário tem de ser maior que 0 €")
                Exit Property
            End If
            _salario = value
        End Set
    End Property

    Property SuperVisionaFuncionario() As Integer
        Get
            SuperVisionaFuncionario = _SuperFunc
        End Get
        Set(ByVal value As Integer)
            If value = 0 Then
                _SuperFunc = 0
            End If
            _SuperFunc = value
        End Set
    End Property


    Property TurnoFuncionario() As String
        Get
            TurnoFuncionario = _turnoFunc
        End Get
        Set(ByVal value As String)
            _turnoFunc = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _nomeFunc & "   " & _CCFunc
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal NomeFuncionario As String, ByVal CCFuncionario As Integer)
        MyBase.New()
        Me.NomeFuncionario = _nomeFunc & " "
        Me.CCFuncionario = _CCFunc
    End Sub

    Public Sub New(ByVal nomeFunc As String)
        MyBase.New()
        Me.NomeFuncionario = NomeFuncionario
    End Sub
End Class