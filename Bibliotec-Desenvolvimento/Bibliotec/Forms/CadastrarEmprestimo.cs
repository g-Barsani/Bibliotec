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

            Image imagemRealizarEmprestimo = Image.FromFile(
    @"G:\Repos\Bibliotec\Bibliotec-Desenvolvimento\Bibliotec\Assets\realizar-emprestimo.png"
);
            Image imagemAtualizarEmprestimo = Image.FromFile(
    @"G:\Repos\Bibliotec\Bibliotec-Desenvolvimento\Bibliotec\Assets\atualizar-emprestimo.png"
);
            Image imagemRegistrarDevolucao = Image.FromFile(
    @"G:\Repos\Bibliotec\Bibliotec-Desenvolvimento\Bibliotec\Assets\registrar-devolucao.png"
);

            Image resizedImageRealizarEmprestimo = ResizeImage(imagemRealizarEmprestimo, 60, 60); // Resize to 60x60
            Image resizedImageAtualizarEmprestimo = ResizeImage(imagemAtualizarEmprestimo, 60, 60);
            Image resizedImageRegistrarDevolucao = ResizeImage(imagemRegistrarDevolucao, 60, 60);

            // Set the button properties
            realizarEmprestimoBtn.Image = resizedImageRealizarEmprestimo; // Assign the resized image
            atualizarEmprestimoBtn.Image = resizedImageAtualizarEmprestimo;
            registrarDevolucaoBtn.Image = resizedImageRegistrarDevolucao;
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

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }
    }
}
