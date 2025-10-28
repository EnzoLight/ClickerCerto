Public Class TelaCadastro
    Private Sub tipo_cmb_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        InserirUsuario(nome_txt.Text, senha_txt.Text, "JOGADOR", email_txt.Text, username_txt.Text)
        Me.Hide()
        Login.Show()
    End Sub
End Class