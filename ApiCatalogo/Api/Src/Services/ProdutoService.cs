using Api.Src.Domain.Dtos;
using Api.Src.Domain.Interfaces.Repositories;
using Api.Src.Domain.Interfaces.Services;
using Api.Src.Modules.ApiCatalogo.Domain.Models;
using Api.Src.Shared.Application.Errors;
using AutoMapper;
using Serilog;

namespace Api.Src.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoRepository, IMapper mapper)
        {
            _produtoRepository = produtoRepository;
            _mapper = mapper;
        }

        public async Task<List<ProdutoDto>> GetAll()
        {
            try
            {
                var result = await _produtoRepository.FindAll();

                if (result is null)
                    throw new AppException("A lista de produtos não foi encontrada.",
                        StatusCodes.Status404NotFound);

                return _mapper.Map<List<Produto>, List<ProdutoDto>>(result);
            }
            catch (Exception ex)
            {
                Log.Error($"Erro ao executar o serviço que mostra os produtos: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<ProdutoDto> GetId(int produtoId)
        {
            try
            {
                var result = await _produtoRepository.FindById(produtoId);

                if (result == null)
                    throw new AppException($"O id: {produtoId} não existe nos produtos.",
                        StatusCodes.Status404NotFound);

                return _mapper.Map<Produto, ProdutoDto>(result);
            }
            catch (Exception ex)
            {
                Log.Error($"Erro ao executar o serviço que mostra a id dos produtos: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<ProdutoDto> PostNew(Produto produto)
        {
            try
            {
                var result = await _produtoRepository.CreateNewCategoria(produto);

                if (result is null)
                    throw new AppException("Solicitação para criar um novo produto inválida.",
                        StatusCodes.Status400BadRequest);

                return _mapper.Map<Produto, ProdutoDto>(result);
            }
            catch (Exception ex)
            {
                Log.Error($"Erro no serviço que cria um novo produto: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<ProdutoDto> PutUpdate(Produto produto)
        {
            try
            {
                Produto result = await _produtoRepository.UpdateCategoria(produto);

                produto.Nome = produto.Nome ?? result.Nome;
                produto.Descricao = produto.Descricao ?? result.Descricao;
                produto.Preco = produto.Preco ?? result.Preco;
                produto.ImagemUrl = produto.ImagemUrl ?? result.ImagemUrl;
                produto.Estoque = produto.Estoque ?? result.Estoque;
                produto.DataCadastro = produto.DataCadastro ?? result.DataCadastro;
                produto.CategoriaProduto = produto.CategoriaProduto ?? result.CategoriaProduto;

                if (result.ProdutoId != produto.ProdutoId)
                    throw new AppException("Solicitação para atualizar um prdouto inválida.",
                        StatusCodes.Status400BadRequest);

                return _mapper.Map<Produto, ProdutoDto>(result);
            }
            catch (Exception ex)
            {
                Log.Error($"Erro no serviço que atualiza os produtos: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }

        public async Task<ProdutoDto> DeleteCategory(int produtoId)
        {
            try
            {
                var result = await _produtoRepository.DeleteById(produtoId);

                if (result is null)
                    throw new AppException($"O id: {produtoId} não existe nos produtos.",
                        StatusCodes.Status404NotFound);

                return _mapper.Map<Produto, ProdutoDto>(result);
            }
            catch (Exception ex)
            {
                Log.Error($"Erro ao executar o serviço que deleta o produto por id: {ex.Message}");
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
