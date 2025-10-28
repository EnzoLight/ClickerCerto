Public Class TelaCadastroADM
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        InserirUsuario(nome_txt.Text, senha_txt.Text, tipo_cmb.Text, email_txt.Text, username_txt.Text)
        Me.Hide()
        Login.Show()
    End Sub
End Class