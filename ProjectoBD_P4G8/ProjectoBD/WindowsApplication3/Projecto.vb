Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class listaFuncionarios
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentFunc As Integer
    Dim adding As Boolean

    '' Botão adicionar
    Private Sub addButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles addButton.Click
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub


    '' Botão editar
    Private Sub editButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editButton.Click
        currentFunc = ListBox1.SelectedIndex
        If currentFunc <= 0 Then
            MsgBox("Por favor, selecione um funcionário para editar")
            Exit Sub
        End If
        adding = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentFunc = ListBox1.SelectedIndex
            ShowFunc()
        End If
    End Sub

    'botão remover'

    Private Sub removeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Seleccione um funcionário para remover!")
        End If
        If ListBox1.SelectedIndex > -1 Then
            Try
                CMD.CommandText = "DELETE FROM cafe.Funcionario WHERE CCFuncionario=@CCFuncionario"
                CMD.Parameters.Clear()
                CN.Open()
                CMD.ExecuteNonQuery()
            Catch ex As Exception
                CN.Close()
            End Try

            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If currentFunc = ListBox1.Items.Count Then currentFunc = ListBox1.Items.Count - 1
            If currentFunc = -1 Then
                ClearFields()
                MsgBox("Não existe mais funcionários!!!")
            Else
                ShowFunc()
            End If
        End If
    End Sub

    ''botão Ok

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Try
            SaveFuncionario()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(NFuncBox.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    ''botão cancelar
    Private Sub cancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelarButton.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentFunc = ListBox1.SelectedIndex
            If currentFunc < 0 Then currentFunc = 0
            ShowFunc()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        '' Change this line...
        CN = AllConnections.ligacao()
        'CN = New SqlConnection("data source=tcp:193.136.175.33\\SQLSERVER2012,8293;initial catalog=p4g8; User ID=p4g8; Password=tomasgabriel")
        CMD = New SqlCommand
        CMD.Connection = CN
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub
    Private Function SaveFuncionario() As Boolean
        Dim funcionario As New CafeFuncionario
        Try
            funcionario.NomeFuncionario = namefuncBox.Text
            funcionario.CCFuncionario = CCfuncBox.Text
            funcionario.NumFuncionario = NFuncBox.Text
            funcionario.MoradaFuncionario = moradaFuncBox.Text
            funcionario.TelefoneFuncionario = telefoneFuncBox.Text
            funcionario.SalarioFuncionario = SalarioFuncBox.Text
            funcionario.SuperVisionaFuncionario = SupervisorBox.Text
            funcionario.TurnoFuncionario = TurnoFuncBox.Text

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        If adding Then
            SubmeterFuncionario(funcionario)
            ListBox1.Items.Add(funcionario)
        Else
            UpdateFuncionario(funcionario)
            ListBox1.Items(currentFunc) = funcionario
        End If
        Return True
    End Function


    Private Sub SubmeterFuncionario(ByVal C As CafeFuncionario)
        'CMD.CommandText = "INSERT cafe.Funcionario (nomeFunc, CCFunc, numFunc, moradaFunc, " & _
        '                  "telefoneFunc, salario, SuperFunc, turnoFunc) " & _
        '                  "VALUES (@NomeFuncionario, @CCFuncionario, @NumFuncionario, @MoradaFuncionario, " & _
        '                  "@TelefoneFuncionario, @SalarioFuncionario, @SuperVisionaFuncionario, @TurnoFuncionario) "
        CMD.CommandText = "exec cafe.sp_InsertFunc @NomeFuncionario, @CCFuncionario, @NumFuncionario, @MoradaFuncionario, " & _
                                "@TelefoneFuncionario, @SalarioFuncionario, @SuperVisionaFuncionario, @TurnoFuncionario"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NomeFuncionario", C.NomeFuncionario)
        CMD.Parameters.AddWithValue("@CCFuncionario", C.CCFuncionario)
        CMD.Parameters.AddWithValue("@NumFuncionario", C.NumFuncionario)
        CMD.Parameters.AddWithValue("@MoradaFuncionario", C.MoradaFuncionario)
        CMD.Parameters.AddWithValue("@TelefoneFuncionario", C.TelefoneFuncionario)
        CMD.Parameters.AddWithValue("@SalarioFuncionario", C.SalarioFuncionario)
        CMD.Parameters.AddWithValue("@SuperVisionaFuncionario", C.SuperVisionaFuncionario)
        CMD.Parameters.AddWithValue("@TurnoFuncionario", C.TurnoFuncionario)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update contact in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub CarregarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CarregarToolStripMenuItem.Click
        CMD.CommandText = "SELECT * FROM  cafe.Funcionario"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New CafeFuncionario
            C.NomeFuncionario = RDR.Item("nomeFunc")
            C.CCFuncionario = RDR.Item("CCFunc")
            C.NumFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("numFunc")), "", RDR.Item("numFunc")))
            C.MoradaFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("moradaFunc")), "", RDR.Item("moradaFunc")))
            C.TelefoneFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("telefoneFunc")), "", RDR.Item("telefoneFunc")))
            C.SalarioFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("salario")), "", RDR.Item("salario")))
            C.SuperVisionaFuncionario = (IIf(RDR.IsDBNull(RDR.GetOrdinal("SuperFunc")), 0, RDR.Item("SuperFunc")))
            C.TurnoFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("turnoFunc")), "", RDR.Item("turnoFunc")))
            ListBox1.Items.Add(C)
            ListBox1.Sorted = True
        End While
        CN.Close()
        currentFunc = 0
        ShowFunc()
    End Sub

    Private Sub UpdateFuncionario(ByVal C As CafeFuncionario)
        CMD.CommandText = "UPDATE cafe.Funcionario " & _
            "SET nomeFunc = @NomeFuncionario, " & _
            "    numFunc = @NumFuncionario, " & _
            "    moradaFunc = @MoradaFuncionario, " & _
            "    telefoneFunc = @TelefoneFuncionario, " & _
            "    salario = @SalarioFuncionario, " & _
            "    SuperFunc = @SuperVisionaFuncionario, " & _
            "    turnoFunc = @TurnoFuncionario " & _
            "WHERE CCFunc = @CCFuncionario"
        'CMD.CommandText = "exec cafe.sp_UpdateFunc @NomeFuncionario, @CCFuncionario, @NumFuncionario, @MoradaFuncionario, " & _
        '    "@TelefoneFuncionario, @SalarioFuncionario, @SuperVisionaFuncionario, @TurnoFuncionario"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@NomeFuncionario", C.NomeFuncionario)
        CMD.Parameters.AddWithValue("@CCFuncionario", C.CCFuncionario)
        CMD.Parameters.AddWithValue("@NumFuncionario", C.NumFuncionario)
        CMD.Parameters.AddWithValue("@MoradaFuncionario", C.MoradaFuncionario)
        CMD.Parameters.AddWithValue("@TelefoneFuncionario", C.TelefoneFuncionario)
        CMD.Parameters.AddWithValue("@SalarioFuncionario", C.SalarioFuncionario)
        CMD.Parameters.AddWithValue("@SuperVisionaFuncionario", C.SuperVisionaFuncionario)
        CMD.Parameters.AddWithValue("@TurnoFuncionario", C.TurnoFuncionario)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update funcionário in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub RemoverFuncionario(ByVal CCFuncionario As Integer)
        CMD.CommandText = "DELETE FROM cafe.Funcionario WHERE CCFuncionario=@CCFuncionario"
        CMD.Parameters.Clear()
        'CMD.Parameters.AddWithValue("@contactID", ContactID)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete funcionário in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub


    Sub ShowFunc()
        If ListBox1.Items.Count = 0 Or currentFunc < 0 Then Exit Sub
        Dim funcionario As New CafeFuncionario

        funcionario = CType(ListBox1.Items.Item(currentFunc), CafeFuncionario)
        namefuncBox.Text = funcionario.NomeFuncionario
        CCfuncBox.Text = funcionario.CCFuncionario
        NFuncBox.Text = funcionario.NumFuncionario
        moradaFuncBox.Text = funcionario.MoradaFuncionario
        telefoneFuncBox.Text = funcionario.TelefoneFuncionario
        SalarioFuncBox.Text = funcionario.SalarioFuncionario
        SupervisorBox.Text = funcionario.SuperVisionaFuncionario
        TurnoFuncBox.Text = funcionario.TurnoFuncionario

    End Sub

    Sub ClearFields()
        namefuncBox.Text = ""   '' textBox1 = nome
        CCfuncBox.Text = 0    '' textBox2 = cc   
        NFuncBox.Text = 0    '' textBox3 = numfunc 
        moradaFuncBox.Text = ""   '' textBox4 = morada
        telefoneFuncBox.Text = 0    '' textBox5 = telefone
        SalarioFuncBox.Text = 0    '' textBox6 = salario
        SupervisorBox.Text = 0    '' textbox7 = SuperFunc
        TurnoFuncBox.Text = ""   '' textBox8 = turno   
    End Sub

    Private Sub HideButtons()
        UnlockControls()
        addButton.Visible = False
        editButton.Visible = False
        removeButton.Visible = False
        OKButton.Visible = True
        cancelarButton.Visible = True
    End Sub

    Sub LockControls()
        namefuncBox.ReadOnly = True
        CCfuncBox.ReadOnly = True
        NFuncBox.ReadOnly = True
        moradaFuncBox.ReadOnly = True
        telefoneFuncBox.ReadOnly = True
        SalarioFuncBox.ReadOnly = True
        SupervisorBox.ReadOnly = True
        TurnoFuncBox.ReadOnly = True
    End Sub

    Sub UnlockControls()
        namefuncBox.ReadOnly = False
        CCfuncBox.ReadOnly = False
        NFuncBox.ReadOnly = False
        moradaFuncBox.ReadOnly = False
        telefoneFuncBox.ReadOnly = False
        SalarioFuncBox.ReadOnly = False
        SupervisorBox.ReadOnly = False
        TurnoFuncBox.ReadOnly = False
    End Sub

    Sub ShowButtons()
        LockControls()
        addButton.Visible = True
        editButton.Visible = True
        removeButton.Visible = True
        OKButton.Visible = False
        cancelarButton.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles namefuncBox.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles CCfuncBox.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs) Handles NFuncBox.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged_1(sender As Object, e As EventArgs) Handles moradaFuncBox.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles telefoneFuncBox.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged_1(sender As Object, e As EventArgs) Handles SalarioFuncBox.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged_1(sender As Object, e As EventArgs) Handles SupervisorBox.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged_1(sender As Object, e As EventArgs) Handles TurnoFuncBox.TextChanged

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub searchFuncButton_Click(sender As Object, e As EventArgs) Handles searchFuncButton.Click
        Dim texto As String
        texto = searchFuncBox.Text
        CMD.CommandText = "exec cafe.SearchFunc 'texto'"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New CafeFuncionario
            C.NomeFuncionario = RDR.Item("nomeFunc")
            C.CCFuncionario = RDR.Item("CCFunc")
            C.NumFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("numFunc")), "", RDR.Item("numFunc")))
            C.MoradaFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("moradaFunc")), "", RDR.Item("moradaFunc")))
            C.TelefoneFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("telefoneFunc")), "", RDR.Item("telefoneFunc")))
            C.SalarioFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("salario")), "", RDR.Item("salario")))
            C.SuperVisionaFuncionario = (IIf(RDR.IsDBNull(RDR.GetOrdinal("SuperFunc")), 0, RDR.Item("SuperFunc")))
            C.TurnoFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("turnoFunc")), "", RDR.Item("turnoFunc")))
            ListBox1.Items.Add(C)
            ListBox1.Sorted = True
        End While
        CN.Close()
        currentFunc = 0
        ShowFunc()
    End Sub
End Class
