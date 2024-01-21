using DesafioArquitetura.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace DesafioArquitetura.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteLancamento> ClienteLancamentos { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
