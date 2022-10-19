using Api.Src.Modules.ApiCatalogo.Domain.Models;
using System.Text.Json.Serialization;

namespace Api.Src.Domain.Dtos
{
    public class CategoriaDto
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }
        [JsonIgnore]
        public virtual List<Produto> Produtos { get; set; }
    }
}
