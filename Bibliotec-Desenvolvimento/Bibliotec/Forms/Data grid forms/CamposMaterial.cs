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
            string[] campos = { titleTextB.Text, isbnTextB.Text };
            return campos;
        }

        public bool mostrarExemplares()
        {
            return mostrarExemplarCheckbox.Checked;
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
    }
}
