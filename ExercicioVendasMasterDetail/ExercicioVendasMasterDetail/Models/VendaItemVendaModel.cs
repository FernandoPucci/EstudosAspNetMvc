using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExercicioVendasMasterDetail.Models
{
    public class VendaItemVendaModel
    {

        public VendaItemVendaModel(Cliente c, List<ItemVenda> itensVenda)
        {

            Cliente = c;

            Venda = new Venda();
            Venda.Cliente = c;
            Venda.DtVenda = DateTime.Now;


        }


        public VendaItemVendaModel()
        {
            Cliente = new Cliente();
            Venda = new Venda();
            Venda.DtVenda = DateTime.Now;
        }


        public Venda Venda { get; set; }
        public Cliente Cliente { get; set; }


    }
}