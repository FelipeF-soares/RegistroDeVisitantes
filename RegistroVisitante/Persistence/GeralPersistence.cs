using RegistroVisitante.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Persistence;

public class GeralPersistence : IGeralPersistence
{
    private readonly VisitanteContext context;
    public GeralPersistence()
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
}
