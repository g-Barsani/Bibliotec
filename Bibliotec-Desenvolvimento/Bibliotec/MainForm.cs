namespace Bibliotec
{
    public partial class MainForm : Form
    {
        private Form activeForm = null!; // define como não nulo
        private Button lastButton = null!;


        public MainForm()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
        }

        // Abrir Forms filhos
        private void OpenChildForm(Form childForm, Button btn)
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
            this.homePanel.Controls.Add(childForm);
            this.homePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            btn.BackColor = Color.Gray;

            lastButton = btn;

        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Pesquisa(), searchBtn);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Deixar o Form bloqueado em tela cheia:
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void CadastrarMaterialBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CadastrarMaterial(), registerMaterialBtn);
        }

        private void CloseBtn_Click(object sender, EventArgs e) //Botão criado para fechar formulário
        {
            this.Close(); //Comando para fechar Form
        }

        private void registerUserBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CadastrarUsuario(), registerUserBtn);
        }
    }
}