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
    public partial class Pesquisar : Form
    {
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void cadastrarMaterialBtn_Click(object sender, EventArgs e)
        {
            tituloTextBox.Text = "";
            autorTextBox.Text = "";
            editoraTextBox.Text = "";
            palavrasChavesTextBox.Text = "";
            numDePagTextBox.Text = "";
            isbnTextBox.Text = "";
            edicaoTextBox.Text = "";
            notaFiscalTextBox.Text = "";
            assuntoTextBox.Text = "";
            generoTextBox.Text = "";
        }

        private void isbnTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
