Public Class CafeCompras
    Private _nºcompra As Integer
    Private _forma_pagamento As String
    Private _data_compra As Date
    Private _nome_prod As String
    Private _compras_numFunc As Integer
    Private _compras_nifCli As Integer

    Property NumCompra() As Integer
        Get
            NumCompra = _nºcompra
        End Get

        Set(value As Integer)
            If value = 0 Then
                Throw New Exception("O nº de compra não pode ser 0")
                Exit Property
            End If
            _nºcompra = value
        End Set
    End Property

    Property FormaPagCompra() As String
        Get
            FormaPagCompra = _forma_pagamento
        End Get
        Set(ByVal value As String)
            _forma_pagamento = value
        End Set
    End Property
    Property DataCompra() As Date
        Get
            DataCompra = _data_compra
        End Get
        Set(ByVal value As Date)
            If Not IsDate(value) Then
                MsgBox("Digite a data de compra corretamente! (mm/dd/aaaa)")
            End If
            _data_compra = value
        End Set
    End Property


    Property NomeProdCompra() As String
        Get
            NomeProdCompra = _nome_prod
        End Get

        Set(ByVal value As String)
            _nome_prod = value
        End Set
    End Property

    Property NumFuncCompra() As Integer
        Get
            NumFuncCompra = _compras_numFunc
        End Get
        Set(ByVal value As Integer)
            _compras_numFunc = value
        End Set
    End Property

    Property NIFCompras() As Integer
        Get
            NIFCompras = _compras_nifCli
        End Get
        Set(ByVal value As Integer)
            _compras_nifCli = value
        End Set
    End Property

    Overrides Function ToString() As String
        Return _nºcompra & "   " & _nome_prod
    End Function

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal NumCompra As Integer, ByVal NomeProdCompra As String)
        MyBase.New()
        Me.NumCompra = _nºcompra & " "
        Me.NomeProdCompra = _nome_prod
    End Sub

    Public Sub New(ByVal nºcompra As Integer)
        MyBase.New()
        Me.NumCompra = NumCompra
    End Sub
End Class
