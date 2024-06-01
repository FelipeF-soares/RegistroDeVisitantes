using RegistroVisitante.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Persistence.Interfaces;

public interface ILivroDePassagemPersistence
{
    LivroDePassagemDeServico[] BuscarTodosRelatorios(); 
    LivroDePassagemDeServico[] BuscarRelatoriosPorData(); 
    LivroDePassagemDeServico[] BuscarRelatoriosPorColaborador(); 
}
