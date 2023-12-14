using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AntonioMeireles.Models
{
    public class Item
    {
        public int Id { get; set; }
        public double Preco { get; set; }
        public int Percentual { get; set; }
        public int Quantidade { get; set; }
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
        [Display(Name = "Nota de Venda")]
        public int NotaDeVendaId { get; set; }
        public NotaDeVenda? NotaDeVenda { get; set; }
    }
}