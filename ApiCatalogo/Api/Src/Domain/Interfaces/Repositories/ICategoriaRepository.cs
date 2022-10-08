using Api.Src.Modules.ApiCatalogo.Domain.Models;

namespace Api.Src.Domain.Interfaces.Repositories
{
    public interface ICategoriaRepository
    {
        public Task<IEnumerable<Categoria>> FindAll();
        public Task<Categoria> FindById(int categoriaId);
        public Task<Categoria> CreateNewCategoria(Categoria categoria);

    }
}
