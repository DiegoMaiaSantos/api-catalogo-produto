using System.Text.Json.Serialization;

namespace Api.Src.Modules.ApiCatalogo.Domain.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal? Preco { get; set; }
        public string ImagemUrl { get; set; }
        public int? Estoque { get; set; }
        public DateTime? DataCadastro { get; set; } = DateTime.Now;
        public int? CategoriaProduto { get; set; }
        [JsonIgnore]
        public virtual Categoria Categoria { get; set; }
    }
}
