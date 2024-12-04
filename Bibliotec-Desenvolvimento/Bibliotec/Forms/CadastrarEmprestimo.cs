using Bibliotec.Classes.Helpers;
using Bibliotec.Classes.Materiais;
using Bibliotec.Classes.Usuarios;
using MySql.Data.MySqlClient;

namespace Bibliotec.Forms
{
    public partial class CadastrarEmprestimo : Form
    {
        public CadastrarEmprestimo()
        {
            InitializeComponent();
        }

        private void FuncaoCadastrarEmprestimo()
        {
            // Recebe dados de input
            string ra = raAlunoTxtB.Text;
            string numeroExemplar = registroTxtB.Text;
            string dataDevolucao = dataDevolucaoTxtB.Text;
            string dataEmprestimo = dataEmprestimoTxtB.Text;
            string previsaoDevolucao = previsaoDevolucaoTxtB.Text;
            dataDevolucao = Helper.ConverterData(dataDevolucao);
            dataEmprestimo = Helper.ConverterData(dataEmprestimo);
            previsaoDevolucao = Helper.ConverterData(previsaoDevolucao);

            Emprestimo emprestimo = new Emprestimo(
                ra,
                numeroExemplar,
                dataEmprestimo,
                previsaoDevolucao,
                dataDevolucao
            );

            emprestimo.CadastrarEmprestimo();
        }

        private void registerMaterialBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FuncaoCadastrarEmprestimo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registrarDevolucaoBtn_Click(object sender, EventArgs e)
        {
            string ra = raAlunoTxtB.Text;
            string numeroExemplar = registroTxtB.Text;
            string dataDevolucao = dataDevolucaoTxtB.Text;

            dataDevolucao = Helper.ConverterData(dataDevolucao);

            Emprestimo emprestimo = new Emprestimo(
                ra,
                numeroExemplar,
                "",
                "",
                dataDevolucao
            );

            emprestimo.RegistrarDevolucao();
        }

        private void dataDevolucaoTxtB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void atualizarEmprestimoBtn_Click(object sender, EventArgs e)
        {
            // Recebe dados de input
            string ra = raAlunoTxtB.Text;
            string numeroExemplar = registroTxtB.Text;
            string dataDevolucao = dataDevolucaoTxtB.Text;
            string dataEmprestimo = dataEmprestimoTxtB.Text;
            string previsaoDevolucao = previsaoDevolucaoTxtB.Text;
            dataDevolucao = Helper.ConverterData(dataDevolucao);
            dataEmprestimo = Helper.ConverterData(dataEmprestimo);
            previsaoDevolucao = Helper.ConverterData(previsaoDevolucao);

            Emprestimo emprestimo = new Emprestimo(
                ra,
                numeroExemplar,
                dataEmprestimo,
                previsaoDevolucao,
                dataDevolucao
            );

            emprestimo.AtualizarEmprestimo();
        }
    }
}
