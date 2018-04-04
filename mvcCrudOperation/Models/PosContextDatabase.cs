namespace mvcCrudOperation.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PosContextDatabase : DbContext
    {
        public PosContextDatabase()
            : base("name=PosContextDatabase")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCatagory> ProductCatagories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
