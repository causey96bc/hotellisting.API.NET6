using Microsoft.EntityFrameworkCore;

namespace hotellisting.api.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options): base(options)
        {
          
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "United States",
                    CountryCode = "US",

                },
                new Country
                {
                Id = 2,
                    Name = "Bahamas",
                    CountryCode = "BH",

                },
                new Country
                {
                    Id = 3,
                    Name = "Italy",
                    CountryCode = "IT",

                });

            modelBuilder.Entity<Hotel>().HasData(
                 new Hotel
                 {
                     Id = 1,
                     Name = "Marriot",
                     Address = "test1234",
                     Rating = 5,
                     CountryId = 1,

                 },
                new Hotel
                {
                    Id = 2,
                    Name = "Holiday Inn",
                    Address = "One Ocean",
                    Rating = 3,
                    CountryId = 2

                },
                new Hotel
                {
                    Id = 3,
                    Name = "VillaSuites",
                    Address = "The Villa",
                    Rating = 4,
                    CountryId = 3,

                }
                );
        }

    }
}
