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
            editBtn = new Button();
            deleteBtn = new Button();
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
            createBtn.Location = new Point(11, 12);
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
            readBtn.Location = new Point(259, 12);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(220, 60);
            readBtn.TabIndex = 7;
            readBtn.Text = "Ler";
            readBtn.UseVisualStyleBackColor = false;
            // 
            // editBtn
            // 
            editBtn.Anchor = AnchorStyles.Top;
            editBtn.AutoSize = true;
            editBtn.BackColor = Color.Maroon;
            editBtn.BackgroundImageLayout = ImageLayout.Center;
            editBtn.FlatStyle = FlatStyle.Popup;
            editBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            editBtn.ForeColor = Color.White;
            editBtn.ImageAlign = ContentAlignment.MiddleLeft;
            editBtn.Location = new Point(506, 12);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(220, 60);
            editBtn.TabIndex = 8;
            editBtn.Text = "Editar";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Top;
            deleteBtn.AutoSize = true;
            deleteBtn.BackColor = Color.Maroon;
            deleteBtn.BackgroundImageLayout = ImageLayout.Center;
            deleteBtn.FlatStyle = FlatStyle.Popup;
            deleteBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteBtn.Location = new Point(749, 12);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(220, 60);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Deletar";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // BotoesCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 88);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(readBtn);
            Controls.Add(createBtn);
            Name = "BotoesCrud";
            Text = "BotoesCrud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createBtn;
        private Button readBtn;
        private Button editBtn;
        private Button deleteBtn;
    }
}