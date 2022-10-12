using Api.Src.Domain.Dtos;
using Api.Src.Modules.ApiCatalogo.Domain.Models;

namespace Api.Src.Domain.Interfaces.Services
{
    public interface ICategoriaService
    {
        public Task<IEnumerable<CategoriaDto>> GetAll();
        public Task<Categoria> GetId(int categoriaId);
        public Task<Categoria> PostNew(Categoria categoria);
        public Task<Categoria> PutUpdate(Categoria categoria);
        public Task<Categoria> DeleteCategory(int categoriaId);

    }
}
