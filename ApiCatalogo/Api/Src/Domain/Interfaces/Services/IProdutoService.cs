using Api.Src.Domain.Dtos;
using Api.Src.Modules.ApiCatalogo.Domain.Models;

namespace Api.Src.Domain.Interfaces.Services
{
    public interface IProdutoService
    {
        public Task<List<ProdutoDto>> GetAll();
        public Task<ProdutoDto> GetId(int produtoId);
        public Task<PostProdutoDto> PostNew(Produto produto);
        public Task PutUpdate(UpdateProdutoDto produto);
        public Task<ProdutoDto> DeleteCategory(int produtoId);
    }
}
