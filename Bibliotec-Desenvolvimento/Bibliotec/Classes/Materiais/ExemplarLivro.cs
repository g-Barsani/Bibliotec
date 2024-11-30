using MySql.Data.MySqlClient;
using System;

namespace Bibliotec.Classes.Materiais
{
    internal class ExemplarLivro
    {
        private string numeroExemplar { get; set; }
        private string isbn { get; set; }
        private bool tarjaVermelha { get; set; }
        private bool disponivel { get; set; }
        private string formaAquisicao { get; set; }

        // Construtor vazio
        public ExemplarLivro() { }
        
        // Construtor completo
        public ExemplarLivro(string numeroExemplar, string isbn, bool tarjaVermelha, bool disponivel, string formaAquisicao)
        {
            this.numeroExemplar = numeroExemplar;
            this.isbn = isbn;
            this.tarjaVermelha = tarjaVermelha;
            this.disponivel = disponivel;
            this.formaAquisicao = formaAquisicao;
        }

        // Métodos CRUD
        public void CadastrarExemplarLivro()
        {
            String strConection = "server=localhost;uid=root;password=root;pwd=;database=db_bibliotec";
            MySqlConnection conec = new MySqlConnection(strConection);

            try
            {
                conec.Open();

                string strSQL =  $"INSERT INTO tb_exemplar_livro (numero_exemplar, isbn, tarja_vermelha, disponivel, forma_aquisicao) " +
                  $"VALUES ({numeroExemplar}, {isbn}, {tarjaVermelha}, {disponivel}, '{formaAquisicao}')";
                MySqlCommand insertSample = new MySqlCommand(strSQL, conec);
                insertSample.ExecuteNonQuery();
                MessageBox.Show("Exemplar cadastrado com sucesso!");
            }
            catch (Exception er)
            {
                // Exibe uma mensagem de erro em caso de falha no cadastro
                MessageBox.Show($"Erro ao cadastrar exemplar: {er.Message}");
            }

            finally
            {
                // Fecha a conexão com o banco de dados
                conec.Close();
            }
        }

        public string AtualizarDisponibilidade(bool novaDisponibilidade)
        {
            return $"UPDATE tb_exemplar_livro SET disponivel = {novaDisponibilidade} WHERE numero_exemplar = {numeroExemplar}";
        }

        public string RemoverExemplarLivro()
        {
            return $"DELETE FROM tb_exemplar_livro WHERE numero_exemplar = {numeroExemplar}";
        }

        public string RemoverTodosExemplares()
        {
            return $"DELETE FROM tb_exemplar_livro";
        }

         // Métodos de consulta
        public string ConsultarTodosExemplares()
        {
            return $"SELECT * FROM tb_exemplar_livro";
        }

        public string ConsultarPorISBN(string isbn)
        {
            return $"SELECT * FROM tb_exemplar_livro WHERE isbn = {isbn}";
        }

        // Método de consulta por numeroExemplar
        public string ConsultarPorNumeroExemplar(string numeroExemplar)
        {
            return $"SELECT * FROM tb_exemplar_livro WHERE numero_exemplar = {numeroExemplar}";
        }

        // Getters
        public string GetNumeroExemplar()
        {
            return numeroExemplar;
        }

        public string GetIsbn()
        {
            return isbn;
        }

        public bool IsDisponivel()
        {
            return disponivel;
        }

        public bool HasTarjaVermelha()
        {
            return tarjaVermelha;
        }

        public string GetFormaAquisicao()
        {
            return formaAquisicao;
        }
    }
}
