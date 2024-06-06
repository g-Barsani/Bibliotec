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
            string strConection = "server=localhost;uid=root;password=root;database=db_bibliotec";
            using (MySqlConnection conec = new MySqlConnection(strConection))
            {
                try
                {
                    // Abre a conexão com o banco de dados
                    conec.Open();

                    // Construção da string SQL para consultar livro
                    string strSQLLivro = "SELECT * FROM tb_livros WHERE isbn = @isbn";
                    MySqlCommand commandLivro = new MySqlCommand(strSQLLivro, conec);
                    commandLivro.Parameters.AddWithValue("@isbn", isbnLivro);

                    int idLivro = 0;
                    bool disponibilidade = false;
                    bool livroEncontrado = false;

                    using (MySqlDataReader readerLivro = commandLivro.ExecuteReader())
                    {
                        if (readerLivro.Read())
                        {
                            idLivro = readerLivro.GetInt32("id");
                            disponibilidade = readerLivro.GetBoolean("disponibilidade");
                            livroEncontrado = true;
                        }
                    } // Fecha readerLivro aqui

                    if (!livroEncontrado)
                    {
                        MessageBox.Show("Livro não encontrado!");
                        return;
                    }

                    // Construção da string SQL para consultar Aluno
                    string strSQLAluno = "SELECT * FROM tb_alunos WHERE ra = @ra";
                    MySqlCommand commandAluno = new MySqlCommand(strSQLAluno, conec);
                    commandAluno.Parameters.AddWithValue("@ra", registroUsuario);

                    int idAluno = 0;
                    int emprestimosAluno = 0;
                    int tempoEmprestimo = 0;
                    bool alunoEncontrado = false;

                    using (MySqlDataReader readerAluno = commandAluno.ExecuteReader())
                    {
                        if (readerAluno.Read())
                        {
                            idAluno = readerAluno.GetInt32("id");
                            emprestimosAluno = readerAluno.GetInt32("quantidade_emprestimo");
                            tempoEmprestimo = readerAluno.GetInt32("tempo_emprestimo_semanas");
                            alunoEncontrado = true;
                        }
                    } // Fecha readerAluno aqui

                    if (!alunoEncontrado)
                    {
                        MessageBox.Show("Aluno não encontrado!");
                        return;
                    }

                    if (disponibilidade && emprestimosAluno > 0)
                    {
                        // Cria objeto Emprestimo
                        Emprestimo emprestimo = new Emprestimo(registroUsuario, isbnLivro, tempoEmprestimo);
                        string strSQLEmprestimo = emprestimo.realizarEmprestimo(idLivro, idAluno);
                        string strSQLUpdateAluno = $"UPDATE tb_alunos SET quantidade_emprestimo = {emprestimosAluno - 1} WHERE id = {idAluno}";
                        string strSQLUpdateLivro = $"UPDATE tb_livros SET disponibilidade = FALSE WHERE id = {idLivro}";

                        // Executa as atualizações
                        using (var insertEmprestimo = new MySqlCommand(strSQLEmprestimo, conec))
                        {
                            insertEmprestimo.ExecuteNonQuery();
                        }
                        using (var updateAluno = new MySqlCommand(strSQLUpdateAluno, conec))
                        {
                            updateAluno.ExecuteNonQuery();
                        }
                        using (var updateLivro = new MySqlCommand(strSQLUpdateLivro, conec))
                        {
                            updateLivro.ExecuteNonQuery();
                        }

                        MessageBox.Show("Empréstimo realizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Livro indisponível ou quantidade de empréstimos esgotada!");
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show($"Erro ao realizar empréstimo: {er.Message}");
                }
                finally
                {
                    // Limpa os campos do formulário
                    registroTxtB.Text = "";
                    isbnTxtB.Text = "";
                    conec.Close();
                }
            }
        }

        private void registerMaterialBtn_Click(object sender, EventArgs e)
        {
            Emprestimo();
        }
    }
}
