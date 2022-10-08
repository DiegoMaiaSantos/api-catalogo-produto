using Api.Src.Modules.ApiCatalogo.Domain.Models;

namespace Api.Src.Domain.Interfaces.Services
{
    public interface ICategoriaService
    {
        public Task<IEnumerable<Categoria>> GetAll();
        public Task<Categoria> GetId(int categoriaId);
    }
}
