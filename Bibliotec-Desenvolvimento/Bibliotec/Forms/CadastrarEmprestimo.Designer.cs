namespace Bibliotec.Forms
{
    partial class CadastrarEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarEmprestimo));
            realizarEmprestimoBtn = new Button();
            isbnLbl = new Label();
            isbnTxtB = new TextBox();
            registroLbl = new Label();
            registroTxtB = new TextBox();
            SuspendLayout();
            // 
            // realizarEmprestimoBtn
            // 
            realizarEmprestimoBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            realizarEmprestimoBtn.AutoSize = true;
            realizarEmprestimoBtn.BackColor = Color.Maroon;
            realizarEmprestimoBtn.FlatStyle = FlatStyle.Popup;
            realizarEmprestimoBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            realizarEmprestimoBtn.ForeColor = Color.White;
            realizarEmprestimoBtn.Image = (Image)resources.GetObject("realizarEmprestimoBtn.Image");
            realizarEmprestimoBtn.ImageAlign = ContentAlignment.MiddleLeft;
            realizarEmprestimoBtn.Location = new Point(804, 441);
            realizarEmprestimoBtn.Name = "realizarEmprestimoBtn";
            realizarEmprestimoBtn.Size = new Size(191, 60);
            realizarEmprestimoBtn.TabIndex = 20;
            realizarEmprestimoBtn.TabStop = false;
            realizarEmprestimoBtn.Text = "          Realizar Emprestimo";
            realizarEmprestimoBtn.UseVisualStyleBackColor = false;
            realizarEmprestimoBtn.Click += registerMaterialBtn_Click;
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
            // isbnTxtB
            // 
            isbnTxtB.Anchor = AnchorStyles.None;
            isbnTxtB.BorderStyle = BorderStyle.FixedSingle;
            isbnTxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbnTxtB.Location = new Point(617, 251);
            isbnTxtB.Multiline = true;
            isbnTxtB.Name = "isbnTxtB";
            isbnTxtB.Size = new Size(378, 26);
            isbnTxtB.TabIndex = 19;
            // 
            // registroLbl
            // 
            registroLbl.Anchor = AnchorStyles.None;
            registroLbl.AutoSize = true;
            registroLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registroLbl.Location = new Point(182, 228);
            registroLbl.Name = "registroLbl";
            registroLbl.Size = new Size(157, 20);
            registroLbl.TabIndex = 17;
            registroLbl.Text = "*Numero do Registro";
            // 
            // registroTxtB
            // 
            registroTxtB.Anchor = AnchorStyles.None;
            registroTxtB.BorderStyle = BorderStyle.FixedSingle;
            registroTxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registroTxtB.Location = new Point(182, 251);
            registroTxtB.Multiline = true;
            registroTxtB.Name = "registroTxtB";
            registroTxtB.Size = new Size(378, 26);
            registroTxtB.TabIndex = 18;
            // 
            // EmprestimoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 521);
            Controls.Add(realizarEmprestimoBtn);
            Controls.Add(isbnLbl);
            Controls.Add(isbnTxtB);
            Controls.Add(registroLbl);
            Controls.Add(registroTxtB);
            Name = "EmprestimoForm";
            Text = "Emprestimo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button realizarEmprestimoBtn;
        private Label isbnLbl;
        private TextBox isbnTxtB;
        private Label registroLbl;
        private TextBox registroTxtB;
    }
}