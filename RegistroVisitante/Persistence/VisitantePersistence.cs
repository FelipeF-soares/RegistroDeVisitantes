using RegistroVisitante.Domain;
using RegistroVisitante.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Persistence;

public class VisitantePersistence : IVisitantePersistence
{
    private VisitanteContext context;
    public VisitantePersistence()
    {
        context = new VisitanteContext();
    }
    public Visitante[] BuscarTodosVisitantesSemHorarioSaida()
    {
        IQueryable<Visitante> visitantes = context.Visitantes;
        visitantes = visitantes.OrderBy(x => x.Id)
                    .Where(x => x.DataHoraSaida == DateTime.MinValue);

        return visitantes.ToArray();
    }
    public Visitante BuscarVisitantePorID(int id)
    {
        var visitante = context.Visitantes.FirstOrDefault(x => x.Id == id);
        return visitante;
    }
    public Visitante[] BuscarTodosVisitantesPorUnidade(string bloco, string unidade)
    {
        var visitantes = context.Visitantes.Where(visitante => (visitante.Bloco == bloco) && (visitante.Apto == unidade)).ToArray();
        if (visitantes.Length <= 0) throw new Exception("Nenhum visitante encontrado!");
        return visitantes.ToArray();
    }

    public Visitante[] BuscarTodosVisitantesPorData(DateTime data)
    {
       var visiatante = context.Visitantes.Where(x => x.DataHoraEntrada.Date == data.Date).ToArray();
        if (visiatante.Length <= 0) throw new Exception("Nenhum visitante encontrado!");
        return visiatante.ToArray();
    }

    public Visitante[] BuscarTodasVisitasPorRg(string RG)
    {
        var visitantes = context.Visitantes.Where(visiatante => visiatante.Rg == RG).ToArray();
        if (visitantes.Length <= 0) throw new Exception("Nenhum visitante encontrado!");
        return visitantes.ToArray();
    }

}
