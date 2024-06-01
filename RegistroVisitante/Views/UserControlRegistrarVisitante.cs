using RegistroVisitante.Controller;
using RegistroVisitante.Domain;
using RegistroVisitante.Domain.Dto;
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
    public partial class UserControlRegistrarVisitante : UserControl
    {
        private VisitanteController controller;
        public UserControlRegistrarVisitante()
        {
            InitializeComponent();
            controller = new VisitanteController();
        }

        private void buttonRegistrar_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                VisitanteDto dto = new VisitanteDto();
                dto.Nome = textBoxNome.Text;
                dto.Rg = maskedTextBoxRG.Text;
                dto.Infomacoes = textBoxInformacoes.Text;
                dto.Apto = comboBoxApto.Text;
                dto.Bloco = comboBoxBloco.Text;

                if (controller.RegistrarEntrada(dto))
                {
                    MessageBox.Show("Registro Realizado Com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao Registrar!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxNome.Text = string.Empty;
            maskedTextBoxRG.Text = string.Empty;
            textBoxInformacoes.Text = string.Empty;
            comboBoxApto.SelectedIndex = -1;
            comboBoxBloco.SelectedIndex = -1;

        }


    }
}
