<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listaCompras))
        Me.removeButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.cancelarButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.funcComprasBox = New System.Windows.Forms.TextBox()
        Me.formaPagBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nomeComprasBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dataCompraBox = New System.Windows.Forms.TextBox()
        Me.numCompraBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reclamacoesButton = New System.Windows.Forms.Button()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NIFComprasBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'removeButton
        '
        Me.removeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.removeButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.removeButton.Location = New System.Drawing.Point(557, 312)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(87, 26)
        Me.removeButton.TabIndex = 173
        Me.removeButton.Text = "Remover"
        '
        'editButton
        '
        Me.editButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.editButton.Location = New System.Drawing.Point(478, 312)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(73, 26)
        Me.editButton.TabIndex = 172
        Me.editButton.Text = "Editar"
        '
        'addButton
        '
        Me.addButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addButton.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.addButton.Location = New System.Drawing.Point(382, 312)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(92, 26)
        Me.addButton.TabIndex = 171
        Me.addButton.Text = "Adicionar"
        '
        'cancelarButton
        '
        Me.cancelarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelarButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.cancelarButton.Location = New System.Drawing.Point(521, 263)
        Me.cancelarButton.Name = "cancelarButton"
        Me.cancelarButton.Size = New System.Drawing.Size(91, 26)
        Me.cancelarButton.TabIndex = 170
        Me.cancelarButton.Text = "Cancelar"
        Me.cancelarButton.Visible = False
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.OKButton.Location = New System.Drawing.Point(423, 263)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(92, 26)
        Me.OKButton.TabIndex = 169
        Me.OKButton.Text = "OK"
        Me.OKButton.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(379, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "NºFuncionário Responsável"
        '
        'funcComprasBox
        '
        Me.funcComprasBox.Location = New System.Drawing.Point(382, 204)
        Me.funcComprasBox.Name = "funcComprasBox"
        Me.funcComprasBox.Size = New System.Drawing.Size(40, 20)
        Me.funcComprasBox.TabIndex = 167
        '
        'formaPagBox
        '
        Me.formaPagBox.Location = New System.Drawing.Point(478, 55)
        Me.formaPagBox.Name = "formaPagBox"
        Me.formaPagBox.Size = New System.Drawing.Size(105, 20)
        Me.formaPagBox.TabIndex = 166
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(475, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Forma de pagamento"
        '
        'nomeComprasBox
        '
        Me.nomeComprasBox.Location = New System.Drawing.Point(543, 127)
        Me.nomeComprasBox.Name = "nomeComprasBox"
        Me.nomeComprasBox.Size = New System.Drawing.Size(97, 20)
        Me.nomeComprasBox.TabIndex = 164
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(540, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Produtos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(379, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Data"
        '
        'dataCompraBox
        '
        Me.dataCompraBox.Location = New System.Drawing.Point(382, 127)
        Me.dataCompraBox.Name = "dataCompraBox"
        Me.dataCompraBox.Size = New System.Drawing.Size(106, 20)
        Me.dataCompraBox.TabIndex = 161
        '
        'numCompraBox
        '
        Me.numCompraBox.Location = New System.Drawing.Point(382, 55)
        Me.numCompraBox.Name = "numCompraBox"
        Me.numCompraBox.Size = New System.Drawing.Size(40, 20)
        Me.numCompraBox.TabIndex = 160
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "NºCompra"
        '
        'reclamacoesButton
        '
        Me.reclamacoesButton.Location = New System.Drawing.Point(9, 246)
        Me.reclamacoesButton.Name = "reclamacoesButton"
        Me.reclamacoesButton.Size = New System.Drawing.Size(86, 23)
        Me.reclamacoesButton.TabIndex = 158
        Me.reclamacoesButton.Text = "Reclamações"
        Me.reclamacoesButton.UseVisualStyleBackColor = True
        '
        'turnosButton
        '
        Me.turnosButton.Location = New System.Drawing.Point(9, 217)
        Me.turnosButton.Name = "turnosButton"
        Me.turnosButton.Size = New System.Drawing.Size(86, 23)
        Me.turnosButton.TabIndex = 157
        Me.turnosButton.Text = "Turnos"
        Me.turnosButton.UseVisualStyleBackColor = True
        '
        'encomendasButton
        '
        Me.encomendasButton.Location = New System.Drawing.Point(9, 188)
        Me.encomendasButton.Name = "encomendasButton"
        Me.encomendasButton.Size = New System.Drawing.Size(86, 23)
        Me.encomendasButton.TabIndex = 156
        Me.encomendasButton.Text = "Encomendas"
        Me.encomendasButton.UseVisualStyleBackColor = True
        '
        'produtosButton
        '
        Me.produtosButton.Location = New System.Drawing.Point(9, 156)
        Me.produtosButton.Name = "produtosButton"
        Me.produtosButton.Size = New System.Drawing.Size(86, 23)
        Me.produtosButton.TabIndex = 155
        Me.produtosButton.Text = "Produtos"
        Me.produtosButton.UseVisualStyleBackColor = True
        '
        'fornecedorButton
        '
        Me.fornecedorButton.Location = New System.Drawing.Point(9, 127)
        Me.fornecedorButton.Name = "fornecedorButton"
        Me.fornecedorButton.Size = New System.Drawing.Size(86, 23)
        Me.fornecedorButton.TabIndex = 154
        Me.fornecedorButton.Text = "Fornecedores"
        Me.fornecedorButton.UseVisualStyleBackColor = True
        '
        'clienteButton
        '
        Me.clienteButton.Location = New System.Drawing.Point(9, 98)
        Me.clienteButton.Name = "clienteButton"
        Me.clienteButton.Size = New System.Drawing.Size(86, 23)
        Me.clienteButton.TabIndex = 153
        Me.clienteButton.Text = "Clientes"
        Me.clienteButton.UseVisualStyleBackColor = True
        '
        'funcionarioButton
        '
        Me.funcionarioButton.Location = New System.Drawing.Point(9, 69)
        Me.funcionarioButton.Name = "funcionarioButton"
        Me.funcionarioButton.Size = New System.Drawing.Size(86, 23)
        Me.funcionarioButton.TabIndex = 152
        Me.funcionarioButton.Text = "Funcionários"
        Me.funcionarioButton.UseVisualStyleBackColor = True
        '
        'MenuButton
        '
        Me.MenuButton.Location = New System.Drawing.Point(9, 40)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(86, 23)
        Me.MenuButton.TabIndex = 151
        Me.MenuButton.Text = "Menu Principal"
        Me.MenuButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(655, 24)
        Me.MenuStrip1.TabIndex = 150
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
        Me.ListBox1.Location = New System.Drawing.Point(101, 40)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(263, 298)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 149
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(540, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "NIF Cliente"
        '
        'NIFComprasBox
        '
        Me.NIFComprasBox.Location = New System.Drawing.Point(543, 204)
        Me.NIFComprasBox.Name = "NIFComprasBox"
        Me.NIFComprasBox.Size = New System.Drawing.Size(97, 20)
        Me.NIFComprasBox.TabIndex = 175
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 298)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 90)
        Me.PictureBox1.TabIndex = 176
        Me.PictureBox1.TabStop = False
        '
        'listaCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 413)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NIFComprasBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.cancelarButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.funcComprasBox)
        Me.Controls.Add(Me.formaPagBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nomeComprasBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dataCompraBox)
        Me.Controls.Add(Me.numCompraBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.reclamacoesButton)
        Me.Controls.Add(Me.turnosButton)
        Me.Controls.Add(Me.encomendasButton)
        Me.Controls.Add(Me.produtosButton)
        Me.Controls.Add(Me.fornecedorButton)
        Me.Controls.Add(Me.clienteButton)
        Me.Controls.Add(Me.funcionarioButton)
        Me.Controls.Add(Me.MenuButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "listaCompras"
        Me.Text = "Lista de Compras"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents cancelarButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents funcComprasBox As System.Windows.Forms.TextBox
    Friend WithEvents formaPagBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nomeComprasBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dataCompraBox As System.Windows.Forms.TextBox
    Friend WithEvents numCompraBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents reclamacoesButton As System.Windows.Forms.Button
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NIFComprasBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
