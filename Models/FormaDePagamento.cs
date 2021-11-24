using System;
using System.Collections.Generic;

namespace API.Models
{
    public class FormasDePagamento
    {
        public FormasDePagamento() => CriadoEm = DateTime.Now;
        public int FormasDePagamentoId { get; set; }
        public string OpcaoPagamento { get; set; }
        public string ParcelaPagamento { get; set; }
        public DateTime CriadoEm { get; set; }
        // public List<Produto> Produtos { get; set; }
    }
}