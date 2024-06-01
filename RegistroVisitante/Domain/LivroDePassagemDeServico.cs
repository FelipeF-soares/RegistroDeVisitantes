using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Domain;

public class LivroDePassagemDeServico
{
    public int Id { get; set; }
    public string NomeColaborador { get; set; }
    public string RelatorioDiario { get; set; }
    public DateTime DataRelatorio { get; set; }

    public void RegitraDate()
    {
        DataRelatorio = DateTime.Now;
    }
}
