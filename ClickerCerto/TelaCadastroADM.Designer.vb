<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaCadastroADM
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btn_cadastrar = New Button()
        nome_txt = New TextBox()
        username_txt = New TextBox()
        email_txt = New TextBox()
        senha_txt = New TextBox()
        tipo_cmb = New ComboBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(98, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nome:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(98, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 1
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(98, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 2
        Label3.Text = "Email:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(98, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 3
        Label4.Text = "Senha:"
        ' 
        ' btn_cadastrar
        ' 
        btn_cadastrar.Location = New Point(179, 273)
        btn_cadastrar.Name = "btn_cadastrar"
        btn_cadastrar.Size = New Size(253, 65)
        btn_cadastrar.TabIndex = 4
        btn_cadastrar.Text = "CADASTRAR"
        btn_cadastrar.UseVisualStyleBackColor = True
        ' 
        ' nome_txt
        ' 
        nome_txt.Location = New Point(172, 71)
        nome_txt.Name = "nome_txt"
        nome_txt.Size = New Size(363, 23)
        nome_txt.TabIndex = 5
        ' 
        ' username_txt
        ' 
        username_txt.Location = New Point(172, 108)
        username_txt.Name = "username_txt"
        username_txt.Size = New Size(363, 23)
        username_txt.TabIndex = 6
        ' 
        ' email_txt
        ' 
        email_txt.Location = New Point(172, 143)
        email_txt.Name = "email_txt"
        email_txt.Size = New Size(363, 23)
        email_txt.TabIndex = 7
        ' 
        ' senha_txt
        ' 
        senha_txt.Location = New Point(172, 179)
        senha_txt.Name = "senha_txt"
        senha_txt.Size = New Size(363, 23)
        senha_txt.TabIndex = 8
        ' 
        ' tipo_cmb
        ' 
        tipo_cmb.FormattingEnabled = True
        tipo_cmb.Items.AddRange(New Object() {"ADM", "JOGADOR"})
        tipo_cmb.Location = New Point(157, 222)
        tipo_cmb.Name = "tipo_cmb"
        tipo_cmb.Size = New Size(378, 23)
        tipo_cmb.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(106, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 15)
        Label5.TabIndex = 20
        Label5.Text = "Tipo:"
        ' 
        ' TelaCadastroADM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tipo_cmb)
        Controls.Add(Label5)
        Controls.Add(senha_txt)
        Controls.Add(email_txt)
        Controls.Add(username_txt)
        Controls.Add(nome_txt)
        Controls.Add(btn_cadastrar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "TelaCadastroADM"
        Text = "TelaCadastroADM"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents nome_txt As TextBox
    Friend WithEvents username_txt As TextBox
    Friend WithEvents email_txt As TextBox
    Friend WithEvents senha_txt As TextBox
    Friend WithEvents tipo_cmb As ComboBox
    Friend WithEvents Label5 As Label
End Class
