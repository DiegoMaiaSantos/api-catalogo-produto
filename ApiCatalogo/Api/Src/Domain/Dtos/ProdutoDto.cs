using Api.Src.Modules.ApiCatalogo.Domain;

namespace Api.Src.Domain.Dtos
{
    public class ProdutoDto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal? Preco { get; set; }
        public string ImagemUrl { get; set; }
        public int? Estoque { get; set; }
        public DateTime? DataCadastro { get; set; } = DateTime.Now;
        public int? CategoriaProduto { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
