using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AntonioMeireles.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        public string? Banco { get; set; }
        public string? NomeDoBanco { get; set; }
    }
}