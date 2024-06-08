using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace Bibliotec.Forms
{
    public partial class BotoesCrud : Form
    {
        private Form activeForm = null!; // define como não nulo
        private Button lastButton = null!;

        public BotoesCrud()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
           OpenChildForm(new CadastrarMaterial(), createBtn);
        }
        protected void OpenChildForm(Form childForm, Button btn)
        {
            MainForm mainForm = new MainForm();
            activeForm?.Close(); // se activeForme for diferente de nulo

            if (lastButton != null)
            {
                lastButton.BackColor = Color.Maroon;
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainForm.homePanel.Controls.Add(childForm);
            mainForm.homePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btn.BackColor = Color.Gray;

            lastButton = btn;

        }

    }
}
