namespace clXPos.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class XPosContext : DbContext
    {
        // Your context has been configured to use a 'XPosContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'clXPos.DataModel.XPosContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'XPosContext' 
        // connection string in the application configuration file.
        public XPosContext()
            : base("name=XPosContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Variant> Variants { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<OrderHeader> OrderHeaders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);
            modelBuilder.Entity<OrderHeader>()
                .Property(e => e.Amount)
                .HasPrecision(18, 4);
            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 4);
            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}