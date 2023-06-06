using Microsoft.EntityFrameworkCore;

namespace ApiBlog.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {}

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
