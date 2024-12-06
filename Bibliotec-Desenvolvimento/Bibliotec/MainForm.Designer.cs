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
            homeBtn = new Button();
            materialBtn = new Button();
            headerBox = new PictureBox();
            navigationPanel = new Panel();
            userBtn = new Button();
            logo = new PictureBox();
            closeBtn = new Button();
            borrowingBtn = new Button();
            btnsPanel = new Panel();
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
            optionsPanel.Location = new Point(16, 191);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(1192, 25);
            optionsPanel.TabIndex = 12;
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
            homeBtn.Location = new Point(49, 128);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(260, 60);
            homeBtn.TabIndex = 1;
            homeBtn.Text = "      Home";
            homeBtn.UseVisualStyleBackColor = false;
            // 
            // materialBtn
            // 
            materialBtn.Anchor = AnchorStyles.Top;
            materialBtn.AutoSize = true;
            materialBtn.BackColor = Color.Maroon;
            materialBtn.FlatStyle = FlatStyle.Popup;
            materialBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            materialBtn.ForeColor = Color.White;
            materialBtn.Image = (Image)resources.GetObject("materialBtn.Image");
            materialBtn.ImageAlign = ContentAlignment.MiddleLeft;
            materialBtn.Location = new Point(315, 128);
            materialBtn.Name = "materialBtn";
            materialBtn.Size = new Size(294, 60);
            materialBtn.TabIndex = 3;
            materialBtn.Text = "   Material";
            materialBtn.UseVisualStyleBackColor = false;
            materialBtn.Click += CadastrarMaterialBtn_Click;
            // 
            // headerBox
            // 
            headerBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerBox.BackColor = Color.Maroon;
            headerBox.BackgroundImage = (Image)resources.GetObject("headerBox.BackgroundImage");
            headerBox.BackgroundImageLayout = ImageLayout.Zoom;
            headerBox.Location = new Point(0, 0);
            headerBox.Name = "headerBox";
            headerBox.Size = new Size(1224, 125);
            headerBox.SizeMode = PictureBoxSizeMode.StretchImage;
            headerBox.TabIndex = 0;
            headerBox.TabStop = false;
            // 
            // navigationPanel
            // 
            navigationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            navigationPanel.BackColor = SystemColors.ButtonFace;
            navigationPanel.Controls.Add(userBtn);
            navigationPanel.Controls.Add(logo);
            navigationPanel.Controls.Add(closeBtn);
            navigationPanel.Controls.Add(optionsPanel);
            navigationPanel.Controls.Add(headerBox);
            navigationPanel.Controls.Add(materialBtn);
            navigationPanel.Controls.Add(borrowingBtn);
            navigationPanel.Controls.Add(homeBtn);
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(1224, 210);
            navigationPanel.TabIndex = 30;
            navigationPanel.Paint += navigationPanel_Paint;
            // 
            // userBtn
            // 
            userBtn.Anchor = AnchorStyles.Top;
            userBtn.AutoSize = true;
            userBtn.BackColor = Color.Maroon;
            userBtn.FlatStyle = FlatStyle.Popup;
            userBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            userBtn.ForeColor = Color.White;
            userBtn.Image = (Image)resources.GetObject("userBtn.Image");
            userBtn.ImageAlign = ContentAlignment.MiddleLeft;
            userBtn.Location = new Point(615, 128);
            userBtn.Name = "userBtn";
            userBtn.Size = new Size(266, 60);
            userBtn.TabIndex = 4;
            userBtn.Text = "  Estudantes";
            userBtn.UseVisualStyleBackColor = false;
            userBtn.Click += registerUserBtn_Click;
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
            closeBtn.Location = new Point(1160, 3);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(48, 44);
            closeBtn.TabIndex = 0;
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += CloseBtn_Click;
            // 
            // borrowingBtn
            // 
            borrowingBtn.Anchor = AnchorStyles.Top;
            borrowingBtn.AutoSize = true;
            borrowingBtn.BackColor = Color.Maroon;
            borrowingBtn.BackgroundImageLayout = ImageLayout.Center;
            borrowingBtn.FlatStyle = FlatStyle.Popup;
            borrowingBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            borrowingBtn.ForeColor = Color.White;
            borrowingBtn.Image = (Image)resources.GetObject("borrowingBtn.Image");
            borrowingBtn.ImageAlign = ContentAlignment.MiddleLeft;
            borrowingBtn.Location = new Point(887, 128);
            borrowingBtn.Name = "borrowingBtn";
            borrowingBtn.Size = new Size(284, 60);
            borrowingBtn.TabIndex = 5;
            borrowingBtn.Text = "Empréstimos";
            borrowingBtn.UseVisualStyleBackColor = false;
            borrowingBtn.Click += borrowingBtn_Click;
            // 
            // btnsPanel
            // 
            btnsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnsPanel.BackColor = SystemColors.Control;
            btnsPanel.Location = new Point(2, 212);
            btnsPanel.Name = "btnsPanel";
            btnsPanel.Size = new Size(1222, 596);
            btnsPanel.TabIndex = 0;
            btnsPanel.Paint += btnsPanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 766);
            Controls.Add(btnsPanel);
            Controls.Add(navigationPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1208, 766);
            Name = "MainForm";
            Text = "Bibliotec";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)headerBox).EndInit();
            navigationPanel.ResumeLayout(false);
            navigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel optionsPanel;
        private Button homeBtn;
        private Button materialBtn;
        private PictureBox headerBox;
        private Panel navigationPanel;
        private Button closeBtn;
        private PictureBox logo;
        private Button userBtn;
        private Button borrowingBtn;
        private Panel btnsPanel;
    }
}