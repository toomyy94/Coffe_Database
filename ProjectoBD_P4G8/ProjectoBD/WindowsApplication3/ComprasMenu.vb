Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class listaCompras
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentComp As Integer
    Dim adding As Boolean
    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        currentComp = ListBox1.SelectedIndex
        If currentComp <= 0 Then
            MsgBox("Por favor, selecione uma encomenda para editar")
            Exit Sub
        End If
        adding = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub removeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles removeButton.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Seleccione uma compra para remover!")
        End If
        If ListBox1.SelectedIndex > -1 Then
            Try
                CMD.CommandText = "DELETE FROM cafe.Cliente WHERE nºcompra=@NumCompra"
                CMD.Parameters.Clear()
                CN.Open()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
                CN.Close()
            End Try
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If currentComp = ListBox1.Items.Count Then currentComp = ListBox1.Items.Count - 1
            If currentComp = -1 Then
                ClearFields()
                MsgBox("Não existem mais compras!!!")
            Else
                ShowCompra()
            End If
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Try
            SaveCompra()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(numCompraBox.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles cancelarButton.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentComp = ListBox1.SelectedIndex
            If currentComp < 0 Then currentComp = 0
            ShowCompra()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Sub ClearFields()
        numCompraBox.Text = 0
        formaPagBox.Text = ""
        dataCompraBox.Text = String.Empty
        nomeComprasBox.Text = ""
        funcComprasBox.Text = 0
        NIFComprasBox.Text = 0
    End Sub

    Private Sub HideButtons()
        UnlockControls()
        addButton.Visible = False
        editButton.Visible = False
        removeButton.Visible = False
        OKButton.Visible = True
        cancelarButton.Visible = True
    End Sub

    Sub UnlockControls()
        numCompraBox.ReadOnly = False
        formaPagBox.ReadOnly = False
        dataCompraBox.ReadOnly = False
        nomeComprasBox.ReadOnly = False
        funcComprasBox.ReadOnly = False
        NIFComprasBox.ReadOnly = False
    End Sub

    Sub LockControls()
        numCompraBox.ReadOnly = True
        formaPagBox.ReadOnly = True
        dataCompraBox.ReadOnly = True
        nomeComprasBox.ReadOnly = True
        funcComprasBox.ReadOnly = True
        NIFComprasBox.ReadOnly = True
    End Sub
    Sub ShowButtons()
        LockControls()
        addButton.Visible = True
        editButton.Visible = True
        removeButton.Visible = True
        OKButton.Visible = False
        cancelarButton.Visible = False
    End Sub

    'Dim myConnection As SqlConnection
    'get
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        '' Change this line...
        'CN = New SqlConnection("data source=tcp:193.136.175.33\\SQLSERVER2012,8293;initial catalog=p4g8; User ID=p4g8; Password=tomasgabriel")
        CN = AllConnections.ligacao()
        CMD = New SqlCommand
        CMD.Connection = CN
    End Sub
    Private Sub CarregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarregarToolStripMenuItem.Click
        CMD.CommandText = "SELECT * FROM  cafe.Compras"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New CafeCompras
            C.NumCompra = RDR.Item("nºcompra")
            C.FormaPagCompra = RDR.Item("forma_pagamento")
            C.DataCompra = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("data_compra")), "", RDR.Item("data_compra")))
            C.NomeProdCompra = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("nome_prod")), "", RDR.Item("nome_prod")))
            C.NumFuncCompra = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("compras_numFunc")), "", RDR.Item("compras_numFunc")))
            C.NIFCompras = IIf(RDR.IsDBNull(RDR.GetOrdinal("compras_nifCli")), 0, RDR.Item("compras_nifCli"))

            ListBox1.Items.Add(C)

            ListBox1.Sorted = True
        End While
        CN.Close()
        currentComp = 0
        ShowCompra()
    End Sub

    Private Sub SubmeterCompra(ByVal C As CafeCompras)
        'CMD.CommandText = "INSERT cafe.Compras (nºcompra, forma_pagamento, data_compra, nome_prod, compras_numFunc, compras_nifCli)" & _
        '                  "VALUES (@NumCompra, @FormaPagCompra, @DataCompra, @NomeProdCompra, @NumFuncCompra, @NIFCompras) "
        CMD.CommandText = "exec cafe.sp_InsertCompras @NumCompra, @FormaPagCompra, @DataCompra, @NomeProdCompra, @NumFuncCompra, @NIFCompras"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NumCompra", C.NumCompra)
        CMD.Parameters.AddWithValue("@FormaPagCompra", C.FormaPagCompra)
        CMD.Parameters.AddWithValue("@DataCompra", C.DataCompra)
        CMD.Parameters.AddWithValue("@NomeProdCompra", C.NomeProdCompra)
        CMD.Parameters.AddWithValue("@NumFuncCompra", C.NumFuncCompra)
        CMD.Parameters.AddWithValue("@NIFCompras", C.NIFCompras)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update compras in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub UpdateCompra(ByVal C As CafeCompras)
        'CMD.CommandText = "UPDATE cafe.Encomenda " & _
        '    "SET forma_pagamento = @FormaPagCompra, " & _
        '    "    data_compra = @DataCompra, " & _
        '    "    nome_prod = @NomeProdCompra, " & _
        '    "    compras_numFunc = @NumFuncCompra, " & _
        '    "    compras_nifCli = @NIFCompras " & _
        '    "WHERE nºcompra = @NumCompra"
        CMD.CommandText = "exec cafe.sp_UpdateCompras @NumCompra, @FormaPagCompra, @DataCompra, @NomeProdCompra, @NumFuncCompra, @NIFCompras"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NumCompra", C.NumCompra)
        CMD.Parameters.AddWithValue("@FormaPagCompra", C.FormaPagCompra)
        CMD.Parameters.AddWithValue("@DataCompra", C.DataCompra)
        CMD.Parameters.AddWithValue("@NomeProdCompra", C.NomeProdCompra)
        CMD.Parameters.AddWithValue("@NumFuncCompra", C.NumFuncCompra)
        CMD.Parameters.AddWithValue("@NIFCompras", C.NIFCompras)


        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update compras in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub
    Private Function SaveCompra() As Boolean
        Dim compras As New CafeCompras
        Try
            compras.NumCompra = numCompraBox.Text
            compras.FormaPagCompra = formaPagBox.Text
            compras.DataCompra = dataCompraBox.Text
            compras.NomeProdCompra = nomeComprasBox.Text
            compras.NumFuncCompra = funcComprasBox.Text
            compras.NIFCompras = NIFComprasBox.Text

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        If adding Then
            SubmeterCompra(compras)
            ListBox1.Items.Add(compras)
        Else
            UpdateCompra(compras)
            ListBox1.Items(currentComp) = compras
        End If
        Return True
    End Function
    Sub ShowCompra()
        If ListBox1.Items.Count = 0 Or currentComp < 0 Then Exit Sub
        Dim compras As New CafeCompras
        compras = CType(ListBox1.Items.Item(currentComp), CafeCompras)
        numCompraBox.Text = compras.NumCompra
        formaPagBox.Text = compras.FormaPagCompra
        dataCompraBox.Text = compras.DataCompra
        nomeComprasBox.Text = compras.NomeProdCompra
        funcComprasBox.Text = compras.NumFuncCompra
        NIFComprasBox.Text = compras.NIFCompras

    End Sub

    
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentComp = ListBox1.SelectedIndex
            ShowCompra()
        End If
    End Sub
    Private Sub funcionarioButton_Click(sender As Object, e As EventArgs) Handles funcionarioButton.Click
        Dim funcionariosPage As New listaFuncionarios
        funcionariosPage.Show()
        Me.Hide()
    End Sub

    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        Dim mainMenu As New MainMenu
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub clienteButton_Click(sender As Object, e As EventArgs) Handles clienteButton.Click
        Dim clientesPage As New listaClientes
        clientesPage.Show()
        Me.Hide()
    End Sub

    Private Sub fornecedorButton_Click(sender As Object, e As EventArgs) Handles fornecedorButton.Click
        Dim fornecedoresPage As New listaFornecedores
        fornecedoresPage.Show()
        Me.Hide()
    End Sub

    Private Sub produtosButton_Click(sender As Object, e As EventArgs) Handles produtosButton.Click
        Dim produtospage As New listaProdutos
        produtospage.Show()
        Me.Hide()
    End Sub

    Private Sub encomendasButton_Click(sender As Object, e As EventArgs) Handles encomendasButton.Click
        Dim encomendasPage As New listaEncomendas
        encomendasPage.Show()
        Me.Hide()
    End Sub

    Private Sub turnosButton_Click(sender As Object, e As EventArgs) Handles turnosButton.Click
        Dim turnosPage As New listaTurnos
        turnosPage.Show()
        Me.Hide()
    End Sub

    Private Sub reclamacoesButton_Click(sender As Object, e As EventArgs) Handles reclamacoesButton.Click
        Dim reclamacoesPage As New listaReclamacoes
        reclamacoesPage.Show()
        Me.Hide()
    End Sub
End Class