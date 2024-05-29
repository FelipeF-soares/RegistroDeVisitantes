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
        public UserControlRelatorios()
        {
            InitializeComponent();
        }

        private void buttonGerarRelatorio_Click(object sender, EventArgs e)
        {
            CriarRelatorio criarRelatorio = new CriarRelatorio();
            VisitantePersistence visitantePersistence = new VisitantePersistence();
            var visitantes = visitantePersistence.BuscarTodosVisitantesSemHorarioSaida();
            criarRelatorio.GerarRelatorioEmPDF(visitantes);
        }
    }
}
