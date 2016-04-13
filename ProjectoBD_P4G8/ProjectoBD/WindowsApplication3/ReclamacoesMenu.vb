Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class listaReclamacoes
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentRecla As Integer
    Dim adding As Boolean

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        currentRecla = ListBox1.SelectedIndex
        If currentRecla <= 0 Then
            MsgBox("Por favor, selecione uma encomenda para editar")
            Exit Sub
        End If
        adding = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub removeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles removeButton.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Seleccione uma reclamação para remover!")
        End If
        If ListBox1.SelectedIndex > -1 Then
            Try
                CMD.CommandText = "DELETE FROM cafe.Reclamacao WHERE nºreclamacao=@NumRecla"
                CMD.Parameters.Clear()
                CN.Open()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
                CN.Close()
            End Try
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If currentRecla = ListBox1.Items.Count Then currentRecla = ListBox1.Items.Count - 1
            If currentRecla = -1 Then
                ClearFields()
                MsgBox("Não existem mais reclamações!!!")
            Else
                ShowRecla()
            End If
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Try
            SaveReclamacao()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(numReclaBox.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles cancelarButton.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentRecla = ListBox1.SelectedIndex
            If currentRecla < 0 Then currentRecla = 0
            ShowRecla()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Sub ClearFields()
        numReclaBox.Text = 0
        NIFCliBox.Text = 0
        MotivoBox.Text = ""
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
        numReclaBox.ReadOnly = False
        NIFCliBox.ReadOnly = False
        MotivoBox.ReadOnly = False
    End Sub

    Sub LockControls()
        numReclaBox.ReadOnly = True
        NIFCliBox.ReadOnly = True
        MotivoBox.ReadOnly = True
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
        CMD.CommandText = "SELECT * FROM  cafe.Reclamacao"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New CafeReclamacao
            C.NumRecla = RDR.Item("nºreclamacao")
            C.MotivoRecla = RDR.Item("motivo")
            C.NIFRecla = IIf(RDR.IsDBNull(RDR.GetOrdinal("reclam_nifCli")), 0, RDR.Item("reclam_nifCli"))

            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentRecla = 0
        ShowRecla()
    End Sub

    Private Sub SubmeterReclamacao(ByVal C As CafeReclamacao)
        'CMD.CommandText = "INSERT cafe.Reclamacao (nºreclamacao, motivo, reclam_nifCli)" & _
        '                  "VALUES (@NumRecla, @MotivoRecla, @NIFRecla) "
        CMD.CommandText = "exec cafe.sp_InsertReclamacao @NumRecla, @MotivoRecla, @NIFRecla"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NumRecla", C.NumRecla)
        CMD.Parameters.AddWithValue("@MotivoRecla", C.MotivoRecla)
        CMD.Parameters.AddWithValue("@NIFRecla", C.NIFRecla)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update reclamação in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub UpdateReclamacao(ByVal C As CafeReclamacao)
        'CMD.CommandText = "UPDATE cafe.Reclamacao " & _
        '    "SET motivo = @MotivoRecla, " & _
        '    "    reclam_nifCli = @NIFRecla " & _
        '    "WHERE nºreclamacao = @NumRecla"
        CMD.CommandText = "exec cafe.sp_UpdateReclamacao @NumRecla, @MotivoRecla, @NIFRecla"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NumRecla", C.NumRecla)
        CMD.Parameters.AddWithValue("@MotivoRecla", C.MotivoRecla)
        CMD.Parameters.AddWithValue("@NIFRecla", C.NIFRecla)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update reclamação in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub
    Private Function SaveReclamacao() As Boolean
        Dim reclamacao As New CafeReclamacao
        Try
            reclamacao.NumRecla = numReclaBox.Text
            reclamacao.MotivoRecla = MotivoBox.Text
            reclamacao.NIFRecla = NIFCliBox.Text


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        If adding Then
            SubmeterReclamacao(reclamacao)
            ListBox1.Items.Add(reclamacao)
        Else
            UpdateReclamacao(reclamacao)
            ListBox1.Items(currentRecla) = reclamacao
        End If
        Return True
    End Function
    Sub ShowRecla()
        If ListBox1.Items.Count = 0 Or currentRecla < 0 Then Exit Sub
        Dim reclamacao As New CafeReclamacao
        reclamacao = CType(ListBox1.Items.Item(currentRecla), CafeReclamacao)
        numReclaBox.Text = reclamacao.NumRecla
        MotivoBox.Text = reclamacao.MotivoRecla
        NIFCliBox.Text = reclamacao.NIFRecla

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentRecla = ListBox1.SelectedIndex
            ShowRecla()
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



End Class