namespace Bibliotec.Forms.Data_grid_forms
{
    partial class CamposMaterial
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
            isbnLbl = new Label();
            isbnTextB = new TextBox();
            titleLbl = new Label();
            titleTextB = new TextBox();
            mostrarExemplarCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // isbnLbl
            // 
            isbnLbl.Anchor = AnchorStyles.None;
            isbnLbl.AutoSize = true;
            isbnLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbnLbl.Location = new Point(423, 115);
            isbnLbl.Name = "isbnLbl";
            isbnLbl.Size = new Size(53, 20);
            isbnLbl.TabIndex = 10;
            isbnLbl.Text = "*ISBN";
            // 
            // isbnTextB
            // 
            isbnTextB.Anchor = AnchorStyles.None;
            isbnTextB.BorderStyle = BorderStyle.FixedSingle;
            isbnTextB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbnTextB.Location = new Point(423, 138);
            isbnTextB.Multiline = true;
            isbnTextB.Name = "isbnTextB";
            isbnTextB.Size = new Size(295, 26);
            isbnTextB.TabIndex = 14;
            isbnTextB.TextChanged += isbnTextB_TextChanged;
            // 
            // titleLbl
            // 
            titleLbl.Anchor = AnchorStyles.None;
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleLbl.Location = new Point(81, 115);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(53, 20);
            titleLbl.TabIndex = 12;
            titleLbl.Text = "*Título";
            // 
            // titleTextB
            // 
            titleTextB.Anchor = AnchorStyles.None;
            titleTextB.BorderStyle = BorderStyle.FixedSingle;
            titleTextB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleTextB.Location = new Point(81, 138);
            titleTextB.Multiline = true;
            titleTextB.Name = "titleTextB";
            titleTextB.Size = new Size(320, 26);
            titleTextB.TabIndex = 13;
            titleTextB.TextChanged += titleTextB_TextChanged;
            // 
            // mostrarExemplarCheckbox
            // 
            mostrarExemplarCheckbox.AutoSize = true;
            mostrarExemplarCheckbox.Location = new Point(738, 143);
            mostrarExemplarCheckbox.Name = "mostrarExemplarCheckbox";
            mostrarExemplarCheckbox.Size = new Size(130, 19);
            mostrarExemplarCheckbox.TabIndex = 15;
            mostrarExemplarCheckbox.Text = "Mostrar Exemplares";
            mostrarExemplarCheckbox.UseVisualStyleBackColor = true;
            mostrarExemplarCheckbox.CheckedChanged += mostrarExemplarCheckbox_CheckedChanged;
            // 
            // CamposMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 176);
            Controls.Add(mostrarExemplarCheckbox);
            Controls.Add(isbnLbl);
            Controls.Add(isbnTextB);
            Controls.Add(titleLbl);
            Controls.Add(titleTextB);
            Name = "CamposMaterial";
            Text = "Campos Material";
            Load += CamposMaterial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label isbnLbl;
        private TextBox isbnTextB;
        private Label titleLbl;
        private TextBox titleTextB;
        private CheckBox mostrarExemplarCheckbox;
    }
}