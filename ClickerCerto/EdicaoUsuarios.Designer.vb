<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EdicaoUsuarios
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        users_grid = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        nome = New DataGridViewTextBoxColumn()
        username = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        senha = New DataGridViewTextBoxColumn()
        contador = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        CType(users_grid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' users_grid
        ' 
        users_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        users_grid.Columns.AddRange(New DataGridViewColumn() {id, nome, username, email, senha, contador})
        users_grid.Location = New Point(84, 44)
        users_grid.Name = "users_grid"
        users_grid.Size = New Size(643, 290)
        users_grid.TabIndex = 0
        ' 
        ' id
        ' 
        id.DataPropertyName = "id"
        id.HeaderText = "ID"
        id.Name = "id"
        ' 
        ' nome
        ' 
        nome.DataPropertyName = "nome"
        nome.HeaderText = "NOME"
        nome.Name = "nome"
        ' 
        ' username
        ' 
        username.DataPropertyName = "username"
        username.HeaderText = "USERNAME"
        username.Name = "username"
        ' 
        ' email
        ' 
        email.DataPropertyName = "email"
        email.HeaderText = "E-MAIL"
        email.Name = "email"
        ' 
        ' senha
        ' 
        senha.DataPropertyName = "senha"
        senha.HeaderText = "SENHA"
        senha.Name = "senha"
        ' 
        ' contador
        ' 
        contador.DataPropertyName = "contador"
        contador.HeaderText = "CONTADOR"
        contador.Name = "contador"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(279, 365)
        Button1.Name = "Button1"
        Button1.Size = New Size(255, 57)
        Button1.TabIndex = 1
        Button1.Text = "EXCLUIR USUARIO"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' EdicaoUsuarios
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(users_grid)
        Name = "EdicaoUsuarios"
        Text = "EdicaoUsuarios"
        CType(users_grid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents users_grid As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents senha As DataGridViewTextBoxColumn
    Friend WithEvents contador As DataGridViewTextBoxColumn
End Class
