using Bibliotec.Classes.Materiais;
using MySql.Data.MySqlClient;

namespace Bibliotec.Forms
{
    public partial class EmprestimoForm : Form
    {
        public EmprestimoForm()
        {
            InitializeComponent();
        }

        private void Emprestimo()
        {
            // Recebe dados de input
            string registroUsuario = registroTxtB.Text;
            long isbnLivro = Int64.Parse(isbnTxtB.Text);

            // Configuração da string de conexão com o banco de dados MySQL
            String strConection = "server=localhost;uid=root;password=root;pwd=;database=db_bibliotec";
            MySqlConnection conec = new(strConection);

            try
            {
                // Abre a conexão com o banco de dados
                conec.Open();

                // Construção da string SQL para consultar livro
                String strSQL = $"SELECT * FROM tb_livros WHERE isbn = @isbn";

                // Criação do comando SQL e execução
                MySqlCommand command = new(strSQL, conec);

                command.Parameters.AddWithValue("@isbn", isbnLivro);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    long isbn = reader.GetInt64("isbn");
                    bool disponibilidade = reader.GetBoolean("disponibilidade");

                    if(disponibilidade)
                    {
                        // Cria objeto Emprestimo
                        Emprestimo emprestimo = new Emprestimo(registroUsuario, isbnLivro);
                        emprestimo.realizarEmprestimo();

                        MessageBox.Show("Empréstimo realizado com sucesso!");
                    } else 
                        MessageBox.Show("Livro indisponível!");

                }

                // Limpa os campos do formulário
                registroTxtB.Text = "";
                isbnTxtB.Text = "";
            }
            catch (Exception er)
            {
                MessageBox.Show($"Erro ao realizar empréstimo: {er.Message}");
            }
            finally
            {
                conec.Close();
            }

        }


        private void registerMaterialBtn_Click(object sender, EventArgs e)
        {
            Emprestimo();
        }
    }
}
