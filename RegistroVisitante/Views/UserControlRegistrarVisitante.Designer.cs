namespace RegistroVisitante.Views
{
    partial class UserControlRegistrarVisitante
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            labelNome = new Label();
            labelRG = new Label();
            labelBloco = new Label();
            label1 = new Label();
            textBoxNome = new TextBox();
            textBoxRG = new TextBox();
            comboBoxBloco = new ComboBox();
            comboBoxApto = new ComboBox();
            buttonLimpar = new Button();
            buttonRegistrar = new Button();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.None;
            labelNome.AutoSize = true;
            labelNome.Location = new Point(34, 47);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(99, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome Completo:";
            // 
            // labelRG
            // 
            labelRG.Anchor = AnchorStyles.None;
            labelRG.AutoSize = true;
            labelRG.Location = new Point(34, 93);
            labelRG.Name = "labelRG";
            labelRG.Size = new Size(25, 15);
            labelRG.TabIndex = 1;
            labelRG.Text = "RG:";
            // 
            // labelBloco
            // 
            labelBloco.Anchor = AnchorStyles.None;
            labelBloco.AutoSize = true;
            labelBloco.Location = new Point(34, 161);
            labelBloco.Name = "labelBloco";
            labelBloco.Size = new Size(40, 15);
            labelBloco.TabIndex = 2;
            labelBloco.Text = "Bloco:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(216, 161);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Apto:";
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.None;
            textBoxNome.Location = new Point(139, 44);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(291, 23);
            textBoxNome.TabIndex = 4;
            // 
            // textBoxRG
            // 
            textBoxRG.Anchor = AnchorStyles.None;
            textBoxRG.Location = new Point(65, 90);
            textBoxRG.Name = "textBoxRG";
            textBoxRG.Size = new Size(100, 23);
            textBoxRG.TabIndex = 5;
            // 
            // comboBoxBloco
            // 
            comboBoxBloco.Anchor = AnchorStyles.None;
            comboBoxBloco.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBloco.FormattingEnabled = true;
            comboBoxBloco.Items.AddRange(new object[] { "A", "B" });
            comboBoxBloco.Location = new Point(80, 158);
            comboBoxBloco.Name = "comboBoxBloco";
            comboBoxBloco.Size = new Size(121, 23);
            comboBoxBloco.TabIndex = 6;
            // 
            // comboBoxApto
            // 
            comboBoxApto.Anchor = AnchorStyles.None;
            comboBoxApto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxApto.FormattingEnabled = true;
            comboBoxApto.Items.AddRange(new object[] { "T1", "T2", "T3", "T4" });
            comboBoxApto.Location = new Point(258, 158);
            comboBoxApto.Name = "comboBoxApto";
            comboBoxApto.Size = new Size(121, 23);
            comboBoxApto.TabIndex = 7;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Anchor = AnchorStyles.None;
            buttonLimpar.BackColor = Color.Khaki;
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Location = new Point(80, 338);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(121, 29);
            buttonLimpar.TabIndex = 8;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.Anchor = AnchorStyles.None;
            buttonRegistrar.BackColor = Color.DarkSeaGreen;
            buttonRegistrar.FlatStyle = FlatStyle.Flat;
            buttonRegistrar.Location = new Point(258, 338);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new Size(121, 29);
            buttonRegistrar.TabIndex = 9;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_ClickAsync;
            // 
            // UserControlRegistrarVisitante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRegistrar);
            Controls.Add(buttonLimpar);
            Controls.Add(comboBoxApto);
            Controls.Add(comboBoxBloco);
            Controls.Add(textBoxRG);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Controls.Add(labelBloco);
            Controls.Add(labelRG);
            Controls.Add(labelNome);
            Name = "UserControlRegistrarVisitante";
            Size = new Size(492, 395);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelRG;
        private Label labelBloco;
        private Label label1;
        private TextBox textBoxNome;
        private TextBox textBoxRG;
        private ComboBox comboBoxBloco;
        private ComboBox comboBoxApto;
        private Button buttonLimpar;
        private Button buttonRegistrar;
    }
}
