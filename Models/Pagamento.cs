using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AntonioMeireles.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public DateTime DataLimite { get; set; }
        public double Valor { get; set; }
        public bool Pago { get; set; }
        [Display(Name = "Nota de Venda")]
        public int NotaDeVendaId { get; set; }
        public NotaDeVenda? NotaDeVenda { get; set; }
    }
}