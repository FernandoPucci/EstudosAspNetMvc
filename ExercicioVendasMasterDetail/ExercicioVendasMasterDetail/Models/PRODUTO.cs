namespace ExercicioVendasMasterDetail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENDAS_DB.PRODUTO")]
    public partial class PRODUTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUTO()
        {
            ITEM_VENDA = new HashSet<ITEM_VENDA>();
        }

        [Key]
        public decimal ID_PRODUTO { get; set; }

        [StringLength(300)]
        public string DESCRICAO { get; set; }

        public decimal? VLR_UNIT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_VENDA> ITEM_VENDA { get; set; }
    }
}
