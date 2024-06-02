namespace RegistroVisitante
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenuLateral = new Panel();
            buttonRelatorioDePassagemDeServico = new Button();
            buttonRelatorioDiario = new Button();
            pictureBox1 = new PictureBox();
            buttonGerarRelatorio = new Button();
            buttonRegistrarSaida = new Button();
            buttonRegistrarEntrada = new Button();
            tabControl = new TabControl();
            panelMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.MediumPurple;
            panelMenuLateral.Controls.Add(buttonRelatorioDePassagemDeServico);
            panelMenuLateral.Controls.Add(buttonRelatorioDiario);
            panelMenuLateral.Controls.Add(pictureBox1);
            panelMenuLateral.Controls.Add(buttonGerarRelatorio);
            panelMenuLateral.Controls.Add(buttonRegistrarSaida);
            panelMenuLateral.Controls.Add(buttonRegistrarEntrada);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(168, 450);
            panelMenuLateral.TabIndex = 0;
            // 
            // buttonRelatorioDePassagemDeServico
            // 
            buttonRelatorioDePassagemDeServico.FlatStyle = FlatStyle.Flat;
            buttonRelatorioDePassagemDeServico.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRelatorioDePassagemDeServico.Location = new Point(0, 396);
            buttonRelatorioDePassagemDeServico.Name = "buttonRelatorioDePassagemDeServico";
            buttonRelatorioDePassagemDeServico.Size = new Size(168, 53);
            buttonRelatorioDePassagemDeServico.TabIndex = 5;
            buttonRelatorioDePassagemDeServico.Text = "Relatório De Passagem de Serviço";
            buttonRelatorioDePassagemDeServico.UseVisualStyleBackColor = true;
            buttonRelatorioDePassagemDeServico.Click += buttonRelatorioDePassagemDeServico_Click;
            // 
            // buttonRelatorioDiario
            // 
            buttonRelatorioDiario.FlatStyle = FlatStyle.Flat;
            buttonRelatorioDiario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRelatorioDiario.Location = new Point(0, 343);
            buttonRelatorioDiario.Name = "buttonRelatorioDiario";
            buttonRelatorioDiario.Size = new Size(168, 53);
            buttonRelatorioDiario.TabIndex = 4;
            buttonRelatorioDiario.Text = "Passagem de Serviço";
            buttonRelatorioDiario.UseVisualStyleBackColor = true;
            buttonRelatorioDiario.Click += buttonRelatorioDiario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonGerarRelatorio
            // 
            buttonGerarRelatorio.FlatStyle = FlatStyle.Flat;
            buttonGerarRelatorio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarRelatorio.Location = new Point(0, 290);
            buttonGerarRelatorio.Name = "buttonGerarRelatorio";
            buttonGerarRelatorio.Size = new Size(168, 53);
            buttonGerarRelatorio.TabIndex = 2;
            buttonGerarRelatorio.Text = "Relatório De Visitantes";
            buttonGerarRelatorio.UseVisualStyleBackColor = true;
            buttonGerarRelatorio.Click += buttonGerarRelatorio_Click;
            // 
            // buttonRegistrarSaida
            // 
            buttonRegistrarSaida.FlatStyle = FlatStyle.Flat;
            buttonRegistrarSaida.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegistrarSaida.Location = new Point(0, 237);
            buttonRegistrarSaida.Name = "buttonRegistrarSaida";
            buttonRegistrarSaida.Size = new Size(168, 53);
            buttonRegistrarSaida.TabIndex = 1;
            buttonRegistrarSaida.Text = "Registrar Saída";
            buttonRegistrarSaida.UseVisualStyleBackColor = true;
            buttonRegistrarSaida.Click += buttonRegistrarSaida_Click;
            // 
            // buttonRegistrarEntrada
            // 
            buttonRegistrarEntrada.FlatStyle = FlatStyle.Flat;
            buttonRegistrarEntrada.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegistrarEntrada.Location = new Point(0, 184);
            buttonRegistrarEntrada.Name = "buttonRegistrarEntrada";
            buttonRegistrarEntrada.Size = new Size(168, 53);
            buttonRegistrarEntrada.TabIndex = 0;
            buttonRegistrarEntrada.Text = "Registrar Entrada";
            buttonRegistrarEntrada.UseVisualStyleBackColor = true;
            buttonRegistrarEntrada.Click += buttonRegistrarVisitante_Click;
            // 
            // tabControl
            // 
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(168, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(743, 450);
            tabControl.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 450);
            Controls.Add(tabControl);
            Controls.Add(panelMenuLateral);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Visitantes";
            panelMenuLateral.ResumeLayout(false);
            panelMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Button buttonRegistrarEntrada;
        private TabControl tabControl;
        private Button buttonRegistrarSaida;
        private Button buttonGerarRelatorio;
        private PictureBox pictureBox1;
        private Button buttonRelatorioDiario;
        private Button buttonRelatorioDePassagemDeServico;
    }
}
