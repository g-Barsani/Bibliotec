using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Bibliotec.Forms
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        // Método para realizar o cadastro de livros
        private void testar_cadastro()
        {
            // Configuração da string de conexão com o banco de dados MySQL
            var strConexao= "server=localhost;uid=root;pwd=;database=biblioteca";
            var conexao= new MySqlConnection(strConexao);


            try
            {
                // Abre a conexão com o banco de dados
                conexao.Open();

                // Obtenção dos valores dos campos do formulário
                string a_titulo= tituloTextBox.Text;
                string b_autor= autorTextBox.Text;
                string c_editora= editoraTextBox.Text;
                string d_palavrasChaves= palavrasChavesTextBox.Text;
                string e_formaAdquirida= formaAdquirida.Text;
                string f_isbn= isbnTextBox.Text;
                string g_edicao= edicaoTextBox.Text; //title do BD do Arthur - Arrumar depois
                string h_localPublica= localpublica_txt.Text;
                string h_assunto= assuntoTextBox.Text;
                string i_genero= generoTextBox.Text;
                string k_data_publica= data_publica.Text;
                bool disponibilidade= false;
                string l_subTitulo= subtitulo.Text;

                // Verifica se o livro está disponível
                if (possui_btn.Checked == true)
                    disponibilidade= true;
                else
                    disponibilidade= false;


                // Construção da string SQL para inserir um novo livro
                string insereLivro= $"CALL insere_livro_novo('{a_titulo}', '{k_data_publica}', '{i_genero}', '{c_editora}', {disponibilidade}, '{b_autor}', '{e_formaAdquirida}', '{l_subTitulo}', '{d_palavrasChaves}', '{h_assunto}', '{g_edicao}', '{f_isbn}' , '{h_localPublica}' )";

                // Criação do comando SQL e execução
                var inserir_book= new MySqlCommand(insereLivro, conexao);
                inserir_book.ExecuteNonQuery();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Livros Cadastrados com Sucesso");
            }
            catch (Exception er)
            {
                // Exibe uma mensagem de erro em caso de falha no cadastro
                MessageBox.Show($"Erro ao cadastrar livros: {er.Message}");
            }

            finally
            {
                // Fecha a conexão com o banco de dados
                conexao.Close();
            }

            // Limpa os campos do formulário após o cadastro
            tituloTextBox.Text= "";
            autorTextBox.Text= "";
            editoraTextBox.Text= "";
            palavrasChavesTextBox.Text= "";
            formaAdquirida.Text= "";
            isbnTextBox.Text= "";
            edicaoTextBox.Text= "";
            localpublica_txt.Text= "";
            assuntoTextBox.Text= "";
            generoTextBox.Text= "";
            possui_btn.Checked= false;
            npossui_btn.Checked= false;
            data_publica.Text= "";
        }

        // Método chamado quando o botão de cadastrar é clicado
        private void cadastrarMaterialBtn_Click(object sender, EventArgs e)
        {
            // Chama o método de cadastro
            testar_cadastro();
        }

        //N/A
        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}