<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listaClientes))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NomeClienteBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CCClienteBox = New System.Windows.Forms.TextBox()
        Me.NIFClienteBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MoradaClienteBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TelefoneClienteBox = New System.Windows.Forms.TextBox()
        Me.MenuButton = New System.Windows.Forms.Button()
        Me.funcionarioButton = New System.Windows.Forms.Button()
        Me.fornecedorButton = New System.Windows.Forms.Button()
        Me.produtosButton = New System.Windows.Forms.Button()
        Me.encomendasButton = New System.Windows.Forms.Button()
        Me.comprasButton = New System.Windows.Forms.Button()
        Me.turnosButton = New System.Windows.Forms.Button()
        Me.reclamacoesButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.cancelarButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(101, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(237, 298)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 108
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(629, 24)
        Me.MenuStrip1.TabIndex = 109
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "Nome"
        '
        'NomeClienteBox
        '
        Me.NomeClienteBox.Location = New System.Drawing.Point(348, 52)
        Me.NomeClienteBox.Name = "NomeClienteBox"
        Me.NomeClienteBox.Size = New System.Drawing.Size(156, 20)
        Me.NomeClienteBox.TabIndex = 111
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(348, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "CC"
        '
        'CCClienteBox
        '
        Me.CCClienteBox.Location = New System.Drawing.Point(348, 109)
        Me.CCClienteBox.Name = "CCClienteBox"
        Me.CCClienteBox.Size = New System.Drawing.Size(100, 20)
        Me.CCClienteBox.TabIndex = 113
        '
        'NIFClienteBox
        '
        Me.NIFClienteBox.Location = New System.Drawing.Point(483, 109)
        Me.NIFClienteBox.Name = "NIFClienteBox"
        Me.NIFClienteBox.Size = New System.Drawing.Size(100, 20)
        Me.NIFClienteBox.TabIndex = 114
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "NIF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(345, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "Morada"
        '
        'MoradaClienteBox
        '
        Me.MoradaClienteBox.Location = New System.Drawing.Point(348, 172)
        Me.MoradaClienteBox.Name = "MoradaClienteBox"
        Me.MoradaClienteBox.Size = New System.Drawing.Size(156, 20)
        Me.MoradaClienteBox.TabIndex = 117
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(348, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Telefone"
        '
        'TelefoneClienteBox
        '
        Me.TelefoneClienteBox.Location = New System.Drawing.Point(348, 235)
        Me.TelefoneClienteBox.Name = "TelefoneClienteBox"
        Me.TelefoneClienteBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefoneClienteBox.TabIndex = 119
        '
        'MenuButton
        '
        Me.MenuButton.Location = New System.Drawing.Point(9, 35)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(86, 23)
        Me.MenuButton.TabIndex = 120
        Me.MenuButton.Text = "Menu Principal"
        Me.MenuButton.UseVisualStyleBackColor = True
        '
        'funcionarioButton
        '
        Me.funcionarioButton.Location = New System.Drawing.Point(9, 64)
        Me.funcionarioButton.Name = "funcionarioButton"
        Me.funcionarioButton.Size = New System.Drawing.Size(86, 23)
        Me.funcionarioButton.TabIndex = 121
        Me.funcionarioButton.Text = "Funcionários"
        Me.funcionarioButton.UseVisualStyleBackColor = True
        '
        'fornecedorButton
        '
        Me.fornecedorButton.Location = New System.Drawing.Point(9, 93)
        Me.fornecedorButton.Name = "fornecedorButton"
        Me.fornecedorButton.Size = New System.Drawing.Size(86, 23)
        Me.fornecedorButton.TabIndex = 122
        Me.fornecedorButton.Text = "Fornecedores"
        Me.fornecedorButton.UseVisualStyleBackColor = True
        '
        'produtosButton
        '
        Me.produtosButton.Location = New System.Drawing.Point(9, 122)
        Me.produtosButton.Name = "produtosButton"
        Me.produtosButton.Size = New System.Drawing.Size(86, 23)
        Me.produtosButton.TabIndex = 123
        Me.produtosButton.Text = "Produtos"
        Me.produtosButton.UseVisualStyleBackColor = True
        '
        'encomendasButton
        '
        Me.encomendasButton.Location = New System.Drawing.Point(9, 151)
        Me.encomendasButton.Name = "encomendasButton"
        Me.encomendasButton.Size = New System.Drawing.Size(86, 23)
        Me.encomendasButton.TabIndex = 124
        Me.encomendasButton.Text = "Encomendas"
        Me.encomendasButton.UseVisualStyleBackColor = True
        '
        'comprasButton
        '
        Me.comprasButton.Location = New System.Drawing.Point(9, 180)
        Me.comprasButton.Name = "comprasButton"
        Me.comprasButton.Size = New System.Drawing.Size(86, 23)
        Me.comprasButton.TabIndex = 125
        Me.comprasButton.Text = "Compras"
        Me.comprasButton.UseVisualStyleBackColor = True
        '
        'turnosButton
        '
        Me.turnosButton.Location = New System.Drawing.Point(9, 209)
        Me.turnosButton.Name = "turnosButton"
        Me.turnosButton.Size = New System.Drawing.Size(86, 23)
        Me.turnosButton.TabIndex = 126
        Me.turnosButton.Text = "Turnos"
        Me.turnosButton.UseVisualStyleBackColor = True
        '
        'reclamacoesButton
        '
        Me.reclamacoesButton.Location = New System.Drawing.Point(9, 238)
        Me.reclamacoesButton.Name = "reclamacoesButton"
        Me.reclamacoesButton.Size = New System.Drawing.Size(86, 23)
        Me.reclamacoesButton.TabIndex = 127
        Me.reclamacoesButton.Text = "Reclamações"
        Me.reclamacoesButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.OKButton.Location = New System.Drawing.Point(394, 274)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(92, 26)
        Me.OKButton.TabIndex = 128
        Me.OKButton.Text = "OK"
        Me.OKButton.Visible = False
        '
        'cancelarButton
        '
        Me.cancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelarButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cancelarButton.Location = New System.Drawing.Point(492, 274)
        Me.cancelarButton.Name = "cancelarButton"
        Me.cancelarButton.Size = New System.Drawing.Size(91, 26)
        Me.cancelarButton.TabIndex = 129
        Me.cancelarButton.Text = "Cancelar"
        Me.cancelarButton.Visible = False
        '
        'addButton
        '
        Me.addButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.addButton.Location = New System.Drawing.Point(350, 307)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(92, 26)
        Me.addButton.TabIndex = 130
        Me.addButton.Text = "Adicionar"
        '
        'editButton
        '
        Me.editButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.editButton.Location = New System.Drawing.Point(448, 307)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(73, 26)
        Me.editButton.TabIndex = 131
        Me.editButton.Text = "Editar"
        '
        'removeButton
        '
        Me.removeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.removeButton.Location = New System.Drawing.Point(527, 307)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(87, 26)
        Me.removeButton.TabIndex = 132
        Me.removeButton.Text = "Remover"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 304)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 90)
        Me.PictureBox1.TabIndex = 153
        Me.PictureBox1.TabStop = False
        '
        'listaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 399)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.cancelarButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.reclamacoesButton)
        Me.Controls.Add(Me.turnosButton)
        Me.Controls.Add(Me.comprasButton)
        Me.Controls.Add(Me.encomendasButton)
        Me.Controls.Add(Me.produtosButton)
        Me.Controls.Add(Me.fornecedorButton)
        Me.Controls.Add(Me.funcionarioButton)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.TelefoneClienteBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MoradaClienteBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NIFClienteBox)
        Me.Controls.Add(Me.CCClienteBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NomeClienteBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "listaClientes"
        Me.Text = "Lista de Clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarregarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NomeClienteBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CCClienteBox As System.Windows.Forms.TextBox
    Friend WithEvents NIFClienteBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MoradaClienteBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TelefoneClienteBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuButton As System.Windows.Forms.Button
    Friend WithEvents funcionarioButton As System.Windows.Forms.Button
    Friend WithEvents fornecedorButton As System.Windows.Forms.Button
    Friend WithEvents produtosButton As System.Windows.Forms.Button
    Friend WithEvents encomendasButton As System.Windows.Forms.Button
    Friend WithEvents comprasButton As System.Windows.Forms.Button
    Friend WithEvents turnosButton As System.Windows.Forms.Button
    Friend WithEvents reclamacoesButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents cancelarButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
