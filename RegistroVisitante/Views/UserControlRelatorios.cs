using RegistroVisitante.Controller;
using RegistroVisitante.Domain.Relatorio;
using RegistroVisitante.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroVisitante.Views
{
    public partial class UserControlRelatorios : UserControl
    {
        private VisitanteController controller;
        public UserControlRelatorios()
        {
            InitializeComponent();
            controller = new VisitanteController();
        }

        private void buttonGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                var dataSelecionda = monthCalendar.SelectionStart;
                var visitantes = controller.RetornaVisitantesPorData(dataSelecionda);
                controller.GerarRelatorio(visitantes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var rg = maskedTextBoxRG.Text;
                var visitantes = controller.RetornaVisitantesRG(rg);
                controller.GerarRelatorio(visitantes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGeraRelatorioUnidade_Click(object sender, EventArgs e)
        {
            try
            {
                string bloco = comboBoxBloco.Text;
                string apto = comboBoxApto.Text;
                var visitantes = controller.RetornaVisitantesUnidade(bloco, apto);
                controller.GerarRelatorio(visitantes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
