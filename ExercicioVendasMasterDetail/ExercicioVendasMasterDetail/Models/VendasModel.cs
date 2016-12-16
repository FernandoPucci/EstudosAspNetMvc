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

        public virtual DbSet<Cliente> CLIENTE { get; set; }
        public virtual DbSet<ItemVenda> ITEM_VENDA { get; set; }
        public virtual DbSet<Produto> PRODUTO { get; set; }
        public virtual DbSet<Venda> VENDA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.IdCliente)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Sobrenome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Venda)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemVenda>()
                .Property(e => e.ID_ITEM_VENDA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ItemVenda>()
                .Property(e => e.ID_VENDA)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ItemVenda>()
                .Property(e => e.ID_PRODUTO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ItemVenda>()
                .Property(e => e.QUANTIDADE)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ItemVenda>()
                .Property(e => e.SUB_TOTAL)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Produto>()
                .Property(e => e.IdProduto)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Produto>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Produto>()
                .Property(e => e.VlrUnit)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Produto>()
                .HasMany(e => e.ItemVenda)
                .WithRequired(e => e.PRODUTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Venda>()
                .Property(e => e.IdVenda)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Venda>()
                .Property(e => e.IdCliente)
                .HasPrecision(38, 0);

            modelBuilder.Entity<Venda>()
                .HasMany(e => e.ItemVenda)
                .WithRequired(e => e.VENDA)
                .WillCascadeOnDelete(false);
        }
    }
}
