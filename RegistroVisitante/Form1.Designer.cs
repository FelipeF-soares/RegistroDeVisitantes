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
            panelMenuLateral = new Panel();
            buttonRegistrarSaida = new Button();
            buttonRegistrarEntrada = new Button();
            tabControl = new TabControl();
            panelMenuLateral.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.MediumPurple;
            panelMenuLateral.Controls.Add(buttonRegistrarSaida);
            panelMenuLateral.Controls.Add(buttonRegistrarEntrada);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(168, 450);
            panelMenuLateral.TabIndex = 0;
            // 
            // buttonRegistrarSaida
            // 
            buttonRegistrarSaida.FlatStyle = FlatStyle.Flat;
            buttonRegistrarSaida.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegistrarSaida.Location = new Point(0, 166);
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
            buttonRegistrarEntrada.Location = new Point(0, 114);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Visitantes";
            panelMenuLateral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Button buttonRegistrarEntrada;
        private TabControl tabControl;
        private Button buttonRegistrarSaida;
    }
}
