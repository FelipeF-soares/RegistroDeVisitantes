using RegistroVisitante.Domain;
using RegistroVisitante.Domain.Dto;
using RegistroVisitante.Domain.Relatorio;
using RegistroVisitante.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Controller;

public class LivroDePassagemController
{
    private readonly GeralPersistence geral;
    private LivroDePassagemPersistence persistence;
    public LivroDePassagemController()
    {
        geral = new GeralPersistence();
        persistence = new LivroDePassagemPersistence();
    }
    public bool RegistrarPassagemDeServico(LivroDePassagemDeServicoDto dto)
    {
        var livro = dto.LivroDePassagemDeServicoValido();
        livro.RegitraDate();
        geral.Registrar(livro);
        CriarRelatorio criarRelatorio = new CriarRelatorio();
        criarRelatorio.GeraRelatorioDePassagemDeServico(livro);
        return geral.Salvar();
    }

    public LivroDePassagemDeServico[] BuscaTodasPassagens()
    {
       return persistence.BuscarTodosRelatorios();
    }
}
