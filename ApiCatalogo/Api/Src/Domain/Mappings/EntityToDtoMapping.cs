﻿using Api.Src.Domain.Dtos;
using Api.Src.Modules.ApiCatalogo.Domain;
using AutoMapper;

namespace Api.Src.Domain.Mappings
{
    public class EntityToDtoMapping : Profile
    {
        public EntityToDtoMapping()
        {
            CreateMap<Categoria, CategoriaDto>();
        }
    }
}
