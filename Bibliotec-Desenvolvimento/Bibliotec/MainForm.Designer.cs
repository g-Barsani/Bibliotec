namespace Bibliotec
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            optionsPanel = new Panel();
            logInLabel = new LinkLabel();
            accessLabel = new LinkLabel();
            helpLabel = new LinkLabel();
            homePanel = new Panel();
            homeBtn = new Button();
            searchBtn = new Button();
            repositoryBtn = new Button();
            registerMaterialBtn = new Button();
            borrowingBtn = new Button();
            headerBox = new PictureBox();
            navigationPanel = new Panel();
            registerUserBtn = new Button();
            logo = new PictureBox();
            closeBtn = new Button();
            optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)headerBox).BeginInit();
            navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // optionsPanel
            // 
            optionsPanel.Anchor = AnchorStyles.Top;
            optionsPanel.AutoSize = true;
            optionsPanel.BackColor = Color.Maroon;
            optionsPanel.BorderStyle = BorderStyle.FixedSingle;
            optionsPanel.Controls.Add(logInLabel);
            optionsPanel.Controls.Add(accessLabel);
            optionsPanel.Controls.Add(helpLabel);
            optionsPanel.Location = new Point(0, 191);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(1192, 25);
            optionsPanel.TabIndex = 12;
            // 
            // logInLabel
            // 
            logInLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logInLabel.AutoSize = true;
            logInLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            logInLabel.ForeColor = Color.White;
            logInLabel.LinkColor = Color.White;
            logInLabel.Location = new Point(1111, -1);
            logInLabel.Name = "logInLabel";
            logInLabel.Size = new Size(43, 17);
            logInLabel.TabIndex = 9;
            logInLabel.TabStop = true;
            logInLabel.Text = "Entrar";
            // 
            // accessLabel
            // 
            accessLabel.AutoSize = true;
            accessLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            accessLabel.ForeColor = Color.White;
            accessLabel.LinkColor = Color.White;
            accessLabel.Location = new Point(50, 0);
            accessLabel.Name = "accessLabel";
            accessLabel.Size = new Size(88, 17);
            accessLabel.TabIndex = 8;
            accessLabel.TabStop = true;
            accessLabel.Text = "Acessiblidade";
            // 
            // helpLabel
            // 
            helpLabel.AutoSize = true;
            helpLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            helpLabel.ForeColor = Color.White;
            helpLabel.LinkColor = Color.White;
            helpLabel.Location = new Point(3, 0);
            helpLabel.Name = "helpLabel";
            helpLabel.Size = new Size(41, 17);
            helpLabel.TabIndex = 7;
            helpLabel.TabStop = true;
            helpLabel.Text = "Ajuda";
            // 
            // homePanel
            // 
            homePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homePanel.BackColor = SystemColors.ButtonFace;
            homePanel.Location = new Point(0, 212);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(1192, 515);
            homePanel.TabIndex = 0;
            // 
            // homeBtn
            // 
            homeBtn.Anchor = AnchorStyles.Top;
            homeBtn.AutoSize = true;
            homeBtn.BackColor = Color.Maroon;
            homeBtn.BackgroundImageLayout = ImageLayout.Center;
            homeBtn.FlatStyle = FlatStyle.Popup;
            homeBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            homeBtn.ForeColor = Color.White;
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(2, 128);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(140, 60);
            homeBtn.TabIndex = 1;
            homeBtn.Text = "      Home";
            homeBtn.UseVisualStyleBackColor = false;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top;
            searchBtn.AutoSize = true;
            searchBtn.BackColor = Color.Maroon;
            searchBtn.BackgroundImageLayout = ImageLayout.Center;
            searchBtn.FlatStyle = FlatStyle.Popup;
            searchBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.ForeColor = Color.White;
            searchBtn.Image = (Image)resources.GetObject("searchBtn.Image");
            searchBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchBtn.Location = new Point(151, 128);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(139, 60);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "         Pesquisa";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += SearchBtn_Click;
            // 
            // repositoryBtn
            // 
            repositoryBtn.Anchor = AnchorStyles.Top;
            repositoryBtn.AutoSize = true;
            repositoryBtn.BackColor = Color.Maroon;
            repositoryBtn.BackgroundImageLayout = ImageLayout.Center;
            repositoryBtn.FlatStyle = FlatStyle.Popup;
            repositoryBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            repositoryBtn.ForeColor = Color.White;
            repositoryBtn.Image = (Image)resources.GetObject("repositoryBtn.Image");
            repositoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            repositoryBtn.Location = new Point(699, 128);
            repositoryBtn.Name = "repositoryBtn";
            repositoryBtn.Size = new Size(220, 60);
            repositoryBtn.TabIndex = 5;
            repositoryBtn.Text = "           Repositório Institucional";
            repositoryBtn.UseVisualStyleBackColor = false;
            // 
            // registerMaterialBtn
            // 
            registerMaterialBtn.Anchor = AnchorStyles.Top;
            registerMaterialBtn.AutoSize = true;
            registerMaterialBtn.BackColor = Color.Maroon;
            registerMaterialBtn.FlatStyle = FlatStyle.Popup;
            registerMaterialBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            registerMaterialBtn.ForeColor = Color.White;
            registerMaterialBtn.Image = (Image)resources.GetObject("registerMaterialBtn.Image");
            registerMaterialBtn.ImageAlign = ContentAlignment.MiddleLeft;
            registerMaterialBtn.Location = new Point(299, 128);
            registerMaterialBtn.Name = "registerMaterialBtn";
            registerMaterialBtn.Size = new Size(191, 60);
            registerMaterialBtn.TabIndex = 3;
            registerMaterialBtn.Text = "          Cadastrar Material";
            registerMaterialBtn.UseVisualStyleBackColor = false;
            registerMaterialBtn.Click += CadastrarMaterialBtn_Click;
            // 
            // borrowingBtn
            // 
            borrowingBtn.Anchor = AnchorStyles.Top;
            borrowingBtn.AutoSize = true;
            borrowingBtn.BackColor = Color.Maroon;
            borrowingBtn.FlatStyle = FlatStyle.Popup;
            borrowingBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            borrowingBtn.ForeColor = Color.White;
            borrowingBtn.Image = (Image)resources.GetObject("borrowingBtn.Image");
            borrowingBtn.ImageAlign = ContentAlignment.MiddleLeft;
            borrowingBtn.Location = new Point(927, 128);
            borrowingBtn.Name = "borrowingBtn";
            borrowingBtn.Size = new Size(265, 60);
            borrowingBtn.TabIndex = 6;
            borrowingBtn.Text = "            Emprestimo";
            borrowingBtn.TextAlign = ContentAlignment.MiddleLeft;
            borrowingBtn.UseVisualStyleBackColor = false;
            borrowingBtn.Click += borrowingBtn_Click;
            // 
            // headerBox
            // 
            headerBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerBox.BackColor = Color.Maroon;
            headerBox.BackgroundImage = (Image)resources.GetObject("headerBox.BackgroundImage");
            headerBox.BackgroundImageLayout = ImageLayout.Zoom;
            headerBox.Location = new Point(0, 0);
            headerBox.Name = "headerBox";
            headerBox.Size = new Size(1192, 125);
            headerBox.SizeMode = PictureBoxSizeMode.StretchImage;
            headerBox.TabIndex = 0;
            headerBox.TabStop = false;
            // 
            // navigationPanel
            // 
            navigationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            navigationPanel.BackColor = SystemColors.ButtonFace;
            navigationPanel.Controls.Add(registerUserBtn);
            navigationPanel.Controls.Add(logo);
            navigationPanel.Controls.Add(closeBtn);
            navigationPanel.Controls.Add(optionsPanel);
            navigationPanel.Controls.Add(headerBox);
            navigationPanel.Controls.Add(borrowingBtn);
            navigationPanel.Controls.Add(registerMaterialBtn);
            navigationPanel.Controls.Add(repositoryBtn);
            navigationPanel.Controls.Add(searchBtn);
            navigationPanel.Controls.Add(homeBtn);
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(1192, 210);
            navigationPanel.TabIndex = 30;
            // 
            // registerUserBtn
            // 
            registerUserBtn.Anchor = AnchorStyles.Top;
            registerUserBtn.AutoSize = true;
            registerUserBtn.BackColor = Color.Maroon;
            registerUserBtn.FlatStyle = FlatStyle.Popup;
            registerUserBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            registerUserBtn.ForeColor = Color.White;
            registerUserBtn.Image = (Image)resources.GetObject("registerUserBtn.Image");
            registerUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            registerUserBtn.Location = new Point(499, 128);
            registerUserBtn.Name = "registerUserBtn";
            registerUserBtn.Size = new Size(191, 60);
            registerUserBtn.TabIndex = 4;
            registerUserBtn.Text = "          Cadastrar Usuário";
            registerUserBtn.UseVisualStyleBackColor = false;
            registerUserBtn.Click += registerUserBtn_Click;
            // 
            // logo
            // 
            logo.BackColor = Color.Maroon;
            logo.BackgroundImage = Properties.Resources.Logo_biblioteca11;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(12, 12);
            logo.Name = "logo";
            logo.Size = new Size(110, 97);
            logo.TabIndex = 31;
            logo.TabStop = false;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeBtn.BackColor = Color.Maroon;
            closeBtn.BackgroundImage = Properties.Resources.baseline_close_white_24dp;
            closeBtn.BackgroundImageLayout = ImageLayout.Center;
            closeBtn.Location = new Point(1141, 3);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(48, 44);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 727);
            Controls.Add(navigationPanel);
            Controls.Add(homePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1208, 766);
            Name = "MainForm";
            Text = "Bibliotec";
            Load += MainForm_Load;
            optionsPanel.ResumeLayout(false);
            optionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)headerBox).EndInit();
            navigationPanel.ResumeLayout(false);
            navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel optionsPanel;
        private LinkLabel accessLabel;
        private LinkLabel helpLabel;
        private LinkLabel logInLabel;
        private Panel homePanel;
        private Button searchBtn;
        private Button homeBtn;
        private Button repositoryBtn;
        private Button registerMaterialBtn;
        private Button borrowingBtn;
        private PictureBox headerBox;
        private Panel navigationPanel;
        private Button closeBtn;
        private PictureBox logo;
        private Button registerUserBtn;
    }
}