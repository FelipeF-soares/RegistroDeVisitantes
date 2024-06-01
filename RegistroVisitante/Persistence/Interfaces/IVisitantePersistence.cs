using RegistroVisitante.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Persistence.Interfaces;

public interface IVisitantePersistence
{ 
    Visitante[] BuscarTodosVisitantesSemHorarioSaida();
    Visitante[] BuscarTodosVisitantesPorUnidade(string bloco, string unidade);
    Visitante[] BuscarTodosVisitantesPorData(DateTime data);
    Visitante[] BuscarTodasVisitasPorRg(string RG);
    Visitante BuscarVisitantePorID(int id);
}
