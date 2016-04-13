Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Public Class listaTurnos
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentTurno As Integer
    Dim adding As Boolean

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        adding = True
        ClearFields()
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        currentTurno = ListBox1.SelectedIndex
        If currentTurno <= 0 Then
            MsgBox("Por favor, selecione um turno para editar")
            Exit Sub
        End If
        adding = False
        HideButtons()
        ListBox1.Enabled = False
    End Sub

    Private Sub removeButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles removeButton.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Seleccione um turno para remover!")
        End If
        If ListBox1.SelectedIndex > -1 Then
            Try
                CMD.CommandText = "DELETE FROM cafe.horario WHERE numeroHoras=@NumeroHoras"
                CMD.Parameters.Clear()
                CN.Open()

            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
                CN.Close()
            End Try
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            If currentTurno = ListBox1.Items.Count Then currentTurno = ListBox1.Items.Count - 1
            If currentTurno = -1 Then
                ClearFields()
                MsgBox("Lista de turnos vazia!!!")
            Else
                ShowTurno()
            End If
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Try
            SaveTurno()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ListBox1.Enabled = True
        Dim idx As Integer = ListBox1.FindString(horasBox.Text)
        ListBox1.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles cancelarButton.Click
        ListBox1.Enabled = True
        If ListBox1.Items.Count > 0 Then
            currentTurno = ListBox1.SelectedIndex
            If currentTurno < 0 Then currentTurno = 0
            ShowTurno()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Sub ClearFields()
        turnoBox.Text = ""
        horasBox.Text = 0
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
        turnoBox.ReadOnly = False
        horasBox.ReadOnly = False
    End Sub

    Sub LockControls()
        turnoBox.ReadOnly = True
        horasBox.ReadOnly = True
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
        CMD.CommandText = "SELECT * FROM  cafe.horario"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New CafeTurno
            C.Turno = RDR.Item("turno")
            C.NumeroHoras = RDR.Item("numeroHoras")
           
            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentTurno = 0
        ShowTurno()
    End Sub

    Private Sub SubmeterTurno(ByVal C As CafeTurno)
        'CMD.CommandText = "INSERT cafe.horario (turno, numeroHoras)" & _
        '                  "VALUES (@Turno, @NumeroHoras) "
        CMD.CommandText = "exec cafe.sp_InsertHorario @Turno, @NumeroHoras"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@Turno", C.Turno)
        CMD.Parameters.AddWithValue("@NumeroHoras", C.NumeroHoras)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update turno in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        CN.Close()
    End Sub

    Private Sub UpdateTurno(ByVal C As CafeTurno)
        'CMD.CommandText = "UPDATE cafe.horario " & _
        '    "SET turno = @Turno " & _
        '    "WHERE numeroHoras = @NumeroHoras"

        CMD.CommandText = "exec cafe.sp_UpdateHorario @Turno, @NumeroHoras"
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@Turno", C.Turno)
        CMD.Parameters.AddWithValue("@NumeroHoras", C.NumeroHoras)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update turno in database. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub
    Private Function SaveTurno() As Boolean
        Dim turno As New CafeTurno
        Try
            turno.Turno = turnoBox.Text
            turno.NumeroHoras = horasBox.Text

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        If adding Then
            SubmeterTurno(turno)
            ListBox1.Items.Add(turno)
        Else
            UpdateTurno(turno)
            ListBox1.Items(currentTurno) = turno
        End If
        Return True
    End Function
    Sub ShowTurno()
        If ListBox1.Items.Count = 0 Or currentTurno < 0 Then Exit Sub
        Dim turno As New CafeTurno
        turno = CType(ListBox1.Items.Item(currentTurno), CafeTurno)
        turnoBox.Text = turno.Turno
        horasBox.Text = turno.NumeroHoras
       
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            currentTurno = ListBox1.SelectedIndex
            ShowTurno()
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

    Private Sub reclamacoesButton_Click(sender As Object, e As EventArgs) Handles reclamacoesButton.Click
        Dim reclamacoesPage As New listaReclamacoes
        reclamacoesPage.Show()
        Me.Hide()
    End Sub
End Class