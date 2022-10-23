using Api.Src.Modules.ApiCatalogo.Domain.Models;

namespace Api.Src.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository
    {
        public Task<List<Produto>> FindAll();
        public Task<Produto> FindById(int produtoId);
        public Task<Produto> CreateNewCategoria(Produto produto);
        public Task<Produto> UpdateCategoria(Produto produto);
        public Task<Produto> DeleteById(int produtoId);
    }
}
