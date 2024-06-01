using RegistroVisitante.Controller;
using RegistroVisitante.Domain;
using RegistroVisitante.Domain.Dto;
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
    public partial class UserControlRelatorioDiario : UserControl
    {
        private readonly LivroDePassagemController controller;
        public UserControlRelatorioDiario()
        {
            InitializeComponent();
            controller = new LivroDePassagemController();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                LivroDePassagemDeServicoDto dto = new LivroDePassagemDeServicoDto();
                dto.NomeColaborador = textBoxNomeColaborador.Text;
                dto.RelatorioDiario = richTextBoxConteudo.Text;
                if (controller.RegistrarPassagemDeServico(dto))
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

        public void LimparCampos()
        {
            textBoxNomeColaborador.Text = string.Empty;
            richTextBoxConteudo.Text = string.Empty;
        }
    }
}
