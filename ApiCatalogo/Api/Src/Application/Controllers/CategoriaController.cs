using Api.Src.Domain.Dtos;
using Api.Src.Domain.Interfaces.Services;
using Api.Src.Modules.ApiCatalogo.Domain.Models;
using Api.Src.Shared.Application.Errors;
using Microsoft.AspNetCore.Mvc;

namespace Api.Src.Application.Controllers
{
    [Route("api/catalogo")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        /// <summary>
        /// Busca uma lista das categorias
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetAllCategoria()
        {
            try
            {
                var data = await _categoriaService.GetAll();

                return Ok(data);
            }
            catch (AppException ex)
            {
                return StatusCode(ex.StatusCode ?? StatusCodes.Status500InternalServerError,
                    new { ex.Message });
            }
        }

        /// <summary>
        /// Busca uma categoria pela id
        /// </summary>
        /// <param name="categoriaId"></param>
        /// <returns></returns>
        [HttpGet("{categoriaId}")]
        public async Task<ActionResult> GetByIdCategoria([FromRoute] int categoriaId)
        {
            try
            {
                var data = await _categoriaService.GetId(categoriaId);

                return Ok(data);
            }
            catch (AppException ex)
            {
                return StatusCode(ex.StatusCode ?? StatusCodes.Status500InternalServerError,
                    new { ex.Message });
            }
        }

        /// <summary>
        /// Cria uma nova categoria
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> PostCategoria(Categoria categoria)
        {
            try
            {
                var data = await _categoriaService.PostNew(categoria);

                return Ok(data);
            }
            catch (AppException ex)
            {
                return StatusCode(ex.StatusCode ?? StatusCodes.Status500InternalServerError,
                    new { ex.Message });
            }
        }

        /// <summary>
        /// Atualiza uma categoria pela id
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> PutCategoria([FromBody] Categoria categoria)
        {
            try
            {
                var data = await _categoriaService.PutUpdate(categoria);

                return Ok(data);
            }
            catch (AppException ex)
            {
                return StatusCode(ex.StatusCode ?? StatusCodes.Status500InternalServerError,
                    new { ex.Message });
            }
        }

        /// <summary>
        /// Deleta uma categoria pela id
        /// </summary>
        /// <param name="categoriaId"></param>
        /// <returns></returns>
        [HttpDelete("{categoriaId}")]
        public async Task<ActionResult> DeleteCategoria([FromRoute] int categoriaId)
        {
            try
            {
                var data = await _categoriaService.DeleteCategory(categoriaId);

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
