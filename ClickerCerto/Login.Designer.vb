<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label2 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        user_txt = New TextBox()
        senha_txt = New TextBox()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(123, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 15)
        Label2.TabIndex = 1
        Label2.Text = "Username/Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(144, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 3
        Label4.Text = "Senha"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(256, 311)
        Button1.Name = "Button1"
        Button1.Size = New Size(268, 76)
        Button1.TabIndex = 4
        Button1.Text = "Entrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' user_txt
        ' 
        user_txt.Location = New Point(230, 142)
        user_txt.Name = "user_txt"
        user_txt.Size = New Size(253, 23)
        user_txt.TabIndex = 5
        ' 
        ' senha_txt
        ' 
        senha_txt.Location = New Point(230, 175)
        senha_txt.Name = "senha_txt"
        senha_txt.Size = New Size(253, 23)
        senha_txt.TabIndex = 6
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(225, 226)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(69, 15)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Registrar-se"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LinkLabel1)
        Controls.Add(senha_txt)
        Controls.Add(user_txt)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents user_txt As TextBox
    Friend WithEvents senha_txt As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
