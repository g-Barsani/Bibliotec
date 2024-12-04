using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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

        private string strConnection = "server=localhost;uid=root;password=root;database=db_bibliotec";

        // Métodos CRUD
        public void CadastrarExemplarLivro()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"INSERT INTO tb_exemplar_livro (numero_exemplar, isbn, tarja_vermelha, disponivel, forma_aquisicao) " +
                                    $"VALUES ('{numeroExemplar}', '{isbn}', {tarjaVermelha}, {disponivel}, '{formaAquisicao}')";
                    MySqlCommand insertSample = new MySqlCommand(strSQL, conec);
                    insertSample.ExecuteNonQuery();
                    MessageBox.Show("Exemplar cadastrado com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro ao cadastrar exemplar: {er.Message}");
                }
            }
        }

        public void AtualizarDisponibilidade(bool novaDisponibilidade)
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"UPDATE tb_exemplar_livro SET disponivel = {novaDisponibilidade} WHERE numero_exemplar = '{numeroExemplar}'";
                    MySqlCommand updateSample = new MySqlCommand(strSQL, conec);
                    updateSample.ExecuteNonQuery();
                    MessageBox.Show("Disponibilidade atualizada com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro ao atualizar disponibilidade: {er.Message}");
                }
            }
        }

        public void RemoverExemplarLivro()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"DELETE FROM tb_exemplar_livro WHERE numero_exemplar = '{numeroExemplar}'";
                    MySqlCommand deleteSample = new MySqlCommand(strSQL, conec);
                    deleteSample.ExecuteNonQuery();
                    MessageBox.Show("Exemplar removido com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro ao remover exemplar: {er.Message}");
                }
            }
        }

        public void RemoverTodosExemplares()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = "DELETE FROM tb_exemplar_livro";
                    MySqlCommand deleteAllSamples = new MySqlCommand(strSQL, conec);
                    deleteAllSamples.ExecuteNonQuery();
                    MessageBox.Show("Todos os exemplares foram removidos com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro ao remover todos os exemplares: {er.Message}");
                }
            }
        }

        public void ConsultarPorISBN(string isbn)
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"SELECT * FROM tb_exemplar_livro WHERE isbn = '{isbn}'";
                    MySqlCommand selectSample = new MySqlCommand(strSQL, conec);
                    MySqlDataReader reader = selectSample.ExecuteReader();

                    while (reader.Read())
                    {
                        // Exemplo: Exibe dados no console
                        Console.WriteLine($"Número Exemplar: {reader["numero_exemplar"]}, Disponível: {reader["disponivel"]}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar exemplares: {ex.Message}");
                }
            }
        }

        // Getters e Setters
        public string GetNumeroExemplar()
        {
            return numeroExemplar;
        }

        public void SetNumeroExemplar(string numeroExemplar)
        {
            this.numeroExemplar = numeroExemplar;
        }

        public string GetIsbn()
        {
            return isbn;
        }

        public void SetIsbn(string isbn)
        {
            this.isbn = isbn;
        }

        public bool IsTarjaVermelha()
        {
            return tarjaVermelha;
        }

        public void SetTarjaVermelha(bool tarjaVermelha)
        {
            this.tarjaVermelha = tarjaVermelha;
        }

        public bool IsDisponivel()
        {
            return disponivel;
        }

        public void SetDisponivel(bool disponivel)
        {
            this.disponivel = disponivel;
        }

        public string GetFormaAquisicao()
        {
            return formaAquisicao;
        }

        public void SetFormaAquisicao(string formaAquisicao)
        {
            this.formaAquisicao = formaAquisicao;
        }
    }
}
