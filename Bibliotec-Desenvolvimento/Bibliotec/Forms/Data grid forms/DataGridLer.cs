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
        String strConection = "server=localhost;uid=root;password=root;pwd=;database=db_bibliotec";
        String btnPressed;

        public DataGridLer(string btnPressed)
        {
            InitializeComponent();
            this.btnPressed = btnPressed;
            switch (btnPressed)
            {
                case "materialBtn":
                    OpenChildFormField(new CamposMaterial());
                    
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

                switch (btnPressed)
                {
                    case "materialBtn":
                        
                        table = "tb_livros";
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
                //adapta a tabela
                string query = @"
                SELECT 
                tb_emprestimos.id AS emprestimo_id,
                tb_emprestimos.data_emprestimo,
                tb_emprestimos.devolucao_emprestimo,
                tb_emprestimos.data_devolucao_emprestimo,
                tb_alunos.id AS aluno_id,
                tb_alunos.nome AS aluno_nome,
                tb_alunos.email AS aluno_email,
                tb_alunos.ra AS aluno_ra,
                tb_livros.id AS livro_id,
                tb_livros.titulo AS livro_titulo,
                tb_livros.isbn AS livro_isbn
                FROM 
                tb_emprestimos
                INNER JOIN 
                tb_alunos ON tb_emprestimos.id_aluno = tb_alunos.id
                INNER JOIN 
                tb_livros ON tb_emprestimos.id_livro = tb_livros.id;
                ";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoBd);
                //cria um objeto do tipo tabela
                DataTable tb = new DataTable();
                //preenche a tabela com os dados adaptados
                adapter.Fill(tb);
                //encaixa a tabela dentro do datagrid
                Dtgv.DataSource = tb;
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
    }
}
