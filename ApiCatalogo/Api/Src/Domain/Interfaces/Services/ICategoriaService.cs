using Api.Src.Modules.ApiCatalogo.Domain.Models;

namespace Api.Src.Domain.Interfaces.Services
{
    public interface ICategoriaService
    {
        public Task<Categoria> Execute(int categoriaId);
    }
}
