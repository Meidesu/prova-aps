using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AntonioMeireles.Models
{
    public class Marca
    {  
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public List<Produto>? Produtos { get; set; }
    }
}