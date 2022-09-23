using Api.Src.Modules.ApiCatalogo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Src.Modules.ApiCatalogo.Infra.Data.Repository.Entity
{
    public class ApiCatalogoDbContext : DbContext
    {
        public ApiCatalogoDbContext(DbContextOptions<ApiCatalogoDbContext> options) : base(options) 
        {}

        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
    }
}
