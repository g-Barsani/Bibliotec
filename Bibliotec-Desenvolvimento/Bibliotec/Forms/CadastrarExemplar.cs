using Bibliotec.Classes.Materiais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotec.Forms
{
    public partial class CadastrarExemplar : Form
    {
        public CadastrarExemplar()
        {
            InitializeComponent();
            isbnTxt.Text = CadastrarMaterial.GetLastIsbn();
        }

        private void userNameTxtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void acquisitionMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registerSamplelBtn_Click(object sender, EventArgs e)
        {
            if (livroRadioButton.Checked)
            {
                ExemplarLivro exemplarLivro = new ExemplarLivro(sampleNumberTxt.Text, isbnTxt.Text, redTargeCheckBox.Checked,
                    availableCheckBox.Checked, acquisitionMethodComboBox.Text);
                exemplarLivro.CadastrarExemplarLivro();
            }
            else if (revistasRadioButton.Checked)
            {
                ExemplarRevista exemplarRevista = new ExemplarRevista(sampleNumberTxt.Text, isbnTxt.Text, availableCheckBox.Checked,
                    acquisitionMethodComboBox.Text);
                exemplarRevista.CadastrarExemplarRevista();
            }

        }

        private void updateSamplelBtn_Click(object sender, EventArgs e)
        {
            ExemplarLivro exemplarLivro = new ExemplarLivro(sampleNumberTxt.Text, isbnTxt.Text, redTargeCheckBox.Checked,
                availableCheckBox.Checked, acquisitionMethodComboBox.Text);
            exemplarLivro.AtualizarDisponibilidade(redTargeCheckBox.Checked);
        }

        private void revistasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            schoolEmailLbl.Text = "Nome da Revista";
            redTargeCheckBox.Enabled = false;
            redTargeCheckBox.Checked = false;
        }

        private void livroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            schoolEmailLbl.Text = "ISBN";
            redTargeCheckBox.Enabled = true;
        }

        private void redTargeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
