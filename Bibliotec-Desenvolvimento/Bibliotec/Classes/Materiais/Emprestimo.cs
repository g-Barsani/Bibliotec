using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Windows.Forms;

namespace Bibliotec.Classes.Materiais
{
    internal class Emprestimo
    {
        private int idEmprestimo { get; set; }
        private string raAluno { get; set; }
        private string numeroExemplarLivro { get; set; }
        private int? numeroExemplarRevista { get; set; }
        private int nExemplarRevista { get; set; }
        private int? idTrabalhoGraduacao { get; set; }
        private string dataEmprestimo { get; set; }
        private string previsaoDevolucao { get; set; }
        private string dataDevolucaoEmprestimo { get; set; }
        private string material { get; set; }

        // Construtor vazio
        public Emprestimo() { }

        // Construtor completo
        public Emprestimo(string raAluno, string numeroExemplarLivro, int? numeroExemplarRevista, int? idTrabalhoGraduacao, string dataEmprestimo, string previsaoDevolucao, string dataDevolucaoEmprestimo)
        {
            this.raAluno = raAluno;
            this.numeroExemplarLivro = numeroExemplarLivro;
            this.numeroExemplarRevista = numeroExemplarRevista;
            this.idTrabalhoGraduacao = idTrabalhoGraduacao;
            this.dataEmprestimo = dataEmprestimo;
            this.previsaoDevolucao = previsaoDevolucao;
            this.dataDevolucaoEmprestimo = dataDevolucaoEmprestimo;
        }


        public Emprestimo(string raAluno, string numeroExemplarLivro, string dataEmprestimo, string previsaoDevolucao, string dataDevolucaoEmprestimo)
        {
            this.raAluno = raAluno;
            this.numeroExemplarLivro = numeroExemplarLivro;
            this.dataEmprestimo = dataEmprestimo;
            this.previsaoDevolucao = previsaoDevolucao;
            this.dataDevolucaoEmprestimo = dataDevolucaoEmprestimo;
        }

        public Emprestimo(string material, string raAluno, string numeroExemplar, string dataEmprestimo, string previsaoDevolucao, string dataDevolucaoEmprestimo)
        {
            this.raAluno = raAluno;
            this.material = material;
            if (material == "livro")
            {
                MessageBox.Show("construtor de livro");
                this.numeroExemplarLivro = numeroExemplar;
            } else if (material == "trabalho graduacao") {
                MessageBox.Show("construtor de tg");
                TrabalhoGraduacao tg = new TrabalhoGraduacao();
                this.idTrabalhoGraduacao = tg.PegarIdTgPeloTitulo(numeroExemplar); 
            } else if (material == "revista") {
                MessageBox.Show("construtor de revista");
                this.numeroExemplarRevista = Int32.Parse(numeroExemplar);
                this.nExemplarRevista = Int32.Parse(numeroExemplar);
            }
            
            this.dataEmprestimo = dataEmprestimo;
            this.previsaoDevolucao = previsaoDevolucao;
            this.dataDevolucaoEmprestimo = dataDevolucaoEmprestimo;
        }

        private string strConnection = "server=localhost;uid=root;password=root;database=db_bibliotec";

        // Métodos CRUD
        public void CadastrarEmprestimoLivro()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = "INSERT INTO tb_emprestimos (ra_aluno, numero_exemplar_livro, numero_exemplar_revista, id_trabalho_graduacao, data_emprestimo, previsao_devolucao, data_devolucao_emprestimo) " +
                                    "VALUES (@raAluno, @numeroExemplarLivro, @numeroExemplarRevista, @idTrabalhoGraduacao, @dataEmprestimo, @previsaoDevolucao, @dataDevolucaoEmprestimo)";
                    MySqlCommand insertLoan = new MySqlCommand(strSQL, conec);
                    insertLoan.Parameters.AddWithValue("@raAluno", raAluno);
                    insertLoan.Parameters.AddWithValue("@numeroExemplarLivro", numeroExemplarLivro);
                    insertLoan.Parameters.AddWithValue("@numeroExemplarRevista", null);
                    insertLoan.Parameters.AddWithValue("@idTrabalhoGraduacao", null);
                    insertLoan.Parameters.AddWithValue("@dataEmprestimo", dataEmprestimo);
                    insertLoan.Parameters.AddWithValue("@previsaoDevolucao", previsaoDevolucao);
                    insertLoan.Parameters.AddWithValue("@dataDevolucaoEmprestimo", dataDevolucaoEmprestimo);

                    insertLoan.ExecuteNonQuery();
                    MessageBox.Show("Empréstimo cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar empréstimo: {ex.Message}");
                }
            }
        }

        // Métodos CRUD
        public void CadastrarEmprestimoRevista()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = "INSERT INTO tb_emprestimos (ra_aluno, numero_exemplar_livro, numero_exemplar_revista, id_trabalho_graduacao, data_emprestimo, previsao_devolucao, data_devolucao_emprestimo) " +
                                    "VALUES (@raAluno, @numeroExemplarLivro, @numeroExemplarRevista, @idTrabalhoGraduacao, @dataEmprestimo, @previsaoDevolucao, @dataDevolucaoEmprestimo)";
                    MySqlCommand insertLoan = new MySqlCommand(strSQL, conec);
                    insertLoan.Parameters.AddWithValue("@raAluno", raAluno);
                    insertLoan.Parameters.AddWithValue("@numeroExemplarLivro", null);
                    insertLoan.Parameters.AddWithValue("@numeroExemplarRevista", numeroExemplarRevista);
                    insertLoan.Parameters.AddWithValue("@idTrabalhoGraduacao", null);
                    insertLoan.Parameters.AddWithValue("@dataEmprestimo", dataEmprestimo);
                    insertLoan.Parameters.AddWithValue("@previsaoDevolucao", previsaoDevolucao);
                    insertLoan.Parameters.AddWithValue("@dataDevolucaoEmprestimo", dataDevolucaoEmprestimo);

                    insertLoan.ExecuteNonQuery();
                    MessageBox.Show("Empréstimo cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar empréstimo: {ex.Message}");
                }
            }
        }

        // Métodos CRUD
        public void CadastrarEmprestimoTrabalhoGraduacao()
        {
            using (MySqlConnection conec = new MySqlConnection(strConnection))
            {
                try
                {
                    conec.Open();
                    string strSQL = "INSERT INTO tb_emprestimos (ra_aluno, numero_exemplar_livro, numero_exemplar_revista, id_trabalho_graduacao, data_emprestimo, previsao_devolucao, data_devolucao_emprestimo) " +
                                    "VALUES (@raAluno, @numeroExemplarLivro, @numeroExemplarRevista, @idTrabalhoGraduacao, @dataEmprestimo, @previsaoDevolucao, @dataDevolucaoEmprestimo)";
                    MySqlCommand insertLoan = new MySqlCommand(strSQL, conec);
                    insertLoan.Parameters.AddWithValue("@raAluno", raAluno);
                    insertLoan.Parameters.AddWithValue("@numeroExemplarLivro", null);
                    insertLoan.Parameters.AddWithValue("@numeroExemplarRevista", null);
                    insertLoan.Parameters.AddWithValue("@idTrabalhoGraduacao", idTrabalhoGraduacao);
                    insertLoan.Parameters.AddWithValue("@dataEmprestimo", dataEmprestimo);
                    insertLoan.Parameters.AddWithValue("@previsaoDevolucao", previsaoDevolucao);
                    insertLoan.Parameters.AddWithValue("@dataDevolucaoEmprestimo", dataDevolucaoEmprestimo);

                    insertLoan.ExecuteNonQuery();
                    MessageBox.Show("Empréstimo cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar empréstimo: {ex.Message}");
                }
            }
        }

        public void AtualizarEmprestimo(string raAluno, string numeroExemplarLivro, string numeroExemplarRevista, int idTrabalhoGraduacao, string dataEmprestimo, string previsaoDevolucao, string dataDevolucaoEmprestimo)
{
    using (MySqlConnection conec = new MySqlConnection(strConnection))
    {
        try
        {
            conec.Open();

            // Base para a consulta de atualização
            string strSQL = "UPDATE tb_emprestimos SET " +
                            "ra_aluno = @raAluno, " +
                            "data_emprestimo = @dataEmprestimo, " +
                            "previsao_devolucao = @previsaoDevolucao, " +
                            "data_devolucao_emprestimo = @dataDevolucaoEmprestimo ";

            // Verifica se o número do exemplar de livro, revista ou trabalho está presente, e inclui o campo correspondente
            if (!string.IsNullOrEmpty(numeroExemplarLivro))
            {
                strSQL += ", numero_exemplar_livro = @numeroExemplarLivro ";
            }
            else if (!string.IsNullOrEmpty(numeroExemplarRevista))
            {
                strSQL += ", numero_exemplar_revista = @numeroExemplarRevista ";
            }
            else if (idTrabalhoGraduacao > 0)
            {
                strSQL += ", id_trabalho_graduacao = @idTrabalhoGraduacao ";
            }

            strSQL += "WHERE ra_aluno = @raAluno AND ";

            // Identifica se é empréstimo de livro, revista ou trabalho e aplica a condição WHERE apropriada
            if (!string.IsNullOrEmpty(numeroExemplarLivro))
            {
                strSQL += "numero_exemplar_livro = @numeroExemplarLivro";
            }
            else if (!string.IsNullOrEmpty(numeroExemplarRevista))
            {
                strSQL += "numero_exemplar_revista = @numeroExemplarRevista";
            }
            else if (idTrabalhoGraduacao > 0)
            {
                strSQL += "id_trabalho_graduacao = @idTrabalhoGraduacao";
            }

            // Comando de atualização
            MySqlCommand updateLoan = new MySqlCommand(strSQL, conec);
            updateLoan.Parameters.AddWithValue("@raAluno", raAluno);
            updateLoan.Parameters.AddWithValue("@dataEmprestimo", dataEmprestimo);
            updateLoan.Parameters.AddWithValue("@previsaoDevolucao", previsaoDevolucao);
            updateLoan.Parameters.AddWithValue("@dataDevolucaoEmprestimo", dataDevolucaoEmprestimo);

            // Adiciona os parâmetros dinamicamente dependendo do tipo de material
            if (!string.IsNullOrEmpty(numeroExemplarLivro))
            {
                updateLoan.Parameters.AddWithValue("@numeroExemplarLivro", numeroExemplarLivro);
            }
            if (!string.IsNullOrEmpty(numeroExemplarRevista))
            {
                updateLoan.Parameters.AddWithValue("@numeroExemplarRevista", numeroExemplarRevista);
            }
            if (idTrabalhoGraduacao > 0)
            {
                updateLoan.Parameters.AddWithValue("@idTrabalhoGraduacao", idTrabalhoGraduacao);
            }

            // Executa o comando
            updateLoan.ExecuteNonQuery();
            MessageBox.Show("Empréstimo atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao atualizar empréstimo: {ex.Message}");
        }
    }
}


       public void RemoverEmprestimo(string raAluno, string numeroExemplarLivro, string numeroExemplarRevista, int idTrabalhoGraduacao)
{
    using (MySqlConnection conec = new MySqlConnection(strConnection))
    {
        try
        {
            conec.Open();

            // Base da consulta de remoção
            string strSQL = "DELETE FROM tb_emprestimos WHERE ra_aluno = @raAluno ";

            // Verifica qual tipo de material e adiciona a condição correspondente
            if (!string.IsNullOrEmpty(numeroExemplarLivro))
            {
                strSQL += "AND numero_exemplar_livro = @numeroExemplarLivro";
            }
            else if (!string.IsNullOrEmpty(numeroExemplarRevista))
            {
                strSQL += "AND numero_exemplar_revista = @numeroExemplarRevista";
            }
            else if (idTrabalhoGraduacao > 0)
            {
                strSQL += "AND id_trabalho_graduacao = @idTrabalhoGraduacao";
            }

            // Comando para deletar
            MySqlCommand deleteLoan = new MySqlCommand(strSQL, conec);
            deleteLoan.Parameters.AddWithValue("@raAluno", raAluno);

            // Adiciona os parâmetros dinamicamente dependendo do tipo de material
            if (!string.IsNullOrEmpty(numeroExemplarLivro))
            {
                deleteLoan.Parameters.AddWithValue("@numeroExemplarLivro", numeroExemplarLivro);
            }
            if (!string.IsNullOrEmpty(numeroExemplarRevista))
            {
                deleteLoan.Parameters.AddWithValue("@numeroExemplarRevista", numeroExemplarRevista);
            }
            if (idTrabalhoGraduacao > 0)
            {
                deleteLoan.Parameters.AddWithValue("@idTrabalhoGraduacao", idTrabalhoGraduacao);
            }

            // Executa a exclusão
            deleteLoan.ExecuteNonQuery();
            MessageBox.Show("Empréstimo removido com sucesso!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao remover empréstimo: {ex.Message}");
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
                    if (material == "livro")
                    {
                        strSQL = "UPDATE tb_emprestimos SET data_devolucao_emprestimo = @dataDevolucao WHERE ra_aluno = @raAluno AND numero_exemplar_livro = @numeroExemplarLivro";
                    }
                    else if (material == "trabalho graduacao")
                    {
                        strSQL = "UPDATE tb_emprestimos SET data_devolucao_emprestimo = @dataDevolucao WHERE ra_aluno = @raAluno AND id_trabalho_graduacao = @idTrabalhoGraduacao";
                    }
                    else if (material == "revista")
                    {
                        strSQL = "UPDATE tb_emprestimos SET data_devolucao_emprestimo = @dataDevolucao WHERE ra_aluno = @raAluno AND numero_exemplar_revista = @numeroExemplarRevista";
                    }

                    conec.Open();
                    MySqlCommand updateLoan = new MySqlCommand(strSQL, conec);

                    // Adicione os parâmetros conforme o tipo de material:
                    updateLoan.Parameters.AddWithValue("@dataDevolucao", dataDevolucaoEmprestimo);
                    updateLoan.Parameters.AddWithValue("@raAluno", raAluno);

                    if (material == "livro")
                    {
                        updateLoan.Parameters.AddWithValue("@numeroExemplarLivro", numeroExemplarLivro);
                    }
                    else if (material == "trabalho graduacao")
                    {
                        updateLoan.Parameters.AddWithValue("@idTrabalhoGraduacao", idTrabalhoGraduacao);
                    }
                    else if (material == "revista")
                    {
                        updateLoan.Parameters.AddWithValue("@numeroExemplarRevista", nExemplarRevista);
                    }

                    int rowsAffected = updateLoan.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Devolução cadastrada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma linha foi atualizada. Verifique os dados informados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar devolução: {ex.Message}");
                }
            }
        }


        // Getters e Setters
        public int GetIdEmprestimo()
        {
            return idEmprestimo;
        }

        public void SetIdEmprestimo(int idEmprestimo)
        {
            this.idEmprestimo = idEmprestimo;
        }

        public string GetRaAluno()
        {
            return raAluno;
        }

        public void SetRaAluno(string raAluno)
        {
            this.raAluno = raAluno;
        }

        public string GetNumeroExemplarLivro()
        {
            return numeroExemplarLivro;
        }

        public void SetNumeroExemplarLivro(string numeroExemplarLivro)
        {
            this.numeroExemplarLivro = numeroExemplarLivro;
        }

        public int? GetNumeroExemplarRevista()
        {
            return numeroExemplarRevista;
        }

        public void SetNumeroExemplarRevista(int? numeroExemplarRevista)
        {
            this.numeroExemplarRevista = numeroExemplarRevista;
        }

        public int? GetIdTrabalhoGraduacao()
        {
            return idTrabalhoGraduacao;
        }

        public void SetIdTrabalhoGraduacao(int? idTrabalhoGraduacao)
        {
            this.idTrabalhoGraduacao = idTrabalhoGraduacao;
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
