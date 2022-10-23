using Api.Src.Modules.ApiCatalogo.Domain.Models;

namespace Api.Src.Domain.Dtos
{
    public class CategoriaDto
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}
