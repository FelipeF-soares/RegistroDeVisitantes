using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Domain.Dto;

public class LivroDePassagemDeServicoDto
{
    private string nomeColaborador;
    public string NomeColaborador
    {
        get { return nomeColaborador; }
        set { nomeColaborador = value.ToUpper().Trim(); }
    }
    private string relatorioDiario;
    public string RelatorioDiario
    {
        get { return relatorioDiario; }
        set { relatorioDiario = value.ToUpper().Trim(); }
    }

    public LivroDePassagemDeServico LivroDePassagemDeServicoValido()
    {
        LivroDePassagemDeServico livro = new LivroDePassagemDeServico();
        livro.NomeColaborador = nomeColaborador;
        livro.RelatorioDiario = relatorioDiario;

        return livro;
    }
}
