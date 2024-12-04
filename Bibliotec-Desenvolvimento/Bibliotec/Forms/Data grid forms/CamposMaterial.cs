using Bibliotec.Classes.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotec.Forms.Data_grid_forms
{
    public partial class CamposMaterial : Form
    {
        public CamposMaterial()
        {
            InitializeComponent();
        }

        private void titleTextB_TextChanged(object sender, EventArgs e)
        {

        }

        public string[] getFieldsValue()
        {
            string[] campos;
            if (livroRadioButton.Checked)
            {
                campos = new string[] { titleTextB.Text, isbnTextB.Text };
            } else {
                campos = new string[] { titleTextB.Text };
            }
            return campos;
        }

        public bool mostrarExemplares()
        {
            return mostrarExemplarCheckbox.Checked;
        }

        public string getCurrentCheck()
        {
            if (livroRadioButton.Checked)
            {
                return "livro";
            } else if (tgRadioButton.Checked) {
                return "tg";
            } else if (revistasRadioButton.Checked) {
                return "revista";
            }
            return null;
        }

        private void isbnTextB_TextChanged(object sender, EventArgs e)
        {

        }

        private void mostrarExemplarCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CamposMaterial_Load(object sender, EventArgs e)
        {

        }

        private void livroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Helper.enableField(isbnTextB);
        }

        private void tgRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Helper.disableField(isbnTextB);
        }

        private void revistasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Helper.disableField(isbnTextB);
        }
    }
}
