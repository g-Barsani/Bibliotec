using Bibliotec.Classes.Usuarios;
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
            var strConection = "server=localhost;uid=root;password=root;pwd=;database=db_bibliotec";
            var conec = new MySqlConnection(strConection);
            try
            {
                // Abre a conexão com o banco de dados
                conec.Open();

                // Obtenção dos valores dos campos do formulário e criando objeto
                string tipoUsuario = userTypeComboB.Text; //Pode estar errado
                string strSQL;

                if (tipoUsuario == "Aluno") {
                    Aluno aluno = new Aluno(userNameTxtB.Text, schoolEmailTxtB.Text, userPhoneMskTxtB.Text, RATxtB.Text);
                    // Construção da string SQL para inserir um novo livro
                    strSQL = aluno.cadastrarAluno();
                }
                else if (tipoUsuario == "Professor")
                {
                    Professor professor = new Professor(userNameTxtB.Text, schoolEmailTxtB.Text, userPhoneMskTxtB.Text, RATxtB.Text);
                    // Construção da string SQL para inserir um novo livro
                    strSQL = professor.cadastrarProfessor();
                }
                else
                {
                    Funcionario funcionario = new Funcionario(userNameTxtB.Text, schoolEmailTxtB.Text, userPhoneMskTxtB.Text, RATxtB.Text);
                    // Construção da string SQL para inserir um novo livro
                    strSQL = funcionario.cadastrarFuncionario();

                }

                // Criação do comando SQL e execução
                var insertBook = new MySqlCommand(strSQL, conec);
                insertBook.ExecuteNonQuery();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Usuário cadastrado com sucesso!");

                // Limpa os campos do formulário após o cadastro
                userNameTxtB.Text = null;
                RATxtB.Text = null;
                schoolEmailTxtB.Text = null;
                userPhoneMskTxtB.Text = null;
                userTypeComboB.Text = null;
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

            

            }
        }
    }

