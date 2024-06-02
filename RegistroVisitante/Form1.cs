using RegistroVisitante.Views;

namespace RegistroVisitante;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonRegistrarVisitante_Click(object sender, EventArgs e)
    {
        try
        {
            tabControl.TabPages.Clear();
            string name = "tabPageRegistraVisitante";
            string text = "Registrar Visitante";
            UserControlRegistrarVisitante userControl = new UserControlRegistrarVisitante();
            AdicionarTabPage(name, text, userControl);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
    private void buttonRegistrarSaida_Click(object sender, EventArgs e)
    {
        try
        {
            tabControl.TabPages.Clear();
            string name = "tabPageRegistraVisitante";
            string text = "Registrar Saída de Visitante";
            UserControlRegistrarSaida userControl = new UserControlRegistrarSaida();
            AdicionarTabPage(name, text, userControl);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void buttonRelatorioDiario_Click(object sender, EventArgs e)
    {
        try
        {
            tabControl.TabPages.Clear();
            string name = "tabPageRelatorioDiario";
            string text = "Relatório Diário";
            UserControlRelatorioDiario userControl = new UserControlRelatorioDiario();
            AdicionarTabPage(name, text, userControl);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void buttonGerarRelatorio_Click(object sender, EventArgs e)
    {
        try
        {
            tabControl.TabPages.Clear();
            string name = "tabPageGerarRelatorio";
            string text = "Gerar Relatório";
            UserControlRelatorios userControl = new UserControlRelatorios();
            AdicionarTabPage(name, text, userControl);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void buttonRelatorioDePassagemDeServico_Click(object sender, EventArgs e)
    {
        try
        {
            tabControl.TabPages.Clear();
            string name = "tabPageGeraRelatorioDePassagemDeSerico";
            string text = "Gera Relatório de Passagem de Serviço";
            UserControlGeraRelatorioDePassagemDeServico userControl = new UserControlGeraRelatorioDePassagemDeServico();
            AdicionarTabPage(name, text, userControl);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void AdicionarTabPage(string name, string text, UserControl userControl)
    {
        TabPage tabPage = new TabPage();
        userControl.Dock = DockStyle.Fill;
        tabPage.Name = name;
        tabPage.Text = text;
        tabPage.Controls.Add(userControl);
        tabControl.TabPages.Add(tabPage);
        tabControl.SelectTab(tabPage);
    }
}
