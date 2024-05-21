namespace Bibliotec.Forms
{
    partial class Emprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emprestimo));
            registerMaterialBtn = new Button();
            isbnLbl = new Label();
            isbnTextB = new TextBox();
            titleLbl = new Label();
            titleTextB = new TextBox();
            SuspendLayout();
            // 
            // registerMaterialBtn
            // 
            registerMaterialBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            registerMaterialBtn.AutoSize = true;
            registerMaterialBtn.BackColor = Color.Maroon;
            registerMaterialBtn.FlatStyle = FlatStyle.Popup;
            registerMaterialBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            registerMaterialBtn.ForeColor = Color.White;
            registerMaterialBtn.Image = (Image)resources.GetObject("registerMaterialBtn.Image");
            registerMaterialBtn.ImageAlign = ContentAlignment.MiddleLeft;
            registerMaterialBtn.Location = new Point(804, 441);
            registerMaterialBtn.Name = "registerMaterialBtn";
            registerMaterialBtn.Size = new Size(191, 60);
            registerMaterialBtn.TabIndex = 20;
            registerMaterialBtn.TabStop = false;
            registerMaterialBtn.Text = "          Realizar Emprestimo";
            registerMaterialBtn.UseVisualStyleBackColor = false;
            // 
            // isbnLbl
            // 
            isbnLbl.Anchor = AnchorStyles.None;
            isbnLbl.AutoSize = true;
            isbnLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbnLbl.Location = new Point(617, 228);
            isbnLbl.Name = "isbnLbl";
            isbnLbl.Size = new Size(91, 20);
            isbnLbl.TabIndex = 16;
            isbnLbl.Text = "*ID do Livro";
            // 
            // isbnTextB
            // 
            isbnTextB.Anchor = AnchorStyles.None;
            isbnTextB.BorderStyle = BorderStyle.FixedSingle;
            isbnTextB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbnTextB.Location = new Point(617, 251);
            isbnTextB.Multiline = true;
            isbnTextB.Name = "isbnTextB";
            isbnTextB.Size = new Size(378, 26);
            isbnTextB.TabIndex = 19;
            // 
            // titleLbl
            // 
            titleLbl.Anchor = AnchorStyles.None;
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.Location = new Point(182, 228);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(157, 20);
            titleLbl.TabIndex = 17;
            titleLbl.Text = "*Numero do Registro";
            // 
            // titleTextB
            // 
            titleTextB.Anchor = AnchorStyles.None;
            titleTextB.BorderStyle = BorderStyle.FixedSingle;
            titleTextB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleTextB.Location = new Point(182, 251);
            titleTextB.Multiline = true;
            titleTextB.Name = "titleTextB";
            titleTextB.Size = new Size(378, 26);
            titleTextB.TabIndex = 18;
            // 
            // Emprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 521);
            Controls.Add(registerMaterialBtn);
            Controls.Add(isbnLbl);
            Controls.Add(isbnTextB);
            Controls.Add(titleLbl);
            Controls.Add(titleTextB);
            Name = "Emprestimo";
            Text = "Emprestimo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerMaterialBtn;
        private Label isbnLbl;
        private TextBox isbnTextB;
        private Label titleLbl;
        private TextBox titleTextB;
    }
}