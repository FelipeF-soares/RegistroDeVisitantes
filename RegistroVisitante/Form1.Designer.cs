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
            pictureBox1 = new PictureBox();
            buttonRelatorioDePassagemDeServico = new Button();
            buttonRelatorioDiario = new Button();
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
            panelMenuLateral.BackColor = Color.FromArgb(54, 54, 54);
            panelMenuLateral.Controls.Add(pictureBox1);
            panelMenuLateral.Controls.Add(buttonRelatorioDePassagemDeServico);
            panelMenuLateral.Controls.Add(buttonRelatorioDiario);
            panelMenuLateral.Controls.Add(buttonGerarRelatorio);
            panelMenuLateral.Controls.Add(buttonRegistrarSaida);
            panelMenuLateral.Controls.Add(buttonRegistrarEntrada);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(168, 450);
            panelMenuLateral.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // buttonRelatorioDePassagemDeServico
            // 
            buttonRelatorioDePassagemDeServico.FlatAppearance.BorderSize = 0;
            buttonRelatorioDePassagemDeServico.FlatStyle = FlatStyle.Flat;
            buttonRelatorioDePassagemDeServico.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRelatorioDePassagemDeServico.ForeColor = SystemColors.ControlLightLight;
            buttonRelatorioDePassagemDeServico.Location = new Point(0, 383);
            buttonRelatorioDePassagemDeServico.Name = "buttonRelatorioDePassagemDeServico";
            buttonRelatorioDePassagemDeServico.Size = new Size(168, 53);
            buttonRelatorioDePassagemDeServico.TabIndex = 5;
            buttonRelatorioDePassagemDeServico.Text = "Relatório De Passagem de Serviço";
            buttonRelatorioDePassagemDeServico.UseVisualStyleBackColor = true;
            buttonRelatorioDePassagemDeServico.Click += buttonRelatorioDePassagemDeServico_Click;
            // 
            // buttonRelatorioDiario
            // 
            buttonRelatorioDiario.FlatAppearance.BorderSize = 0;
            buttonRelatorioDiario.FlatStyle = FlatStyle.Flat;
            buttonRelatorioDiario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRelatorioDiario.ForeColor = SystemColors.ControlLightLight;
            buttonRelatorioDiario.Location = new Point(0, 329);
            buttonRelatorioDiario.Name = "buttonRelatorioDiario";
            buttonRelatorioDiario.Size = new Size(168, 53);
            buttonRelatorioDiario.TabIndex = 4;
            buttonRelatorioDiario.Text = "Passagem de Serviço";
            buttonRelatorioDiario.UseVisualStyleBackColor = true;
            buttonRelatorioDiario.Click += buttonRelatorioDiario_Click;
            // 
            // buttonGerarRelatorio
            // 
            buttonGerarRelatorio.FlatAppearance.BorderSize = 0;
            buttonGerarRelatorio.FlatStyle = FlatStyle.Flat;
            buttonGerarRelatorio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGerarRelatorio.ForeColor = SystemColors.ControlLightLight;
            buttonGerarRelatorio.Location = new Point(0, 278);
            buttonGerarRelatorio.Name = "buttonGerarRelatorio";
            buttonGerarRelatorio.Size = new Size(168, 53);
            buttonGerarRelatorio.TabIndex = 2;
            buttonGerarRelatorio.Text = "Relatório De Visitantes";
            buttonGerarRelatorio.UseVisualStyleBackColor = true;
            buttonGerarRelatorio.Click += buttonGerarRelatorio_Click;
            // 
            // buttonRegistrarSaida
            // 
            buttonRegistrarSaida.FlatAppearance.BorderSize = 0;
            buttonRegistrarSaida.FlatStyle = FlatStyle.Flat;
            buttonRegistrarSaida.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegistrarSaida.ForeColor = SystemColors.ControlLightLight;
            buttonRegistrarSaida.Location = new Point(0, 225);
            buttonRegistrarSaida.Name = "buttonRegistrarSaida";
            buttonRegistrarSaida.Size = new Size(168, 53);
            buttonRegistrarSaida.TabIndex = 1;
            buttonRegistrarSaida.Text = "Registrar Saída";
            buttonRegistrarSaida.UseVisualStyleBackColor = true;
            buttonRegistrarSaida.Click += buttonRegistrarSaida_Click;
            // 
            // buttonRegistrarEntrada
            // 
            buttonRegistrarEntrada.FlatAppearance.BorderSize = 0;
            buttonRegistrarEntrada.FlatStyle = FlatStyle.Flat;
            buttonRegistrarEntrada.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegistrarEntrada.ForeColor = SystemColors.ControlLightLight;
            buttonRegistrarEntrada.Location = new Point(0, 174);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Visitantes";
            panelMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Button buttonRegistrarEntrada;
        private TabControl tabControl;
        private Button buttonRegistrarSaida;
        private Button buttonGerarRelatorio;
        private Button buttonRelatorioDiario;
        private Button buttonRelatorioDePassagemDeServico;
        private PictureBox pictureBox1;
    }
}
