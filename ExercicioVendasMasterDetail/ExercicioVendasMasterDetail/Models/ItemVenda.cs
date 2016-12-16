namespace ExercicioVendasMasterDetail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENDAS_DB.ITEM_VENDA")]
    public partial class ItemVenda
    {
        [Key]
        public decimal ID_ITEM_VENDA { get; set; }

        public decimal ID_VENDA { get; set; }

        public decimal ID_PRODUTO { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public decimal? SUB_TOTAL { get; set; }

        public virtual Venda VENDA { get; set; }

        public virtual Produto PRODUTO { get; set; }
    }
}
