using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Persistence.Interfaces;

public interface IGeralPersistence
{
    void Registrar<T>(T entity) where T : class;
    void Atualizar<T>(T entity) where T : class;
    void Deletar<T>(T entity) where T : class;
    bool Salvar();
}
