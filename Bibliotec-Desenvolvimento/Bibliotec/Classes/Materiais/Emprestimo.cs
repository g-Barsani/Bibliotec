using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Bibliotec.Classes.Materiais
{
    internal class Emprestimo 
    {
        private string ra;
        private long isbn;
        private DateTime dataEmprestimo;
        private DateTime dataDevolucao;
        private DateTime? dataDevolucaoEmprestimo;

        public Emprestimo() { }

        // Construtor para empréstimo
        public Emprestimo(string ra, long isbn, int tempoEmprestimo)
        {
            this.ra = ra;
            this.isbn = isbn;
            dataEmprestimo = DateTime.Now;
            // Conta uma semana apartir da data do Empréstimo
            dataDevolucao = dataEmprestimo.AddDays(tempoEmprestimo*7);
            dataDevolucaoEmprestimo = null;
        }

        // Método CRUD
        public String realizarEmprestimo(int id_aluno, int id_livro)
        {
           
           return $"INSERT INTO tb_emprestimos(id_aluno, id_livro, data_emprestimo, devolucao_emprestimo, data_devolucao_emprestimo) VALUES ('{id_aluno}', '{id_livro}', '{dataEmprestimo.ToString("yyyy-MM-dd")}', '{dataDevolucao.ToString("yyyy-MM-dd")}', NULL)";

        }
    }

}
