namespace Bibliotec.Forms
{
    partial class Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisar));
            pesquisarLivroBtn = new Button();
            label10 = new Label();
            numDePagTextBox = new TextBox();
            label6 = new Label();
            palavrasChavesTextBox = new TextBox();
            label5 = new Label();
            editoraTextBox = new TextBox();
            label2 = new Label();
            autorTextBox = new TextBox();
            label1 = new Label();
            tituloTextBox = new TextBox();
            assuntoTextBox = new TextBox();
            label3 = new Label();
            generoTextBox = new TextBox();
            label4 = new Label();
            isbnTextBox = new TextBox();
            label9 = new Label();
            edicaoTextBox = new TextBox();
            label8 = new Label();
            notaFiscalTextBox = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // pesquisarLivroBtn
            // 
            pesquisarLivroBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pesquisarLivroBtn.AutoSize = true;
            pesquisarLivroBtn.BackColor = Color.Maroon;
            pesquisarLivroBtn.FlatStyle = FlatStyle.Popup;
            pesquisarLivroBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pesquisarLivroBtn.ForeColor = Color.White;
            pesquisarLivroBtn.Image = (Image)resources.GetObject("pesquisarLivroBtn.Image");
            pesquisarLivroBtn.ImageAlign = ContentAlignment.MiddleLeft;
            pesquisarLivroBtn.Location = new Point(996, 590);
            pesquisarLivroBtn.Name = "pesquisarLivroBtn";
            pesquisarLivroBtn.Size = new Size(191, 60);
            pesquisarLivroBtn.TabIndex = 11;
            pesquisarLivroBtn.Text = "   Pesquisar";
            pesquisarLivroBtn.UseVisualStyleBackColor = false;
            pesquisarLivroBtn.Click += cadastrarMaterialBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(48, 387);
            label10.Name = "label10";
            label10.Size = new Size(177, 25);
            label10.TabIndex = 77;
            label10.Text = "Número de Páginas";
            // 
            // numDePagTextBox
            // 
            numDePagTextBox.BorderStyle = BorderStyle.FixedSingle;
            numDePagTextBox.Location = new Point(48, 415);
            numDePagTextBox.Multiline = true;
            numDePagTextBox.Name = "numDePagTextBox";
            numDePagTextBox.Size = new Size(423, 29);
            numDePagTextBox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(48, 307);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 69;
            label6.Text = "Palavras Chaves";
            // 
            // palavrasChavesTextBox
            // 
            palavrasChavesTextBox.BorderStyle = BorderStyle.FixedSingle;
            palavrasChavesTextBox.Location = new Point(48, 335);
            palavrasChavesTextBox.Multiline = true;
            palavrasChavesTextBox.Name = "palavrasChavesTextBox";
            palavrasChavesTextBox.Size = new Size(423, 29);
            palavrasChavesTextBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(47, 227);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 67;
            label5.Text = "Editora";
            // 
            // editoraTextBox
            // 
            editoraTextBox.BorderStyle = BorderStyle.FixedSingle;
            editoraTextBox.Location = new Point(48, 255);
            editoraTextBox.Multiline = true;
            editoraTextBox.Name = "editoraTextBox";
            editoraTextBox.Size = new Size(423, 29);
            editoraTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 149);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 61;
            label2.Text = "Autor";
            // 
            // autorTextBox
            // 
            autorTextBox.BorderStyle = BorderStyle.FixedSingle;
            autorTextBox.Location = new Point(48, 177);
            autorTextBox.Multiline = true;
            autorTextBox.Name = "autorTextBox";
            autorTextBox.Size = new Size(423, 29);
            autorTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 73);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 59;
            label1.Text = "*Título";
            // 
            // tituloTextBox
            // 
            tituloTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tituloTextBox.BorderStyle = BorderStyle.FixedSingle;
            tituloTextBox.Location = new Point(764, 100);
            tituloTextBox.Multiline = true;
            tituloTextBox.Name = "tituloTextBox";
            tituloTextBox.Size = new Size(423, 29);
            tituloTextBox.TabIndex = 6;
            // 
            // assuntoTextBox
            // 
            assuntoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            assuntoTextBox.BorderStyle = BorderStyle.FixedSingle;
            assuntoTextBox.Location = new Point(764, 335);
            assuntoTextBox.Multiline = true;
            assuntoTextBox.Name = "assuntoTextBox";
            assuntoTextBox.Size = new Size(423, 29);
            assuntoTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(764, 307);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 63;
            label3.Text = "Assunto";
            // 
            // generoTextBox
            // 
            generoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            generoTextBox.BorderStyle = BorderStyle.FixedSingle;
            generoTextBox.Location = new Point(764, 415);
            generoTextBox.Multiline = true;
            generoTextBox.Name = "generoTextBox";
            generoTextBox.Size = new Size(423, 29);
            generoTextBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(764, 387);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 65;
            label4.Text = "Gênero";
            // 
            // isbnTextBox
            // 
            isbnTextBox.BorderStyle = BorderStyle.FixedSingle;
            isbnTextBox.Location = new Point(48, 101);
            isbnTextBox.Multiline = true;
            isbnTextBox.Name = "isbnTextBox";
            isbnTextBox.Size = new Size(423, 29);
            isbnTextBox.TabIndex = 1;
            isbnTextBox.TextChanged += isbnTextBox_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(764, 73);
            label9.Name = "label9";
            label9.Size = new Size(60, 25);
            label9.TabIndex = 71;
            label9.Text = "*ISBN";
            // 
            // edicaoTextBox
            // 
            edicaoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edicaoTextBox.BorderStyle = BorderStyle.FixedSingle;
            edicaoTextBox.Location = new Point(764, 177);
            edicaoTextBox.Multiline = true;
            edicaoTextBox.Name = "edicaoTextBox";
            edicaoTextBox.Size = new Size(423, 29);
            edicaoTextBox.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(764, 149);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 73;
            label8.Text = "Edição";
            // 
            // notaFiscalTextBox
            // 
            notaFiscalTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            notaFiscalTextBox.BorderStyle = BorderStyle.FixedSingle;
            notaFiscalTextBox.Location = new Point(764, 255);
            notaFiscalTextBox.Multiline = true;
            notaFiscalTextBox.Name = "notaFiscalTextBox";
            notaFiscalTextBox.Size = new Size(423, 29);
            notaFiscalTextBox.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(764, 227);
            label7.Name = "label7";
            label7.Size = new Size(104, 25);
            label7.TabIndex = 75;
            label7.Text = "Nota Fiscal";
            // 
            // Pesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1226, 678);
            Controls.Add(label10);
            Controls.Add(numDePagTextBox);
            Controls.Add(label7);
            Controls.Add(notaFiscalTextBox);
            Controls.Add(label8);
            Controls.Add(edicaoTextBox);
            Controls.Add(label9);
            Controls.Add(isbnTextBox);
            Controls.Add(label6);
            Controls.Add(palavrasChavesTextBox);
            Controls.Add(label5);
            Controls.Add(editoraTextBox);
            Controls.Add(label4);
            Controls.Add(generoTextBox);
            Controls.Add(label3);
            Controls.Add(assuntoTextBox);
            Controls.Add(label2);
            Controls.Add(autorTextBox);
            Controls.Add(label1);
            Controls.Add(tituloTextBox);
            Controls.Add(pesquisarLivroBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Pesquisar";
            Text = "Pesquisar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button pesquisarLivroBtn;
        private Label label10;
        private TextBox numDePagTextBox;
        private Label label6;
        private TextBox palavrasChavesTextBox;
        private Label label5;
        private TextBox editoraTextBox;
        private Label label2;
        private TextBox autorTextBox;
        private Label label1;
        private TextBox tituloTextBox;
        private TextBox assuntoTextBox;
        private Label label3;
        private TextBox generoTextBox;
        private Label label4;
        private TextBox isbnTextBox;
        private Label label9;
        private TextBox edicaoTextBox;
        private Label label8;
        private TextBox notaFiscalTextBox;
        private Label label7;
    }
}