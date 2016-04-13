Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class listaProdutos
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentProd As Integer
    Dim adding As Boolean

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        currentProd = ListBox1.SelectedIndex
        If currentProd <= 0 Then
            MsgBox("Por favor, selecione um produto para editar")
            Exit Sub
        End If
        adding = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub removeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles removeButton.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Seleccione um produto para remover!")
        End If
        If ListBox1.SelectedIndex > -1 Then
            Try
                CMD.CommandText = "DELETE FROM cafe.Cliente WHERE ID=@ProdID"
                CMD.Parameters.Clear()
                CN.Open()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
                CN.Close()
            End Try

            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If currentProd = ListBox1.Items.Count Then currentProd = ListBox1.Items.Count - 1
            If currentProd = -1 Then
                ClearFields()
                MsgBox("Não existem mais fornecedores!!!")
            Else
                ShowProd()
            End If
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Try
            SaveProduto()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(IDBox.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles cancelarButton.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentProd = ListBox1.SelectedIndex
            If currentProd < 0 Then currentProd = 0
            ShowProd()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Sub ClearFields()
        IDBox.Text = 0
        nomeProdBox.Text = ""
        familiaProdBox.Text = ""
        precoProdBox.Text = 0.0
        numFuncProdBox.Text = 0
        numEncProdBox.Text = 0
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
        IDBox.ReadOnly = False
        nomeProdBox.ReadOnly = False
        familiaProdBox.ReadOnly = False
        precoProdBox.ReadOnly = False
        numFuncProdBox.ReadOnly = False
        numEncProdBox.ReadOnly = False
    End Sub

    Sub LockControls()
        IDBox.ReadOnly = True
        nomeProdBox.ReadOnly = True
        familiaProdBox.ReadOnly = True
        precoProdBox.ReadOnly = True
        numFuncProdBox.ReadOnly = True
        numEncProdBox.ReadOnly = True
    End Sub
    Sub ShowButtons()
        LockControls()
        addButton.Visible = True
        editButton.Visible = True
        removeButton.Visible = True
        OKButton.Visible = False
        cancelarButton.Visible = False
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        '' Change this line...
        'CN = New SqlConnection("data source=tcp:193.136.175.33\\SQLSERVER2012,8293;initial catalog=p4g8; User ID=p4g8; Password=tomasgabriel")
        CN = AllConnections.ligacao()
        CMD = New SqlCommand
        CMD.Connection = CN
    End Sub
    Private Sub CarregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarregarToolStripMenuItem.Click
        CMD.CommandText = "SELECT * FROM  cafe.Produto"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New CafeProduto
            C.ProdID = RDR.Item("prodID")
            C.NomeProduto = RDR.Item("nomeProd")
            C.FamiliaProduto = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("familia")), "", RDR.Item("familia")))
            C.PrecoProduto = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("preco")), "", RDR.Item("preco")))
            C.ProdNumFunc = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("prod_numFunc")), "", RDR.Item("prod_numFunc")))
            C.ProdNumEnc = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("prod_nºencomenda")), "", RDR.Item("prod_nºencomenda")))

            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentProd = 0
        ShowProd()
    End Sub

    Private Sub SubmeterProduto(ByVal C As CafeProduto)
        'CMD.CommandText = "INSERT cafe.Produto (prodID, nomeProd, familia, preco, prod_numFunc, prod_nºencomenda)" & _
        '                  "VALUES (@ProdID, @NomeProduto, @FamiliaProduto, @PrecoProduto, @ProdNumFunc, @ProdNumEnc) "
        CMD.CommandText = "exec cafe.sp_InsertProdutos @ProdID, @NomeProduto, @FamiliaProduto, @PrecoProduto, @ProdNumFunc, @ProdNumEnc"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@ProdID", C.ProdID)
        CMD.Parameters.AddWithValue("@NomeProduto", C.NomeProduto)
        CMD.Parameters.AddWithValue("@FamiliaProduto", C.FamiliaProduto)
        CMD.Parameters.AddWithValue("@PrecoProduto", C.PrecoProduto)
        CMD.Parameters.AddWithValue("@ProdNumFunc", C.ProdNumFunc)
        CMD.Parameters.AddWithValue("@ProdNumEnc", C.ProdNumEnc)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update produto in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub UpdateProduto(ByVal C As CafeProduto)
        CMD.CommandText = "UPDATE cafe.Produto " & _
            "SET nomeProd = @NomeProduto, " & _
            "    familia = @FamiliaProduto, " & _
            "    preco = @PrecoProduto, " & _
            "    prod_numFunc = @ProdNumFunc, " & _
            "    prod_nºencomenda = @ProdNumEnc " & _
            "WHERE prodID = @ProdID"
        'CMD.CommandText = "exec cafe.sp_UpdateProdutos @ProdID, @NomeProduto, @PrecoProduto, @ProdNumFunc, @ProdNumEnc"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@ProdID", C.ProdID)
        CMD.Parameters.AddWithValue("@NomeProduto", C.NomeProduto)
        CMD.Parameters.AddWithValue("@FamiliaProduto", C.FamiliaProduto)
        CMD.Parameters.AddWithValue("@PrecoProduto", C.PrecoProduto)
        CMD.Parameters.AddWithValue("@ProdNumFunc", C.ProdNumFunc)
        CMD.Parameters.AddWithValue("@ProdNumEnc", C.ProdNumEnc)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update produto in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub
    Private Function SaveProduto() As Boolean
        Dim produto As New CafeProduto
        Try
            produto.ProdID = IDBox.Text
            produto.NomeProduto = nomeProdBox.Text
            produto.FamiliaProduto = familiaProdBox.Text
            produto.PrecoProduto = precoProdBox.Text
            produto.ProdNumFunc = numFuncProdBox.Text
            produto.ProdNumEnc = numEncProdBox.Text

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        If adding Then
            SubmeterProduto(produto)
            ListBox1.Items.Add(produto)
        Else
            UpdateProduto(produto)
            ListBox1.Items(currentProd) = produto
        End If
        Return True
    End Function
    Sub ShowProd()
        If ListBox1.Items.Count = 0 Or currentProd < 0 Then Exit Sub
        Dim produto As New CafeProduto
        produto = CType(ListBox1.Items.Item(currentProd), CafeProduto)
        IDBox.Text = produto.ProdID
        nomeProdBox.Text = produto.NomeProduto
        familiaProdBox.Text = produto.FamiliaProduto
        precoProdBox.Text = produto.PrecoProduto
        numFuncProdBox.Text = produto.ProdNumFunc
        numEncProdBox.Text = produto.ProdNumEnc

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentProd = ListBox1.SelectedIndex
            ShowProd()
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

    Private Sub encomendasButton_Click(sender As Object, e As EventArgs) Handles encomendasButton.Click
        Dim encomendasPage As New listaEncomendas
        encomendasPage.Show()
        Me.Hide()
    End Sub

    Private Sub comprasButton_Click(sender As Object, e As EventArgs) Handles comprasButton.Click
        Dim comprasPage As New listaCompras
        comprasPage.Show()
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

    Private Sub numFuncProdBox_TextChanged(sender As Object, e As EventArgs) Handles numFuncProdBox.TextChanged

    End Sub
End Class