using Api.Src.Domain.Interfaces.Repositories;
using Api.Src.Infra.Data.Contexts;
using Api.Src.Modules.ApiCatalogo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Api.Src.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly CatalogoDBContext _catalogoDBContext;

        public ProdutoRepository(CatalogoDBContext catalogoDBContext)
        {
            _catalogoDBContext = catalogoDBContext;
        }

        public async Task<List<Produto>> FindAll()
        {
            try
            {
                return await _catalogoDBContext.Produtos
                    .Include(p => p.Categoria)
                    .AsNoTracking()
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                Log.Error("Erro na busca da lista dos produtos.");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<Produto> FindById(int produtoId)
        {
            try
            {
                return await _catalogoDBContext.Produtos
                    .Include(p => p.Categoria)
                    .FirstOrDefaultAsync(p => p.ProdutoId == produtoId);
            }
            catch (Exception ex)
            {
                Log.Error("Erro na busca do produto por id.");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<Produto> CreateNewCategoria(Produto produto)
        {
            try
            {
                await _catalogoDBContext.Produtos.AddAsync(produto);
                await _catalogoDBContext.SaveChangesAsync();

                return produto;
            }
            catch (Exception ex)
            {
                Log.Error("Erro ao criar um novo produto.");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<Produto> UpdateCategoria(Produto produto)
        {
            try
            {
                _catalogoDBContext.Entry(produto).State = EntityState.Modified;
                await _catalogoDBContext.SaveChangesAsync();

                return produto;
            }
            catch (Exception ex)
            {
                Log.Error("Erro ao atualizar um produto.");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<Produto> DeleteById(int produtoId)
        {
            try
            {
                var result = await _catalogoDBContext.Produtos
                    .FirstOrDefaultAsync(p => p.ProdutoId == produtoId);

                _catalogoDBContext.Produtos.Remove(result);
                await _catalogoDBContext.SaveChangesAsync();

                return result;
            }
            catch (Exception ex)
            {
                Log.Error("Erro ao deletar um produto.");
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
