using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bibliotec.Classes.Materiais
{
    internal class TrabalhoGraduacao
    {
        private int id { get; set; }
        private string titulo { get; set; }
        private string palavraChave { get; set; }
        private string assunto { get; set; }
        private string localPublicacao { get; set; }
        private string dataPublicacao { get; set; }
        private string alunoRa { get; set; }
        private string subtitulo { get; set; }

        // Construtor vazio
        public TrabalhoGraduacao() { }

        // Construtor para cadastro
        public TrabalhoGraduacao(string titulo, string palavraChave, string assunto, string localPublicacao, string dataPublicacao, string alunoRa, string subtitulo)
        {
            this.titulo = titulo;
            this.palavraChave = palavraChave;
            this.assunto = assunto;
            this.localPublicacao = localPublicacao;
            this.dataPublicacao = dataPublicacao;
            this.alunoRa = alunoRa;
            this.subtitulo = subtitulo;
        }

        // Construtor para leitura com ID
        public TrabalhoGraduacao(int id, string titulo, string palavraChave, string assunto, string localPublicacao, string dataPublicacao, string alunoRa, string subtitulo)
        {
            this.id = id;
            this.titulo = titulo;
            this.palavraChave = palavraChave;
            this.assunto = assunto;
            this.localPublicacao = localPublicacao;
            this.dataPublicacao = dataPublicacao;
            this.alunoRa = alunoRa;
            this.subtitulo = subtitulo;
        }

        private string strConnection = "server=localhost;uid=root;password=root;database=db_bibliotec";

        // Método para cadastrar trabalho de graduação no banco de dados
        public void CadastrarTrabalhoGraduacao()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"INSERT INTO tb_trabalhos_graduacao (titulo, palavra_chave, assunto, local_publicacao, ano_publicacao, aluno_ra, subtitulo) " +
                                    $"VALUES ('{titulo}', '{palavraChave}', '{assunto}', '{localPublicacao}', '{dataPublicacao}', '{alunoRa}', '{subtitulo}')";
                    MySqlCommand insertTrabalhoGraduacao = new MySqlCommand(strSQL, conec);
                    insertTrabalhoGraduacao.ExecuteNonQuery();
                    MessageBox.Show("Trabalho de Graduação cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar trabalho de graduação: {ex.Message}");
                }
            }
        }

        // Método para consultar trabalho de graduação por ID
        public void ConsultarTrabalhoGraduacaoPorId(int id)
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"SELECT * FROM tb_trabalhos_graduacao WHERE id = {id}";
                    MySqlCommand selectTrabalhoGraduacao = new MySqlCommand(strSQL, conec);
                    MySqlDataReader reader = selectTrabalhoGraduacao.ExecuteReader();

                    while (reader.Read())
                    {
                        // Exemplo: Exibe dados no console
                        Console.WriteLine($"ID: {reader["id"]}, Título: {reader["titulo"]}, Aluno RA: {reader["aluno_ra"]}, Subtítulo: {reader["subtitulo"]}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar trabalho de graduação: {ex.Message}");
                }
            }
        }

        // Método para atualizar dados do trabalho de graduação
        public void AtualizarTrabalhoGraduacao(int id, string titulo, string palavraChave, string assunto, string localPublicacao, string dataPublicacao, string alunoRa, string subtitulo)
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"UPDATE tb_trabalhos_graduacao SET " +
                                    $"titulo = '{titulo}', " +
                                    $"palavra_chave = '{palavraChave}', " +
                                    $"assunto = '{assunto}', " +
                                    $"local_publicacao = '{localPublicacao}', " +
                                    $"ano_publicacao = '{dataPublicacao}', " +
                                    $"aluno_ra = '{alunoRa}', " +
                                    $"subtitulo = '{subtitulo}' " +
                                    $"WHERE id = {id}";
                    MySqlCommand updateTrabalhoGraduacao = new MySqlCommand(strSQL, conec);
                    updateTrabalhoGraduacao.ExecuteNonQuery();
                    MessageBox.Show("Trabalho de Graduação atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar trabalho de graduação: {ex.Message}");
                }
            }
        }

        // Método para excluir trabalho de graduação pelo ID
        public void ExcluirTrabalhoGraduacao(int id)
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"DELETE FROM tb_trabalhos_graduacao WHERE id = {id}";
                    MySqlCommand deleteTrabalhoGraduacao = new MySqlCommand(strSQL, conec);
                    deleteTrabalhoGraduacao.ExecuteNonQuery();
                    MessageBox.Show("Trabalho de Graduação excluído com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir trabalho de graduação: {ex.Message}");
                }
            }
        }

        public int PegarIdTgPeloTitulo(string titulo)
        {
            int idTg = 0;
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"SELECT id FROM tb_trabalhos_graduacao WHERE titulo = @titulo";
                    MySqlCommand selectSample = new MySqlCommand(strSQL, conec);
                    selectSample.Parameters.AddWithValue("@titulo", titulo);

                    MySqlDataReader reader = selectSample.ExecuteReader();

                    if (reader.Read())
                    {
                        idTg = Int32.Parse(reader["id"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Trabalho Graduação não encontrada.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar trabalho graduação: {ex.Message}");
                }
            }
            return idTg;
        }

        // Getters e Setters
        public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string GetAlunoRa()
        {
            return alunoRa;
        }

        public void SetAlunoRa(string alunoRa)
        {
            this.alunoRa = alunoRa;
        }

        public string GetSubtitulo()
        {
            return subtitulo;
        }

        public void SetSubtitulo(string subtitulo)
        {
            this.subtitulo = subtitulo;
        }
    }
}
