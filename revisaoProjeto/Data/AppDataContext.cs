using Microsoft.EntityFrameworkCore;
using revisaoProjeto.Models;

namespace revisaoProjeto.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
            // Inicialize suas propriedades aqui, se necessário
            Humanos = Set<Humano>();
        }

        // Cada classe que você quer que vire uma tabela no banco coloque aqui
        public DbSet<Humano> Humanos { get; set; }
    }
}
