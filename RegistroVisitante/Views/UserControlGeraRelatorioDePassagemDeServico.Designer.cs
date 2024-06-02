namespace RegistroVisitante.Views
{
    partial class UserControlGeraRelatorioDePassagemDeServico
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
            groupBoxPassagemDeServico = new GroupBox();
            richTextBoxConteudo = new RichTextBox();
            textBoxNomeColaborador = new TextBox();
            dataGridView = new DataGridView();
            groupBoxPassagemDeServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPassagemDeServico
            // 
            groupBoxPassagemDeServico.Anchor = AnchorStyles.None;
            groupBoxPassagemDeServico.Controls.Add(richTextBoxConteudo);
            groupBoxPassagemDeServico.Controls.Add(textBoxNomeColaborador);
            groupBoxPassagemDeServico.Controls.Add(dataGridView);
            groupBoxPassagemDeServico.Location = new Point(3, 3);
            groupBoxPassagemDeServico.Name = "groupBoxPassagemDeServico";
            groupBoxPassagemDeServico.Size = new Size(629, 403);
            groupBoxPassagemDeServico.TabIndex = 0;
            groupBoxPassagemDeServico.TabStop = false;
            // 
            // richTextBoxConteudo
            // 
            richTextBoxConteudo.Anchor = AnchorStyles.None;
            richTextBoxConteudo.BulletIndent = 5;
            richTextBoxConteudo.Location = new Point(63, 61);
            richTextBoxConteudo.Name = "richTextBoxConteudo";
            richTextBoxConteudo.ReadOnly = true;
            richTextBoxConteudo.Size = new Size(519, 168);
            richTextBoxConteudo.TabIndex = 5;
            richTextBoxConteudo.Text = "";
            // 
            // textBoxNomeColaborador
            // 
            textBoxNomeColaborador.Anchor = AnchorStyles.None;
            textBoxNomeColaborador.Location = new Point(143, 22);
            textBoxNomeColaborador.Name = "textBoxNomeColaborador";
            textBoxNomeColaborador.ReadOnly = true;
            textBoxNomeColaborador.Size = new Size(383, 23);
            textBoxNomeColaborador.TabIndex = 4;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(143, 298);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(383, 99);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // UserControlGeraRelatorioDePassagemDeServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxPassagemDeServico);
            Name = "UserControlGeraRelatorioDePassagemDeServico";
            Size = new Size(635, 409);
            groupBoxPassagemDeServico.ResumeLayout(false);
            groupBoxPassagemDeServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPassagemDeServico;
        private DataGridView dataGridView;
        private RichTextBox richTextBoxConteudo;
        private TextBox textBoxNomeColaborador;
    }
}
