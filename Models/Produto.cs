using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AntonioMeireles.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        [Display(Name = "Marca")]
        public int MarcaId { get; set; }
        public Marca? Marca { get; set; }
        public List<Item>? Itens { get; set; }
    }
}