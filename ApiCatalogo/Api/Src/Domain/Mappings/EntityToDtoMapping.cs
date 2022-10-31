using Api.Src.Domain.Dtos;
using Api.Src.Modules.ApiCatalogo.Domain;
using Api.Src.Modules.ApiCatalogo.Domain.Models;
using AutoMapper;

namespace Api.Src.Domain.Mappings
{
    public class EntityToDtoMapping : Profile
    {
        public EntityToDtoMapping()
        {
            CreateMap<Categoria, CategoriaDto>();
            CreateMap<Produto, ProdutoDto>();
            CreateMap<Categoria, UpdateCategoriaDto>();
            CreateMap<Produto, UpdateProdutoDto>();
            CreateMap<Categoria, PostCategoriaDto>();
            CreateMap<Produto,PostProdutoDto>();
        }
    }
}
