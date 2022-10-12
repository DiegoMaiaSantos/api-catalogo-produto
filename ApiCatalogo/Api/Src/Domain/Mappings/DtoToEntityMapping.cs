﻿using Api.Src.Domain.Dtos;
using Api.Src.Modules.ApiCatalogo.Domain.Models;
using AutoMapper;

namespace Api.Src.Domain.Mappings
{
    public class DtoToEntityMapping : Profile
    {
        public DtoToEntityMapping()
        {
            CreateMap<CategoriaDto, Categoria>();
        }
    }
}
