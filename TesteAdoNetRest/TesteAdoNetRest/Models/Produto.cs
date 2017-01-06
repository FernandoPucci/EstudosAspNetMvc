using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteAdoNetRest.Models
{
    public class Produto
    {
        public long IdProduto { get; set; }
        public string Descricao { get; set; }
        public double ValorUnitario { get; set; }

    }
}