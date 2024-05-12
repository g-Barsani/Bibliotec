using Bibliotec.Classes.Materiais;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotec.Forms
{
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
        }

        // Método para realizar o cadastro de livros
        private void Pesquisar()
        {
            // Configuração da string de conexão com o banco de dados MySQL
            var strConection = "server=localhost;uid=root;password=root;pwd=;database=db_bibliotec";
            MySqlConnection connection = new MySqlConnection(strConection);
            try
            {
                // Abre a conexão com o banco de dados
                using (connection)
                {
                    connection.Open();

                    string sql = "SELECT * FROM tb_livros WHERE titulo = @titulo";

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@titulo", titleTextB.Text);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                string titulo = reader.GetString("titulo");
                                string palavraChave = reader.GetString("palavra_chave");
                                string assunto = reader.GetString("assunto");
                                string localPublicacao = reader.GetString("local_publicacao");
                                string anoPublicacao = reader.GetDateTime("ano_publicacao").ToString("yyyy-MM-dd"); // Converte ano para string
                                bool disponibilidade = reader.GetBoolean("disponibilidade");
                                bool tarjaVermelha = reader.GetBoolean("tarja_vermelha");
                                string autor = reader.GetString("autor");
                                string editora = reader.GetString("editora");
                                string aquisicao = reader.GetString("aquisicao");
                                long isbn = reader.GetInt64("isbn");
                                string edicao = reader.GetString("edicao");
                                string genero = reader.GetString("genero");
                                string subtitulo = reader.GetString("subtitulo");

                                // Criar objeto Livro com os dados obtidos
                                Livro livro = new Livro(id, titulo, palavraChave, assunto, localPublicacao, anoPublicacao,
                                                         disponibilidade, tarjaVermelha, autor, editora, aquisicao, isbn.ToString(),
                                                         edicao, genero, subtitulo);

                                MessageBox.Show("Livro encontrado: " + livro.getTitulo() + ", Ano de Publicação: " + anoPublicacao);
                            }
                            else
                            {
                                MessageBox.Show("Nenhum livro encontrado com o título especificado.");
                            }
                        }
                    }
                }

                // Limpa os campos do formulário após o cadastro
                titleTextB.Text = "";
                authorTextB.Text = "";
                subjectTextB.Text = "";
            }
            catch (Exception er)
            {
                // Exibe uma mensagem de erro em caso de falha no cadastro
                MessageBox.Show($"Erro ao pesquisar livro: {er.Message}");
            }

            finally
            {
                // Fecha a conexão com o banco de dados
                connection.Close();
            }


        }

        private void SearchBookBtn_Click(object sender, EventArgs e)
        {
            Pesquisar();  
        }

    }
}
