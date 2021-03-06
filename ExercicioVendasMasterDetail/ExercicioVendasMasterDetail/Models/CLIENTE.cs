namespace ExercicioVendasMasterDetail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VENDAS_DB.CLIENTE")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            Venda = new HashSet<Venda>();
        }

        [Key]
        [Column("ID_CLIENTE")]
        public decimal IdCliente { get; set; }

        [StringLength(30)]
        [Column("NOME")]
        public string Nome { get; set; }

        [StringLength(50)]
        [Column("SOBRENOME")]
        public string Sobrenome { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
