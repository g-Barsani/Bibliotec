namespace Bibliotec.Forms
{
    partial class CadastrarExemplar
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
            sampleNumberTxt = new TextBox();
            isbnTxt = new TextBox();
            schoolEmailLbl = new Label();
            userNamelbl = new Label();
            label1 = new Label();
            availableCheckBox = new CheckBox();
            redTargeCheckBox = new CheckBox();
            acquisitionMethodComboBox = new ComboBox();
            registerSamplelBtn = new Button();
            updateSamplelBtn = new Button();
            SuspendLayout();
            // 
            // sampleNumberTxt
            // 
            sampleNumberTxt.Anchor = AnchorStyles.None;
            sampleNumberTxt.BackColor = Color.White;
            sampleNumberTxt.BorderStyle = BorderStyle.FixedSingle;
            sampleNumberTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sampleNumberTxt.ForeColor = Color.Black;
            sampleNumberTxt.Location = new Point(145, 142);
            sampleNumberTxt.Multiline = true;
            sampleNumberTxt.Name = "sampleNumberTxt";
            sampleNumberTxt.Size = new Size(378, 26);
            sampleNumberTxt.TabIndex = 41;
            sampleNumberTxt.TextChanged += userNameTxtB_TextChanged;
            // 
            // isbnTxt
            // 
            isbnTxt.Anchor = AnchorStyles.None;
            isbnTxt.BackColor = Color.White;
            isbnTxt.BorderStyle = BorderStyle.FixedSingle;
            isbnTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isbnTxt.ForeColor = Color.Black;
            isbnTxt.Location = new Point(649, 142);
            isbnTxt.Multiline = true;
            isbnTxt.Name = "isbnTxt";
            isbnTxt.Size = new Size(378, 26);
            isbnTxt.TabIndex = 40;
            // 
            // schoolEmailLbl
            // 
            schoolEmailLbl.Anchor = AnchorStyles.None;
            schoolEmailLbl.AutoSize = true;
            schoolEmailLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            schoolEmailLbl.ForeColor = Color.Black;
            schoolEmailLbl.Location = new Point(654, 119);
            schoolEmailLbl.Name = "schoolEmailLbl";
            schoolEmailLbl.Size = new Size(47, 20);
            schoolEmailLbl.TabIndex = 37;
            schoolEmailLbl.Text = "ISBN";
            // 
            // userNamelbl
            // 
            userNamelbl.Anchor = AnchorStyles.None;
            userNamelbl.AutoSize = true;
            userNamelbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userNamelbl.ForeColor = Color.Black;
            userNamelbl.Location = new Point(150, 119);
            userNamelbl.Name = "userNamelbl";
            userNamelbl.Size = new Size(135, 20);
            userNamelbl.TabIndex = 39;
            userNamelbl.Text = "Número Exemplar";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(150, 230);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 45;
            label1.Text = "Forma Aquisição";
            // 
            // availableCheckBox
            // 
            availableCheckBox.Anchor = AnchorStyles.None;
            availableCheckBox.AutoSize = true;
            availableCheckBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            availableCheckBox.Location = new Point(654, 254);
            availableCheckBox.Name = "availableCheckBox";
            availableCheckBox.Size = new Size(100, 24);
            availableCheckBox.TabIndex = 49;
            availableCheckBox.Text = "Disponível";
            availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // redTargeCheckBox
            // 
            redTargeCheckBox.Anchor = AnchorStyles.None;
            redTargeCheckBox.AutoSize = true;
            redTargeCheckBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            redTargeCheckBox.Location = new Point(892, 254);
            redTargeCheckBox.Name = "redTargeCheckBox";
            redTargeCheckBox.Size = new Size(135, 24);
            redTargeCheckBox.TabIndex = 50;
            redTargeCheckBox.Text = "Tarja Vermelha";
            redTargeCheckBox.UseVisualStyleBackColor = true;
            // 
            // acquisitionMethodComboBox
            // 
            acquisitionMethodComboBox.Anchor = AnchorStyles.None;
            acquisitionMethodComboBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            acquisitionMethodComboBox.FormattingEnabled = true;
            acquisitionMethodComboBox.Items.AddRange(new object[] { "Compra", "Doação" });
            acquisitionMethodComboBox.Location = new Point(145, 254);
            acquisitionMethodComboBox.Name = "acquisitionMethodComboBox";
            acquisitionMethodComboBox.Size = new Size(378, 28);
            acquisitionMethodComboBox.TabIndex = 51;
            acquisitionMethodComboBox.SelectedIndexChanged += acquisitionMethodComboBox_SelectedIndexChanged;
            // 
            // registerSamplelBtn
            // 
            registerSamplelBtn.Anchor = AnchorStyles.None;
            registerSamplelBtn.AutoSize = true;
            registerSamplelBtn.BackColor = Color.Maroon;
            registerSamplelBtn.FlatStyle = FlatStyle.Popup;
            registerSamplelBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            registerSamplelBtn.ForeColor = Color.White;
            registerSamplelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            registerSamplelBtn.Location = new Point(649, 324);
            registerSamplelBtn.Name = "registerSamplelBtn";
            registerSamplelBtn.Size = new Size(191, 60);
            registerSamplelBtn.TabIndex = 52;
            registerSamplelBtn.Text = "Cadastrar Exemplar";
            registerSamplelBtn.UseVisualStyleBackColor = false;
            registerSamplelBtn.Click += registerSamplelBtn_Click;
            // 
            // updateSamplelBtn
            // 
            updateSamplelBtn.Anchor = AnchorStyles.None;
            updateSamplelBtn.AutoSize = true;
            updateSamplelBtn.BackColor = Color.Maroon;
            updateSamplelBtn.FlatStyle = FlatStyle.Popup;
            updateSamplelBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            updateSamplelBtn.ForeColor = Color.White;
            updateSamplelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            updateSamplelBtn.Location = new Point(846, 324);
            updateSamplelBtn.Name = "updateSamplelBtn";
            updateSamplelBtn.Size = new Size(191, 60);
            updateSamplelBtn.TabIndex = 53;
            updateSamplelBtn.Text = "Atualizar Exemplar";
            updateSamplelBtn.UseVisualStyleBackColor = false;
            updateSamplelBtn.Click += updateSamplelBtn_Click;
            // 
            // CadastrarExemplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 521);
            Controls.Add(updateSamplelBtn);
            Controls.Add(registerSamplelBtn);
            Controls.Add(acquisitionMethodComboBox);
            Controls.Add(redTargeCheckBox);
            Controls.Add(availableCheckBox);
            Controls.Add(label1);
            Controls.Add(sampleNumberTxt);
            Controls.Add(isbnTxt);
            Controls.Add(schoolEmailLbl);
            Controls.Add(userNamelbl);
            Name = "CadastrarExemplar";
            Text = "CadastrarExemplar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox sampleNumberTxt;
        private TextBox isbnTxt;
        private Label schoolEmailLbl;
        private Label userNamelbl;
        private Label label1;
        private CheckBox availableCheckBox;
        private CheckBox redTargeCheckBox;
        private ComboBox acquisitionMethodComboBox;
        private Button registerSamplelBtn;
        private Button updateSamplelBtn;
    }
}