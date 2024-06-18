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
        private string btnPressed;
        private Form activeForm = null!; // define como não nulo
        private Button lastButton = null!;

        public BotoesCrud(string btnPressed)
        {
            this.btnPressed = btnPressed;
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            openCrudForm(this.btnPressed, "create");
        }

        protected void OpenChildForm(Form childForm, Button btn)
        {
            activeForm?.Close(); // se activeForme for diferente de nulo

            if (lastButton != null)
            {
                lastButton.BackColor = Color.Maroon;
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.crudPanel.Controls.Add(childForm);
            this.crudPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btn.BackColor = Color.Gray;
            lastButton = btn;
        }

        private void BotoesCrud_Load(object sender, EventArgs e)
        {

        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DataGridLer(this.btnPressed), readBtn);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void openCrudForm(string btnPressed, string crudType)
        {
            if(crudType.Equals("create"))
            {
                switch (this.btnPressed)
                {
                    case "materialBtn":
                        OpenChildForm(new CadastrarMaterial(), createBtn);
                        break;
                    case "userBtn":
                        OpenChildForm(new CadastrarUsuario(), createBtn);
                        break;
                    case "borrowingBtn":
                        OpenChildForm(new CadastrarEmprestimo(), createBtn);
                        break;
                    default:
                        MessageBox.Show(this.btnPressed);
                        break;
                }
            }
        }
    }
}
