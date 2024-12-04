namespace Bibliotec.Forms
{
    partial class CadastrarEmprestimo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarEmprestimo));
            registrarDevolucaoBtn = new Button();
            isbnLbl = new Label();
            raAlunoTxtB = new TextBox();
            registroLbl = new Label();
            registroTxtB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataEmprestimoTxtB = new MaskedTextBox();
            dataDevolucaoTxtB = new MaskedTextBox();
            previsaoDevolucaoTxtB = new MaskedTextBox();
            label3 = new Label();
            realizarEmprestimoBtn = new Button();
            atualizarEmprestimoBtn = new Button();
            SuspendLayout();
            // 
            // registrarDevolucaoBtn
            // 
            registrarDevolucaoBtn.Anchor = AnchorStyles.None;
            registrarDevolucaoBtn.AutoSize = true;
            registrarDevolucaoBtn.BackColor = Color.Maroon;
            registrarDevolucaoBtn.FlatStyle = FlatStyle.Popup;
            registrarDevolucaoBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            registrarDevolucaoBtn.ForeColor = Color.White;
            registrarDevolucaoBtn.Image = (Image)resources.GetObject("registrarDevolucaoBtn.Image");
            registrarDevolucaoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            registrarDevolucaoBtn.Location = new Point(815, 272);
            registrarDevolucaoBtn.Name = "registrarDevolucaoBtn";
            registrarDevolucaoBtn.Size = new Size(191, 60);
            registrarDevolucaoBtn.TabIndex = 20;
            registrarDevolucaoBtn.TabStop = false;
            registrarDevolucaoBtn.Text = "          Registrar Devolução";
            registrarDevolucaoBtn.UseVisualStyleBackColor = false;
            registrarDevolucaoBtn.Click += registrarDevolucaoBtn_Click;
            // 
            // isbnLbl
            // 
            isbnLbl.Anchor = AnchorStyles.None;
            isbnLbl.AutoSize = true;
            isbnLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbnLbl.Location = new Point(628, 78);
            isbnLbl.Name = "isbnLbl";
            isbnLbl.Size = new Size(105, 20);
            isbnLbl.TabIndex = 16;
            isbnLbl.Text = "*RA do Aluno";
            // 
            // raAlunoTxtB
            // 
            raAlunoTxtB.Anchor = AnchorStyles.None;
            raAlunoTxtB.BorderStyle = BorderStyle.FixedSingle;
            raAlunoTxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            raAlunoTxtB.Location = new Point(628, 101);
            raAlunoTxtB.Multiline = true;
            raAlunoTxtB.Name = "raAlunoTxtB";
            raAlunoTxtB.Size = new Size(378, 26);
            raAlunoTxtB.TabIndex = 19;
            // 
            // registroLbl
            // 
            registroLbl.Anchor = AnchorStyles.None;
            registroLbl.AutoSize = true;
            registroLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registroLbl.Location = new Point(193, 78);
            registroLbl.Name = "registroLbl";
            registroLbl.Size = new Size(157, 20);
            registroLbl.TabIndex = 17;
            registroLbl.Text = "*Numero do Registro";
            // 
            // registroTxtB
            // 
            registroTxtB.Anchor = AnchorStyles.None;
            registroTxtB.BorderStyle = BorderStyle.FixedSingle;
            registroTxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registroTxtB.Location = new Point(193, 101);
            registroTxtB.Multiline = true;
            registroTxtB.Name = "registroTxtB";
            registroTxtB.Size = new Size(378, 26);
            registroTxtB.TabIndex = 18;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(193, 172);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 21;
            label1.Text = "*Data do Empréstimo";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(628, 172);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 22;
            label2.Text = "Data da Devolução";
            // 
            // dataEmprestimoTxtB
            // 
            dataEmprestimoTxtB.Anchor = AnchorStyles.None;
            dataEmprestimoTxtB.BorderStyle = BorderStyle.FixedSingle;
            dataEmprestimoTxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataEmprestimoTxtB.Location = new Point(193, 195);
            dataEmprestimoTxtB.Mask = "00/00/0000";
            dataEmprestimoTxtB.Name = "dataEmprestimoTxtB";
            dataEmprestimoTxtB.Size = new Size(172, 26);
            dataEmprestimoTxtB.TabIndex = 23;
            dataEmprestimoTxtB.ValidatingType = typeof(DateTime);
            // 
            // dataDevolucaoTxtB
            // 
            dataDevolucaoTxtB.Anchor = AnchorStyles.None;
            dataDevolucaoTxtB.BorderStyle = BorderStyle.FixedSingle;
            dataDevolucaoTxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataDevolucaoTxtB.Location = new Point(628, 195);
            dataDevolucaoTxtB.Mask = "00/00/0000";
            dataDevolucaoTxtB.Name = "dataDevolucaoTxtB";
            dataDevolucaoTxtB.Size = new Size(378, 26);
            dataDevolucaoTxtB.TabIndex = 24;
            dataDevolucaoTxtB.ValidatingType = typeof(DateTime);
            dataDevolucaoTxtB.MaskInputRejected += dataDevolucaoTxtB_MaskInputRejected;
            // 
            // previsaoDevolucaoTxtB
            // 
            previsaoDevolucaoTxtB.Anchor = AnchorStyles.None;
            previsaoDevolucaoTxtB.BorderStyle = BorderStyle.FixedSingle;
            previsaoDevolucaoTxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            previsaoDevolucaoTxtB.Location = new Point(385, 195);
            previsaoDevolucaoTxtB.Mask = "00/00/0000";
            previsaoDevolucaoTxtB.Name = "previsaoDevolucaoTxtB";
            previsaoDevolucaoTxtB.Size = new Size(186, 26);
            previsaoDevolucaoTxtB.TabIndex = 26;
            previsaoDevolucaoTxtB.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(385, 172);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 25;
            label3.Text = "*Devolução Prevista";
            label3.Click += label3_Click;
            // 
            // realizarEmprestimoBtn
            // 
            realizarEmprestimoBtn.Anchor = AnchorStyles.None;
            realizarEmprestimoBtn.AutoSize = true;
            realizarEmprestimoBtn.BackColor = Color.Maroon;
            realizarEmprestimoBtn.FlatStyle = FlatStyle.Popup;
            realizarEmprestimoBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            realizarEmprestimoBtn.ForeColor = Color.White;
            realizarEmprestimoBtn.Image = (Image)resources.GetObject("realizarEmprestimoBtn.Image");
            realizarEmprestimoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            realizarEmprestimoBtn.Location = new Point(193, 272);
            realizarEmprestimoBtn.Name = "realizarEmprestimoBtn";
            realizarEmprestimoBtn.Size = new Size(191, 60);
            realizarEmprestimoBtn.TabIndex = 27;
            realizarEmprestimoBtn.TabStop = false;
            realizarEmprestimoBtn.Text = "          Realizar Emprestimo";
            realizarEmprestimoBtn.UseVisualStyleBackColor = false;
            realizarEmprestimoBtn.Click += registerMaterialBtn_Click;
            // 
            // atualizarEmprestimoBtn
            // 
            atualizarEmprestimoBtn.Anchor = AnchorStyles.None;
            atualizarEmprestimoBtn.AutoSize = true;
            atualizarEmprestimoBtn.BackColor = Color.Maroon;
            atualizarEmprestimoBtn.FlatStyle = FlatStyle.Popup;
            atualizarEmprestimoBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            atualizarEmprestimoBtn.ForeColor = Color.White;
            atualizarEmprestimoBtn.Image = (Image)resources.GetObject("atualizarEmprestimoBtn.Image");
            atualizarEmprestimoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            atualizarEmprestimoBtn.Location = new Point(193, 370);
            atualizarEmprestimoBtn.Name = "atualizarEmprestimoBtn";
            atualizarEmprestimoBtn.Size = new Size(191, 60);
            atualizarEmprestimoBtn.TabIndex = 28;
            atualizarEmprestimoBtn.TabStop = false;
            atualizarEmprestimoBtn.Text = "          Atualizar Emprestimo";
            atualizarEmprestimoBtn.UseVisualStyleBackColor = false;
            atualizarEmprestimoBtn.Click += atualizarEmprestimoBtn_Click;
            // 
            // CadastrarEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 521);
            Controls.Add(atualizarEmprestimoBtn);
            Controls.Add(realizarEmprestimoBtn);
            Controls.Add(previsaoDevolucaoTxtB);
            Controls.Add(label3);
            Controls.Add(dataDevolucaoTxtB);
            Controls.Add(dataEmprestimoTxtB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registrarDevolucaoBtn);
            Controls.Add(isbnLbl);
            Controls.Add(raAlunoTxtB);
            Controls.Add(registroLbl);
            Controls.Add(registroTxtB);
            Name = "CadastrarEmprestimo";
            Text = "Emprestimo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registrarDevolucaoBtn;
        private Label isbnLbl;
        private TextBox raAlunoTxtB;
        private Label registroLbl;
        private TextBox registroTxtB;
        private Label label1;
        private Label label2;
        private MaskedTextBox dataEmprestimoTxtB;
        private MaskedTextBox dataDevolucaoTxtB;
        private MaskedTextBox previsaoDevolucaoTxtB;
        private Label label3;
        private Button realizarEmprestimoBtn;
        private Button atualizarEmprestimoBtn;
    }
}