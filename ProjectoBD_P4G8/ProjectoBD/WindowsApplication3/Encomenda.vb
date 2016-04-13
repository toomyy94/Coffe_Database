Public Class CafeEncomenda
    Private _nºencomenda As Integer
    Private _data_realizacao As Date
    Private _quantidade As Integer
    Private _Enc_cod_int As String
    Private _enc_numFunc As Integer

    Property NumEnc() As Integer
        Get
            NumEnc = _nºencomenda
        End Get

        Set(value As Integer)
            If value = 0 Then
                Throw New Exception("O nº de encomenda não pode ser 0")
                Exit Property
            End If
            _nºencomenda = value
        End Set
    End Property
    Property DataEnc() As Date
        Get
            DataEnc = _data_realizacao
        End Get
        Set(ByVal value As Date)
            If Not IsDate(value) Then
                MsgBox("Digite a data de realização corretamente! (mm/dd/aaaa)")
            End If
            _data_realizacao = value
        End Set
    End Property


    Property QuantidadeEnc() As Integer
        Get
            QuantidadeEnc = _quantidade
        End Get

        Set(ByVal value As Integer)
            _quantidade = value
        End Set
    End Property

    Property CodigoIntEnc() As String
        Get
            CodigoIntEnc = _Enc_cod_int
        End Get
        Set(ByVal value As String)
            _Enc_cod_int = value
        End Set
    End Property

    Property NumFuncEnc() As Integer
        Get
            NumFuncEnc = _enc_numFunc
        End Get
        Set(ByVal value As Integer)
            _enc_numFunc = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _nºencomenda & "   " & _data_realizacao
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal NumEnc As Integer, ByVal DataEnc As Date)
        MyBase.New()
        Me.NumEnc = _nºencomenda & " "
        Me.DataEnc = _data_realizacao
    End Sub

    Public Sub New(ByVal nºencomenda As Integer)
        MyBase.New()
        Me.NumEnc = NumEnc
    End Sub
End Class
