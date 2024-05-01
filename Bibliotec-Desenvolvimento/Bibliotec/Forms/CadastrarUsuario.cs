using Microsoft.VisualBasic.Devices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bibliotec.Forms
{
    public partial class CadastrarUsuario : Form
    {
        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void registerUserlBtn_Click(object sender, EventArgs e)
        {
            // Configuração da string de conexão com o banco de dados MySQL
            var strConection = "server=localhost;uid=root;password=root;pwd=;database=biblioteca";
            var conec = new MySqlConnection(strConection);
            try
            {
                // Abre a conexão com o banco de dados
                conec.Open();

                // Obtenção dos valores dos campos do formulário
                string name = userNameTxtB.Text;
                string ra = RATxtB.Text;
                string rg = RGTxtB.Text;
                string emailInstitucional = schoolEmailTxtB.Text;
                string emailPessoal = personalEmailTxtB.Text;
                string numeroCelular = userPhoneMskTxtB.Text;

                string tipoUsuario = userTypeComboB.Text; //Pode estar errado
                Console.WriteLine("celular" + numeroCelular);

                // Construção da string SQL para inserir um novo livro

                string strSQL;
                if (tipoUsuario == "Aluno") {
                    strSQL = $"CALL insereAluno('{name}', '{ra}', '{rg}', '{emailInstitucional}', '{emailPessoal}', '{numeroCelular}')";
                }
                else if (tipoUsuario == "Professor")
                {
                    strSQL = $"CALL insere_professor_novo('')";
                }
                else
                {
                    strSQL = $"CALL insere_funcionario_novo('')";

                }

                //string strSQL = $"CALL insere_livro_novo('{title}', '{publishDate}', '{gender}', '{publisher}', {availability}, '{author}', '{acquisition}', '{subtitle}', '{keyWord}', '{subject}', '{edition}', '{isbn}' , '{publishLocal}' )";

                // Criação do comando SQL e execução
                var insertBook = new MySqlCommand(strSQL, conec);
                insertBook.ExecuteNonQuery();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }
            catch (Exception er)
            {
                // Exibe uma mensagem de erro em caso de falha no cadastro
                MessageBox.Show($"Erro ao cadastrar usuário: {er.Message}");
            }

            finally
            {
                // Fecha a conexão com o banco de dados
                conec.Close();
            }

            // Limpa os campos do formulário após o cadastro
            userNameTxtB.Text = null;
            RATxtB.Text = null;
            RGTxtB.Text = null;
            schoolEmailTxtB.Text = null ;
            personalEmailTxtB.Text = null;
            userPhoneMskTxtB.Text= null;
            userTypeComboB.Text = null;

            }
        }
    }

