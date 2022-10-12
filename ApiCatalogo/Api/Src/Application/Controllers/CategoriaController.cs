﻿using Api.Src.Domain.Dtos;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaDto>>> GetCategoria()
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

        [HttpGet("{categoriaId}", Name ="ObterCategoria")]
        public async Task<ActionResult> GetCategoria([FromRoute] int categoriaId)
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

        [HttpPost]
        public async Task<ActionResult> PostCategoria(Categoria categoria)
        {
            try
            {
                var data = await _categoriaService.PostNew(categoria);

                return Ok(new CreatedAtRouteResult("ObterCategoria",
                    new { categoriaId = data.CategoriaId }, data));
            }
            catch (AppException ex)
            {
                return StatusCode(ex.StatusCode ?? StatusCodes.Status500InternalServerError,
                    new { ex.Message });
            }
        }

        [HttpPut("{categoriaId}")]
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
