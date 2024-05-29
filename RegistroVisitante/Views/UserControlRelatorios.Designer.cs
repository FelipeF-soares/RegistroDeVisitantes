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
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Anchor = AnchorStyles.Top;
            monthCalendar.Location = new Point(195, 9);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // buttonGerarRelatorio
            // 
            buttonGerarRelatorio.Anchor = AnchorStyles.Top;
            buttonGerarRelatorio.Location = new Point(258, 183);
            buttonGerarRelatorio.Name = "buttonGerarRelatorio";
            buttonGerarRelatorio.Size = new Size(124, 23);
            buttonGerarRelatorio.TabIndex = 1;
            buttonGerarRelatorio.Text = "Gerar Relatório";
            buttonGerarRelatorio.UseVisualStyleBackColor = true;
            buttonGerarRelatorio.Click += buttonGerarRelatorio_Click;
            // 
            // UserControlRelatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonGerarRelatorio);
            Controls.Add(monthCalendar);
            Name = "UserControlRelatorios";
            Size = new Size(590, 389);
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar;
        private Button buttonGerarRelatorio;
    }
}
