using Api.Src.Infra.Data.Mappers;
using Api.Src.Modules.ApiCatalogo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Src.Infra.Data.Contexts
{
    public class CatalogoDBContext : DbContext
    {
        public virtual DbSet<Categoria>? Categorias { get; set; }
        public virtual DbSet<Produto>? Produtos { get; set; }
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options) 
            : base(options)
        { 
        }

        private static void ApplyMappers(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMapper());
            modelBuilder.ApplyConfiguration(new ProdutoMapper());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyMappers(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
