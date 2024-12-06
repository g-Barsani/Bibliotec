using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Bibliotec.Classes.Materiais
{
    internal class ExemplarRevista
    {
        private string numeroExemplar { get; set; }
        private string idRevista { get; set; }
        private string nomeRevista { get; set; }
        private bool disponivel { get; set; }
        private string formaAquisicao { get; set; }

        // Construtor vazio
        public ExemplarRevista() { }

        // Construtor completo
        public ExemplarRevista(string numeroExemplar, string nomeRevista, bool disponivel, string formaAquisicao)
        {
            this.numeroExemplar = numeroExemplar;
            this.nomeRevista = nomeRevista;
            this.disponivel = disponivel;
            this.formaAquisicao = formaAquisicao;
        }

        private string strConnection = "server=localhost;uid=root;password=root;database=db_bibliotec";

        // Métodos CRUD
        public void CadastrarExemplarRevista()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    int idRevista = PegarIdRevistaPeloTitulo(nomeRevista);
                    string strSQL = $"INSERT INTO tb_exemplar_revistas (numero_exemplar, id_revista, forma_aquisicao, disponibilidade) " +
                                    $"VALUES ('{numeroExemplar}', '{idRevista}', '{formaAquisicao}', {disponivel})";
                    MySqlCommand insertSample = new MySqlCommand(strSQL, conec);
                    insertSample.ExecuteNonQuery();
                    MessageBox.Show("Exemplar de revista cadastrado com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro ao cadastrar exemplar de revista: {er.Message}");
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
                    string strSQL = $"UPDATE tb_exemplar_revistas SET disponibilidade = {novaDisponibilidade} WHERE numero_exemplar = '{numeroExemplar}'";
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

        public void RemoverExemplarRevista()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"DELETE FROM tb_exemplar_revistas WHERE numero_exemplar = '{numeroExemplar}'";
                    MySqlCommand deleteSample = new MySqlCommand(strSQL, conec);
                    deleteSample.ExecuteNonQuery();
                    MessageBox.Show("Exemplar de revista removido com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro ao remover exemplar de revista: {er.Message}");
                }
            }
        }

        public void RemoverTodosExemplaresRevistas()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = "DELETE FROM tb_exemplar_revistas";
                    MySqlCommand deleteAllSamples = new MySqlCommand(strSQL, conec);
                    deleteAllSamples.ExecuteNonQuery();
                    MessageBox.Show("Todos os exemplares de revistas foram removidos com sucesso!");
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro ao remover todos os exemplares de revistas: {er.Message}");
                }
            }
        }

        public void ConsultarPorIdRevista(string idRevista)
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"SELECT * FROM tb_exemplar_revistas WHERE id_revista = '{idRevista}'";
                    MySqlCommand selectSample = new MySqlCommand(strSQL, conec);
                    MySqlDataReader reader = selectSample.ExecuteReader();

                    while (reader.Read())
                    {
                        // Exemplo: Exibe dados no console
                        Console.WriteLine($"Número Exemplar: {reader["numero_exemplar"]}, Disponível: {reader["disponibilidade"]}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar exemplares de revistas: {ex.Message}");
                }
            }
        }

        public int PegarIdRevistaPeloTitulo(string titulo)
        {
            int idRevista = 0; // Variável para armazenar o id da revista
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    // A consulta agora busca pelo título da revista, em vez de id_revista
                    string strSQL = $"SELECT id FROM tb_revistas WHERE titulo = @titulo";
                    MySqlCommand selectSample = new MySqlCommand(strSQL, conec);
                    selectSample.Parameters.AddWithValue("@titulo", titulo); // Adiciona o parâmetro do título

                    MySqlDataReader reader = selectSample.ExecuteReader();

                    if (reader.Read()) // Verifica se existe um resultado
                    {
                        idRevista = Int32.Parse(reader["id"].ToString()); // Armazena o id da revista
                    }
                    else
                    {
                        MessageBox.Show("Revista não encontrada.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar revista: {ex.Message}");
                }
            }
            return idRevista; // Retorna o id da revista
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

        public string GetIdRevista()
        {
            return idRevista;
        }

        public void SetIdRevista(string idRevista)
        {
            this.idRevista = idRevista;
        }

        public bool IsDisponivel()
        {
            return disponivel;
        }

        public void SetDisponivel(bool disponivel)
        {
            this.disponivel = disponivel;
        }
    }
}
