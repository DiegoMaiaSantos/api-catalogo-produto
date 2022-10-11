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

        public async Task<IEnumerable<Categoria>> FindAll()
        {
            try
            {
                var categorias = await _catalogoDBContext.Categorias.ToListAsync();

                return categorias;
            }
            catch (Exception ex)
            {
                Log.Error("Erro na busca da lista de categorias.");
                throw new Exception(ex.Message);
            }
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
                Log.Error("Erro na busca da categoria por id.");
                throw new Exception(ex.Message);
            }
        }

        public async Task<Categoria> CreateNewCategoria(Categoria categoria)
        {
            try
            {
                await _catalogoDBContext.Categorias.AddAsync(categoria);
                await _catalogoDBContext.SaveChangesAsync();

                return categoria;
            }
            catch (Exception ex)
            {
                Log.Error("Erro ao criar uma nova categoria.");
                throw new Exception(ex.Message);
            }
        }

        public async Task<Categoria> UpdateCategoria(Categoria categoria)
        {
            try
            {
                _catalogoDBContext.Entry(categoria).State = EntityState.Modified;
                await _catalogoDBContext.SaveChangesAsync();

                return categoria;
            }
            catch (Exception ex)
            {
                Log.Error("Erro ao atualizar uma categoria.");
                throw new Exception(ex.Message);
            }
        }

    }
}
