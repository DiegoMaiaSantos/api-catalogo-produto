using Api.Src.Domain.Interfaces.Services;
using Api.Src.Shared.Application.Errors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Src.Application.Controllers
{
    [Route("api/[catalogo]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet("{categoriaId}")]
        public async Task<ActionResult> GetCategoria([FromRoute] int categoriaId)
        {
            try
            {
                var data = await _categoriaService.Execute(categoriaId);

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
