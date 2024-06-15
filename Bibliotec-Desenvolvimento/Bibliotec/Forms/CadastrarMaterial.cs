using Bibliotec.Classes.Materiais;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Bibliotec.Forms
{
    public partial class CadastrarMaterial : Form
    {
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

                Livro livro = new Livro(titleTextB.Text, keyWordsTextB.Text, subjectTextB.Text, publishLocalTextB.Text, publishDateTextB.Text, availableRBtn.Checked == true, tarjaVermelha, authorTextB.Text,
                    publisherTextB.Text, acquisitionTextB.Text, isbnTextB.Text, editionTextB.Text, genderTextB.Text, subtitleTextB.Text);

                // Construção da string SQL para inserir um novo livro
                string strSQL = livro.cadastrarLivro();

                // Criação do comando SQL e execução
                MySqlCommand insertBook = new MySqlCommand(strSQL, conec);
                insertBook.ExecuteNonQuery();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Livro cadastrado com sucesso!");

                // Limpa os campos do formulário após o cadastro
                titleTextB.Text = "";
                authorTextB.Text = "";
                publisherTextB.Text = "";
                keyWordsTextB.Text = "";
                acquisitionTextB.Text = "";
                isbnTextB.Text = "";
                editionTextB.Text = "";
                publishLocalTextB.Text = "";
                subjectTextB.Text = "";
                genderTextB.Text = "";
                availableRBtn.Checked = false;
                nonAvailableRBtn.Checked = false;
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
    }
}