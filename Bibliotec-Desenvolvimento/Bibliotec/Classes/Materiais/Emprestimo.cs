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
        private int isbn;

        // Construtor para empréstimo
        public Emprestimo(string ra, int isbn)
        {
            this.ra = ra;
            this.isbn = isbn;
        }

        // Métodos CRUD
        public String realizarEmprestimo()
        {
            // Implementar
            MessageBox.Show("Implementar empréstimo");
            MessageBox.Show($"ra = {this.ra}     " +
                $"isbn = {this.isbn}" );
            return "teste";
        }
    }

}
