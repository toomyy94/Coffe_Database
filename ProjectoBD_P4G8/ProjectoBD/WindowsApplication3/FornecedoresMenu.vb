Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary


Public Class listaFornecedores
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentForn As Integer
    Dim adding As Boolean
    Private Sub CCFornecedorBox_TextChanged(sender As Object, e As EventArgs) Handles CCFornecedorBox.TextChanged

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        currentForn = ListBox1.SelectedIndex
        If currentForn <= 0 Then
            MsgBox("Por favor, selecione um fornecedor para editar")
            Exit Sub
        End If
        adding = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub removeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles removeButton.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Seleccione um fornecedor para remover!")
        End If
        If ListBox1.SelectedIndex > -1 Then
            Try
                CMD.CommandText = "DELETE FROM cafe.Fornecedor WHERE CC_Forn=@CCFornecedor"
                CMD.Parameters.Clear()
                CN.Open()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
                CN.Close()
            End Try

            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If currentForn = ListBox1.Items.Count Then currentForn = ListBox1.Items.Count - 1
            If currentForn = -1 Then
                ClearFields()
                MsgBox("Não existem mais fornecedores!!!")
            Else
                ShowForn()
            End If
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Try
            SaveFornecedor()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(codigoFornBox.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles cancelarButton.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentForn = ListBox1.SelectedIndex
            If currentForn < 0 Then currentForn = 0
            ShowForn()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Sub ClearFields()
        NomeFornBox.Text = ""
        CCFornecedorBox.Text = 0
        codigoFornBox.Text = 0
        MoradaFornBox.Text = ""
        TelefoneFornBox.Text = 0
        FaxFornBox.Text = 0
        PagFornBox.Text = ""
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
        NomeFornBox.ReadOnly = False
        CCFornecedorBox.ReadOnly = False
        codigoFornBox.ReadOnly = False
        MoradaFornBox.ReadOnly = False
        TelefoneFornBox.ReadOnly = False
        FaxFornBox.ReadOnly = False
        PagFornBox.ReadOnly = False
    End Sub

    Sub LockControls()
        NomeFornBox.ReadOnly = True
        CCFornecedorBox.ReadOnly = True
        codigoFornBox.ReadOnly = True
        MoradaFornBox.ReadOnly = True
        TelefoneFornBox.ReadOnly = True
        FaxFornBox.ReadOnly = True
        PagFornBox.ReadOnly = True
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
        CMD.CommandText = "SELECT * FROM  cafe.Fornecedor"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New CafeFornecedor
            C.NomeFornecedor = RDR.Item("nomeForn")
            C.CCFornecedor = RDR.Item("CC_Forn")
            C.CodigoInt = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("codigo_interno")), "", RDR.Item("codigo_interno")))
            C.MoradaFornecedor = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("moradaForn")), "", RDR.Item("moradaForn")))
            C.TelefoneFornecedor = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("telefoneForn")), "", RDR.Item("telefoneForn")))
            C.FaxFornecedor = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("fax")), "", RDR.Item("fax")))
            C.Pag_Fornecedor = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("forma_pag")), "", RDR.Item("forma_pag")))

            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentForn = 0
        ShowForn()
    End Sub

    Private Sub SubmeterFornecedor(ByVal C As CafeFornecedor)
        'CMD.CommandText = "INSERT cafe.Fornecedor (nomeForn, CC_Forn, codigo_interno, moradaForn, telefoneForn, fax, forma_pag)" & _
        '                  "VALUES (@NomeFornecedor, @CCFornecedor, @CodigoInt, @MoradaFornecedor, @TelefoneFornecedor, @FaxFornecedor, @Pag_Fornecedor) "
        CMD.CommandText = "exec cafe.sp_InsertForn @NomeFornecedor, @CCFornecedor, @CodigoInt, @MoradaFornecedor, @TelefoneFornecedor," & _
                            "@FaxFornecedor, @Pag_Fornecedor"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NomeFornecedor", C.NomeFornecedor)
        CMD.Parameters.AddWithValue("@CCFornecedor", C.CCFornecedor)
        CMD.Parameters.AddWithValue("@CodigoInt", C.CodigoInt)
        CMD.Parameters.AddWithValue("@MoradaFornecedor", C.MoradaFornecedor)
        CMD.Parameters.AddWithValue("@TelefoneFornecedor", C.TelefoneFornecedor)
        CMD.Parameters.AddWithValue("@FaxFornecedor", C.FaxFornecedor)
        CMD.Parameters.AddWithValue("@Pag_Fornecedor", C.Pag_Fornecedor)


        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update fornecedor in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub UpdateFornecedor(ByVal C As CafeFornecedor)
        'CMD.CommandText = "UPDATE cafe.Fornecedor " & _
        '    "SET nomeForn = @NomeFornecedor, " & _
        '    "    CC_Forn = @CCFornecedor, " & _
        '    "    moradaForn = @MoradaFornecedor, " & _
        '    "    telefoneForn = @TelefoneFornecedor, " & _
        '    "    fax = @FaxFornecedor, " & _
        '    "    forma_pag = @Pag_Fornecedor " & _
        '    "WHERE codigo_interno = @CodigoInt"
        CMD.CommandText = "exec cafe.sp_UpdateFornecedor @NomeFornecedor, @CCFornecedor, @CodigoInt, @MoradaFornecedor, " & _
                            "@TelefoneFornecedor, @FaxFornecedor, @Pag_Fornecedor"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NomeFornecedor", C.NomeFornecedor)
        CMD.Parameters.AddWithValue("@CCFornecedor", C.CCFornecedor)
        CMD.Parameters.AddWithValue("@CodigoInt", C.CodigoInt)
        CMD.Parameters.AddWithValue("@MoradaFornecedor", C.MoradaFornecedor)
        CMD.Parameters.AddWithValue("@TelefoneFornecedor", C.TelefoneFornecedor)
        CMD.Parameters.AddWithValue("@FaxFornecedor", C.FaxFornecedor)
        CMD.Parameters.AddWithValue("@Pag_Fornecedor", C.Pag_Fornecedor)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update fornecedor in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub
    Private Function SaveFornecedor() As Boolean
        Dim fornecedor As New CafeFornecedor
        Try
            fornecedor.NomeFornecedor = NomeFornBox.Text
            fornecedor.CCFornecedor = CCFornecedorBox.Text
            fornecedor.CodigoInt = codigoFornBox.Text
            fornecedor.MoradaFornecedor = MoradaFornBox.Text
            fornecedor.TelefoneFornecedor = TelefoneFornBox.Text
            fornecedor.FaxFornecedor = FaxFornBox.Text
            fornecedor.Pag_Fornecedor = PagFornBox.Text

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        If adding Then
            SubmeterFornecedor(fornecedor)
            ListBox1.Items.Add(fornecedor)
        Else
            UpdateFornecedor(fornecedor)
            ListBox1.Items(currentForn) = fornecedor
        End If
        Return True
    End Function
    Sub ShowForn()
        If ListBox1.Items.Count = 0 Or currentForn < 0 Then Exit Sub
        Dim fornecedor As New CafeFornecedor
        fornecedor = CType(ListBox1.Items.Item(currentForn), CafeFornecedor)
        NomeFornBox.Text = fornecedor.NomeFornecedor
        CCFornecedorBox.Text = fornecedor.CCFornecedor
        codigoFornBox.Text = fornecedor.CodigoInt
        MoradaFornBox.Text = fornecedor.MoradaFornecedor
        TelefoneFornBox.Text = fornecedor.TelefoneFornecedor
        FaxFornBox.Text = fornecedor.FaxFornecedor
        PagFornBox.Text = fornecedor.Pag_Fornecedor

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentForn = ListBox1.SelectedIndex
            ShowForn()
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

    Private Sub produtosButton_Click(sender As Object, e As EventArgs) Handles produtosButton.Click
        Dim produtosPage As New listaProdutos
        produtosPage.Show()
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
End Class