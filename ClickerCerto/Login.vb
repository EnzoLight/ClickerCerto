Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim user_input As String = user_txt.Text
        Dim senha_input As String = senha_txt.Text

        Dim tipo As String = ConexaoBD.CarregarDadosUsuario(user_input, senha_input)

        If tipo = "JOGADOR" Then

            ' Abre a tela do Jogador
            Me.Hide()
            Dim telaJogadorNovo As New telaJogador()
            telaJogadorNovo.Show()

        ElseIf tipo = "ADM" Then

            ' Abre a tela do Administrador
            Me.Hide()
            Dim telaAdmNova As New AreaADM()
            telaAdmNova.Show()

        ElseIf tipo = "" Then
            ' Login falhou (Usuário/Senha incorretos)
            MessageBox.Show("Credenciais inválidas. Tente novamente.", "Login Falhou")

        ElseIf tipo = "ERRO" Then
            ' Erro na conexão com o banco ou na query
            MessageBox.Show("Não foi possível processar o login devido a um erro no sistema.", "Erro Crítico")

        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class