Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Module ConexaoBD
    Public conn As SqlConnection
    Public sql, diretorio As String
    Public count As Int64
    Public audio As Object
    Public nomeVozOpcional As String
    'Friend WithEvents cmb_Guiche As ComboBox

    ' 🔹 Conexão com o banco Azure SQL
    Sub Conecta_banco()
        Try
            Dim connStr As String = "Server=tcp:starlinex.database.windows.net,1433;" &
                                "Database=Clicker;" &
                                "User ID=sabicol;" &
                                "Password=colsabi12@;" &
                                "Encrypt=True;" &
                                "TrustServerCertificate=False;" &
                                "Connection Timeout=30;"

            conn = New SqlConnection(connStr)
            conn.Open()
            MsgBox("Conexão realizada com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Starline")

        Catch ex As Exception
            MsgBox("Erro na conexão" & Environment.NewLine & ex.ToString(), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "SQL SERVER")
        End Try
    End Sub

    Private loginValido As Boolean = False


    ' Modificar a função no Module conexaoDB
    ' NO MÓDULO ConexaoBD

    Function CarregarDadosUsuario(user_input As String, senha As String) As String
        Try
            ' 1. Modificar a query para selecionar ID, TIPO E CONTADOR
            Dim sqlSelect As String = "SELECT ID, TIPO, CONTADOR FROM USUARIOS WHERE (USERNAME = @user_input OR EMAIL = @user_input) AND SENHA = @senha"

            Using cmd As New SqlCommand(sqlSelect, conn)
                cmd.Parameters.AddWithValue("@user_input", user_input)
                cmd.Parameters.AddWithValue("@senha", senha)

                ' Usamos ExecuteReader para ler múltiplas colunas (ID, TIPO, CONTADOR)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' 2. LOGIN BEM-SUCEDIDO: SALVAR DADOS NA MEMÓRIA GLOBAL
                        EstadoGlobal.PlayerID = Convert.ToInt32(reader("ID"))
                        EstadoGlobal.PlayerScore = Convert.ToInt64(reader("CONTADOR"))

                        ' 3. Retornar o Tipo
                        Return reader("TIPO").ToString().ToUpper()
                    Else
                        ' Login falhou
                        EstadoGlobal.PlayerID = -1 ' Reseta o ID
                        Return ""
                    End If
                End Using ' Fecha o DataReader

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao obter dados do usuário: " & ex.Message)
            Return "ERRO"
        End Try
    End Function

    Sub InserirUsuario(nome As String, senha As String, tipo As String, email As String, username As String)
        Try
            Dim sqlInsert As String = "INSERT INTO USUARIOS (NOME, SENHA, TIPO, EMAIL, USERNAME) VALUES (@nome, @senha, @tipo, @email, @username)"
            Using cmd As New SqlCommand(sqlInsert, conn)
                cmd.Parameters.AddWithValue("@nome", nome)
                cmd.Parameters.AddWithValue("@senha", senha)
                cmd.Parameters.AddWithValue("@tipo", tipo)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@username", username)


                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Usuário inserido com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Else
                    MsgBox("Nenhum usuário inserido.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                End If
            End Using
        Catch ex As Exception
            MsgBox("Erro ao inserir usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Sub contarClicks()
        Try
            EstadoGlobal.PlayerScore += 1
        Catch ex As Exception
            MessageBox.Show("Erro ao contar o clique: " & ex.Message)
        End Try
    End Sub

    Sub AtualizarContadorDB()
        Try
            ' Obtém os dados do jogador logado (salvos em EstadoGlobal após o login)
            Dim playerID As Integer = EstadoGlobal.PlayerID
            Dim novaPontuacao As Int64 = EstadoGlobal.PlayerScore

            ' Comando SQL: Atualiza apenas o CONTADOR usando o ID do jogador
            Dim sqlUpdate As String = "UPDATE usuarios SET CONTADOR = @contador WHERE ID = @id"

            ' Usa a conexão pública do módulo ConexaoBD
            Using cmd As New SqlCommand(sqlUpdate, ConexaoBD.conn)
                cmd.Parameters.AddWithValue("@contador", novaPontuacao)
                cmd.Parameters.AddWithValue("@id", playerID)

                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar o contador no banco de dados: " & ex.Message, "Erro de Salvamento")
        End Try
    End Sub

    Sub atualizarClicks()

        ' Variáveis para uso na consulta
        Dim playerID As Integer = EstadoGlobal.PlayerID
        Dim novaPontuacao As Int64 = EstadoGlobal.PlayerScore

        'Verificação de Segurança (Garantir que há um jogador logado)
        If playerID <= 0 Then
            ' O ID é inválido, não tente atualizar
            MessageBox.Show("Erro: Nenhum jogador ativo para salvar a pontuação.", "Erro de Sessão")
            Return ' Sai da sub
        End If

        Try
            Dim sqlUpdate As String = "UPDATE usuarios SET contador = @pontuacao WHERE id = @id"

            Using cmd As New SqlCommand(sqlUpdate, ConexaoBD.conn)

                cmd.Parameters.AddWithValue("@pontuacao", novaPontuacao)
                cmd.Parameters.AddWithValue("@id", playerID)
                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao salvar a pontuação no banco de dados: " & ex.Message, "Erro de DB")
        End Try
    End Sub

    ' NO MÓDULO ConexaoBD.vb (ou onde está a conexão)

    Function ObterTodosUsuarios() As DataTable
        ' Cria uma tabela vazia para guardar os dados
        Dim dt As New DataTable()

        Try
            ' 1. Comando SQL para buscar todos os dados
            Dim sqlSelect As String = "SELECT * FROM usuarios ORDER BY id ASC"

            ' 2. Usa o DataAdapter para preencher o DataTable
            ' O SqlDataAdapter sabe como buscar e preencher a tabela
            Using adapter As New SqlDataAdapter(sqlSelect, conn)

                ' Certificar que a conexão está aberta, embora o DataAdapter geralmente lide com isso
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                ' Preenche o DataTable com os resultados da query
                adapter.Fill(dt)

            End Using ' O Using garante que o adapter seja descartado

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar lista de usuários: " & ex.Message, "Erro de DB")
        End Try

        Return dt ' Retorna a tabela preenchida
    End Function

    Sub AtualizarUsuario(id As Integer, nome As String, tipo As String, email As String, senha As String, contador As Int64)
        Try
            Dim sqlUpdate As String = "UPDATE usuarios SET nome = @nome, tipo = @tipo, email = @email, senha = @senha, contador = @contador WHERE id = @id"
            Using cmd As New SqlCommand(sqlUpdate, conn)
                cmd.Parameters.AddWithValue("@nome", nome)
                cmd.Parameters.AddWithValue("@tipo", tipo)
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@senha", senha)
                cmd.Parameters.AddWithValue("@contador", contador)
                cmd.Parameters.AddWithValue("@id", id)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Usuário atualizado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Else
                    MsgBox("Nenhum usuário atualizado.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                End If
            End Using
        Catch ex As Exception
            MsgBox("Erro ao atualizar usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Sub ExcluirUsuario(id As Integer)
        Try
            Dim sqlDelete As String = "DELETE FROM USUARIOS WHERE ID = @id"
            Using cmd As New SqlCommand(sqlDelete, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Usuário excluído com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                Else
                    MsgBox("Nenhum usuário excluído.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                End If
            End Using
        Catch ex As Exception
            MsgBox("Erro ao excluir usuário: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Module
