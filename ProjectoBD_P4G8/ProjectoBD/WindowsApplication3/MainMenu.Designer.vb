<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.FuncionarioButton = New System.Windows.Forms.Button()
        Me.clientesButton = New System.Windows.Forms.Button()
        Me.fornecedorButton = New System.Windows.Forms.Button()
        Me.produtosButton = New System.Windows.Forms.Button()
        Me.encomendasButton = New System.Windows.Forms.Button()
        Me.comprasButton = New System.Windows.Forms.Button()
        Me.turnosButton = New System.Windows.Forms.Button()
        Me.reclamacoesButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FuncionarioButton
        '
        Me.FuncionarioButton.Font = New System.Drawing.Font("Tunga", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuncionarioButton.Location = New System.Drawing.Point(40, 34)
        Me.FuncionarioButton.Name = "FuncionarioButton"
        Me.FuncionarioButton.Size = New System.Drawing.Size(104, 36)
        Me.FuncionarioButton.TabIndex = 0
        Me.FuncionarioButton.Text = "Funcionários"
        Me.FuncionarioButton.UseVisualStyleBackColor = True
        '
        'clientesButton
        '
        Me.clientesButton.Font = New System.Drawing.Font("Tunga", 12.5!)
        Me.clientesButton.Location = New System.Drawing.Point(221, 34)
        Me.clientesButton.Name = "clientesButton"
        Me.clientesButton.Size = New System.Drawing.Size(104, 36)
        Me.clientesButton.TabIndex = 1
        Me.clientesButton.Text = "Clientes"
        Me.clientesButton.UseVisualStyleBackColor = True
        '
        'fornecedorButton
        '
        Me.fornecedorButton.Font = New System.Drawing.Font("Tunga", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fornecedorButton.Location = New System.Drawing.Point(40, 98)
        Me.fornecedorButton.Name = "fornecedorButton"
        Me.fornecedorButton.Size = New System.Drawing.Size(104, 36)
        Me.fornecedorButton.TabIndex = 2
        Me.fornecedorButton.Text = "Fornecedores"
        Me.fornecedorButton.UseVisualStyleBackColor = True
        '
        'produtosButton
        '
        Me.produtosButton.Font = New System.Drawing.Font("Tunga", 12.5!)
        Me.produtosButton.Location = New System.Drawing.Point(221, 98)
        Me.produtosButton.Name = "produtosButton"
        Me.produtosButton.Size = New System.Drawing.Size(104, 36)
        Me.produtosButton.TabIndex = 3
        Me.produtosButton.Text = "Produtos"
        Me.produtosButton.UseVisualStyleBackColor = True
        '
        'encomendasButton
        '
        Me.encomendasButton.Font = New System.Drawing.Font("Tunga", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.encomendasButton.Location = New System.Drawing.Point(40, 162)
        Me.encomendasButton.Name = "encomendasButton"
        Me.encomendasButton.Size = New System.Drawing.Size(104, 36)
        Me.encomendasButton.TabIndex = 4
        Me.encomendasButton.Text = "Encomendas"
        Me.encomendasButton.UseVisualStyleBackColor = True
        '
        'comprasButton
        '
        Me.comprasButton.Font = New System.Drawing.Font("Tunga", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comprasButton.Location = New System.Drawing.Point(221, 162)
        Me.comprasButton.Name = "comprasButton"
        Me.comprasButton.Size = New System.Drawing.Size(104, 36)
        Me.comprasButton.TabIndex = 5
        Me.comprasButton.Text = "Compras"
        Me.comprasButton.UseVisualStyleBackColor = True
        '
        'turnosButton
        '
        Me.turnosButton.Font = New System.Drawing.Font("Tunga", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.turnosButton.Location = New System.Drawing.Point(40, 224)
        Me.turnosButton.Name = "turnosButton"
        Me.turnosButton.Size = New System.Drawing.Size(104, 36)
        Me.turnosButton.TabIndex = 6
        Me.turnosButton.Text = "Turnos"
        Me.turnosButton.UseVisualStyleBackColor = True
        '
        'reclamacoesButton
        '
        Me.reclamacoesButton.Font = New System.Drawing.Font("Tunga", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reclamacoesButton.Location = New System.Drawing.Point(221, 224)
        Me.reclamacoesButton.Name = "reclamacoesButton"
        Me.reclamacoesButton.Size = New System.Drawing.Size(104, 36)
        Me.reclamacoesButton.TabIndex = 7
        Me.reclamacoesButton.Text = "Reclamações"
        Me.reclamacoesButton.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(368, 311)
        Me.Controls.Add(Me.reclamacoesButton)
        Me.Controls.Add(Me.turnosButton)
        Me.Controls.Add(Me.comprasButton)
        Me.Controls.Add(Me.encomendasButton)
        Me.Controls.Add(Me.produtosButton)
        Me.Controls.Add(Me.fornecedorButton)
        Me.Controls.Add(Me.clientesButton)
        Me.Controls.Add(Me.FuncionarioButton)
        Me.Name = "MainMenu"
        Me.Text = "Gestão de um café"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FuncionarioButton As System.Windows.Forms.Button
    Friend WithEvents clientesButton As System.Windows.Forms.Button
    Friend WithEvents fornecedorButton As System.Windows.Forms.Button
    Friend WithEvents produtosButton As System.Windows.Forms.Button
    Friend WithEvents encomendasButton As System.Windows.Forms.Button
    Friend WithEvents comprasButton As System.Windows.Forms.Button
    Friend WithEvents turnosButton As System.Windows.Forms.Button
    Friend WithEvents reclamacoesButton As System.Windows.Forms.Button
End Class
