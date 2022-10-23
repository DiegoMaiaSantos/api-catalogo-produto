using Api.Src.Modules.ApiCatalogo.Domain;

namespace Api.Src.Domain.Interfaces.Repositories
{
    public interface ICategoriaRepository
    {
        public Task<List<Categoria>> FindAll();
        public Task<Categoria> FindById(int categoriaId);
        public Task<Categoria> CreateNewCategoria(Categoria categoria);
        public Task<Categoria> UpdateCategoria(Categoria categoria);
        public Task<Categoria> DeleteById(int categoriaId);
    }
}
