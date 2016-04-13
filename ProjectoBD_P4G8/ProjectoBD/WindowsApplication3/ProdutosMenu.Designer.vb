<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listaProdutos))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.funcionarioButton = New System.Windows.Forms.Button()
        Me.clienteButton = New System.Windows.Forms.Button()
        Me.fornecedorButton = New System.Windows.Forms.Button()
        Me.encomendasButton = New System.Windows.Forms.Button()
        Me.comprasButton = New System.Windows.Forms.Button()
        Me.turnosButton = New System.Windows.Forms.Button()
        Me.reclamacoesButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nomeProdBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.familiaProdBox = New System.Windows.Forms.TextBox()
        Me.precoProdBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numFuncProdBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numEncProdBox = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.cancelarButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(650, 24)
        Me.MenuStrip1.TabIndex = 111
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
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(99, 37)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(265, 298)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 112
        '
        'MenuButton
        '
        Me.MenuButton.Location = New System.Drawing.Point(6, 37)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(86, 23)
        Me.MenuButton.TabIndex = 122
        Me.MenuButton.Text = "Menu Principal"
        Me.MenuButton.UseVisualStyleBackColor = True
        '
        'funcionarioButton
        '
        Me.funcionarioButton.Location = New System.Drawing.Point(6, 66)
        Me.funcionarioButton.Name = "funcionarioButton"
        Me.funcionarioButton.Size = New System.Drawing.Size(86, 23)
        Me.funcionarioButton.TabIndex = 123
        Me.funcionarioButton.Text = "Funcionários"
        Me.funcionarioButton.UseVisualStyleBackColor = True
        '
        'clienteButton
        '
        Me.clienteButton.Location = New System.Drawing.Point(6, 95)
        Me.clienteButton.Name = "clienteButton"
        Me.clienteButton.Size = New System.Drawing.Size(86, 23)
        Me.clienteButton.TabIndex = 124
        Me.clienteButton.Text = "Clientes"
        Me.clienteButton.UseVisualStyleBackColor = True
        '
        'fornecedorButton
        '
        Me.fornecedorButton.Location = New System.Drawing.Point(6, 124)
        Me.fornecedorButton.Name = "fornecedorButton"
        Me.fornecedorButton.Size = New System.Drawing.Size(86, 23)
        Me.fornecedorButton.TabIndex = 125
        Me.fornecedorButton.Text = "Fornecedores"
        Me.fornecedorButton.UseVisualStyleBackColor = True
        '
        'encomendasButton
        '
        Me.encomendasButton.Location = New System.Drawing.Point(7, 153)
        Me.encomendasButton.Name = "encomendasButton"
        Me.encomendasButton.Size = New System.Drawing.Size(86, 23)
        Me.encomendasButton.TabIndex = 127
        Me.encomendasButton.Text = "Encomendas"
        Me.encomendasButton.UseVisualStyleBackColor = True
        '
        'comprasButton
        '
        Me.comprasButton.Location = New System.Drawing.Point(7, 182)
        Me.comprasButton.Name = "comprasButton"
        Me.comprasButton.Size = New System.Drawing.Size(86, 23)
        Me.comprasButton.TabIndex = 128
        Me.comprasButton.Text = "Compras"
        Me.comprasButton.UseVisualStyleBackColor = True
        '
        'turnosButton
        '
        Me.turnosButton.Location = New System.Drawing.Point(7, 211)
        Me.turnosButton.Name = "turnosButton"
        Me.turnosButton.Size = New System.Drawing.Size(86, 23)
        Me.turnosButton.TabIndex = 129
        Me.turnosButton.Text = "Turnos"
        Me.turnosButton.UseVisualStyleBackColor = True
        '
        'reclamacoesButton
        '
        Me.reclamacoesButton.Location = New System.Drawing.Point(6, 240)
        Me.reclamacoesButton.Name = "reclamacoesButton"
        Me.reclamacoesButton.Size = New System.Drawing.Size(86, 23)
        Me.reclamacoesButton.TabIndex = 130
        Me.reclamacoesButton.Text = "Reclamações"
        Me.reclamacoesButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(381, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "ID"
        '
        'IDBox
        '
        Me.IDBox.Location = New System.Drawing.Point(384, 53)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(84, 20)
        Me.IDBox.TabIndex = 132
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Nome do produto"
        '
        'nomeProdBox
        '
        Me.nomeProdBox.Location = New System.Drawing.Point(490, 53)
        Me.nomeProdBox.Name = "nomeProdBox"
        Me.nomeProdBox.Size = New System.Drawing.Size(107, 20)
        Me.nomeProdBox.TabIndex = 134
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(381, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "Família"
        '
        'familiaProdBox
        '
        Me.familiaProdBox.Location = New System.Drawing.Point(384, 140)
        Me.familiaProdBox.Name = "familiaProdBox"
        Me.familiaProdBox.Size = New System.Drawing.Size(100, 20)
        Me.familiaProdBox.TabIndex = 136
        '
        'precoProdBox
        '
        Me.precoProdBox.Location = New System.Drawing.Point(518, 140)
        Me.precoProdBox.Name = "precoProdBox"
        Me.precoProdBox.Size = New System.Drawing.Size(51, 20)
        Me.precoProdBox.TabIndex = 137
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(515, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Preço"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(381, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "NºFuncionario"
        '
        'numFuncProdBox
        '
        Me.numFuncProdBox.Location = New System.Drawing.Point(384, 227)
        Me.numFuncProdBox.Name = "numFuncProdBox"
        Me.numFuncProdBox.Size = New System.Drawing.Size(46, 20)
        Me.numFuncProdBox.TabIndex = 140
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(501, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "NºEncomenda"
        '
        'numEncProdBox
        '
        Me.numEncProdBox.Location = New System.Drawing.Point(504, 227)
        Me.numEncProdBox.Name = "numEncProdBox"
        Me.numEncProdBox.Size = New System.Drawing.Size(46, 20)
        Me.numEncProdBox.TabIndex = 142
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.OKButton.Location = New System.Drawing.Point(416, 271)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(92, 26)
        Me.OKButton.TabIndex = 143
        Me.OKButton.Text = "OK"
        Me.OKButton.Visible = False
        '
        'cancelarButton
        '
        Me.cancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelarButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cancelarButton.Location = New System.Drawing.Point(514, 271)
        Me.cancelarButton.Name = "cancelarButton"
        Me.cancelarButton.Size = New System.Drawing.Size(91, 26)
        Me.cancelarButton.TabIndex = 144
        Me.cancelarButton.Text = "Cancelar"
        Me.cancelarButton.Visible = False
        '
        'addButton
        '
        Me.addButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.addButton.Location = New System.Drawing.Point(376, 309)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(92, 26)
        Me.addButton.TabIndex = 145
        Me.addButton.Text = "Adicionar"
        '
        'editButton
        '
        Me.editButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.editButton.Location = New System.Drawing.Point(472, 309)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(73, 26)
        Me.editButton.TabIndex = 146
        Me.editButton.Text = "Editar"
        '
        'removeButton
        '
        Me.removeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.removeButton.Location = New System.Drawing.Point(551, 309)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(87, 26)
        Me.removeButton.TabIndex = 147
        Me.removeButton.Text = "Remover"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(571, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 17)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "€"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 320)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 90)
        Me.PictureBox1.TabIndex = 154
        Me.PictureBox1.TabStop = False
        '
        'listaProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 419)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.cancelarButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.numEncProdBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.numFuncProdBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.precoProdBox)
        Me.Controls.Add(Me.familiaProdBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nomeProdBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IDBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.reclamacoesButton)
        Me.Controls.Add(Me.turnosButton)
        Me.Controls.Add(Me.comprasButton)
        Me.Controls.Add(Me.encomendasButton)
        Me.Controls.Add(Me.fornecedorButton)
        Me.Controls.Add(Me.clienteButton)
        Me.Controls.Add(Me.funcionarioButton)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "listaProdutos"
        Me.Text = "Lista de Produtos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents funcionarioButton As System.Windows.Forms.Button
    Friend WithEvents clienteButton As System.Windows.Forms.Button
    Friend WithEvents fornecedorButton As System.Windows.Forms.Button
    Friend WithEvents encomendasButton As System.Windows.Forms.Button
    Friend WithEvents comprasButton As System.Windows.Forms.Button
    Friend WithEvents turnosButton As System.Windows.Forms.Button
    Friend WithEvents reclamacoesButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IDBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nomeProdBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents familiaProdBox As System.Windows.Forms.TextBox
    Friend WithEvents precoProdBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numFuncProdBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents numEncProdBox As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents cancelarButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
