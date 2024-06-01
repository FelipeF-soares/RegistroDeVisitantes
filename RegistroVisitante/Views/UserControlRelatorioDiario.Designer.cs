namespace RegistroVisitante.Views
{
    partial class UserControlRelatorioDiario
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
            labelNomeDoColaborador = new Label();
            textBoxNomeColaborador = new TextBox();
            groupBoxRelatorioDiario = new GroupBox();
            buttonSalvar = new Button();
            richTextBoxConteudo = new RichTextBox();
            groupBoxRelatorioDiario.SuspendLayout();
            SuspendLayout();
            // 
            // labelNomeDoColaborador
            // 
            labelNomeDoColaborador.Anchor = AnchorStyles.None;
            labelNomeDoColaborador.AutoSize = true;
            labelNomeDoColaborador.Location = new Point(24, 36);
            labelNomeDoColaborador.Name = "labelNomeDoColaborador";
            labelNomeDoColaborador.Size = new Size(130, 15);
            labelNomeDoColaborador.TabIndex = 0;
            labelNomeDoColaborador.Text = "Nome Do Colaborador:";
            // 
            // textBoxNomeColaborador
            // 
            textBoxNomeColaborador.Anchor = AnchorStyles.None;
            textBoxNomeColaborador.Location = new Point(160, 33);
            textBoxNomeColaborador.Name = "textBoxNomeColaborador";
            textBoxNomeColaborador.Size = new Size(383, 23);
            textBoxNomeColaborador.TabIndex = 1;
            // 
            // groupBoxRelatorioDiario
            // 
            groupBoxRelatorioDiario.Anchor = AnchorStyles.None;
            groupBoxRelatorioDiario.Controls.Add(buttonSalvar);
            groupBoxRelatorioDiario.Controls.Add(richTextBoxConteudo);
            groupBoxRelatorioDiario.Controls.Add(textBoxNomeColaborador);
            groupBoxRelatorioDiario.Controls.Add(labelNomeDoColaborador);
            groupBoxRelatorioDiario.Location = new Point(3, 3);
            groupBoxRelatorioDiario.Name = "groupBoxRelatorioDiario";
            groupBoxRelatorioDiario.Size = new Size(568, 390);
            groupBoxRelatorioDiario.TabIndex = 2;
            groupBoxRelatorioDiario.TabStop = false;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.None;
            buttonSalvar.BackColor = Color.LightGreen;
            buttonSalvar.FlatStyle = FlatStyle.Flat;
            buttonSalvar.Location = new Point(198, 294);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(170, 36);
            buttonSalvar.TabIndex = 3;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = false;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // richTextBoxConteudo
            // 
            richTextBoxConteudo.Anchor = AnchorStyles.None;
            richTextBoxConteudo.BulletIndent = 5;
            richTextBoxConteudo.Location = new Point(24, 85);
            richTextBoxConteudo.Name = "richTextBoxConteudo";
            richTextBoxConteudo.Size = new Size(519, 168);
            richTextBoxConteudo.TabIndex = 2;
            richTextBoxConteudo.Text = "";
            // 
            // UserControlRelatorioDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxRelatorioDiario);
            Name = "UserControlRelatorioDiario";
            Size = new Size(574, 396);
            groupBoxRelatorioDiario.ResumeLayout(false);
            groupBoxRelatorioDiario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelNomeDoColaborador;
        private TextBox textBoxNomeColaborador;
        private GroupBox groupBoxRelatorioDiario;
        private RichTextBox richTextBoxConteudo;
        private Button buttonSalvar;
    }
}
