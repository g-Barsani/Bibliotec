using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bibliotec.Forms
{
    public partial class DataGridLer : Form
    {
        String strConection = "server=localhost;uid=root;password=root;pwd=;database=db_bibliotec";
        String btnPressed;

        public DataGridLer(string btnPressed)
        {
            InitializeComponent();
            this.btnPressed = btnPressed;
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
                //adapta a tabela
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM tb_livros", conexaoBd);
                //cria um objeto do tipo tabela
                DataTable tb = new DataTable();
                //preenche a tabela com os dados adaptados
                adapter.Fill(tb);

                //encaixa a tabela dentro do datagrid
                Dtgv.DataSource = tb;


            }
        }
    }
}
