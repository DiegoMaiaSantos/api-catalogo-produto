using Api.Src.Domain.Dtos;
using Api.Src.Modules.ApiCatalogo.Domain;
using Api.Src.Modules.ApiCatalogo.Domain.Models;
using AutoMapper;

namespace Api.Src.Domain.Mappings
{
    public class DtoToEntityMapping : Profile
    {
        public DtoToEntityMapping()
        {
            CreateMap<CategoriaDto, Categoria>();
            CreateMap<ProdutoDto, Produto>();
            CreateMap<UpdateCategoriaDto, Categoria>();
            CreateMap<UpdateProdutoDto, Produto>();
            CreateMap<PostCategoriaDto, Categoria>();
            CreateMap<PostProdutoDto, Produto>();
        }
    }
}
