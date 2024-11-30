using Bibliotec.Classes.Materiais;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace Bibliotec.Forms
{
    public partial class CadastrarMaterial : Form
    {
        private Form activeForm = null!; // define como não nulo
        private Button lastButton = null!;

        public CadastrarMaterial()
        {
            InitializeComponent();
        }

        // Método para realizar o cadastro de livros
        private void cadastrarMaterial()
        {
            // Configuração da string de conexão com o banco de dados MySQL
            String strConection = "server=localhost;uid=root;password=root;pwd=;database=db_bibliotec";
            MySqlConnection conec = new MySqlConnection(strConection);


            try
            {
                // Abre a conexão com o banco de dados
                conec.Open();

                // Obtenção dos valores dos campos do formulário
                bool tarjaVermelha = true;

                Livro livro = new Livro(titleTextB.Text, keyWordsTextB.Text, subjectTextB.Text, publishLocalTextB.Text, publishDateTextB.Text, authorTextB.Text,
                    publisherTextB.Text, isbnTextB.Text, editionTextB.Text, genderTextB.Text, subtitleTextB.Text);

                // Construção da string SQL para inserir um novo livro
                string strSQL = livro.cadastrarLivro();

                // Criação do comando SQL e execução
                MySqlCommand insertBook = new MySqlCommand(strSQL, conec);
                insertBook.ExecuteNonQuery();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Livro cadastrado com sucesso!");

                // Limpa os campos do formulário após o cadastro
                titleTextB.Text = "";
                subtitleTextB.Text = "";
                authorTextB.Text = "";
                publisherTextB.Text = "";
                keyWordsTextB.Text = "";
                isbnTextB.Text = "";
                editionTextB.Text = "";
                publishLocalTextB.Text = "";
                subjectTextB.Text = "";
                genderTextB.Text = "";
                publishDateTextB.Text = "";
            }
            catch (Exception er)
            {
                // Exibe uma mensagem de erro em caso de falha no cadastro
                MessageBox.Show($"Erro ao cadastrar livro: {er.Message}");
            }

            finally
            {
                // Fecha a conexão com o banco de dados
                conec.Close();
            }


        }

        // Método chamado quando o botão de cadastrar é clicado
        private void RegisterMaterialBtn_Click(object sender, EventArgs e)
        {
            // Chama o método de cadastro
            cadastrarMaterial();
        }

        private void CadastrarMaterial_Load(object sender, EventArgs e)
        {

        }

        private void subtitleTextB_TextChanged(object sender, EventArgs e)
        {

        }

        protected void OpenChildForm(Form childForm)
        {
           
        }

        private void manageCopiesBtn_Click(object sender, EventArgs e)
        {
            BotoesCrud crud = new BotoesCrud();
            crud.OpenCopiesForm();
        }
    }
}