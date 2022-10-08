﻿using Api.Src.Modules.ApiCatalogo.Domain.Models;

namespace Api.Src.Domain.Interfaces.Repositories
{
    public interface ICategoriaRepository
    {
        public Task<Categoria> FindById(int categoriaId);
    }
}