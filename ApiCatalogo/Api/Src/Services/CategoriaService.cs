using Api.Src.Domain.Dtos;
using Api.Src.Domain.Interfaces.Repositories;
using Api.Src.Domain.Interfaces.Services;
using Api.Src.Modules.ApiCatalogo.Domain.Models;
using Api.Src.Shared.Application.Errors;
using AutoMapper;
using Serilog;

namespace Api.Src.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoriaDto>> GetAll()
        {
            try
            {
                var result = await _categoriaRepository.FindAll();

                if (result is null)
                    throw new AppException("A lista de categorias não foi encontrada.", 
                        StatusCodes.Status404NotFound);

                return _mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaDto>>(result);
            }
            catch (Exception ex)
            {
                Log.Error($"Erro ao executar o serviço que mostra as categorias: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<CategoriaDto> GetId(int categoriaId)
        {
            try
            {
                var result = await _categoriaRepository.FindById(categoriaId);

                if (result == null)
                    throw new AppException($"O id: {categoriaId} não existe na categoria.", 
                        StatusCodes.Status404NotFound);

                return _mapper.Map<Categoria,CategoriaDto>(result);
            } 
            catch (Exception ex)
            {
                Log.Error($"Erro ao executar o serviço que mostra a id das categorias: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<CategoriaDto> PostNew(Categoria categoria)
        {
            try
            {
                var result = await _categoriaRepository.CreateNewCategoria(categoria);

                if (result is null)
                    throw new AppException("Solicitação para criar uma nova categoria inválida.",
                        StatusCodes.Status400BadRequest);

                return _mapper.Map<Categoria, CategoriaDto>(result);
            }
            catch (Exception ex)
            {
                Log.Error($"Erro no serviço que cria uma nova categoria: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<CategoriaDto> PutUpdate(Categoria categoria)
        {
            try
            {
                Categoria result = await _categoriaRepository.UpdateCategoria(categoria);

                categoria.Nome = categoria.Nome ?? result.Nome;
                categoria.ImagemUrl = categoria.ImagemUrl ?? result.ImagemUrl;

                if (result.CategoriaId != categoria.CategoriaId)
                    throw new AppException("Solicitação para atualizar uma categoria inválida.",
                        StatusCodes.Status400BadRequest);

                return _mapper.Map<Categoria, CategoriaDto>(result);
            }
            catch (Exception ex)
            {
                Log.Error($"Erro no serviço que atualiza a categoria: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<CategoriaDto> DeleteCategory(int categoriaId)
        {
            try
            {
                var result = await _categoriaRepository.DeleteById(categoriaId);

                if (result is null)
                    throw new AppException($"O id: {categoriaId} não existe na categoria.",
                        StatusCodes.Status404NotFound);

                return _mapper.Map<Categoria, CategoriaDto>(result);
            }
            catch (Exception ex)
            {
                Log.Error($"Erro ao executar o serviço que deleta a categoria por id: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
