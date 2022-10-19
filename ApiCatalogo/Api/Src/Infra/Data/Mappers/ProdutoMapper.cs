using Api.Src.Modules.ApiCatalogo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Src.Infra.Data.Mappers
{
    public class ProdutoMapper : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTO");

            builder.HasKey(e => e.ProdutoId);

            builder.HasOne(e => e.Categoria)
                .WithMany(e => e.Produtos)
                .HasForeignKey(e => e.CategoriaProduto);

            builder.Property(e => e.ProdutoId)
                .HasColumnName("PRODUTO_ID");

            builder.Property(e => e.Nome)
                .HasColumnName("NOME_PRODUTO");

            builder.Property(e => e.Descricao)
                .HasColumnName("DESCRICAO_PRODUTO");

            builder.Property(e => e.Preco)
                .HasColumnName("PRECO");

            builder.Property(e => e.ImagemUrl)
                .HasColumnName("IMAGEM_URL");

            builder.Property(e => e.Estoque)
                .HasColumnName("ESTOQUE");

            builder.Property(e => e.DataCadastro)
                .HasColumnName("DATA_CADASTRO");

            builder.Property(e => e.CategoriaProduto)
                .HasColumnName("CATEGORIA_PRODUTO");
        }
    }
}
