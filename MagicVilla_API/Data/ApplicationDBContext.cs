using MagicVilla_API.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base (options)
        {
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa> ().HasData (
                new Villa ()
                {
                    Id = 1,
                    Name = "Cozy Apartment",
                    Sqft = 800,
                    Occupancy = 2,
                    Details = "",
                    Rate = 1200.50,
                    ImageUrl = "https://t4.ftcdn.net/jpg/03/70/64/43/360_F_370644357_MDF4UXLAXTyyi2OyuK66tWW9cA2f8svL.jpg",
                    Amenity = "Balcony, Parking",
                    CreatedDate = DateTime.Now
                },
                new Villa ()
                {
                    Id = 2,
                    Name = "Modern Loft",
                    Sqft = 1200,
                    Occupancy = 4,
                    Details = "",
                    Rate = 2000.75,
                    ImageUrl = "https://im.proptiger.com/1/3232159/6/scape-villas-elevation-146125154.jpeg",
                    Amenity = "Gym, Pool",
                    CreatedDate = DateTime.Now
                },
                 new Villa ()
                 {
                     Id = 3,
                     Name = "Charming House",
                     Sqft = 1500,
                     Occupancy = 6,
                     Details = "",
                     Rate = 2500.25,
                     ImageUrl = "https://sky119191.b-cdn.net/wp-content/uploads/2023/02/word-image-50349-1-1.jpeg",
                     Amenity = "Garden, Fireplace",
                     CreatedDate = DateTime.Now
                 },
                  new Villa ()
                  {
                      Id = 4,
                      Name = "Seaside Villa",
                      Sqft = 2000,
                      Occupancy = 8,
                      Details = "",
                      Rate = 3500.00,
                      ImageUrl = "https://amazingarchitecture.com/storage/711/Deep-Villa-Atrey-and-Associates-New-Delhi-ndia-Amazing-Architecture-House.jpg",
                      Amenity = "Beach Access, Ocean View",
                      CreatedDate = DateTime.Now
                  },
                   new Villa ()
                   {
                       Id = 5,
                       Name = "Downtown Penthouse",
                       Sqft = 1800,
                       Occupancy = 4,
                       Details = "",
                       Rate = 2800.50,
                       ImageUrl = "https://speed.damacproperties.com/sites/default/files/2021-05/premier-villas-hero-banner-mobile.jpg",
                       Amenity = "City View, Concierge",
                       CreatedDate = DateTime.Now
                   });
        }
    }
}
