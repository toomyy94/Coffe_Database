Public Class CafeReclamacao
    Private _numreclamacao As Integer
    Private _motivo As String
    Private _reclam_nifCli As Integer

    Property NumRecla() As Integer
        Get
            NumRecla = _numreclamacao
        End Get

        Set(value As Integer)
            If value = 0 Then
                Throw New Exception("O nº de reclamação não pode ser 0")
                Exit Property
            End If
            _numreclamacao = value
        End Set
    End Property
    Property MotivoRecla() As String
        Get
            MotivoRecla = _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
        End Set
    End Property


    Property NIFRecla() As Integer
        Get
            NIFRecla = _reclam_nifCli
        End Get
        Set(ByVal value As Integer)
            _reclam_nifCli = value
        End Set
    End Property



    Overrides Function ToString() As String
        Return _numreclamacao & "   " & _motivo
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal NumRecla As Integer, ByVal MotivoRecla As String)
        MyBase.New()
        Me.NumRecla = _numreclamacao & " "
        Me.MotivoRecla = _motivo
    End Sub

    Public Sub New(ByVal numreclamacao As Integer)
        MyBase.New()
        Me.NumRecla = NumRecla
    End Sub
End Class
