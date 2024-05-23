using Bibliotec.Classes.Materiais;

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
    public partial class EmprestimoForm : Form
    {
        string titleTextBox;
        int isbnTextBox;
        public EmprestimoForm()
        {
            InitializeComponent();
        }
        private void registerMaterialBtn_Click(object sender, EventArgs e)
        {
            titleTextBox = titleTextB.Text;
            isbnTextBox = Int32.Parse(isbnTextB.Text);

            var emprestimo = new Bibliotec.Classes.Materiais.Emprestimo(titleTextBox, isbnTextBox);
            emprestimo.realizarEmprestimo();
        }
    }
}
