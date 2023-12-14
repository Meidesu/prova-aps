using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AntonioMeireles.Models
{
    public class NotaDeVenda
    {
        public int Id { get; set; }
        public DateTime DataDaVenda { get; set; }
        public bool Tipo { get; set; }
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        [Display(Name = "Vendedor")]
        public int VendedorId { get; set; }
        public Vendedor? Vendedor { get; set; }
        [Display(Name = "Transportadora")]
        public int TransportadoraId { get; set; }
        public Transportadora? Transportadora { get; set; }
        [Display(Name = "Tipo de Pagamento")]
        public int TipoDePagamentoId { get; set; }
        public TipoDePagamento? TipoDePagamento { get; set; }
        public List<Pagamento>? Pagamentos { get; set; }
        public List<Item>? Itens { get; set; }
    }
}

git init
git add .
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/Meidesu/prova-aps.git
git push -u origin main

