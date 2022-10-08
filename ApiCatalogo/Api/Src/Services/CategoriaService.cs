using Api.Src.Domain.Interfaces.Repositories;
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

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            try
            {
                var categorias = await _categoriaRepository.FindAll();

                if (categorias is null)
                    throw new AppException("Categorias não encontradas.", 
                        StatusCodes.Status404NotFound);

                return categorias;
            }
            catch (Exception ex)
            {
                Log.Error($"Erro ao executar o serviço que mostra as categorias: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<Categoria> GetId(int categoriaId)
        {
            try
            {
                Categoria categoria = await _categoriaRepository.FindById(categoriaId);

                if (categoria == null)
                    throw new AppException($"O id: {categoriaId} não existe na categoria.", 
                        StatusCodes.Status404NotFound);

                return categoria;
            } 
            catch (Exception ex)
            {
                Log.Error($"Erro ao executar o serviço que mostra a id das categorias: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<Categoria> PostCate(Categoria categoria)
        {
            try
            {
                Categoria result = await _categoriaRepository.CreateNewCategoria(categoria);

                if (result is null)
                    throw new AppException("Solicitação para criar uma nova categoria inválida.",
                        StatusCodes.Status400BadRequest);

                return result;
            }
            catch (Exception ex)
            {
                Log.Error($"Erro no serviço que cria uma nova categoria: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
