using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Domain;

public class Visitante
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Rg { get; set; }
    public string Informacoes { get; set; }
    public DateTime DataHoraEntrada { get; set; }
    public DateTime DataHoraSaida { get; set; }
    public string Bloco { get; set; }
    public string  Apto { get; set; }

    public void RegistrarEntrada()
    {
        DataHoraEntrada = DateTime.Now;
    }

    public void RegistrarSaida()
    {
        DataHoraSaida = DateTime.Now;
    }
}
