using Microsoft.EntityFrameworkCore;
using RegistroVisitante.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroVisitante.Persistence;

public class VisitanteContext : DbContext
{
    private string connectionString = "server=localhost;database=controle_visitantes;username= root;password= root";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    public DbSet<Visitante> Visitantes { get; set; }
    public DbSet<LivroDePassagemDeServico> PassagemDeServico { get; set; }
}
