using Api.Src.Domain.Interfaces.Services;
using Api.Src.Modules.ApiCatalogo.Domain.Models;
using Api.Src.Shared.Application.Errors;
using Serilog;

namespace Api.Src.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<Categoria> Execute(int categoriaId)
        {
            try
            {
                Categoria categoria = await _categoriaRepository.FindById(categoriaId);

                if (categoria == null)
                    throw new AppException("A categoria selecionada não existe.", 
                        StatusCodes.Status404NotFound);
            } 
            catch (Exception ex)
            {
                Log.Error($"Erro ao executar o serviço que mostra as categorias: {ex.Message}");
                throw new ArgumentException(ex.Message, ex.Message);
            }
        }
    }
}
