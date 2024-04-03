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
        private void Register()
        {
            // Configuração da string de conexão com o banco de dados MySQL
            var strConection = "server=localhost;uid=root;pwd=;database=biblioteca";
            var conec = new MySqlConnection(strConection);


            try
            {
                // Abre a conexão com o banco de dados
                conec.Open();

                // Obtenção dos valores dos campos do formulário
                string title = titleTextB.Text;
                string subtitle = subtitleTextB.Text;
                string author = authorTextB.Text;
                string edition = editionTextB.Text; //title do BD do Arthur - Arrumar depois
                string publisher = publisherTextB.Text;
                string publishDate = publishDateTextB.Text;
                string publishLocal = publishLocalTextB.Text;
                string isbn = isbnTextB.Text;
                string gender = genderTextB.Text;
                string subject = subjectTextB.Text;
                string keyWord = keyWordsTextB.Text;
                string acquisition = acquisitionTextB.Text;
                bool availability = false;
              

                // Verifica se o livro está disponível
                if (availableRBtn.Checked == true)
                    availability = true;
                else
                    availability = false;


                // Construção da string SQL para inserir um novo livro
                string strSQL = $"CALL insere_livro_novo('{title}', '{publishDate}', '{gender}', '{publisher}', {availability}, '{author}', '{acquisition}', '{subtitle}', '{keyWord}', '{subject}', '{edition}', '{isbn}' , '{publishLocal}' )";

                // Criação do comando SQL e execução
                var insertBook = new MySqlCommand(strSQL, conec);
                insertBook.ExecuteNonQuery();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Livro cadastrado com sucesso!");
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

            // Limpa os campos do formulário após o cadastro
            titleTextB.Text= "";
            authorTextB.Text= "";
            publisherTextB.Text= "";
            keyWordsTextB.Text= "";
            acquisitionTextB.Text= "";
            isbnTextB.Text= "";
            editionTextB.Text= "";
            publishLocalTextB.Text= "";
            subjectTextB.Text= "";
            genderTextB.Text= "";
            availableRBtn.Checked= false;
            nonAvailableRBtn.Checked= false;
            publishDateTextB.Text= "";
        }

        // Método chamado quando o botão de cadastrar é clicado
        private void RegisterMaterialBtn_Click(object sender, EventArgs e)
        {
            // Chama o método de cadastro
            Register();
        }

   
    }
}