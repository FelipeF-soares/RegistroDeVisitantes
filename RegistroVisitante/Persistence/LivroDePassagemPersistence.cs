using RegistroVisitante.Domain;
using RegistroVisitante.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Persistence;

public class LivroDePassagemPersistence : ILivroDePassagemPersistence
{
    private VisitanteContext context;
    public LivroDePassagemPersistence()
    {
        context = new VisitanteContext();
    }
    public LivroDePassagemDeServico[] BuscarRelatoriosPorColaborador()
    {
        throw new NotImplementedException();
    }

    public LivroDePassagemDeServico[] BuscarRelatoriosPorData()
    {
        throw new NotImplementedException();
    }

    public LivroDePassagemDeServico[] BuscarTodosRelatorios()
    {
        IQueryable<LivroDePassagemDeServico> passagens = context.PassagemDeServico;
        passagens = passagens.OrderByDescending(x => x.Id);
        return passagens.ToArray();
    }
}
