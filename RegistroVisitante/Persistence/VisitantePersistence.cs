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
    public void Registrar<T>(T entity) where T : class
    {
        context.Add(entity);
    }
    public void Atualizar<T>(T entity) where T : class
    {
        context.Update(entity);
    }
    public void Deletar<T>(T entity) where T : class
    {
        context.Remove(entity);
    }
    public bool Salvar()
    {
        return (context.SaveChanges()) > 0;
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
        throw new NotImplementedException();
    }

    public Visitante[] BuscarTodosVisitantesPorData(DateTime data)
    {
        throw new NotImplementedException();
    }

    public Visitante[] BuscarTodasVisitasPorRg(string RG)
    {
        throw new NotImplementedException();
    }

}
