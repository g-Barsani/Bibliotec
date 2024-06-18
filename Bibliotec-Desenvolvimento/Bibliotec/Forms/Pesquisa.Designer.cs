namespace Bibliotec.Forms
{
    partial class Pesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa));
            searchBookBtn = new Button();
            authorLbl = new Label();
            authorTextB = new TextBox();
            titleLbl = new Label();
            subjectTextB = new TextBox();
            subjectLbl = new Label();
            titleTextB = new TextBox();
            resultBookSearch = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)resultBookSearch).BeginInit();
            SuspendLayout();
            // 
            // searchBookBtn
            // 
            searchBookBtn.Anchor = AnchorStyles.None;
            searchBookBtn.AutoSize = true;
            searchBookBtn.BackColor = Color.Maroon;
            searchBookBtn.FlatStyle = FlatStyle.Popup;
            searchBookBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBookBtn.ForeColor = Color.White;
            searchBookBtn.Image = (Image)resources.GetObject("searchBookBtn.Image");
            searchBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchBookBtn.Location = new Point(157, 308);
            searchBookBtn.Name = "searchBookBtn";
            searchBookBtn.Size = new Size(164, 61);
            searchBookBtn.TabIndex = 11;
            searchBookBtn.Text = "   Pesquisar";
            searchBookBtn.UseVisualStyleBackColor = false;
            searchBookBtn.Click += SearchBookBtn_Click;
            // 
            // authorLbl
            // 
            authorLbl.Anchor = AnchorStyles.None;
            authorLbl.AutoSize = true;
            authorLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorLbl.Location = new Point(42, 142);
            authorLbl.Name = "authorLbl";
            authorLbl.Size = new Size(48, 20);
            authorLbl.TabIndex = 61;
            authorLbl.Text = "Autor";
            // 
            // authorTextB
            // 
            authorTextB.Anchor = AnchorStyles.None;
            authorTextB.BorderStyle = BorderStyle.FixedSingle;
            authorTextB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            authorTextB.Location = new Point(42, 165);
            authorTextB.Multiline = true;
            authorTextB.Name = "authorTextB";
            authorTextB.Size = new Size(396, 29);
            authorTextB.TabIndex = 2;
            // 
            // titleLbl
            // 
            titleLbl.Anchor = AnchorStyles.None;
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.Location = new Point(42, 71);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(53, 20);
            titleLbl.TabIndex = 59;
            titleLbl.Text = "*Título";
            // 
            // subjectTextB
            // 
            subjectTextB.Anchor = AnchorStyles.None;
            subjectTextB.BorderStyle = BorderStyle.FixedSingle;
            subjectTextB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subjectTextB.Location = new Point(42, 240);
            subjectTextB.Multiline = true;
            subjectTextB.Name = "subjectTextB";
            subjectTextB.Size = new Size(396, 29);
            subjectTextB.TabIndex = 9;
            // 
            // subjectLbl
            // 
            subjectLbl.Anchor = AnchorStyles.None;
            subjectLbl.AutoSize = true;
            subjectLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            subjectLbl.Location = new Point(42, 217);
            subjectLbl.Name = "subjectLbl";
            subjectLbl.Size = new Size(68, 20);
            subjectLbl.TabIndex = 63;
            subjectLbl.Text = "Assunto";
            // 
            // titleTextB
            // 
            titleTextB.Anchor = AnchorStyles.None;
            titleTextB.BorderStyle = BorderStyle.FixedSingle;
            titleTextB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleTextB.Location = new Point(42, 94);
            titleTextB.Multiline = true;
            titleTextB.Name = "titleTextB";
            titleTextB.Size = new Size(396, 29);
            titleTextB.TabIndex = 1;
            // 
            // resultBookSearch
            // 
            resultBookSearch.Anchor = AnchorStyles.None;
            resultBookSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultBookSearch.Location = new Point(531, 71);
            resultBookSearch.Name = "resultBookSearch";
            resultBookSearch.ReadOnly = true;
            resultBookSearch.RowTemplate.Height = 25;
            resultBookSearch.Size = new Size(604, 334);
            resultBookSearch.TabIndex = 0;
            // 
            // Pesquisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1176, 476);
            Controls.Add(resultBookSearch);
            Controls.Add(titleTextB);
            Controls.Add(subjectLbl);
            Controls.Add(subjectTextB);
            Controls.Add(authorLbl);
            Controls.Add(authorTextB);
            Controls.Add(titleLbl);
            Controls.Add(searchBookBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Pesquisa";
            Text = "x";
            ((System.ComponentModel.ISupportInitialize)resultBookSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button searchBookBtn;
        private Label authorLbl;
        private TextBox authorTextB;
        private Label titleLbl;
        private TextBox subjectTextB;
        private Label subjectLbl;
        private TextBox titleTextB;
        private DataGridView resultBookSearch;
    }
}