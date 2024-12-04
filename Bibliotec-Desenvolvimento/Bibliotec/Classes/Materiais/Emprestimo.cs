using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Bibliotec.Classes.Materiais
{
    internal class Emprestimo
    {
        private string raAluno { get; set; }
        private string numeroExemplar { get; set; }
        private string dataEmprestimo { get; set; }
        private string previsaoDevolucao { get; set; }
        private string dataDevolucaoEmprestimo { get; set; }

        // Construtor vazio
        public Emprestimo() { }

        // Construtor completo
        public Emprestimo(string raAluno, string numeroExemplar, string dataEmprestimo, string previsaoDevolucao, string dataDevolucaoEmprestimo)
        {
            this.raAluno = raAluno;
            this.numeroExemplar = numeroExemplar;
            this.dataEmprestimo = dataEmprestimo;
            this.previsaoDevolucao = previsaoDevolucao;
            this.dataDevolucaoEmprestimo = dataDevolucaoEmprestimo;
        }

        private string strConnection = "server=localhost;uid=root;password=root;database=db_bibliotec";

        // Métodos CRUD
        public void CadastrarEmprestimo()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = "";
                    if (String.IsNullOrEmpty(dataDevolucaoEmprestimo))
                    {
                        strSQL = $"INSERT INTO tb_emprestimos (ra_aluno, numero_exemplar, data_emprestimo, previsao_devolucao) " +
                                   $"VALUES ('{raAluno}', '{numeroExemplar}', '{dataEmprestimo}', '{previsaoDevolucao}')";
                    } else {
                        strSQL = $"INSERT INTO tb_emprestimos (ra_aluno, numero_exemplar, data_emprestimo, previsao_devolucao, data_devolucao_emprestimo) " +
                                    $"VALUES ('{raAluno}', '{numeroExemplar}', '{dataEmprestimo}', '{previsaoDevolucao}', '{dataDevolucaoEmprestimo}')";
                    }
                    MySqlCommand insertLoan = new MySqlCommand(strSQL, conec);
                    insertLoan.ExecuteNonQuery();
                    MessageBox.Show("Empréstimo cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar empréstimo: {ex.Message}");
                }
            }
        }

        public void AtualizarEmprestimo()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    string strSQL = "";
                    conec.Open();
                    if (String.IsNullOrEmpty(dataDevolucaoEmprestimo))
                    {
                        strSQL = $"UPDATE tb_emprestimos SET " +
                                $"data_emprestimo = '{dataEmprestimo}', " +
                                $"previsao_devolucao = '{previsaoDevolucao}' " +
                                $"WHERE ra_aluno = '{raAluno}' AND numero_exemplar = '{numeroExemplar}'";
                    } else {
                        strSQL = $"UPDATE tb_emprestimos SET " +
                                $"data_emprestimo = '{dataEmprestimo}', " +
                                $"previsao_devolucao = '{previsaoDevolucao}', " +
                                $"data_devolucao_emprestimo = '{dataDevolucaoEmprestimo}' " +
                                $"WHERE ra_aluno = '{raAluno}' AND numero_exemplar = '{numeroExemplar}'";
                    }
                        
                    MySqlCommand updateLoan = new MySqlCommand(strSQL, conec);
                    updateLoan.ExecuteNonQuery();
                    MessageBox.Show("Empréstimo atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao atualizar empréstimo: {ex.Message}");
                }
            }
        }

        public void RegistrarDevolucao()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    string strSQL = "";
                    conec.Open();
                    strSQL = $"UPDATE tb_emprestimos SET " +
                            $"data_devolucao_emprestimo = '{dataDevolucaoEmprestimo}' " +
                            $"WHERE ra_aluno = '{raAluno}' AND numero_exemplar = '{numeroExemplar}'";
                    MySqlCommand updateLoan = new MySqlCommand(strSQL, conec);
                    updateLoan.ExecuteNonQuery();
                    MessageBox.Show("Devolução cadastrada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar devolução: {ex.Message}");
                }
            }
        }

        public void RemoverEmprestimo()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"DELETE FROM tb_emprestimos WHERE ra_aluno = '{raAluno}' AND numero_exemplar = '{numeroExemplar}'";
                    MySqlCommand deleteLoan = new MySqlCommand(strSQL, conec);
                    deleteLoan.ExecuteNonQuery();
                    MessageBox.Show("Empréstimo removido com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover empréstimo: {ex.Message}");
                }
            }
        }

        public void RemoverTodosEmprestimos()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = "DELETE FROM tb_emprestimos";
                    MySqlCommand deleteAllLoans = new MySqlCommand(strSQL, conec);
                    deleteAllLoans.ExecuteNonQuery();
                    MessageBox.Show("Todos os empréstimos foram removidos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover todos os empréstimos: {ex.Message}");
                }
            }
        }

        public void ConsultarPorRaAluno(string raAluno)
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = $"SELECT * FROM tb_emprestimos WHERE ra_aluno = '{raAluno}'";
                    MySqlCommand selectLoan = new MySqlCommand(strSQL, conec);
                    MySqlDataReader reader = selectLoan.ExecuteReader();

                    while (reader.Read())
                    {
                        // Exemplo: Exibe dados no console
                        Console.WriteLine($"Número Exemplar: {reader["numero_exemplar"]}, Data Empréstimo: {reader["data_emprestimo"]}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar empréstimos: {ex.Message}");
                }
            }
        }

        // Getters e Setters
        public string GetRaAluno()
        {
            return raAluno;
        }

        public void SetRaAluno(string raAluno)
        {
            this.raAluno = raAluno;
        }

        public string GetNumeroExemplar()
        {
            return numeroExemplar;
        }

        public void SetNumeroExemplar(string numeroExemplar)
        {
            this.numeroExemplar = numeroExemplar;
        }

        public string GetDataEmprestimo()
        {
            return dataEmprestimo;
        }

        public void SetDataEmprestimo(string dataEmprestimo)
        {
            this.dataEmprestimo = dataEmprestimo;
        }

        public string GetPrevisaoDevolucao()
        {
            return previsaoDevolucao;
        }

        public void SetPrevisaoDevolucao(string previsaoDevolucao)
        {
            this.previsaoDevolucao = previsaoDevolucao;
        }

        public string GetDataDevolucaoEmprestimo()
        {
            return dataDevolucaoEmprestimo;
        }

        public void SetDataDevolucaoEmprestimo(string dataDevolucaoEmprestimo)
        {
            this.dataDevolucaoEmprestimo = dataDevolucaoEmprestimo;
        }
    }
}
