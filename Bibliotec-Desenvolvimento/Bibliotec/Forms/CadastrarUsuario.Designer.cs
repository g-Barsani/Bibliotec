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
            RALbl = new Label();
            schoolEmailLbl = new Label();
            userPhoneLbl = new Label();
            userNamelbl = new Label();
            schoolEmailTxtB = new TextBox();
            userNameTxtB = new TextBox();
            RATxtB = new TextBox();
            userTypeComboB = new ComboBox();
            userTypeLbl = new Label();
            registerUserlBtn = new Button();
            userPhoneMskTxtB = new MaskedTextBox();
            SuspendLayout();
            // 
            // RALbl
            // 
            RALbl.Anchor = AnchorStyles.None;
            RALbl.AutoSize = true;
            RALbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RALbl.ForeColor = Color.Black;
            RALbl.Location = new Point(167, 228);
            RALbl.Name = "RALbl";
            RALbl.Size = new Size(178, 20);
            RALbl.TabIndex = 11;
            RALbl.Text = "Número de Registro/RA";
            // 
            // schoolEmailLbl
            // 
            schoolEmailLbl.Anchor = AnchorStyles.None;
            schoolEmailLbl.AutoSize = true;
            schoolEmailLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            schoolEmailLbl.ForeColor = Color.Black;
            schoolEmailLbl.Location = new Point(674, 110);
            schoolEmailLbl.Name = "schoolEmailLbl";
            schoolEmailLbl.Size = new Size(137, 20);
            schoolEmailLbl.TabIndex = 12;
            schoolEmailLbl.Text = "Email Institucional";
            // 
            // userPhoneLbl
            // 
            userPhoneLbl.Anchor = AnchorStyles.None;
            userPhoneLbl.AutoSize = true;
            userPhoneLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userPhoneLbl.ForeColor = Color.Black;
            userPhoneLbl.Location = new Point(673, 228);
            userPhoneLbl.Name = "userPhoneLbl";
            userPhoneLbl.Size = new Size(153, 20);
            userPhoneLbl.TabIndex = 13;
            userPhoneLbl.Text = "Número de Telefone";
            // 
            // userNamelbl
            // 
            userNamelbl.Anchor = AnchorStyles.None;
            userNamelbl.AutoSize = true;
            userNamelbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userNamelbl.ForeColor = Color.Black;
            userNamelbl.Location = new Point(169, 110);
            userNamelbl.Name = "userNamelbl";
            userNamelbl.Size = new Size(123, 20);
            userNamelbl.TabIndex = 16;
            userNamelbl.Text = "Nome Completo";
            // 
            // schoolEmailTxtB
            // 
            schoolEmailTxtB.Anchor = AnchorStyles.None;
            schoolEmailTxtB.BackColor = Color.White;
            schoolEmailTxtB.BorderStyle = BorderStyle.FixedSingle;
            schoolEmailTxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            schoolEmailTxtB.ForeColor = Color.Black;
            schoolEmailTxtB.Location = new Point(673, 133);
            schoolEmailTxtB.Multiline = true;
            schoolEmailTxtB.Name = "schoolEmailTxtB";
            schoolEmailTxtB.Size = new Size(378, 26);
            schoolEmailTxtB.TabIndex = 22;
            // 
            // userNameTxtB
            // 
            userNameTxtB.Anchor = AnchorStyles.None;
            userNameTxtB.BackColor = Color.White;
            userNameTxtB.BorderStyle = BorderStyle.FixedSingle;
            userNameTxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userNameTxtB.ForeColor = Color.Black;
            userNameTxtB.Location = new Point(164, 133);
            userNameTxtB.Multiline = true;
            userNameTxtB.Name = "userNameTxtB";
            userNameTxtB.Size = new Size(378, 26);
            userNameTxtB.TabIndex = 23;
            // 
            // RATxtB
            // 
            RATxtB.Anchor = AnchorStyles.None;
            RATxtB.BackColor = Color.White;
            RATxtB.BorderStyle = BorderStyle.FixedSingle;
            RATxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RATxtB.ForeColor = Color.Black;
            RATxtB.Location = new Point(164, 251);
            RATxtB.Multiline = true;
            RATxtB.Name = "RATxtB";
            RATxtB.Size = new Size(378, 26);
            RATxtB.TabIndex = 24;
            // 
            // userTypeComboB
            // 
            userTypeComboB.Anchor = AnchorStyles.None;
            userTypeComboB.ForeColor = Color.Black;
            userTypeComboB.FormattingEnabled = true;
            userTypeComboB.Items.AddRange(new object[] { "Aluno", "Professor", "Funcionário" });
            userTypeComboB.Location = new Point(164, 354);
            userTypeComboB.Name = "userTypeComboB";
            userTypeComboB.Size = new Size(210, 23);
            userTypeComboB.TabIndex = 29;
            // 
            // userTypeLbl
            // 
            userTypeLbl.Anchor = AnchorStyles.None;
            userTypeLbl.AutoSize = true;
            userTypeLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point);
            userTypeLbl.ForeColor = Color.Black;
            userTypeLbl.Location = new Point(169, 331);
            userTypeLbl.Name = "userTypeLbl";
            userTypeLbl.Size = new Size(120, 20);
            userTypeLbl.TabIndex = 30;
            userTypeLbl.Text = "Tipo de Usuário";
            // 
            // registerUserlBtn
            // 
            registerUserlBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            registerUserlBtn.AutoSize = true;
            registerUserlBtn.BackColor = Color.Maroon;
            registerUserlBtn.FlatStyle = FlatStyle.Popup;
            registerUserlBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            registerUserlBtn.ForeColor = Color.White;
            registerUserlBtn.Image = (Image)resources.GetObject("registerUserlBtn.Image");
            registerUserlBtn.ImageAlign = ContentAlignment.MiddleLeft;
            registerUserlBtn.Location = new Point(802, 333);
            registerUserlBtn.Name = "registerUserlBtn";
            registerUserlBtn.Size = new Size(191, 60);
            registerUserlBtn.TabIndex = 32;
            registerUserlBtn.Text = "  Cadastrar";
            registerUserlBtn.UseVisualStyleBackColor = false;
            registerUserlBtn.Click += registerUserlBtn_Click;
            // 
            // userPhoneMskTxtB
            // 
            userPhoneMskTxtB.Anchor = AnchorStyles.None;
            userPhoneMskTxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userPhoneMskTxtB.Location = new Point(673, 251);
            userPhoneMskTxtB.Mask = "(99)00000-0000";
            userPhoneMskTxtB.Name = "userPhoneMskTxtB";
            userPhoneMskTxtB.Size = new Size(378, 26);
            userPhoneMskTxtB.TabIndex = 35;
            // 
            // CadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1176, 521);
            Controls.Add(userPhoneMskTxtB);
            Controls.Add(registerUserlBtn);
            Controls.Add(userTypeLbl);
            Controls.Add(userTypeComboB);
            Controls.Add(RATxtB);
            Controls.Add(userNameTxtB);
            Controls.Add(schoolEmailTxtB);
            Controls.Add(RALbl);
            Controls.Add(schoolEmailLbl);
            Controls.Add(userPhoneLbl);
            Controls.Add(userNamelbl);
            Location = new Point(804, 441);
            Name = "CadastrarUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RALbl;
        private Label schoolEmailLbl;
        private Label userPhoneLbl;
        private Label userNamelbl;
        private TextBox schoolEmailTxtB;
        private TextBox userNameTxtB;
        private TextBox RATxtB;
        private ComboBox userTypeComboB;
        private Label userTypeLbl;
        private Button registerUserlBtn;
        private MaskedTextBox userPhoneMskTxtB;
    }
}