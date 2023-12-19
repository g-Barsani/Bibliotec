namespace Bibliotec
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomePanel.Visible= true;
        }

        //Configurações de Forms filhos
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm= childForm;
            childForm.TopLevel= false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            this.HomePanel.Controls.Add(childForm);
            this.HomePanel.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchBtn.BackColor= Color.Gray; //Mudar cor do botão selecionado
            cadastrarMaterialBtn.BackColor= Color.Maroon;
            OpenChildForm(new Forms.Pesquisar()); //Abrir form de pesquisa
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Deixar o Form bloqueado em tela cheia:
            this.TopMost= true;
            this.FormBorderStyle= FormBorderStyle.None;
            this.WindowState= FormWindowState.Maximized;
        }

        private void cadastrarMaterialBtn_Click(object sender, EventArgs e)
        {
            searchBtn.BackColor= Color.Maroon;
            cadastrarMaterialBtn.BackColor= Color.Gray; //Mudar cor do botão selecionado
            OpenChildForm(new Forms.Cadastrar()); //Abrir form de cadastro
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e) //Botão criado para fechar formulário
        {
            this.Close(); //Comando para fechar Form
        }

    }
}