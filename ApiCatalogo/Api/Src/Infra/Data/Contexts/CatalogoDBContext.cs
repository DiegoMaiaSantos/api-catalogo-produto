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
    }
}
