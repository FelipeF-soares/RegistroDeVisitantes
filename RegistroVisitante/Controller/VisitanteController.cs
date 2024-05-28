using RegistroVisitante.Domain;
using RegistroVisitante.Domain.Dto;
using RegistroVisitante.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Controller;

public class VisitanteController
{
    private VisitantePersistence persistence;
    public VisitanteController()
    {
        persistence = new VisitantePersistence();
    }
    public bool RegistrarEntrada(VisitanteDto dto)
    {
        try
        {
            var visitante = dto.VisitanteValido();
            visitante.RegistrarEntrada();
            persistence.Registrar(visitante);
            return persistence.Salvar();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public Visitante[] RetornarTodosVisitantes()
    {
        return persistence.BuscarTodosVisitantesSemHorarioSaida();
    }

    public Visitante RetornaVisitantePorId(int id)
    {
       return persistence.BuscarVisitantePorID(id);
    }

    public void AtualizarVisitante(Visitante visitante)
    {
        persistence.Atualizar(visitante);
        persistence.Salvar();
    }
}
