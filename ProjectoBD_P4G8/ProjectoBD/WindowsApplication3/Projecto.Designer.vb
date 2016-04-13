<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaFuncionarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listaFuncionarios))
        Me.addButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.cancelarButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.namefuncBox = New System.Windows.Forms.TextBox()
        Me.CCfuncBox = New System.Windows.Forms.TextBox()
        Me.NFuncBox = New System.Windows.Forms.TextBox()
        Me.moradaFuncBox = New System.Windows.Forms.TextBox()
        Me.telefoneFuncBox = New System.Windows.Forms.TextBox()
        Me.SalarioFuncBox = New System.Windows.Forms.TextBox()
        Me.SupervisorBox = New System.Windows.Forms.TextBox()
        Me.TurnoFuncBox = New System.Windows.Forms.TextBox()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.clienteButton = New System.Windows.Forms.Button()
        Me.fornecedorButton = New System.Windows.Forms.Button()
        Me.produtosButton = New System.Windows.Forms.Button()
        Me.encomendasButton = New System.Windows.Forms.Button()
        Me.comprasButton = New System.Windows.Forms.Button()
        Me.turnosButton = New System.Windows.Forms.Button()
        Me.reclamacoesButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.searchFuncButton = New System.Windows.Forms.Button()
        Me.searchFuncBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addButton
        '
        Me.addButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.addButton.Location = New System.Drawing.Point(354, 307)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(92, 26)
        Me.addButton.TabIndex = 104
        Me.addButton.Text = "Adicionar"
        '
        'editButton
        '
        Me.editButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.editButton.Location = New System.Drawing.Point(452, 307)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(73, 26)
        Me.editButton.TabIndex = 104
        Me.editButton.Text = "Editar"
        '
        'removeButton
        '
        Me.removeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.removeButton.Location = New System.Drawing.Point(531, 307)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(87, 26)
        Me.removeButton.TabIndex = 104
        Me.removeButton.Text = "Remover"
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.OKButton.Location = New System.Drawing.Point(390, 275)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(92, 26)
        Me.OKButton.TabIndex = 104
        Me.OKButton.Text = "OK"
        Me.OKButton.Visible = False
        '
        'cancelarButton
        '
        Me.cancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelarButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cancelarButton.Location = New System.Drawing.Point(488, 275)
        Me.cancelarButton.Name = "cancelarButton"
        Me.cancelarButton.Size = New System.Drawing.Size(91, 26)
        Me.cancelarButton.TabIndex = 104
        Me.cancelarButton.Text = "Cancelar"
        Me.cancelarButton.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.Location = New System.Drawing.Point(367, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(515, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "CC"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(371, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nº Funcionário"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(498, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Morada"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(371, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Telefone"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(498, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Salário"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(369, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Nº Supervisor"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(501, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Turno"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(106, 33)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(242, 298)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 107
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(630, 24)
        Me.MenuStrip1.TabIndex = 108
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CarregarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FileToolStripMenuItem.Text = "Ficheiro"
        '
        'CarregarToolStripMenuItem
        '
        Me.CarregarToolStripMenuItem.Name = "CarregarToolStripMenuItem"
        Me.CarregarToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CarregarToolStripMenuItem.Text = "Carregar "
        '
        'namefuncBox
        '
        Me.namefuncBox.Location = New System.Drawing.Point(370, 50)
        Me.namefuncBox.Name = "namefuncBox"
        Me.namefuncBox.Size = New System.Drawing.Size(122, 20)
        Me.namefuncBox.TabIndex = 109
        '
        'CCfuncBox
        '
        Me.CCfuncBox.Location = New System.Drawing.Point(518, 50)
        Me.CCfuncBox.Name = "CCfuncBox"
        Me.CCfuncBox.Size = New System.Drawing.Size(100, 20)
        Me.CCfuncBox.TabIndex = 110
        '
        'NFuncBox
        '
        Me.NFuncBox.Location = New System.Drawing.Point(372, 110)
        Me.NFuncBox.Name = "NFuncBox"
        Me.NFuncBox.Size = New System.Drawing.Size(46, 20)
        Me.NFuncBox.TabIndex = 111
        '
        'moradaFuncBox
        '
        Me.moradaFuncBox.Location = New System.Drawing.Point(501, 110)
        Me.moradaFuncBox.Name = "moradaFuncBox"
        Me.moradaFuncBox.Size = New System.Drawing.Size(117, 20)
        Me.moradaFuncBox.TabIndex = 112
        '
        'telefoneFuncBox
        '
        Me.telefoneFuncBox.Location = New System.Drawing.Point(372, 174)
        Me.telefoneFuncBox.Name = "telefoneFuncBox"
        Me.telefoneFuncBox.Size = New System.Drawing.Size(100, 20)
        Me.telefoneFuncBox.TabIndex = 113
        '
        'SalarioFuncBox
        '
        Me.SalarioFuncBox.Location = New System.Drawing.Point(501, 174)
        Me.SalarioFuncBox.Name = "SalarioFuncBox"
        Me.SalarioFuncBox.Size = New System.Drawing.Size(67, 20)
        Me.SalarioFuncBox.TabIndex = 114
        '
        'SupervisorBox
        '
        Me.SupervisorBox.Location = New System.Drawing.Point(372, 236)
        Me.SupervisorBox.Name = "SupervisorBox"
        Me.SupervisorBox.Size = New System.Drawing.Size(46, 20)
        Me.SupervisorBox.TabIndex = 115
        '
        'TurnoFuncBox
        '
        Me.TurnoFuncBox.Location = New System.Drawing.Point(501, 236)
        Me.TurnoFuncBox.Name = "TurnoFuncBox"
        Me.TurnoFuncBox.Size = New System.Drawing.Size(78, 20)
        Me.TurnoFuncBox.TabIndex = 116
        '
        'MenuButton
        '
        Me.MenuButton.Location = New System.Drawing.Point(12, 33)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(86, 23)
        Me.MenuButton.TabIndex = 117
        Me.MenuButton.Text = "Menu Principal"
        Me.MenuButton.UseVisualStyleBackColor = True
        '
        'clienteButton
        '
        Me.clienteButton.Location = New System.Drawing.Point(12, 62)
        Me.clienteButton.Name = "clienteButton"
        Me.clienteButton.Size = New System.Drawing.Size(86, 23)
        Me.clienteButton.TabIndex = 118
        Me.clienteButton.Text = "Clientes"
        Me.clienteButton.UseVisualStyleBackColor = True
        '
        'fornecedorButton
        '
        Me.fornecedorButton.Location = New System.Drawing.Point(12, 91)
        Me.fornecedorButton.Name = "fornecedorButton"
        Me.fornecedorButton.Size = New System.Drawing.Size(86, 23)
        Me.fornecedorButton.TabIndex = 119
        Me.fornecedorButton.Text = "Fornecedores"
        Me.fornecedorButton.UseVisualStyleBackColor = True
        '
        'produtosButton
        '
        Me.produtosButton.Location = New System.Drawing.Point(12, 120)
        Me.produtosButton.Name = "produtosButton"
        Me.produtosButton.Size = New System.Drawing.Size(86, 23)
        Me.produtosButton.TabIndex = 120
        Me.produtosButton.Text = "Produtos"
        Me.produtosButton.UseVisualStyleBackColor = True
        '
        'encomendasButton
        '
        Me.encomendasButton.Location = New System.Drawing.Point(12, 149)
        Me.encomendasButton.Name = "encomendasButton"
        Me.encomendasButton.Size = New System.Drawing.Size(86, 23)
        Me.encomendasButton.TabIndex = 121
        Me.encomendasButton.Text = "Encomendas"
        Me.encomendasButton.UseVisualStyleBackColor = True
        '
        'comprasButton
        '
        Me.comprasButton.Location = New System.Drawing.Point(12, 178)
        Me.comprasButton.Name = "comprasButton"
        Me.comprasButton.Size = New System.Drawing.Size(86, 23)
        Me.comprasButton.TabIndex = 122
        Me.comprasButton.Text = "Compras"
        Me.comprasButton.UseVisualStyleBackColor = True
        '
        'turnosButton
        '
        Me.turnosButton.Location = New System.Drawing.Point(12, 207)
        Me.turnosButton.Name = "turnosButton"
        Me.turnosButton.Size = New System.Drawing.Size(86, 23)
        Me.turnosButton.TabIndex = 123
        Me.turnosButton.Text = "Turnos"
        Me.turnosButton.UseVisualStyleBackColor = True
        '
        'reclamacoesButton
        '
        Me.reclamacoesButton.Location = New System.Drawing.Point(12, 236)
        Me.reclamacoesButton.Name = "reclamacoesButton"
        Me.reclamacoesButton.Size = New System.Drawing.Size(86, 23)
        Me.reclamacoesButton.TabIndex = 124
        Me.reclamacoesButton.Text = "Reclamações"
        Me.reclamacoesButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(570, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 17)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "€"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 316)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 90)
        Me.PictureBox1.TabIndex = 150
        Me.PictureBox1.TabStop = False
        '
        'searchFuncButton
        '
        Me.searchFuncButton.Location = New System.Drawing.Point(143, 366)
        Me.searchFuncButton.Name = "searchFuncButton"
        Me.searchFuncButton.Size = New System.Drawing.Size(88, 23)
        Me.searchFuncButton.TabIndex = 151
        Me.searchFuncButton.Text = "Search"
        Me.searchFuncButton.UseVisualStyleBackColor = True
        '
        'searchFuncBox
        '
        Me.searchFuncBox.Location = New System.Drawing.Point(237, 368)
        Me.searchFuncBox.Name = "searchFuncBox"
        Me.searchFuncBox.Size = New System.Drawing.Size(183, 20)
        Me.searchFuncBox.TabIndex = 152
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(237, 349)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "Nome do funcionário"
        '
        'listaFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 409)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.searchFuncBox)
        Me.Controls.Add(Me.searchFuncButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.reclamacoesButton)
        Me.Controls.Add(Me.turnosButton)
        Me.Controls.Add(Me.comprasButton)
        Me.Controls.Add(Me.encomendasButton)
        Me.Controls.Add(Me.produtosButton)
        Me.Controls.Add(Me.fornecedorButton)
        Me.Controls.Add(Me.clienteButton)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.TurnoFuncBox)
        Me.Controls.Add(Me.SupervisorBox)
        Me.Controls.Add(Me.SalarioFuncBox)
        Me.Controls.Add(Me.telefoneFuncBox)
        Me.Controls.Add(Me.moradaFuncBox)
        Me.Controls.Add(Me.NFuncBox)
        Me.Controls.Add(Me.CCfuncBox)
        Me.Controls.Add(Me.namefuncBox)
        Me.Controls.Add(Me.cancelarButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "listaFuncionarios"
        Me.Text = "Lista de Funcionários"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents cancelarButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents namefuncBox As System.Windows.Forms.TextBox
    Friend WithEvents CCfuncBox As System.Windows.Forms.TextBox
    Friend WithEvents NFuncBox As System.Windows.Forms.TextBox
    Friend WithEvents moradaFuncBox As System.Windows.Forms.TextBox
    Friend WithEvents telefoneFuncBox As System.Windows.Forms.TextBox
    Friend WithEvents SalarioFuncBox As System.Windows.Forms.TextBox
    Friend WithEvents SupervisorBox As System.Windows.Forms.TextBox
    Friend WithEvents TurnoFuncBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents clienteButton As System.Windows.Forms.Button
    Friend WithEvents fornecedorButton As System.Windows.Forms.Button
    Friend WithEvents produtosButton As System.Windows.Forms.Button
    Friend WithEvents encomendasButton As System.Windows.Forms.Button
    Friend WithEvents comprasButton As System.Windows.Forms.Button
    Friend WithEvents turnosButton As System.Windows.Forms.Button
    Friend WithEvents reclamacoesButton As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents searchFuncButton As System.Windows.Forms.Button
    Friend WithEvents searchFuncBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label


End Class
