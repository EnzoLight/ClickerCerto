<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaCadastro
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
        senha_txt = New TextBox()
        email_txt = New TextBox()
        username_txt = New TextBox()
        nome_txt = New TextBox()
        btn_cadastrar = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' senha_txt
        ' 
        senha_txt.Location = New Point(166, 161)
        senha_txt.Name = "senha_txt"
        senha_txt.Size = New Size(363, 23)
        senha_txt.TabIndex = 17
        ' 
        ' email_txt
        ' 
        email_txt.Location = New Point(166, 125)
        email_txt.Name = "email_txt"
        email_txt.Size = New Size(363, 23)
        email_txt.TabIndex = 16
        ' 
        ' username_txt
        ' 
        username_txt.Location = New Point(166, 90)
        username_txt.Name = "username_txt"
        username_txt.Size = New Size(363, 23)
        username_txt.TabIndex = 15
        ' 
        ' nome_txt
        ' 
        nome_txt.Location = New Point(166, 53)
        nome_txt.Name = "nome_txt"
        nome_txt.Size = New Size(363, 23)
        nome_txt.TabIndex = 14
        ' 
        ' btn_cadastrar
        ' 
        btn_cadastrar.Location = New Point(166, 288)
        btn_cadastrar.Name = "btn_cadastrar"
        btn_cadastrar.Size = New Size(253, 65)
        btn_cadastrar.TabIndex = 13
        btn_cadastrar.Text = "CADASTRAR"
        btn_cadastrar.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(92, 164)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 12
        Label4.Text = "Senha:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(92, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 11
        Label3.Text = "Email:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(92, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 10
        Label2.Text = "Username:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(92, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 9
        Label1.Text = "Nome:"
        ' 
        ' TelaCadastro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(senha_txt)
        Controls.Add(email_txt)
        Controls.Add(username_txt)
        Controls.Add(nome_txt)
        Controls.Add(btn_cadastrar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "TelaCadastro"
        Text = "TelaCadastro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents senha_txt As TextBox
    Friend WithEvents email_txt As TextBox
    Friend WithEvents username_txt As TextBox
    Friend WithEvents nome_txt As TextBox
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
