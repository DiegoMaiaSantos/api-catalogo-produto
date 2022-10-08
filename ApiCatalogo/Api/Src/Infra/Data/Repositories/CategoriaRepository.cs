using Api.Src.Domain.Interfaces.Repositories;
using Api.Src.Infra.Data.Contexts;
using Api.Src.Modules.ApiCatalogo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Api.Src.Infra.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly CatalogoDBContext _catalogoDBContext;

        public CategoriaRepository(CatalogoDBContext catalogoDBContext)
        {
            _catalogoDBContext = catalogoDBContext;
        }

        public async Task<Categoria> FindById(int categoriaId)
        {
            try
            {
                return await _catalogoDBContext.Categorias.FirstOrDefaultAsync(
                    c => c.CategoriaId == categoriaId);
            }
            catch (Exception ex)
            {
                Log.Error("Erro na busca da categoria por id");
                throw new Exception(ex.Message);
            }
        }
    }
}
