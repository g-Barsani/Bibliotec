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
            LoadButtonImages();
        }

        private void LoadButtonImages()
        {
            TryLoadButtonImage(realizarEmprestimoBtn, "realizar-emprestimo.png");
            TryLoadButtonImage(registrarDevolucaoBtn, "registrar-devolucao.png");
        }

        private void TryLoadButtonImage(Button button, string imageName)
        {
            string imagePath = Helper.GetAssetPath(imageName);
            MessageBox.Show(imagePath);
            if (File.Exists(imagePath))
            {
                try
                {
                    using (Image originalImage = Image.FromFile(imagePath))
                    {
                        button.Image = ResizeImage(originalImage, 60, 60);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar a imagem {imageName}: {ex.Message}");
                    // Opcionalmente, defina uma imagem padrão ou deixe o botão sem imagem
                }
            }
            else
            {
                Console.WriteLine($"Imagem não encontrada: {imagePath}");
                // Opcionalmente, defina uma imagem padrão ou deixe o botão sem imagem
            }
        }


        private void FuncaoCadastrarEmprestimoLivro()
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
                "livro",
                ra,
                numeroExemplar,
                dataEmprestimo,
                previsaoDevolucao,
                dataDevolucao
            );

            emprestimo.CadastrarEmprestimoLivro();
        }

        private void FuncaoCadastrarEmprestimoRevista()
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
                "revista",
                ra,
                numeroExemplar,
                dataEmprestimo,
                previsaoDevolucao,
                dataDevolucao
            );

            emprestimo.CadastrarEmprestimoRevista();
        }

        private void FuncaoCadastrarTrabalhoGraduacao()
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
                "trabalho graduacao",
                ra,
                numeroExemplar,
                dataEmprestimo,
                previsaoDevolucao,
                dataDevolucao
            );

            emprestimo.CadastrarEmprestimoTrabalhoGraduacao();
        }

        private void registerMaterialBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (livroRadioButton.Checked)
                {
                    FuncaoCadastrarEmprestimoLivro();
                }

                if (revistasRadioButton.Checked)
                {
                    FuncaoCadastrarEmprestimoRevista();
                }
                if (tgRadioButton.Checked)
                {
                    FuncaoCadastrarTrabalhoGraduacao();
                }
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
            string material = "";
            if (livroRadioButton.Checked)
            {
                material = "livro";
            } else if (revistasRadioButton.Checked)
            {
                material = "revista";
            } else if (tgRadioButton.Checked)
            {
                material = "trabalho graduacao";
            }

            Emprestimo emprestimo = new Emprestimo(
                material,
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

            //emprestimo.AtualizarEmprestimo();
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

        private void tgRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            registroLbl.Text = "Titulo do Trabalho";
        }

        private void livroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            registroLbl.Text = "Numero do Registro";
        }

        private void revistasRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            registroLbl.Text = "Numero do Registro";
        }
    }
}
