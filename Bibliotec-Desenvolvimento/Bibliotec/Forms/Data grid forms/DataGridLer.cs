using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotec.Forms.Data_grid_forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskBand;

namespace Bibliotec.Forms
{
    public partial class DataGridLer : Form
    {
        private Form activeForm = null!; // define como não nulo
        private CamposMaterial camposMaterial;
        private CamposUsuario camposUsuario;
        private CamposEmprestimo camposEmprestimo;
        String strConection = "server=localhost;uid=root;password=root;pwd=;database=db_bibliotec";
        String btnPressed;
        String[] campos;

        public DataGridLer(string btnPressed)
        {
            InitializeComponent();
            this.btnPressed = btnPressed;
            switch (btnPressed)
            {
                case "materialBtn":
                    this.camposMaterial = new CamposMaterial();
                    OpenChildFormField(this.camposMaterial);
                    break;
                case "userBtn":
                    this.camposUsuario = new CamposUsuario();
                    OpenChildFormField(this.camposUsuario);
                    break;
                case "borrowingBtn":
                    this.camposEmprestimo = new CamposEmprestimo();
                    OpenChildFormField(this.camposEmprestimo);
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botão que chama a tabela do db
            using (MySqlConnection conexaoBd = new MySqlConnection(strConection))
            {
                try
                {
                    //abre conexão
                    conexaoBd.Open();
                    string table = "";
                    //List<string> campos = new List<string>();
                    switch (btnPressed)
                    {
                        case "materialBtn":
                            campos = this.camposMaterial.getFieldsValue();
                            
                            if (String.Equals(this.camposMaterial.getCurrentCheck(), "livro"))
                            {
                                table = "tb_livros";
                            }
                            else if (String.Equals(this.camposMaterial.getCurrentCheck(), "tg"))
                            {
                                table = "tb_trabalhos_graduacao";
                            }
                            else if (String.Equals(this.camposMaterial.getCurrentCheck(), "revista"))
                            {
                                table = "tb_revistas";
                            }
                            else
                            {
                                throw new Exception("Selecione um tipo de material!");
                            }
                            if (this.camposMaterial.mostrarExemplares())
                            {
                               if (String.Equals(this.camposMaterial.getCurrentCheck(), "livro"))
                                {
                                    table = "tb_exemplar_livro";
                                } else if (String.Equals(this.camposMaterial.getCurrentCheck(), "revista")) {
                                    table = "tb_exemplar_revistas";
                                }
                            }
                            break;
                        case "userBtn":
                            campos = this.camposUsuario.getFieldsValue();
                            table = "tb_alunos";
                            break;
                        case "borrowingBtn":
                            //campos = this.camposEmprestimo.getFieldsValue();
                            table = "tb_emprestimos";
                            break;
                        default:
                            break;
                    }
                    string query = Query(table);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoBd);
                    //cria um objeto do tipo tabela
                    DataTable tb = new DataTable();
                    //preenche a tabela com os dados adaptados
                    adapter.Fill(tb);
                    //encaixa a tabela dentro do datagrid
                    Dtgv.DataSource = tb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void OpenChildFormField(Form form)
        {
            activeForm?.Close(); // se activeForme for diferente de nulo
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            camposPanel.Controls.Add(form);
            camposPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private string Query(string table)
        {
            string query = "";
            //adapta a tabela
            switch (table)
            {
                case "tb_livros":
                    query = $@"
                    SELECT
                    tb_livros.isbn AS 'ISBN',
                    tb_livros.titulo AS 'Titulo',
                    tb_livros.subtitulo AS 'Subtítulo',
                    tb_livros.palavra_chave AS 'Palavra Chave',
                    tb_livros.assunto AS 'Assunto',
                    tb_livros.local_publicacao AS 'Local Publicação',
                    tb_livros.ano_publicacao AS 'Ano de Publicação',
                    tb_livros.autor AS 'Autor',
                    tb_livros.editora AS 'Editora',
                    tb_livros.edicao AS 'Edição',
                    tb_livros.genero AS 'Gênero',
                    tb_livros.total_exemplares AS 'Total de Exemplares'
                    FROM 
                    tb_livros
                    WHERE 
                    1=1";
                    if (!string.IsNullOrEmpty(campos[0]))
                    {
                        query += $" AND tb_livros.titulo LIKE '%{campos[0]}%'";
                    }
                    if (!string.IsNullOrEmpty(campos[1]))
                    {
                        query += $" AND tb_livros.isbn LIKE '%{campos[1]}%'";
                    }

                    break;
                case "tb_alunos":
                    query = $@"
                    SELECT 
                    tb_alunos.nome AS 'Nome',
                    tb_alunos.email AS 'Email',
                    tb_alunos.celular AS 'Celular',
                    tb_alunos.ra AS 'RA',
                    tb_alunos.quantidade_emprestimo AS 'Quantidade Emprestimo',
                    tb_alunos.tempo_emprestimo_semanas AS 'Tempo Emprestimo Semanas'
                    FROM 
                    tb_alunos
                    WHERE 
                    1=1";

                    if (!string.IsNullOrEmpty(campos[0]))
                    {
                        query += $" AND tb_alunos.ra LIKE '%{campos[0]}%'";
                    }
                    if (!string.IsNullOrEmpty(campos[0]))
                    {
                        query += $" AND tb_alunos.email LIKE '%{campos[1]}%'";
                    }
                    break;
                case "tb_emprestimos":
                    query = $@"
                    SELECT 
                    tb_emprestimos.data_emprestimo AS 'Data Emprestimo',
                    tb_emprestimos.previsao_devolucao AS 'Previsão Devolução',
                    tb_emprestimos.data_devolucao_emprestimo AS 'Data Devolução Emprestimo',
                    tb_alunos.nome AS 'Nome do Aluno',
                    tb_alunos.email AS 'Email do Aluno',
                    tb_alunos.ra AS 'RA Aluno',
                    tb_exemplar_livro.numero_exemplar AS 'Numero Exemplar',
                    tb_livros.titulo AS 'Titulo do Livro',
                    tb_livros.isbn AS 'ISBN'
                    FROM 
                    tb_emprestimos
                    INNER JOIN 
                    tb_alunos ON tb_emprestimos.ra_aluno = tb_alunos.ra
                    INNER JOIN 
                    tb_exemplar_livro ON tb_emprestimos.numero_exemplar = tb_exemplar_livro.numero_exemplar
                    INNER JOIN 
                    tb_livros ON tb_exemplar_livro.isbn = tb_livros.isbn
                    WHERE 
                    1=1";

                    break;

                case "tb_revistas":
                    query = $@"
                    SELECT
                    tb_revistas.id AS 'ID',
                    tb_revistas.titulo AS 'Título',
                    tb_revistas.palavra_chave AS 'Palavra Chave',
                    tb_revistas.assunto AS 'Assunto',
                    tb_revistas.local_publicacao AS 'Local de Publicação',
                    tb_revistas.ano_publicacao AS 'Ano de Publicação',
                    tb_revistas.editora AS 'Editora',
                    tb_revistas.edicao AS 'Edição',
                    tb_revistas.genero AS 'Gênero'
                    FROM 
                    tb_revistas
                    WHERE 
                    1=1";

                    if (!string.IsNullOrEmpty(campos[0]))
                    {
                        query += $" AND tb_revistas.titulo LIKE '%{campos[0]}%'";
                    }
                    break;

                case "tb_exemplar_revistas":
                    query = $@"
                    SELECT
                    tb_exemplar_revistas.numero_exemplar AS 'Número Exemplar',
                    tb_exemplar_revistas.id_revista AS 'ID Revista',
                    tb_exemplar_revistas.disponibilidade AS 'Disponibilidade',
                    tb_exemplar_revistas.data_aquisicao AS 'Data de Aquisição',
                    tb_revistas.titulo AS 'Título da Revista'
                    FROM 
                    tb_exemplar_revistas
                    JOIN tb_revistas ON tb_exemplar_revistas.id_revista = tb_revistas.id
                    WHERE 
                    1=1";

                    if (!string.IsNullOrEmpty(campos[0]))
                    {
                        query += $" AND tb_exemplar_revistas.numero_exemplar LIKE '%{campos[0]}%'";
                    }

                    break;


                case "tb_trabalhos_graduacao":
                    query = $@"
                    SELECT
                    tb_trabalhos_graduacao.id AS 'ID',
                    tb_trabalhos_graduacao.titulo AS 'Título',
                    tb_trabalhos_graduacao.palavra_chave AS 'Palavra Chave',
                    tb_trabalhos_graduacao.assunto AS 'Assunto',
                    tb_trabalhos_graduacao.local_publicacao AS 'Local de Publicação',
                    tb_trabalhos_graduacao.ano_publicacao AS 'Ano de Publicação',
                    tb_trabalhos_graduacao.aluno_ra AS 'RA do Aluno',
                    tb_trabalhos_graduacao.subtitulo AS 'Subtítulo',
                    tb_alunos.nome AS 'Nome do Aluno'
                    FROM 
                    tb_trabalhos_graduacao
                    JOIN tb_alunos ON tb_trabalhos_graduacao.aluno_ra = tb_alunos.ra
                    WHERE 
                    1=1";

                    if (!string.IsNullOrEmpty(campos[0]))
                    {
                        query += $" AND tb_trabalhos_graduacao.titulo LIKE '%{campos[0]}%'";
                    }

                    break;


                case "tb_exemplar_livro":
                    query = $@"
                    SELECT 
                    tb_exemplar_livro.numero_exemplar AS 'Numero Exemplar',
                    tb_livros.titulo AS 'Titulo do Livro',
                    tb_livros.isbn AS 'ISBN'
                    FROM 
                    tb_exemplar_livro
                    INNER JOIN 
                    tb_livros ON tb_exemplar_livro.isbn = tb_livros.isbn
                    WHERE 
                    1=1";
                    if (!string.IsNullOrEmpty(campos[0]))
                    {
                        query += $" AND tb_livros.titulo LIKE '%{campos[0]}%'";
                    }
                    if (!string.IsNullOrEmpty(campos[1]))
                    {
                        query += $" AND tb_livros.isbn LIKE '%{campos[1]}%'";
                    }
                    break;
            }

            return query;
        }

    }
}
