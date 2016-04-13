<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaReclamacoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listaReclamacoes))
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cancelarButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.numReclaBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comprasButton = New System.Windows.Forms.Button()
        Me.turnosButton = New System.Windows.Forms.Button()
        Me.encomendasButton = New System.Windows.Forms.Button()
        Me.produtosButton = New System.Windows.Forms.Button()
        Me.fornecedorButton = New System.Windows.Forms.Button()
        Me.clienteButton = New System.Windows.Forms.Button()
        Me.funcionarioButton = New System.Windows.Forms.Button()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MotivoBox = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NIFCliBox = New System.Windows.Forms.TextBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(418, 183)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(97, 20)
        Me.TextBox6.TabIndex = 199
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(415, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "NIF Cliente"
        '
        'cancelarButton
        '
        Me.cancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelarButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cancelarButton.Location = New System.Drawing.Point(551, 242)
        Me.cancelarButton.Name = "cancelarButton"
        Me.cancelarButton.Size = New System.Drawing.Size(91, 26)
        Me.cancelarButton.TabIndex = 197
        Me.cancelarButton.Text = "Cancelar"
        Me.cancelarButton.Visible = False
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.OKButton.Location = New System.Drawing.Point(453, 242)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(92, 26)
        Me.OKButton.TabIndex = 196
        Me.OKButton.Text = "OK"
        Me.OKButton.Visible = False
        '
        'numReclaBox
        '
        Me.numReclaBox.Location = New System.Drawing.Point(418, 54)
        Me.numReclaBox.Name = "numReclaBox"
        Me.numReclaBox.Size = New System.Drawing.Size(44, 20)
        Me.numReclaBox.TabIndex = 193
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(415, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 192
        Me.Label4.Text = "Nºreclamação"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(415, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 190
        Me.Label3.Text = "Motivo"
        '
        'comprasButton
        '
        Me.comprasButton.Location = New System.Drawing.Point(9, 213)
        Me.comprasButton.Name = "comprasButton"
        Me.comprasButton.Size = New System.Drawing.Size(86, 23)
        Me.comprasButton.TabIndex = 185
        Me.comprasButton.Text = "Compras"
        Me.comprasButton.UseVisualStyleBackColor = True
        '
        'turnosButton
        '
        Me.turnosButton.Location = New System.Drawing.Point(9, 242)
        Me.turnosButton.Name = "turnosButton"
        Me.turnosButton.Size = New System.Drawing.Size(86, 23)
        Me.turnosButton.TabIndex = 184
        Me.turnosButton.Text = "Turnos"
        Me.turnosButton.UseVisualStyleBackColor = True
        '
        'encomendasButton
        '
        Me.encomendasButton.Location = New System.Drawing.Point(9, 183)
        Me.encomendasButton.Name = "encomendasButton"
        Me.encomendasButton.Size = New System.Drawing.Size(86, 23)
        Me.encomendasButton.TabIndex = 183
        Me.encomendasButton.Text = "Encomendas"
        Me.encomendasButton.UseVisualStyleBackColor = True
        '
        'produtosButton
        '
        Me.produtosButton.Location = New System.Drawing.Point(9, 154)
        Me.produtosButton.Name = "produtosButton"
        Me.produtosButton.Size = New System.Drawing.Size(86, 23)
        Me.produtosButton.TabIndex = 182
        Me.produtosButton.Text = "Produtos"
        Me.produtosButton.UseVisualStyleBackColor = True
        '
        'fornecedorButton
        '
        Me.fornecedorButton.Location = New System.Drawing.Point(9, 125)
        Me.fornecedorButton.Name = "fornecedorButton"
        Me.fornecedorButton.Size = New System.Drawing.Size(86, 23)
        Me.fornecedorButton.TabIndex = 181
        Me.fornecedorButton.Text = "Fornecedores"
        Me.fornecedorButton.UseVisualStyleBackColor = True
        '
        'clienteButton
        '
        Me.clienteButton.Location = New System.Drawing.Point(9, 96)
        Me.clienteButton.Name = "clienteButton"
        Me.clienteButton.Size = New System.Drawing.Size(86, 23)
        Me.clienteButton.TabIndex = 180
        Me.clienteButton.Text = "Clientes"
        Me.clienteButton.UseVisualStyleBackColor = True
        '
        'funcionarioButton
        '
        Me.funcionarioButton.Location = New System.Drawing.Point(9, 67)
        Me.funcionarioButton.Name = "funcionarioButton"
        Me.funcionarioButton.Size = New System.Drawing.Size(86, 23)
        Me.funcionarioButton.TabIndex = 179
        Me.funcionarioButton.Text = "Funcionários"
        Me.funcionarioButton.UseVisualStyleBackColor = True
        '
        'MenuButton
        '
        Me.MenuButton.Location = New System.Drawing.Point(9, 38)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(86, 23)
        Me.MenuButton.TabIndex = 178
        Me.MenuButton.Text = "Menu Principal"
        Me.MenuButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(702, 24)
        Me.MenuStrip1.TabIndex = 177
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
        Me.ListBox1.Location = New System.Drawing.Point(101, 38)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(308, 284)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 176
        '
        'MotivoBox
        '
        Me.MotivoBox.Location = New System.Drawing.Point(418, 117)
        Me.MotivoBox.Name = "MotivoBox"
        Me.MotivoBox.Size = New System.Drawing.Size(210, 86)
        Me.MotivoBox.TabIndex = 200
        Me.MotivoBox.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 201
        Me.Label1.Text = "NIF Cliente"
        '
        'NIFCliBox
        '
        Me.NIFCliBox.Location = New System.Drawing.Point(531, 54)
        Me.NIFCliBox.Name = "NIFCliBox"
        Me.NIFCliBox.Size = New System.Drawing.Size(126, 20)
        Me.NIFCliBox.TabIndex = 202
        '
        'addButton
        '
        Me.addButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.addButton.Location = New System.Drawing.Point(418, 296)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(92, 26)
        Me.addButton.TabIndex = 203
        Me.addButton.Text = "Adicionar"
        '
        'editButton
        '
        Me.editButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.editButton.Location = New System.Drawing.Point(516, 296)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(73, 26)
        Me.editButton.TabIndex = 204
        Me.editButton.Text = "Editar"
        '
        'removeButton
        '
        Me.removeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.removeButton.Location = New System.Drawing.Point(595, 296)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(87, 26)
        Me.removeButton.TabIndex = 205
        Me.removeButton.Text = "Remover"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 293)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 90)
        Me.PictureBox1.TabIndex = 206
        Me.PictureBox1.TabStop = False
        '
        'listaReclamacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 388)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.NIFCliBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MotivoBox)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cancelarButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.numReclaBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comprasButton)
        Me.Controls.Add(Me.turnosButton)
        Me.Controls.Add(Me.encomendasButton)
        Me.Controls.Add(Me.produtosButton)
        Me.Controls.Add(Me.fornecedorButton)
        Me.Controls.Add(Me.clienteButton)
        Me.Controls.Add(Me.funcionarioButton)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "listaReclamacoes"
        Me.Text = "Lista de Reclamações"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cancelarButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents numReclaBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comprasButton As System.Windows.Forms.Button
    Friend WithEvents turnosButton As System.Windows.Forms.Button
    Friend WithEvents encomendasButton As System.Windows.Forms.Button
    Friend WithEvents produtosButton As System.Windows.Forms.Button
    Friend WithEvents fornecedorButton As System.Windows.Forms.Button
    Friend WithEvents clienteButton As System.Windows.Forms.Button
    Friend WithEvents funcionarioButton As System.Windows.Forms.Button
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MotivoBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NIFCliBox As System.Windows.Forms.TextBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
