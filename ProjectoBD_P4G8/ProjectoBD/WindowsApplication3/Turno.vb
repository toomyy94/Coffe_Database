Public Class CafeTurno
    Private _turno As String
    Private _numeroHoras As Integer


    Property Turno() As String
        Get
            Turno = _turno
        End Get

        Set(value As String)
            If value = "" Or value Is Nothing Then
                Throw New Exception("Digite um turno")
                Exit Property
            End If
            _turno = value
        End Set
    End Property
    Property NumeroHoras() As String
        Get
            NumeroHoras = _numeroHoras
        End Get
        Set(ByVal value As String)
            _numeroHoras = value
        End Set
    End Property


    Overrides Function ToString() As String
        Return _turno & "   " & _numeroHoras
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal Turno As String, ByVal NumeroHoras As Integer)
        MyBase.New()
        Me.Turno = _turno & " "
        Me.NumeroHoras = _numeroHoras
    End Sub

    Public Sub New(ByVal turno As String)
        MyBase.New()
        Me.Turno = turno
    End Sub
End Class
