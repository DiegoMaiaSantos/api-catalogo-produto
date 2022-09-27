﻿using System.Collections.ObjectModel;

namespace Api.Src.Modules.ApiCatalogo.Domain.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public string? ImagemUrl { get; set; }
        public ICollection<Produto>? Produtos { get; set; } = new Collection<Produto>();
    }
}
