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
        [Column("ID_ITEM_VENDA")]
        public decimal IdItemVenda { get; set; }

        [Column("ID_VENDA")]
        public decimal IdVenda { get; set; }

        [Column("ID_PRODUTO")]
        public decimal IdProduto { get; set; }

        [Column("QUANTIDADE")]
        public decimal? Quantidade { get; set; }

        [Column("SUB_TOTAL")]
        public decimal? Subtotal { get; set; }

        public virtual Venda Venda { get; set; }

        public virtual Produto Produto { get; set; }
    }
}
