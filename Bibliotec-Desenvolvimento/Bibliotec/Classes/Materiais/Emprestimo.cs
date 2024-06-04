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
        DateTime dataEmprestimo;
        DateTime dataDevolucao;

        // Construtor para empréstimo
        public Emprestimo(string ra, long isbn)
        {
            this.ra = ra;
            this.isbn = isbn;
            dataEmprestimo = DateTime.Now;
            // Conta uma semana apartir da data do Empréstimo
            dataDevolucao = dataEmprestimo.AddDays(7);
        }

        // Método CRUD
        public String realizarEmprestimo()
        {
           
           return $"INSERT INTO tb_alunos(id_aluno, id_livro, data_emprestimo, devolucao_emprestimo) VALUES ('{ra}', '{isbn}', '{dataEmprestimo}', '{dataDevolucao}')";

        }
    }

}
