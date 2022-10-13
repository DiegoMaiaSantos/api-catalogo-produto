﻿using Api.Src.Domain.Dtos;
using Api.Src.Modules.ApiCatalogo.Domain.Models;

namespace Api.Src.Domain.Interfaces.Services
{
    public interface ICategoriaService
    {
        public Task<IEnumerable<CategoriaDto>> GetAll();
        public Task<CategoriaDto> GetId(int categoriaId);
        public Task<CategoriaDto> PostNew(Categoria categoria);
        public Task<CategoriaDto> PutUpdate(Categoria categoria);
        public Task<CategoriaDto> DeleteCategory(int categoriaId);
    }
}
