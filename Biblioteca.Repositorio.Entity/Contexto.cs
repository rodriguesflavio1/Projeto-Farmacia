using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Biblioteca.Dominio;


namespace Biblioteca.Repositorio.Entity
{
    public class Contexto:DbContext
    {
          //O construtor para para a base do dbcontext que é a nossa conectionstring         
        public Contexto()
            : base("stringConexao")
        {
            
        }

        public DbSet<Produto> Usuarios { get; set; }

        //remove do entity a função de criar as tabelas com plurais
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Produto>().Property(x => x.nome).HasColumnType("varchar").IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Produto>().Property(x => x.fabricante).HasColumnType("varchar").IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Produto>().Property(x => x.principioAtivo).HasColumnType("varchar").IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Produto>().Property(x => x.dataValidade).HasColumnType("date").IsRequired();
            
            modelBuilder.Entity<Produto>().Property(x => x.apresentacao).HasColumnType("varchar").IsRequired().HasMaxLength(100);
        }
    }
}
