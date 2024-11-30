using System;

namespace Bibliotec.Classes.Materiais
{
    internal class Emprestimo
    {
        private int id { get; set; }
        private int idAluno { get; set; }
        private int numeroExemplar { get; set; }
        private string dataEmprestimo { get; set; }
        private string devolucaoEmprestimo { get; set; }
        private string dataDevolucaoEmprestimo { get; set; }

        // Construtor vazio
        public Emprestimo() { }

        // Construtor completo
        public Emprestimo(int id, int idAluno, int numeroExemplar, string dataEmprestimo, string devolucaoEmprestimo, string dataDevolucaoEmprestimo)
        {
            this.id = id;
            this.idAluno = idAluno;
            this.numeroExemplar = numeroExemplar;
            this.dataEmprestimo = dataEmprestimo;
            this.devolucaoEmprestimo = devolucaoEmprestimo;
            this.dataDevolucaoEmprestimo = dataDevolucaoEmprestimo;
        }

        // Métodos CRUD
        public string CadastrarEmprestimo()
        {
            return $"INSERT INTO tb_emprestimos (id_aluno, numero_exemplar, data_emprestimo, devolucao_emprestimo) " +
                   $"VALUES ({idAluno}, {numeroExemplar}, '{dataEmprestimo}', '{devolucaoEmprestimo}')";
        }

        public string AtualizarEmprestimo()
        {
            return $"UPDATE tb_emprestimos SET data_devolucao_emprestimo = '{dataDevolucaoEmprestimo}' WHERE id = {id}";
        }

        public string RemoverEmprestimo()
        {
            return $"DELETE FROM tb_emprestimos WHERE id = {id}";
        }

        public string RemoverTodosEmprestimos()
        {
            return $"DELETE FROM tb_emprestimos";
        }

        // Métodos de consulta

        // Consultar empréstimo por ID (id do empréstimo)
        public string ConsultarPorId(int id)
        {
            return $"SELECT * FROM tb_emprestimos WHERE id = {id}";
        }

        // Consultar empréstimos por ID do aluno
        public string ConsultarPorIdAluno(int idAluno)
        {
            return $"SELECT * FROM tb_emprestimos WHERE id_aluno = {idAluno}";
        }

        // Getters
        public int GetId()
        {
            return id;
        }

        public int GetIdAluno()
        {
            return idAluno;
        }

        public int GetNumeroExemplar()
        {
            return numeroExemplar;
        }

        public string GetDataEmprestimo()
        {
            return dataEmprestimo;
        }

        public string GetDevolucaoEmprestimo()
        {
            return devolucaoEmprestimo;
        }

        public string GetDataDevolucaoEmprestimo()
        {
            return dataDevolucaoEmprestimo;
        }
    }
}