namespace Bibliotec
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            HomePanel = new Panel();
            btn_Home = new Button();
            searchBtn = new Button();
            button2 = new Button();
            cadastrarMaterialBtn = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            btn_Close = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Maroon;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 19);
            panel1.TabIndex = 12;
            // 
            // linkLabel3
            // 
            linkLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel3.ForeColor = Color.White;
            linkLabel3.LinkColor = Color.White;
            linkLabel3.Location = new Point(1118, 0);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(43, 17);
            linkLabel3.TabIndex = 14;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Entrar";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.ForeColor = Color.White;
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(50, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(88, 17);
            linkLabel2.TabIndex = 14;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Acessiblidade";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(3, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(41, 17);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Ajuda";
            // 
            // HomePanel
            // 
            HomePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            HomePanel.AutoSize = true;
            HomePanel.BackColor = SystemColors.ButtonFace;
            HomePanel.Location = new Point(0, 212);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(1192, 519);
            HomePanel.TabIndex = 28;
            // 
            // btn_Home
            // 
            btn_Home.Anchor = AnchorStyles.Top;
            btn_Home.AutoSize = true;
            btn_Home.BackColor = Color.Maroon;
            btn_Home.BackgroundImageLayout = ImageLayout.Center;
            btn_Home.FlatStyle = FlatStyle.Popup;
            btn_Home.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Home.ForeColor = Color.White;
            btn_Home.Image = (Image)resources.GetObject("btn_Home.Image");
            btn_Home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Home.Location = new Point(70, 129);
            btn_Home.Name = "btn_Home";
            btn_Home.Size = new Size(171, 60);
            btn_Home.TabIndex = 31;
            btn_Home.Text = "    Home";
            btn_Home.UseVisualStyleBackColor = false;
            btn_Home.Click += btn_Home_Click;
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
            searchBtn.Location = new Point(247, 129);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(149, 60);
            searchBtn.TabIndex = 30;
            searchBtn.Text = "     Pesquisa";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.AutoSize = true;
            button2.BackColor = Color.Maroon;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(599, 129);
            button2.Name = "button2";
            button2.Size = new Size(220, 60);
            button2.TabIndex = 32;
            button2.Text = "         Repositório Institucional";
            button2.UseVisualStyleBackColor = false;
            // 
            // cadastrarMaterialBtn
            // 
            cadastrarMaterialBtn.Anchor = AnchorStyles.Top;
            cadastrarMaterialBtn.AutoSize = true;
            cadastrarMaterialBtn.BackColor = Color.Maroon;
            cadastrarMaterialBtn.FlatStyle = FlatStyle.Popup;
            cadastrarMaterialBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cadastrarMaterialBtn.ForeColor = Color.White;
            cadastrarMaterialBtn.Image = (Image)resources.GetObject("cadastrarMaterialBtn.Image");
            cadastrarMaterialBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cadastrarMaterialBtn.Location = new Point(402, 129);
            cadastrarMaterialBtn.Name = "cadastrarMaterialBtn";
            cadastrarMaterialBtn.Size = new Size(191, 60);
            cadastrarMaterialBtn.TabIndex = 33;
            cadastrarMaterialBtn.Text = "        Cadastrar Material";
            cadastrarMaterialBtn.UseVisualStyleBackColor = false;
            cadastrarMaterialBtn.Click += cadastrarMaterialBtn_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.AutoSize = true;
            button5.BackColor = Color.Maroon;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(825, 129);
            button5.Name = "button5";
            button5.Size = new Size(296, 60);
            button5.TabIndex = 34;
            button5.Text = "      Levantamentos Bibliográficos";
            button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Maroon;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1192, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btn_Close);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(cadastrarMaterialBtn);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(searchBtn);
            panel3.Controls.Add(btn_Home);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1192, 210);
            panel3.TabIndex = 30;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Maroon;
            pictureBox2.BackgroundImage = Properties.Resources.Logo_biblioteca11;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 97);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Close.BackColor = Color.Maroon;
            btn_Close.BackgroundImage = Properties.Resources.baseline_close_white_24dp;
            btn_Close.BackgroundImageLayout = ImageLayout.Center;
            btn_Close.Location = new Point(1141, 3);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(48, 36);
            btn_Close.TabIndex = 0;
            btn_Close.UseVisualStyleBackColor = false;
            btn_Close.Click += btn_Close_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 727);
            Controls.Add(panel3);
            Controls.Add(HomePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(1208, 766);
            Name = "Form1";
            Text = "Bibliotec";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel3;
        private Panel HomePanel;
        private Button searchBtn;
        private Button btn_Home;
        private Button button2;
        private Button cadastrarMaterialBtn;
        private Button button5;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btn_Close;
        private PictureBox pictureBox2;
    }
}