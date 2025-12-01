using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;

namespace MinimalApi.infraestrutura.Db
{
    public class Dbcontexto : DbContext
    {
        public Dbcontexto(DbContextOptions<Dbcontexto> options)
            : base(options)
        {
        }

        public DbSet<Administrador> Administradores { get; set; } = null!;
    }
}
