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
        String strConection = "server=localhost;uid=root;password=root;pwd=;database=db_bibliotec";
        String btnPressed;

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
                    OpenChildFormField(new CamposUsuario());
                    break;
                case "borrowingBtn":
                    OpenChildFormField(new CamposEmprestimo());
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
            MessageBox.Show(this.btnPressed);
            //Botão que chama a tabela do db
            using (MySqlConnection conexaoBd = new MySqlConnection(strConection))
            {
                //abre conexão
                conexaoBd.Open();
                string table = "";
                //List<string> campos = new List<string>();
                switch (btnPressed)
                {
                    case "materialBtn":
                        table = "tb_livros";
                        //campos.Append(camposMaterial.titleTextB.Text);
                        //campos.Append(camposMaterial.isbnTextB.Text);
                        break;
                    case "userBtn":
                        table = "tb_alunos";
                        break;
                    case "borrowingBtn":
                        table = "tb_emprestimos";
                        break;
                    default:
                        break;
                }
                string query = Query(table);

                try
                {
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
            switch(table)
            {
                case "tb_livros":
                    query = $@"
                    SELECT 
                    tb_livros.titulo AS ""Titulo"",
                    tb_livros.palavra_chave AS ""Palavra Chave"",
                    tb_livros.assunto AS ""Assunto"",
                    tb_livros.local_publicacao AS ""Local Publicação"",
                    tb_livros.ano_publicacao AS ""Ano de Publicação"",
                    tb_livros.disponibilidade AS ""Disponivel?"",
                    tb_livros.tarja_vermelha AS ""Tarja Vermelha?"",
                    tb_livros.autor AS ""Autor"",
                    tb_livros.editora AS ""Editora"",
                    tb_livros.aquisicao AS ""Aquisição"",
                    tb_livros.isbn AS ""ISBN"",
                    tb_livros.edicao AS ""Edição"",
                    tb_livros.genero AS ""Gênero"",
                    tb_livros.subtitulo AS ""Subtítulo""
                    FROM 
                    tb_livros
                    
                    ";
                    //WHERE 
                    //tb_livros.titulo LIKE "" %{campos[0]}% "",
                    //tb_livros.isbn = ""{campos[1]}""
                    break;
                case "tb_alunos":
                    query = $@"
                    SELECT 
                    tb_alunos.nome AS ""Nome"",
                    tb_alunos.email AS ""Email"",
                    tb_alunos.celular AS ""Celular"",
                    tb_alunos.ra AS ""RA"",
                    tb_alunos.quantidade_emprestimo AS ""Quantidade Emprestimo"",
                    tb_alunos.tempo_emprestimo_semanas AS ""Tempo Emprestimo Semanas""
                    FROM 
                    tb_alunos
                    ";
                    //WHERE
                    //tb_alunos.ra = ""{campos[0]}"",
                    //tb_alunos.email LIKE "" %{campos[1]}% ""
                    break;
                case "tb_emprestimos":
                    query = $@"
                    SELECT 
                    tb_emprestimos.data_emprestimo AS ""Data Emprestimo"",
                    tb_emprestimos.devolucao_emprestimo AS ""Devolucao Emprestimo"",
                    tb_emprestimos.data_devolucao_emprestimo AS ""Data Devolucao Emprestimo"",
                    tb_alunos.nome AS ""Nome do Aluno"",
                    tb_alunos.email AS ""Email do Aluno"",
                    tb_alunos.ra AS ""RA Aluno"",
                    tb_livros.titulo AS ""Titulo do Livro"",
                    tb_livros.isbn AS ""ISBN""
                    FROM 
                    tb_emprestimos
                    INNER JOIN 
                    tb_alunos ON tb_emprestimos.id_aluno = tb_alunos.id
                    INNER JOIN 
                    tb_livros ON tb_emprestimos.id_livro = tb_livros.id;
                    ";
                    break;
            }
            
            return query;
        }

    }
}
