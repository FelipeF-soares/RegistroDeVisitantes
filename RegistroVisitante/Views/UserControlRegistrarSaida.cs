using RegistroVisitante.Controller;
using RegistroVisitante.Domain;
using RegistroVisitante.Persistence;
using RegistroVisitante.Persistence.Interfaces;
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

namespace RegistroVisitante.Views;

public partial class UserControlRegistrarSaida : UserControl
{
    private VisitanteController controller;
    private Visitante[] visitantes;
    public UserControlRegistrarSaida()
    {
        InitializeComponent();
        controller = new VisitanteController();
        visitantes = controller.RetornarTodosVisitantes();
        CarregaDados();
    }

    private void CarregaDados()
    {
        try
        {
            dataGridView.DataSource = visitantes;
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
            textBoxID.Text = selectedRow.Cells["Id"].Value.ToString();
            textBoxNome.Text = selectedRow.Cells["Nome"].Value.ToString();
            textBoxRG.Text = selectedRow.Cells["RG"].Value.ToString();
            comboBoxBloco.Text = selectedRow.Cells["Bloco"].Value.ToString();
            comboBoxApto.Text = selectedRow.Cells["Apto"].Value.ToString();
        }
    }

    private void LimparCampo()
    {
        textBoxID.Text = string.Empty;
        textBoxNome.Text = string.Empty;
        textBoxRG.Text = string.Empty; ;
        comboBoxApto.SelectedIndex = -1;
        comboBoxBloco.SelectedIndex = -1;
    }

    private void buttonLimpar_Click(object sender, EventArgs e)
    {
        LimparCampo();
    }

    private void buttonRegistrarSaida_Click(object sender, EventArgs e)
    {
        string id = textBoxID.Text;
        var visitante = controller.RetornaVisitantePorId(int.Parse(id));
        visitante.RegistrarSaida();
        controller.AtualizarVisitante(visitante);
        LimparCampo();
        CarregaDados();
    }
}
