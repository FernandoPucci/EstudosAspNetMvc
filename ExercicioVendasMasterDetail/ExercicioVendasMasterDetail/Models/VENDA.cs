namespace ExercicioVendasMasterDetail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENDAS_DB.VENDA")]
    public partial class VENDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENDA()
        {
            ITEM_VENDA = new HashSet<ITEM_VENDA>();
        }

        [Key]
        public decimal ID_VENDA { get; set; }

        public decimal ID_CLIENTE { get; set; }

        public DateTime? DT_VENDA { get; set; }

        public virtual CLIENTE CLIENTE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_VENDA> ITEM_VENDA { get; set; }
    }
}
