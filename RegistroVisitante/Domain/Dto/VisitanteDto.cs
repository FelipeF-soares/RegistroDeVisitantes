using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Domain.Dto
{
    public class VisitanteDto
    {
        private Visitante visitante;
        public VisitanteDto()
        {
            visitante = new Visitante();
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper().Trim(); }
        }
        private string rg;
        public string Rg
        {
            get { return rg; }
            set { rg = value.ToUpper().Trim(); }
        }
        private string informacoes;
        public string Infomacoes
        {
            get { return rg; }
            set { informacoes = value.ToUpper().Trim(); }
        }

        public string Bloco { get; set; }
        public string Apto { get; set; }

        public Visitante VisitanteValido()
        {
            visitante.Nome = nome;
            visitante.Rg = rg;
            visitante.Informacoes = informacoes;
            visitante.Bloco = Bloco;
            visitante.Apto = Apto;
            return visitante;
        }
    }
}
