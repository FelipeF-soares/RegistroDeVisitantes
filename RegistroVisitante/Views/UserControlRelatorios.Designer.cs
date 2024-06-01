namespace RegistroVisitante.Views
{
    partial class UserControlRelatorios
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
            monthCalendar = new MonthCalendar();
            buttonGerarRelatorio = new Button();
            groupBoxData = new GroupBox();
            groupBoxRg = new GroupBox();
            button1 = new Button();
            maskedTextBoxRG = new MaskedTextBox();
            labelRG = new Label();
            groupBoxUnidade = new GroupBox();
            buttonGeraRelatorioUnidade = new Button();
            comboBoxApto = new ComboBox();
            comboBoxBloco = new ComboBox();
            label1 = new Label();
            labelBloco = new Label();
            groupBoxData.SuspendLayout();
            groupBoxRg.SuspendLayout();
            groupBoxUnidade.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Anchor = AnchorStyles.Top;
            monthCalendar.Location = new Point(12, 28);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // buttonGerarRelatorio
            // 
            buttonGerarRelatorio.Anchor = AnchorStyles.Top;
            buttonGerarRelatorio.Location = new Point(64, 255);
            buttonGerarRelatorio.Name = "buttonGerarRelatorio";
            buttonGerarRelatorio.Size = new Size(124, 23);
            buttonGerarRelatorio.TabIndex = 1;
            buttonGerarRelatorio.Text = "Gerar Relatório";
            buttonGerarRelatorio.UseVisualStyleBackColor = true;
            buttonGerarRelatorio.Click += buttonGerarRelatorio_Click;
            // 
            // groupBoxData
            // 
            groupBoxData.Anchor = AnchorStyles.None;
            groupBoxData.Controls.Add(monthCalendar);
            groupBoxData.Controls.Add(buttonGerarRelatorio);
            groupBoxData.Location = new Point(53, 3);
            groupBoxData.Name = "groupBoxData";
            groupBoxData.Size = new Size(260, 383);
            groupBoxData.TabIndex = 2;
            groupBoxData.TabStop = false;
            groupBoxData.Text = "Relatório Por Data";
            // 
            // groupBoxRg
            // 
            groupBoxRg.Anchor = AnchorStyles.None;
            groupBoxRg.Controls.Add(button1);
            groupBoxRg.Controls.Add(maskedTextBoxRG);
            groupBoxRg.Controls.Add(labelRG);
            groupBoxRg.Location = new Point(319, 3);
            groupBoxRg.Name = "groupBoxRg";
            groupBoxRg.Size = new Size(318, 190);
            groupBoxRg.TabIndex = 3;
            groupBoxRg.TabStop = false;
            groupBoxRg.Text = "Relatório Por RG";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(94, 108);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 2;
            button1.Text = "Gerar Relatório";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedTextBoxRG
            // 
            maskedTextBoxRG.Anchor = AnchorStyles.None;
            maskedTextBoxRG.Location = new Point(123, 46);
            maskedTextBoxRG.Mask = "00,000,000-a";
            maskedTextBoxRG.Name = "maskedTextBoxRG";
            maskedTextBoxRG.Size = new Size(79, 23);
            maskedTextBoxRG.TabIndex = 14;
            // 
            // labelRG
            // 
            labelRG.Anchor = AnchorStyles.None;
            labelRG.AutoSize = true;
            labelRG.Location = new Point(92, 46);
            labelRG.Name = "labelRG";
            labelRG.Size = new Size(25, 15);
            labelRG.TabIndex = 13;
            labelRG.Text = "RG:";
            // 
            // groupBoxUnidade
            // 
            groupBoxUnidade.Anchor = AnchorStyles.None;
            groupBoxUnidade.Controls.Add(buttonGeraRelatorioUnidade);
            groupBoxUnidade.Controls.Add(comboBoxApto);
            groupBoxUnidade.Controls.Add(comboBoxBloco);
            groupBoxUnidade.Controls.Add(label1);
            groupBoxUnidade.Controls.Add(labelBloco);
            groupBoxUnidade.Location = new Point(319, 199);
            groupBoxUnidade.Name = "groupBoxUnidade";
            groupBoxUnidade.Size = new Size(318, 187);
            groupBoxUnidade.TabIndex = 15;
            groupBoxUnidade.TabStop = false;
            groupBoxUnidade.Text = "Relatório Por Unidade";
            // 
            // buttonGeraRelatorioUnidade
            // 
            buttonGeraRelatorioUnidade.Anchor = AnchorStyles.Top;
            buttonGeraRelatorioUnidade.Location = new Point(91, 158);
            buttonGeraRelatorioUnidade.Name = "buttonGeraRelatorioUnidade";
            buttonGeraRelatorioUnidade.Size = new Size(124, 23);
            buttonGeraRelatorioUnidade.TabIndex = 15;
            buttonGeraRelatorioUnidade.Text = "Gerar Relatório";
            buttonGeraRelatorioUnidade.UseVisualStyleBackColor = true;
            buttonGeraRelatorioUnidade.Click += buttonGeraRelatorioUnidade_Click;
            // 
            // comboBoxApto
            // 
            comboBoxApto.Anchor = AnchorStyles.None;
            comboBoxApto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxApto.FormattingEnabled = true;
            comboBoxApto.Items.AddRange(new object[] { "T1", "T2", "T3", "T4" });
            comboBoxApto.Location = new Point(94, 89);
            comboBoxApto.Name = "comboBoxApto";
            comboBoxApto.Size = new Size(121, 23);
            comboBoxApto.TabIndex = 11;
            // 
            // comboBoxBloco
            // 
            comboBoxBloco.Anchor = AnchorStyles.None;
            comboBoxBloco.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBloco.FormattingEnabled = true;
            comboBoxBloco.Items.AddRange(new object[] { "A", "B" });
            comboBoxBloco.Location = new Point(94, 22);
            comboBoxBloco.Name = "comboBoxBloco";
            comboBoxBloco.Size = new Size(121, 23);
            comboBoxBloco.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(48, 89);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 9;
            label1.Text = "Apto:";
            // 
            // labelBloco
            // 
            labelBloco.Anchor = AnchorStyles.None;
            labelBloco.AutoSize = true;
            labelBloco.Location = new Point(48, 25);
            labelBloco.Name = "labelBloco";
            labelBloco.Size = new Size(40, 15);
            labelBloco.TabIndex = 8;
            labelBloco.Text = "Bloco:";
            // 
            // UserControlRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxUnidade);
            Controls.Add(groupBoxRg);
            Controls.Add(groupBoxData);
            Name = "UserControlRelatorios";
            Size = new Size(690, 389);
            groupBoxData.ResumeLayout(false);
            groupBoxRg.ResumeLayout(false);
            groupBoxRg.PerformLayout();
            groupBoxUnidade.ResumeLayout(false);
            groupBoxUnidade.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar;
        private Button buttonGerarRelatorio;
        private GroupBox groupBoxData;
        private GroupBox groupBoxRg;
        private Button button1;
        private MaskedTextBox maskedTextBoxRG;
        private Label labelRG;
        private GroupBox groupBoxUnidade;
        private Button buttonGeraRelatorioUnidade;
        private ComboBox comboBoxApto;
        private ComboBox comboBoxBloco;
        private Label label1;
        private Label labelBloco;
    }
}
