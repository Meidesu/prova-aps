using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AntonioMeireles.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public List<NotaDeVenda>? NotasDeVenda { get; set; }
    }
}