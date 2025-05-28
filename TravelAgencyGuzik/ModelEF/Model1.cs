namespace TravelAgencyGuzik.ModelEF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Bookings> Bookings { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Hotels> Hotels { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<Tours> Tours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bookings>()
                .Property(e => e.PaymentAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Hotels)
                .WithOptional(e => e.Cities)
                .HasForeignKey(e => e.CityId);

            modelBuilder.Entity<Clients>()
                .HasMany(e => e.Bookings)
                .WithOptional(e => e.Clients)
                .HasForeignKey(e => e.ClientId);

            modelBuilder.Entity<Countries>()
                .HasMany(e => e.Cities)
                .WithOptional(e => e.Countries)
                .HasForeignKey(e => e.CountryId);

            modelBuilder.Entity<Hotels>()
                .HasMany(e => e.Tours)
                .WithOptional(e => e.Hotels)
                .HasForeignKey(e => e.HotelId);

            modelBuilder.Entity<Tours>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Tours>()
                .HasMany(e => e.Bookings)
                .WithOptional(e => e.Tours)
                .HasForeignKey(e => e.TourId);
        }
    }
}
