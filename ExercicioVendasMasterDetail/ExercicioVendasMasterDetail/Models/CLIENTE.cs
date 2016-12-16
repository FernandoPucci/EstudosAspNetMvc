namespace ExercicioVendasMasterDetail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENDAS_DB.CLIENTE")]
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            VENDA = new HashSet<VENDA>();
        }

        [Key]
        public decimal ID_CLIENTE { get; set; }

        [StringLength(30)]
        public string NOME { get; set; }

        [StringLength(50)]
        public string SOBRENOME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENDA> VENDA { get; set; }
    }
}
