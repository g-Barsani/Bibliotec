namespace Bibliotec.Forms.Data_grid_forms
{
    partial class CamposUsuario
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
            RATxtB = new TextBox();
            RALbl = new Label();
            schoolEmailTxtB = new TextBox();
            schoolEmailLbl = new Label();
            SuspendLayout();
            // 
            // RATxtB
            // 
            RATxtB.Anchor = AnchorStyles.None;
            RATxtB.BackColor = Color.White;
            RATxtB.BorderStyle = BorderStyle.FixedSingle;
            RATxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RATxtB.ForeColor = Color.Black;
            RATxtB.Location = new Point(106, 138);
            RATxtB.Multiline = true;
            RATxtB.Name = "RATxtB";
            RATxtB.Size = new Size(378, 26);
            RATxtB.TabIndex = 26;
            // 
            // RALbl
            // 
            RALbl.Anchor = AnchorStyles.None;
            RALbl.AutoSize = true;
            RALbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RALbl.ForeColor = Color.Black;
            RALbl.Location = new Point(109, 115);
            RALbl.Name = "RALbl";
            RALbl.Size = new Size(178, 20);
            RALbl.TabIndex = 25;
            RALbl.Text = "Número de Registro/RA";
            // 
            // schoolEmailTxtB
            // 
            schoolEmailTxtB.Anchor = AnchorStyles.None;
            schoolEmailTxtB.BackColor = Color.White;
            schoolEmailTxtB.BorderStyle = BorderStyle.FixedSingle;
            schoolEmailTxtB.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            schoolEmailTxtB.ForeColor = Color.Black;
            schoolEmailTxtB.Location = new Point(548, 138);
            schoolEmailTxtB.Multiline = true;
            schoolEmailTxtB.Name = "schoolEmailTxtB";
            schoolEmailTxtB.Size = new Size(378, 26);
            schoolEmailTxtB.TabIndex = 28;
            // 
            // schoolEmailLbl
            // 
            schoolEmailLbl.Anchor = AnchorStyles.None;
            schoolEmailLbl.AutoSize = true;
            schoolEmailLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            schoolEmailLbl.ForeColor = Color.Black;
            schoolEmailLbl.Location = new Point(549, 115);
            schoolEmailLbl.Name = "schoolEmailLbl";
            schoolEmailLbl.Size = new Size(137, 20);
            schoolEmailLbl.TabIndex = 27;
            schoolEmailLbl.Text = "Email Institucional";
            // 
            // CamposUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 176);
            Controls.Add(schoolEmailTxtB);
            Controls.Add(schoolEmailLbl);
            Controls.Add(RATxtB);
            Controls.Add(RALbl);
            Name = "CamposUsuario";
            Text = "CamposUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RATxtB;
        private Label RALbl;
        private TextBox schoolEmailTxtB;
        private Label schoolEmailLbl;
    }
}