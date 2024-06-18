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
    public partial class CamposUsuario : Form
    {
        public CamposUsuario()
        {
            InitializeComponent();
        }

        private void CamposUsuario_Load(object sender, EventArgs e)
        {

        }

        public string[] getFieldsValue()
        {
            string[] campos = { RATxtB.Text, schoolEmailTxtB.Text };
            return campos;
        }
    }
}
