Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1
    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim currentFunc As Integer
    Dim adding As Boolean

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        adding = True

        ListBox1.Enabled = False
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        '' Change this line...
        CN = New SqlConnection("data source=193.136.175.33\SQLSERVER2012,8293;integrated security=true;initial catalog=p4g8")
        CMD = New SqlCommand
        CMD.Connection = CN
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub


   
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub SubmitContact(ByVal C As CafeFuncionario)
        CMD.CommandText = "INSERT cafe.Funcionario (NomeFuncionario, CCFuncionario, NumFuncionario, MoradaFuncionario, " & _
                          "TelefoneFuncionario, SalarioFuncionario, SuperVisionaFuncionario, TurnoFuncionario) " & _
                          "VALUES (@NomeFuncionario, @CCFuncionario, @NumFuncionario, @MoradaFuncionario, " & _
                          "@TelefoneFuncionario, @SalarioFuncionario, @SuperVisionaFuncionario, @TurnoFuncionario) "
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
        CMD.CommandText = "SELECT * FROM cafe.Funcionario"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        ListBox1.Items.Clear()
        While RDR.Read
            Dim C As New CafeFuncionario
            C.NomeFuncionario = RDR.Item("NomeFuncionario")
            C.CCFuncionario = RDR.Item("CCFuncionario")
            C.NumFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("NumFuncionario")), "", RDR.Item("NumFuncionario")))
            C.MoradaFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("MoradaFuncionario")), "", RDR.Item("MoradaFuncionario")))
            C.TelefoneFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("TelefoneFuncionario")), "", RDR.Item("TelefoneFuncionario")))
            C.SalarioFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("SalarioFuncionario")), "", RDR.Item("SalarioFuncionario")))
            C.SuperVisionaFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("SuperVisionaFuncionario")), "", RDR.Item("SuperVisionaFuncionario")))
            C.TurnoFuncionario = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("TurnoFuncionario")), "", RDR.Item("TurnoFuncionario")))


            ListBox1.Items.Add(C)
        End While
        CN.Close()
        currentFunc = 0
        ShowFunc()

    End Sub

    Sub ShowFunc()
        If ListBox1.Items.Count = 0 Or currentFunc < 0 Then Exit Sub
        Dim funcionario As New CafeFuncionario
        funcionario = CType(ListBox1.Items.Item(currentFunc), CafeFuncionario)
        TextBox1.Text = funcionario.NomeFuncionario
        TextBox2.Text = funcionario.CCFuncionario
        TextBox3.Text = funcionario.NumFuncionario
        TextBox4.Text = funcionario.MoradaFuncionario
        TextBox5.Text = funcionario.TelefoneFuncionario
        NumericUpDown1.Value = funcionario.SalarioFuncionario
        TextBox6.Text = funcionario.SuperVisionaFuncionario
        TextBox7.Text = funcionario.TurnoFuncionario

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
