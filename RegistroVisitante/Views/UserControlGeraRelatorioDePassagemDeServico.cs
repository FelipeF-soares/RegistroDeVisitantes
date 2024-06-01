using RegistroVisitante.Controller;
using RegistroVisitante.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegistroVisitante.Views
{
    public partial class UserControlGeraRelatorioDePassagemDeServico : UserControl
    {
        private LivroDePassagemController controller;
        private LivroDePassagemDeServico[] livros;
        public UserControlGeraRelatorioDePassagemDeServico()
        {
            InitializeComponent();
            controller = new LivroDePassagemController();
            livros = controller.BuscaTodasPassagens();
            CarregaDados();
        }

        private void CarregaDados()
        {
            try
            {
                dataGridView.DataSource = livros;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Carrega os dados da linha nos TextBoxes
                textBoxNomeColaborador.Text = selectedRow.Cells["NomeColaborador"].Value.ToString();
                richTextBoxConteudo.Text = selectedRow.Cells["RelatorioDiario"].Value.ToString();
            }
        }

    }
}
