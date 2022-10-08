using Api.Src.Modules.ApiCatalogo.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Src.Infra.Data.Mappers
{
    public class CategoriaMapper : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("CATEGORIA");

            builder.HasKey(e => e.CategoriaId);

            builder.HasMany(e => e.Produtos)
                .WithOne(e => e.Categoria)
                .HasForeignKey(e => e.ProdutoId);

            builder.Property(e => e.CategoriaId)
                .HasColumnName("CATEGORIA_ID");

            builder.Property(e => e.Nome)
                .HasColumnName("NOME_CATEGORIA");

            builder.Property(e => e.ImagemUrl)
                .HasColumnName("IMAGEM_URL");
        }
    }
}
