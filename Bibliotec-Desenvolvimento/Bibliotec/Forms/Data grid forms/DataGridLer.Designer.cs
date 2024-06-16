namespace Bibliotec.Forms
{
    partial class DataGridLer
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
            Dtgv = new DataGridView();
            searchBtn = new Button();
            camposPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)Dtgv).BeginInit();
            SuspendLayout();
            // 
            // Dtgv
            // 
            Dtgv.Anchor = AnchorStyles.None;
            Dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            Dtgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dtgv.Location = new Point(0, 296);
            Dtgv.Name = "Dtgv";
            Dtgv.RowTemplate.Height = 25;
            Dtgv.Size = new Size(1103, 306);
            Dtgv.TabIndex = 0;
            Dtgv.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.None;
            searchBtn.BackColor = Color.Maroon;
            searchBtn.ForeColor = SystemColors.ButtonHighlight;
            searchBtn.Location = new Point(969, 232);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(134, 58);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Pesquisar";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += button1_Click;
            // 
            // camposPanel
            // 
            camposPanel.Anchor = AnchorStyles.None;
            camposPanel.BackColor = SystemColors.ActiveCaption;
            camposPanel.Location = new Point(0, 124);
            camposPanel.Name = "camposPanel";
            camposPanel.Size = new Size(963, 166);
            camposPanel.TabIndex = 2;
            // 
            // DataGridLer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 602);
            Controls.Add(camposPanel);
            Controls.Add(searchBtn);
            Controls.Add(Dtgv);
            Name = "DataGridLer";
            Text = "DataGridLer";
            ((System.ComponentModel.ISupportInitialize)Dtgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Dtgv;
        private Button searchBtn;
        private Panel camposPanel;
    }
}