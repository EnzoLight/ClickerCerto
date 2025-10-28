<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class telaJogador
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
        click_btn = New Button()
        contador_lbl = New Label()
        SuspendLayout()
        ' 
        ' click_btn
        ' 
        click_btn.Location = New Point(56, 308)
        click_btn.Name = "click_btn"
        click_btn.Size = New Size(300, 80)
        click_btn.TabIndex = 0
        click_btn.Text = "CLICAR"
        click_btn.UseVisualStyleBackColor = True
        ' 
        ' contador_lbl
        ' 
        contador_lbl.AutoSize = True
        contador_lbl.Location = New Point(28, 37)
        contador_lbl.Name = "contador_lbl"
        contador_lbl.Size = New Size(77, 15)
        contador_lbl.TabIndex = 1
        contador_lbl.Text = "CONTADOR: "
        ' 
        ' telaJogador
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(contador_lbl)
        Controls.Add(click_btn)
        Name = "telaJogador"
        Text = "telaJogadorNovo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents click_btn As Button
    Friend WithEvents contador_lbl As Label
End Class
