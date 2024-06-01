using RegistroVisitante.Domain;
using RegistroVisitante.Domain.Dto;
using RegistroVisitante.Domain.Relatorio;
using RegistroVisitante.Persistence;
using RegistroVisitante.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Controller;

public class VisitanteController
{
    private VisitantePersistence persistence;
    private GeralPersistence geralPersistence;
    private CriarRelatorio relatorio;
    public VisitanteController()
    {
        persistence = new VisitantePersistence();
        geralPersistence = new GeralPersistence();
        relatorio = new CriarRelatorio();
    }
    public bool RegistrarEntrada(VisitanteDto dto)
    {
        var visitante = dto.VisitanteValido();
        visitante.RegistrarEntrada();
        geralPersistence.Registrar(visitante);
        return geralPersistence.Salvar();
    }
    public Visitante[] RetornarTodosVisitantes()
    {
        return persistence.BuscarTodosVisitantesSemHorarioSaida();
    }

    public Visitante RetornaVisitantePorId(int id)
    {
       return persistence.BuscarVisitantePorID(id);
    }

    public Visitante[] RetornaVisitantesPorData(DateTime data)
    {
       var visitantes = persistence.BuscarTodosVisitantesPorData(data);
       return visitantes;  
    }

    public Visitante[] RetornaVisitantesRG(string rg)
    {
        var visitantes = persistence.BuscarTodasVisitasPorRg(rg);
        return visitantes;
    }

    public Visitante[] RetornaVisitantesUnidade(string bloco, string unidade)
    {
        var visitantes = persistence.BuscarTodosVisitantesPorUnidade(bloco, unidade);
        return visitantes;
    }

    public void AtualizarVisitante(Visitante visitante)
    {
        geralPersistence.Atualizar(visitante);
        geralPersistence.Salvar();
    }
    public void GerarRelatorio(Visitante[] visitantes)
    {
        relatorio.GerarRelatorioEmPDF(visitantes);
    }
}
