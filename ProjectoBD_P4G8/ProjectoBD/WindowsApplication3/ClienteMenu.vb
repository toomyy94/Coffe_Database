Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class listaClientes
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentFunc As Integer
    Dim adding As Boolean


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        Dim mainMenu As New MainMenu
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub funcionarioButton_Click(sender As Object, e As EventArgs) Handles funcionarioButton.Click
        Dim funcionariosPage As New listaFuncionarios
        funcionariosPage.Show()
        Me.Hide()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        currentFunc = ListBox1.SelectedIndex
        If currentFunc <= 0 Then
            MsgBox("Por favor, selecione um cliente para editar")
            Exit Sub
        End If
        adding = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub removeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles removeButton.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Seleccione um cliente para remover!")
        End If
        If ListBox1.SelectedIndex > -1 Then
            Try
                CMD.CommandText = "DELETE FROM cafe.Cliente WHERE CC_Cliente=@CCCliente"
                CMD.Parameters.Clear()
                CN.Open()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
                CN.Close()
            End Try
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If currentFunc = ListBox1.Items.Count Then currentFunc = ListBox1.Items.Count - 1
            If currentFunc = -1 Then
                ClearFields()
                MsgBox("Não existem mais clientes!!!")
            Else
                ShowCliente()
            End If
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Try
            SaveCliente()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(NIFClienteBox.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles cancelarButton.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentFunc = ListBox1.SelectedIndex
            If currentFunc < 0 Then currentFunc = 0
            ShowCliente()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Sub ClearFields()
        NomeClienteBox.Text = ""
        CCClienteBox.Text = 0
        NIFClienteBox.Text = 0
        MoradaClienteBox.Text = ""
        TelefoneClienteBox.Text = 0
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
        NomeClienteBox.ReadOnly = False
        CCClienteBox.ReadOnly = False
        NIFClienteBox.ReadOnly = False
        MoradaClienteBox.ReadOnly = False
        TelefoneClienteBox.ReadOnly = False
    End Sub

    Sub LockControls()
        NomeClienteBox.ReadOnly = True
        CCClienteBox.ReadOnly = True
        NIFClienteBox.ReadOnly = True
        MoradaClienteBox.ReadOnly = True
        TelefoneClienteBox.ReadOnly = True
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
        CMD.CommandText = "SELECT * FROM  cafe.Cliente"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New CafeCliente
            C.NomeCliente = RDR.Item("nomeCli")
            C.CCCliente = RDR.Item("CC_Cliente")
            C.NIFCliente = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("NIF")), "", RDR.Item("NIF")))
            C.MoradaCliente = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("moradaCli")), "", RDR.Item("moradaCli")))
            C.TelefoneCliente = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("telefoneCli")), "", RDR.Item("telefoneCli")))

            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentFunc = 0
        ShowCliente()
    End Sub

    Private Sub SubmeterCliente(ByVal C As CafeCliente)
        'CMD.CommandText = "INSERT cafe.Cliente (nomeCli, CC_Cliente, NIF, moradaCli, telefoneCli)" & _
        '                  "VALUES (@NomeCliente, @CCCliente, @NIFCliente, @MoradaCliente, @TelefoneCliente) "
        CMD.CommandText = "exec cafe.sp_InsertCliente @NomeCliente, @CCCliente, @NIFCliente, @MoradaCliente, @TelefoneCliente"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NomeCliente", C.NomeCliente)
        CMD.Parameters.AddWithValue("@CCCliente", C.CCCliente)
        CMD.Parameters.AddWithValue("@NIFCliente", C.NIFCliente)
        CMD.Parameters.AddWithValue("@MoradaCliente", C.MoradaCliente)
        CMD.Parameters.AddWithValue("@TelefoneCliente", C.TelefoneCliente)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update cliente in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub UpdateCliente(ByVal C As CafeCliente)
        'CMD.CommandText = "UPDATE cafe.Cliente " & _
        '    "SET nomeCli = @NomeCliente, " & _
        '    "    CC_Cliente = @CCCliente, " & _
        '    "    moradaCli = @MoradaCliente, " & _
        '    "    telefoneCli = @TelefoneCliente " & _
        '    "WHERE NIF = @NIFCliente"
        CMD.CommandText = "exec cafe.sp_UpdateCliente @NomeCliente, @CCCliente, @NIFCliente, @MoradaCliente, @TelefoneCliente"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NomeCliente", C.NomeCliente)
        CMD.Parameters.AddWithValue("@CCCliente", C.CCCliente)
        CMD.Parameters.AddWithValue("@NIFCliente", C.NIFCliente)
        CMD.Parameters.AddWithValue("@MoradaCliente", C.MoradaCliente)
        CMD.Parameters.AddWithValue("@TelefoneCliente", C.TelefoneCliente)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update cliente in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub
    Private Function SaveCliente() As Boolean
        Dim cliente As New CafeCliente
        Try
            cliente.NomeCliente = NomeClienteBox.Text
            cliente.CCCliente = CCClienteBox.Text
            cliente.NIFCliente = NIFClienteBox.Text
            cliente.MoradaCliente = MoradaClienteBox.Text
            cliente.TelefoneCliente = TelefoneClienteBox.Text
            
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        If adding Then
            SubmeterCliente(cliente)
            ListBox1.Items.Add(cliente)
        Else
            UpdateCliente(cliente)
            ListBox1.Items(currentFunc) = cliente
        End If
        Return True
    End Function
    Sub ShowCliente()
        If ListBox1.Items.Count = 0 Or currentFunc < 0 Then Exit Sub
        Dim cliente As New CafeCliente
        cliente = CType(ListBox1.Items.Item(currentFunc), CafeCliente)
        NomeClienteBox.Text = cliente.NomeCliente
        CCClienteBox.Text = cliente.CCCliente
        NIFClienteBox.Text = cliente.NIFCliente
        MoradaClienteBox.Text = cliente.MoradaCliente
        TelefoneClienteBox.Text = cliente.TelefoneCliente

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentFunc = ListBox1.SelectedIndex
            ShowCliente()
        End If
    End Sub
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

   
    Private Sub fornecedorButton_Click(sender As Object, e As EventArgs) Handles fornecedorButton.Click
        Dim fornecedorPage As New listaFornecedores
        fornecedorPage.Show()
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