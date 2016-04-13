Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class listaEncomendas
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentEnc As Integer
    Dim adding As Boolean

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        currentEnc = ListBox1.SelectedIndex
        If currentEnc <= 0 Then
            MsgBox("Por favor, selecione uma encomenda para editar")
            Exit Sub
        End If
        adding = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub removeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles removeButton.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Seleccione uma encomenda para remover!")
        End If
        If ListBox1.SelectedIndex > -1 Then
            Try
                CMD.CommandText = "DELETE FROM cafe.Encomenda WHERE nºencomenda=@NumEnc"
                CMD.Parameters.Clear()
                CN.Open()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
                CN.Close()
            End Try
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If currentEnc = ListBox1.Items.Count Then currentEnc = ListBox1.Items.Count - 1
            If currentEnc = -1 Then
                ClearFields()
                MsgBox("Não existem mais fornecedores!!!")
            Else
                ShowEnc()
            End If
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Try
            SaveEncomenda()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(numeroEncBox.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles cancelarButton.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentEnc = ListBox1.SelectedIndex
            If currentEnc < 0 Then currentEnc = 0
            ShowEnc()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Sub ClearFields()
        numeroEncBox.Text = 0
        dataEncBox.Text = String.Empty
        quantidadeBox.Text = 0
        codigoBox.Text = ""
        funcResBox.Text = 0
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
        numeroEncBox.ReadOnly = False
        dataEncBox.ReadOnly = False
        quantidadeBox.ReadOnly = False
        codigoBox.ReadOnly = False
        funcResBox.ReadOnly = False
    End Sub

    Sub LockControls()
        numeroEncBox.ReadOnly = True
        dataEncBox.ReadOnly = True
        quantidadeBox.ReadOnly = True
        codigoBox.ReadOnly = True
        funcResBox.ReadOnly = True
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
        CMD.CommandText = "SELECT * FROM  cafe.Encomenda"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New CafeEncomenda
            C.NumEnc = RDR.Item("nºencomenda")
            C.DataEnc = RDR.Item("data_realizacao")
            C.QuantidadeEnc = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("quantidade")), "", RDR.Item("quantidade")))
            C.CodigoIntEnc = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Enc_cod_int")), "", RDR.Item("Enc_cod_int")))
            C.NumFuncEnc = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("Enc_numFunc")), "", RDR.Item("Enc_numFunc")))

            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentEnc = 0
        ShowEnc()
    End Sub

    Private Sub SubmeterEncomenda(ByVal C As CafeEncomenda)
        'CMD.CommandText = "INSERT cafe.Encomenda (nºencomenda, data_realizacao, quantidade, Enc_cod_int, Enc_numFunc)" & _
        '                  "VALUES (@NumEnc, @DataEnc, @QuantidadeEnc, @CodigoIntEnc, @NumFuncEnc) "
        CMD.CommandText = "exec cafe.sp_InsertEncomendas @NumEnc, @DataEnc, @QuantidadeEnc, @CodigoIntEnc, @NumFuncEnc"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NumEnc", C.NumEnc)
        CMD.Parameters.AddWithValue("@DataEnc", C.DataEnc)
        CMD.Parameters.AddWithValue("@QuantidadeEnc", C.QuantidadeEnc)
        CMD.Parameters.AddWithValue("@CodigoIntEnc", C.CodigoIntEnc)
        CMD.Parameters.AddWithValue("@NumFuncEnc", C.NumFuncEnc)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update encomenda in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub UpdateEncomenda(ByVal C As CafeEncomenda)
        'CMD.CommandText = "UPDATE cafe.Encomenda " & _
        '    "SET data_realizacao = @DataEnc, " & _
        '    "    quantidade = @QuantidadeEnc, " & _
        '    "    Enc_cod_int = @CodigoIntEnc, " & _
        '    "    Enc_numFunc = @NumFuncEnc " & _
        '    "WHERE nºencomenda = @NumEnc"
        CMD.CommandText = "exec cafe.sp_UpdateEncomendas @NumEnc, @DataEnc, @QuantidadeEnc, @CodigoIntEnc, @NumFuncEnc"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NumEnc", C.NumEnc)
        CMD.Parameters.AddWithValue("@DataEnc", C.DataEnc)
        CMD.Parameters.AddWithValue("@QuantidadeEnc", C.QuantidadeEnc)
        CMD.Parameters.AddWithValue("@CodigoIntEnc", C.CodigoIntEnc)
        CMD.Parameters.AddWithValue("@NumFuncEnc", C.NumFuncEnc)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update encomenda in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub
    Private Function SaveEncomenda() As Boolean
        Dim encomenda As New CafeEncomenda
        Try
            encomenda.NumEnc = numeroEncBox.Text
            encomenda.DataEnc = dataEncBox.Text
            encomenda.QuantidadeEnc = quantidadeBox.Text
            encomenda.CodigoIntEnc = codigoBox.Text
            encomenda.NumFuncEnc = funcResBox.Text

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        If adding Then
            SubmeterEncomenda(encomenda)
            ListBox1.Items.Add(encomenda)
        Else
            UpdateEncomenda(encomenda)
            ListBox1.Items(currentEnc) = encomenda
        End If
        Return True
    End Function
    Sub ShowEnc()
        If ListBox1.Items.Count = 0 Or currentEnc < 0 Then Exit Sub
        Dim encomenda As New CafeEncomenda
        encomenda = CType(ListBox1.Items.Item(currentEnc), CafeEncomenda)
        numeroEncBox.Text = encomenda.NumEnc
        dataEncBox.Text = encomenda.DataEnc
        quantidadeBox.Text = encomenda.QuantidadeEnc
        codigoBox.Text = encomenda.CodigoIntEnc
        funcResBox.Text = encomenda.NumFuncEnc

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentEnc = ListBox1.SelectedIndex
            ShowEnc()
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

    Private Sub comprasButton_Click(sender As Object, e As EventArgs) Handles comprasButton.Click
        Dim comprasPage As New listaCompras
        comprasPage.Show()
        Me.Hide()
    End Sub

    Private Sub reclamacoesButton_Click(sender As Object, e As EventArgs) Handles reclamacoesButton.Click
        Dim reclamacoesPage As New listaReclamacoes
        reclamacoesPage.Show()
        Me.Hide()
    End Sub

    Private Sub turnosButton_Click(sender As Object, e As EventArgs) Handles turnosButton.Click
        Dim turnosPage As New listaTurnos
        turnosPage.Show()
        Me.Hide()
    End Sub
End Class