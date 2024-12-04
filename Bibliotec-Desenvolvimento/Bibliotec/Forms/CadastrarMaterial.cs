using Bibliotec.Classes.Helpers;
using Bibliotec.Classes.Materiais;
using Bibliotec.Classes.Usuarios;
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
        private static string lastIsbn = "";

        public CadastrarMaterial()
        {
            InitializeComponent();
        }

        // Método para realizar o cadastro de livros
        private void cadastrarLivro()
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

                CheckFields();
                string publishDate = Helper.ConverterData(publishDateTextB.Text);
                Livro livro = new Livro(titleTextB.Text, keyWordsTextB.Text, subjectTextB.Text, publishLocalTextB.Text, publishDate, authorTextB.Text,
                    publisherTextB.Text, isbnTextB.Text, editionTextB.Text, genderTextB.Text, subtitleTextB.Text);

                // Construção da string SQL para inserir um novo livro
                string strSQL = livro.cadastrarLivro();

                // Criação do comando SQL e execução
                MySqlCommand insertBook = new MySqlCommand(strSQL, conec);
                insertBook.ExecuteNonQuery();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Livro cadastrado com sucesso!");
                lastIsbn = isbnTextB.Text;
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

        private void cadastrarTrabalhoGraduacao()
        {
            // Configuração da string de conexão com o banco de dados MySQL
            String strConection = "server=localhost;uid=root;password=root;pwd=;database=db_bibliotec";
            MySqlConnection conec = new MySqlConnection(strConection);


            try
            {
                string raAluno = authorTextB.Text;
                // Obtenção dos valores dos campos do formulário
                CheckFields();
                string publishDate = Helper.ConverterData(publishDateTextB.Text);
                TrabalhoGraduacao tg = new TrabalhoGraduacao(
                    titleTextB.Text,
                    keyWordsTextB.Text,
                    subjectTextB.Text,
                    publishLocalTextB.Text,
                    publishDate,
                    raAluno,
                    subtitleTextB.Text
                );

                tg.CadastrarTrabalhoGraduacao();

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

        private void cadastrarRevista()
        {
            // Configuração da string de conexão com o banco de dados MySQL
            String strConection = "server=localhost;uid=root;password=root;pwd=;database=db_bibliotec";
            MySqlConnection conec = new MySqlConnection(strConection);


            try
            {
                // Abre a conexão com o banco de dados
                conec.Open();
                // Obtenção dos valores dos campos do formulário
                CheckFields();

                string publishDate = Helper.ConverterData(publishDateTextB.Text);
                Revista revista = new Revista(
                    titleTextB.Text,
                    keyWordsTextB.Text,
                    subjectTextB.Text,
                    publishLocalTextB.Text,
                    publishDate,
                    publisherTextB.Text,
                    editionTextB.Text,
                    genderTextB.Text
                );

                revista.CadastrarRevista();

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
            if (livroRadioButton.Checked)
            {
                cadastrarLivro();
            }
            else if (tgRadioButton.Checked)
            {
                cadastrarTrabalhoGraduacao();
            }
            else if (revistasRadioButton.Checked)
            {
                cadastrarRevista();
            } 
            else 
            {
                MessageBox.Show("Selecione o tipo de material cadastrado!");
            }
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

        private void publishDateTextB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckFields()
        {
            if (String.IsNullOrWhiteSpace(titleTextB.Text) && String.IsNullOrWhiteSpace(isbnTextB.Text) && String.IsNullOrWhiteSpace(authorTextB.Text))
            {
                throw new Exception("Campo título ou ISBN vazios!");
            }
        }

        private string FormatPublishDate()
        {
            if (String.IsNullOrWhiteSpace(publishDateTextB.Text))
            {
                return null;
            }
            return publishDateTextB.Text;
        }

        public static string GetLastIsbn()
        {
            return lastIsbn;
        }

        private void livroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Helper.enableField(isbnTextB);
            Helper.enableField(authorTextB);
            Helper.enableField(subtitleTextB);
            Helper.enableField(editionTextB);
            Helper.enableField(publisherTextB);
            Helper.enableField(genderTextB);
            authorLbl.Text = "Autor";
        }

        private void tgRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Helper.disableField(isbnTextB);
            Helper.disableField(editionTextB);
            Helper.disableField(publisherTextB);
            Helper.disableField(genderTextB);
            Helper.enableField(subtitleTextB);
            Helper.enableField(authorTextB);
            authorLbl.Text = "RA do Aluno Autor";
        }

        private void revistasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Helper.disableField(isbnTextB);
            Helper.disableField(authorTextB);
            Helper.disableField(subtitleTextB);
            Helper.enableField(publisherTextB);
            Helper.enableField(editionTextB);
            Helper.enableField(genderTextB);
            authorLbl.Text = "Autor";
        }

        private void authorTextB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}