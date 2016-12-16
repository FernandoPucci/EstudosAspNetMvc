namespace ExercicioVendasMasterDetail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENDAS_DB.PRODUTO")]
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            ItemVenda = new HashSet<ItemVenda>();
        }

        [Key]
        [Column("ID_PRODUTO")]
        public decimal IdProduto { get; set; }

        [StringLength(300)]
        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Column("VLR_UNIT")]
        public decimal? VlrUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemVenda> ItemVenda { get; set; }
    }
}
