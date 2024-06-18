namespace Bibliotec.Forms
{
    partial class BotoesCrud
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
            createBtn = new Button();
            readBtn = new Button();
            crudPanel = new Panel();
            SuspendLayout();
            // 
            // createBtn
            // 
            createBtn.Anchor = AnchorStyles.Top;
            createBtn.AutoSize = true;
            createBtn.BackColor = Color.Maroon;
            createBtn.BackgroundImageLayout = ImageLayout.Center;
            createBtn.FlatStyle = FlatStyle.Popup;
            createBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            createBtn.ForeColor = Color.White;
            createBtn.ImageAlign = ContentAlignment.MiddleLeft;
            createBtn.Location = new Point(243, 12);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(220, 60);
            createBtn.TabIndex = 6;
            createBtn.Text = "Cadastrar";
            createBtn.UseVisualStyleBackColor = false;
            createBtn.Click += createBtn_Click;
            // 
            // readBtn
            // 
            readBtn.Anchor = AnchorStyles.Top;
            readBtn.AutoSize = true;
            readBtn.BackColor = Color.Maroon;
            readBtn.BackgroundImageLayout = ImageLayout.Center;
            readBtn.FlatStyle = FlatStyle.Popup;
            readBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            readBtn.ForeColor = Color.White;
            readBtn.ImageAlign = ContentAlignment.MiddleLeft;
            readBtn.Location = new Point(518, 12);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(220, 60);
            readBtn.TabIndex = 7;
            readBtn.Text = "Ler";
            readBtn.UseVisualStyleBackColor = false;
            readBtn.Click += readBtn_Click;
            // 
            // crudPanel
            // 
            crudPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            crudPanel.BackColor = SystemColors.Control;
            crudPanel.Location = new Point(-4, 121);
            crudPanel.Name = "crudPanel";
            crudPanel.Size = new Size(984, 419);
            crudPanel.TabIndex = 10;
            // 
            // BotoesCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 537);
            Controls.Add(crudPanel);
            Controls.Add(readBtn);
            Controls.Add(createBtn);
            Name = "BotoesCrud";
            Text = "BotoesCrud";
            Load += BotoesCrud_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createBtn;
        private Button readBtn;
        private Panel crudPanel;
    }
}