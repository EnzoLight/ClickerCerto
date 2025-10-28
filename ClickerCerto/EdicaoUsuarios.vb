Public Class EdicaoUsuarios
    Private Sub EdicaoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Conecta_banco()
        users_grid.DataSource = ConexaoBD.ObterTodosUsuarios()
    End Sub


    ' NO ARQUIVO DO FORMULÁRIO (Ex: EdicaoUsuarios.vb)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If users_grid.SelectedRows.Count = 0 Then
            MessageBox.Show("Selecione a linha do usuário que deseja excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBox.Show("Confirma a exclusão do usuário selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            Try
                If ConexaoBD.conn.State <> ConnectionState.Open Then
                    ConexaoBD.Conecta_banco()
                End If

                Dim idParaExcluir As Integer = Convert.ToInt32(users_grid.SelectedRows(0).Cells("id").Value)

                ConexaoBD.ExcluirUsuario(idParaExcluir)

                users_grid.DataSource = ConexaoBD.ObterTodosUsuarios()

            Catch ex As Exception
                MessageBox.Show("Erro ao excluir: " & ex.Message, "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub users_grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles users_grid.CellEndEdit
        Try
            If ConexaoBD.conn.State <> ConnectionState.Open Then
                ConexaoBD.Conecta_banco()
            End If

            ' Obtém a linha editada
            Dim row As DataGridViewRow = users_grid.Rows(e.RowIndex)

            ' Recupera os valores editados (Nomes de coluna corrigidos: "id", "nome", etc.)
            Dim id As Integer = Convert.ToInt32(row.Cells("id").Value)
            Dim nome As String = row.Cells("nome").Value.ToString()
            Dim tipo As String = row.Cells("tipo").Value.ToString()
            Dim email As String = row.Cells("email").Value.ToString()
            Dim senha As String = row.Cells("senha").Value.ToString()
            Dim contador As Long = Convert.ToInt64(row.Cells("contador").Value)

            ConexaoBD.AtualizarUsuario(id, nome, tipo, email, senha, contador)

            users_grid.DataSource = ConexaoBD.ObterTodosUsuarios()

        Catch ex As Exception
            MsgBox("Erro ao editar usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

End Class