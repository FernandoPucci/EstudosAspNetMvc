namespace ExercicioVendasMasterDetail.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VendasModel : DbContext
    {
        public VendasModel()
            : base("name=VendasModel")
        {
        }

        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<ITEM_VENDA> ITEM_VENDA { get; set; }
        public virtual DbSet<PRODUTO> PRODUTO { get; set; }
        public virtual DbSet<VENDA> VENDA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.ID_CLIENTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.SOBRENOME)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.VENDA)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ITEM_VENDA>()
                .Property(e => e.ID_ITEM_VENDA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ITEM_VENDA>()
                .Property(e => e.ID_VENDA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ITEM_VENDA>()
                .Property(e => e.ID_PRODUTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ITEM_VENDA>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ITEM_VENDA>()
                .Property(e => e.SUB_TOTAL)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.ID_PRODUTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUTO>()
                .Property(e => e.VLR_UNIT)
                .HasPrecision(5, 2);

            modelBuilder.Entity<PRODUTO>()
                .HasMany(e => e.ITEM_VENDA)
                .WithRequired(e => e.PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.ID_VENDA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VENDA>()
                .Property(e => e.ID_CLIENTE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<VENDA>()
                .HasMany(e => e.ITEM_VENDA)
                .WithRequired(e => e.VENDA)
                .WillCascadeOnDelete(false);
        }
    }
}
