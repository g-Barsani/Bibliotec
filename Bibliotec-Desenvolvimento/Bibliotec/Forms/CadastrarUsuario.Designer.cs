namespace Bibliotec.Forms
{
    partial class CadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarUsuario));
            subtitleLbl = new Label();
            isbnLbl = new Label();
            genderLbl = new Label();
            genderTextB = new TextBox();
            authorLbl = new Label();
            titleLbl = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SignInBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // subtitleLbl
            // 
            subtitleLbl.Anchor = AnchorStyles.Left;
            subtitleLbl.AutoSize = true;
            subtitleLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subtitleLbl.ForeColor = SystemColors.ButtonFace;
            subtitleLbl.Location = new Point(144, 197);
            subtitleLbl.Name = "subtitleLbl";
            subtitleLbl.Size = new Size(32, 20);
            subtitleLbl.TabIndex = 11;
            subtitleLbl.Text = "RA";
            // 
            // isbnLbl
            // 
            isbnLbl.Anchor = AnchorStyles.Right;
            isbnLbl.AutoSize = true;
            isbnLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbnLbl.ForeColor = SystemColors.ButtonFace;
            isbnLbl.Location = new Point(702, 109);
            isbnLbl.Name = "isbnLbl";
            isbnLbl.Size = new Size(48, 20);
            isbnLbl.TabIndex = 12;
            isbnLbl.Text = "Email";
            // 
            // genderLbl
            // 
            genderLbl.Anchor = AnchorStyles.Right;
            genderLbl.AutoSize = true;
            genderLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            genderLbl.ForeColor = SystemColors.ButtonFace;
            genderLbl.Location = new Point(702, 197);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(153, 20);
            genderLbl.TabIndex = 13;
            genderLbl.Text = "Número de Telefone";
            // 
            // genderTextB
            // 
            genderTextB.Anchor = AnchorStyles.Right;
            genderTextB.BackColor = Color.FromArgb(146, 15, 15);
            genderTextB.BorderStyle = BorderStyle.FixedSingle;
            genderTextB.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            genderTextB.ForeColor = SystemColors.Menu;
            genderTextB.Location = new Point(702, 230);
            genderTextB.Multiline = true;
            genderTextB.Name = "genderTextB";
            genderTextB.Size = new Size(343, 36);
            genderTextB.TabIndex = 21;
            // 
            // authorLbl
            // 
            authorLbl.Anchor = AnchorStyles.Left;
            authorLbl.AutoSize = true;
            authorLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorLbl.ForeColor = SystemColors.ButtonFace;
            authorLbl.Location = new Point(142, 283);
            authorLbl.Name = "authorLbl";
            authorLbl.Size = new Size(34, 20);
            authorLbl.TabIndex = 15;
            authorLbl.Text = "RG";
            // 
            // titleLbl
            // 
            titleLbl.Anchor = AnchorStyles.Left;
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.ForeColor = SystemColors.ButtonFace;
            titleLbl.Location = new Point(142, 109);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(123, 20);
            titleLbl.TabIndex = 16;
            titleLbl.Text = "Nome Completo";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(146, 15, 15);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(702, 141);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 36);
            textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.BackColor = Color.FromArgb(146, 15, 15);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.Menu;
            textBox2.Location = new Point(142, 141);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 36);
            textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.BackColor = Color.FromArgb(146, 15, 15);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.Menu;
            textBox3.Location = new Point(142, 230);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(343, 36);
            textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left;
            textBox4.BackColor = Color.FromArgb(146, 15, 15);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.Menu;
            textBox4.Location = new Point(144, 316);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(343, 36);
            textBox4.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(469, -69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 222);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(463, 122);
            label2.Name = "label2";
            label2.Size = new Size(252, 31);
            label2.TabIndex = 28;
            label2.Text = "Cadastrar Usuário";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Aluno", "Professor" });
            comboBox1.Location = new Point(492, 248);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(210, 23);
            comboBox1.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(536, 225);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 30;
            label1.Text = "Tipo de Usuário";
            // 
            // SignInBtn
            // 
            SignInBtn.Anchor = AnchorStyles.None;
            SignInBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SignInBtn.Location = new Point(505, 316);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(183, 54);
            SignInBtn.TabIndex = 31;
            SignInBtn.Text = "Cadastrar";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // CadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(72, 0, 0);
            ClientSize = new Size(1176, 521);
            Controls.Add(SignInBtn);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(subtitleLbl);
            Controls.Add(isbnLbl);
            Controls.Add(genderLbl);
            Controls.Add(genderTextB);
            Controls.Add(authorLbl);
            Controls.Add(titleLbl);
            Name = "CadastrarUsuario";
            Text = "CadastrarUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label subtitleLbl;
        private Label isbnLbl;
        private Label genderLbl;
        private TextBox genderTextB;
        private Label authorLbl;
        private Label titleLbl;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private PictureBox pictureBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button SignInBtn;
    }
}