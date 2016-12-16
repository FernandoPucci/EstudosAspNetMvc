namespace ExercicioVendasMasterDetail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENDAS_DB.VENDA")]
    public partial class Venda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venda()
        {
            ItemVenda = new HashSet<ItemVenda>();
        }

        [Key]
        [Column("ID_VENDA")]
        public decimal IdVenda { get; set; }

        [Column("ID_CLIENTE")]
        public decimal IdCliente { get; set; }

        [Column("DT_VENDA")]
        public DateTime? DtVenda { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemVenda> ItemVenda { get; set; }
    }
}
