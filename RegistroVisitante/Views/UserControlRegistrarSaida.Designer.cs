namespace RegistroVisitante.Views
{
    partial class UserControlRegistrarSaida
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
            dataGridView = new DataGridView();
            comboBoxBloco = new ComboBox();
            textBoxRG = new TextBox();
            textBoxNome = new TextBox();
            label1 = new Label();
            labelBloco = new Label();
            labelRG = new Label();
            labelNome = new Label();
            buttonRegistrarSaida = new Button();
            buttonLimpar = new Button();
            textBoxID = new TextBox();
            labelID = new Label();
            comboBoxApto = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Bottom;
            dataGridView.Location = new Point(0, 275);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(542, 150);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // comboBoxBloco
            // 
            comboBoxBloco.Anchor = AnchorStyles.None;
            comboBoxBloco.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBloco.Enabled = false;
            comboBoxBloco.FormattingEnabled = true;
            comboBoxBloco.Items.AddRange(new object[] { "A", "B" });
            comboBoxBloco.Location = new Point(112, 155);
            comboBoxBloco.Name = "comboBoxBloco";
            comboBoxBloco.Size = new Size(121, 23);
            comboBoxBloco.TabIndex = 14;
            // 
            // textBoxRG
            // 
            textBoxRG.Anchor = AnchorStyles.None;
            textBoxRG.Enabled = false;
            textBoxRG.Location = new Point(97, 87);
            textBoxRG.Name = "textBoxRG";
            textBoxRG.Size = new Size(100, 23);
            textBoxRG.TabIndex = 13;
            // 
            // textBoxNome
            // 
            textBoxNome.Anchor = AnchorStyles.None;
            textBoxNome.Enabled = false;
            textBoxNome.Location = new Point(171, 41);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(291, 23);
            textBoxNome.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(248, 158);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 11;
            label1.Text = "Apto:";
            // 
            // labelBloco
            // 
            labelBloco.Anchor = AnchorStyles.None;
            labelBloco.AutoSize = true;
            labelBloco.Location = new Point(66, 158);
            labelBloco.Name = "labelBloco";
            labelBloco.Size = new Size(40, 15);
            labelBloco.TabIndex = 10;
            labelBloco.Text = "Bloco:";
            // 
            // labelRG
            // 
            labelRG.Anchor = AnchorStyles.None;
            labelRG.AutoSize = true;
            labelRG.Location = new Point(66, 90);
            labelRG.Name = "labelRG";
            labelRG.Size = new Size(25, 15);
            labelRG.TabIndex = 9;
            labelRG.Text = "RG:";
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.None;
            labelNome.AutoSize = true;
            labelNome.Location = new Point(66, 44);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(99, 15);
            labelNome.TabIndex = 8;
            labelNome.Text = "Nome Completo:";
            // 
            // buttonRegistrarSaida
            // 
            buttonRegistrarSaida.Anchor = AnchorStyles.None;
            buttonRegistrarSaida.BackColor = Color.Tomato;
            buttonRegistrarSaida.FlatStyle = FlatStyle.Flat;
            buttonRegistrarSaida.Location = new Point(290, 198);
            buttonRegistrarSaida.Name = "buttonRegistrarSaida";
            buttonRegistrarSaida.Size = new Size(121, 29);
            buttonRegistrarSaida.TabIndex = 17;
            buttonRegistrarSaida.Text = "Registrar Saída";
            buttonRegistrarSaida.UseVisualStyleBackColor = false;
            buttonRegistrarSaida.Click += buttonRegistrarSaida_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Anchor = AnchorStyles.None;
            buttonLimpar.BackColor = Color.Khaki;
            buttonLimpar.FlatStyle = FlatStyle.Flat;
            buttonLimpar.Location = new Point(112, 198);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(121, 29);
            buttonLimpar.TabIndex = 16;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // textBoxID
            // 
            textBoxID.Anchor = AnchorStyles.None;
            textBoxID.Enabled = false;
            textBoxID.Location = new Point(224, 12);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 19;
            // 
            // labelID
            // 
            labelID.Anchor = AnchorStyles.None;
            labelID.AutoSize = true;
            labelID.Location = new Point(193, 15);
            labelID.Name = "labelID";
            labelID.Size = new Size(21, 15);
            labelID.TabIndex = 18;
            labelID.Text = "ID:";
            // 
            // comboBoxApto
            // 
            comboBoxApto.Anchor = AnchorStyles.None;
            comboBoxApto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxApto.FormattingEnabled = true;
            comboBoxApto.Items.AddRange(new object[] { "T1", "T2", "T3", "T4", "T5", "11", "12", "13", "14", "15", "16", "21", "22", "23", "24", "25", "26", "31", "32", "33", "34", "35", "36", "41", "42", "43", "44", "45", "46", "51", "52", "53", "54", "55", "56", "61", "62", "63", "64", "65", "66", "71", "72", "73", "74", "75", "76", "81", "82", "83", "84", "85", "86", "91", "92", "93", "94", "95", "96", "101", "102", "103", "104", "105", "106", "111", "112", "113", "114", "115", "116", "121", "122", "123", "124", "125", "126", "131", "132", "133", "134", "135", "136" });
            comboBoxApto.Location = new Point(290, 155);
            comboBoxApto.Name = "comboBoxApto";
            comboBoxApto.Size = new Size(121, 23);
            comboBoxApto.TabIndex = 20;
            // 
            // UserControlRegistrarSaida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxApto);
            Controls.Add(textBoxID);
            Controls.Add(labelID);
            Controls.Add(buttonRegistrarSaida);
            Controls.Add(buttonLimpar);
            Controls.Add(comboBoxBloco);
            Controls.Add(textBoxRG);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Controls.Add(labelBloco);
            Controls.Add(labelRG);
            Controls.Add(labelNome);
            Controls.Add(dataGridView);
            Name = "UserControlRegistrarSaida";
            Size = new Size(542, 425);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private ComboBox comboBoxBloco;
        private TextBox textBoxRG;
        private TextBox textBoxNome;
        private Label label1;
        private Label labelBloco;
        private Label labelRG;
        private Label labelNome;
        private Button buttonRegistrarSaida;
        private Button buttonLimpar;
        private TextBox textBoxID;
        private Label labelID;
        private ComboBox comboBoxApto;
    }
}
