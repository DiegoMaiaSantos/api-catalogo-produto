using Api.Src.Domain.Dtos;
using Api.Src.Domain.Interfaces.Services;
using Api.Src.Modules.ApiCatalogo.Domain.Models;
using Api.Src.Shared.Application.Errors;
using Microsoft.AspNetCore.Mvc;

namespace Api.Src.Application.Controllers
{
    [Route("api/produto")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        /// <summary>
        /// Busca uma lista de todos os produtos
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetAllCategoria()
        {
            try
            {
                var data = await _produtoService.GetAll();

                return Ok(data);
            }
            catch (AppException ex)
            {
                return StatusCode(ex.StatusCode ?? StatusCodes.Status500InternalServerError,
                    new { ex.Message });
            }
        }

        /// <summary>
        /// Busca um produto pela id
        /// </summary>
        /// <param name="produtoId"></param>
        /// <returns></returns>
        [HttpGet("{produtoId}")]
        public async Task<ActionResult> GetByIdCategoria([FromRoute] int produtoId)
        {
            try
            {
                var data = await _produtoService.GetId(produtoId);

                return Ok(data);
            }
            catch (AppException ex)
            {
                return StatusCode(ex.StatusCode ?? StatusCodes.Status500InternalServerError,
                    new { ex.Message });
            }
        }

        /// <summary>
        /// Cria um novo produto
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> PostCategoria(Produto produto)
        {
            try
            {
                var data = await _produtoService.PostNew(produto);

                return Ok(data);
            }
            catch (AppException ex)
            {
                return StatusCode(ex.StatusCode ?? StatusCodes.Status500InternalServerError,
                    new { ex.Message });
            }
        }

        /// <summary>
        /// Atualiza um produto pela id
        /// </summary>
        /// <param name="produtoDto"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> PutCategoria([FromBody] UpdateProdutoDto produtoDto)
        {
            try
            {
                await _produtoService.PutUpdate(produtoDto);

                return Ok(produtoDto);
            }
            catch (AppException ex)
            {
                return StatusCode(ex.StatusCode ?? StatusCodes.Status500InternalServerError,
                    new { ex.Message });
            }
        }

        /// <summary>
        /// Deleta um produto pela id
        /// </summary>
        /// <param name="produtoId"></param>
        /// <returns></returns>
        [HttpDelete("{produtoId}")]
        public async Task<ActionResult> DeleteCategoria([FromRoute] int produtoId)
        {
            try
            {
                var data = await _produtoService.DeleteCategory(produtoId);

                return Ok(data);
            }
            catch (AppException ex)
            {
                return StatusCode(ex.StatusCode ?? StatusCodes.Status500InternalServerError,
                    new { ex.Message });
            }
        }
    }
}
