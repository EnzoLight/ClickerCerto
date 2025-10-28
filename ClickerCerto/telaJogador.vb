Public Class telaJogador
    Private Sub click_btn_Click(sender As Object, e As EventArgs) Handles click_btn.Click

        contarClicks()

        contador_lbl.Text = "CONTADOR: " & EstadoGlobal.PlayerScore.ToString()

        Try
            If ConexaoBD.conn.State <> ConnectionState.Open Then
                ConexaoBD.Conecta_banco()
            End If

            ' Chama a função que salva no BD
            ConexaoBD.AtualizarContadorDB()

        Catch ex As Exception
            MessageBox.Show("Não foi possível salvar o progresso: " & ex.Message, "Erro de DB")
        End Try
    End Sub

    ' NO FORMULÁRIO user.vb

    Private Sub telaJogador(sender As Object, e As EventArgs) Handles MyBase.Load
        If EstadoGlobal.PlayerID <> -1 Then
            contador_lbl.Text = "CONTADOR: " & EstadoGlobal.PlayerScore.ToString()
        End If
    End Sub

End Class