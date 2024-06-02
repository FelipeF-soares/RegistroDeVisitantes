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
            richTextBoxConteudo.Text = "Relatório de Serviço\r\n\r\nColaborador responsável pela transferência do serviço: " +
                "[Nome do colaborador que passou o serviço]\r\n\r\nNovidades observadas na assunção do serviço:" +
                "\r\n\r\n• [Descrever todas as novidades relevantes do serviço]\r\n• [Descrever todas as novidades relevantes do serviço]" +
                "\r\n• [Descrever todas as novidades relevantes do serviço]\r\n• [Descrever todas as novidades relevantes do serviço]" +
                "\r\n• [Descrever todas as novidades relevantes do serviço]\r\n\r\nColaborador de apoio: [Nome do colaborador de apoio]" +
                "\r\n\r\nPeríodo do turno: [Horário e data de início e término]\r\n\r\nA equipe encontra-se uniformizada, em condições de trabalho e sem ocorrências adicionais." +
                "\r\n\r\nOcorrências durante o turno de serviço:\r\n\r\n• Às 12h00: [Descrever todas as novidades relevantes ocorridas no decorrer do serviço]" +
                "\r\n• Às 13h00: [Descrever todas as novidades relevantes ocorridas no decorrer do serviço]" +
                "\r\n• Às 16h37: [Descrever todas as novidades relevantes ocorridas no decorrer do serviço]" +
                "\r\n\r\nO ambiente foi deixado limpo e organizado, conforme as observações acima." +
                "\r\n\r\nEncerramento do serviço: Serviço encerrado com a equipe e local sem novidades adicionais.\r\n\r\n";
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
