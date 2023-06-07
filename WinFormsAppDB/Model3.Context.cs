namespace WinFormsAppDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using WinFormsAppDB;

    public partial class BesprozvannykhDBEntities : DbContext
    {
        public BesprozvannykhDBEntities()
        : base("name=BesprozvannykhDBEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<PickupPoint> PickUpPoint { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}