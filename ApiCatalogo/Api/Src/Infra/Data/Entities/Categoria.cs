﻿using System.Text.Json.Serialization;

namespace Api.Src.Modules.ApiCatalogo.Domain.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }
        [JsonIgnore]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
