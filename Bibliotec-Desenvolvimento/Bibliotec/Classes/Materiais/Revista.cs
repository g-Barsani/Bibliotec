using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bibliotec.Classes.Materiais
{
    internal class Revista
    {
        private int id { get; set; }
        private string titulo { get; set; }
        private string palavraChave { get; set; }
        private string assunto { get; set; }
        private string localPublicacao { get; set; }
        private string dataPublicacao { get; set; }
        private string editora { get; set; }
        private string edicao { get; set; }
        private string genero { get; set; }

        // Construtor vazio
        public Revista() { }

        // Construtor para cadastro
        public Revista(string titulo, string palavraChave, string assunto, string localPublicacao, string dataPublicacao, string editora, string edicao, string genero)
        {
            this.titulo = titulo;
            this.palavraChave = palavraChave;
            this.assunto = assunto;
            this.localPublicacao = localPublicacao;
            this.dataPublicacao = dataPublicacao;
            this.editora = editora;
            this.edicao = edicao;
            this.genero = genero;
        }

        // Construtor para leitura com ID
        public Revista(int id, string titulo, string palavraChave, string assunto, string localPublicacao, string dataPublicacao, string editora, string edicao, string genero)
        {
            this.id = id;
            this.titulo = titulo;
            this.palavraChave = palavraChave;
            this.assunto = assunto;
            this.localPublicacao = localPublicacao;
            this.dataPublicacao = dataPublicacao;
            this.editora = editora;
            this.edicao = edicao;
            this.genero = genero;
        }

        private string strConnection = "server=localhost;uid=root;password=root;database=db_bibliotec";

        // Método para cadastrar revista no banco de dados
        public void CadastrarRevista()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"INSERT INTO tb_revistas (titulo, palavra_chave, assunto, local_publicacao, ano_publicacao, editora, edicao, genero) " +
                                    $"VALUES ('{titulo}', '{palavraChave}', '{assunto}', '{localPublicacao}', '{dataPublicacao}', '{editora}', '{edicao}', '{genero}')";
                    MySqlCommand insertRevista = new MySqlCommand(strSQL, conec);
                    insertRevista.ExecuteNonQuery();
                    MessageBox.Show("Revista cadastrada com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro ao cadastrar revista: {er.Message}");
                }
            }
        }

        // Método para consultar uma revista por ID
        public void ConsultarRevistaPorId(int id)
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"SELECT * FROM tb_revistas WHERE id = {id}";
                    MySqlCommand selectRevista = new MySqlCommand(strSQL, conec);
                    MySqlDataReader reader = selectRevista.ExecuteReader();

                    while (reader.Read())
                    {
                        // Exemplo: Exibe dados no console
                        Console.WriteLine($"ID: {reader["id"]}, Título: {reader["titulo"]}, Editora: {reader["editora"]}, Edição: {reader["edicao"]}, Gênero: {reader["genero"]}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar revista: {ex.Message}");
                }
            }
        }

        // Método para atualizar dados da revista
        public void AtualizarRevista(int id, string titulo, string palavraChave, string assunto, string localPublicacao, string dataPublicacao, string editora, string edicao, string genero)
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"UPDATE tb_revistas SET " +
                                    $"titulo = '{titulo}', " +
                                    $"palavra_chave = '{palavraChave}', " +
                                    $"assunto = '{assunto}', " +
                                    $"local_publicacao = '{localPublicacao}', " +
                                    $"ano_publicacao = '{dataPublicacao}', " +
                                    $"editora = '{editora}', " +
                                    $"edicao = '{edicao}', " +
                                    $"genero = '{genero}' " +
                                    $"WHERE id = {id}";
                    MySqlCommand updateRevista = new MySqlCommand(strSQL, conec);
                    updateRevista.ExecuteNonQuery();
                    MessageBox.Show("Revista atualizada com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro ao atualizar revista: {er.Message}");
                }
            }
        }

        // Método para excluir revista pelo ID
        public void ExcluirRevista(int id)
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"DELETE FROM tb_revistas WHERE id = {id}";
                    MySqlCommand deleteRevista = new MySqlCommand(strSQL, conec);
                    deleteRevista.ExecuteNonQuery();
                    MessageBox.Show("Revista excluída com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro ao excluir revista: {er.Message}");
                }
            }
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

        public string GetEditora()
        {
            return editora;
        }

        public void SetEditora(string editora)
        {
            this.editora = editora;
        }

        public string GetEdicao()
        {
            return edicao;
        }

        public void SetEdicao(string edicao)
        {
            this.edicao = edicao;
        }

        public string GetGenero()
        {
            return genero;
        }

        public void SetGenero(string genero)
        {
            this.genero = genero;
        }
    }
}
