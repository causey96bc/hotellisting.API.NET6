using Microsoft.EntityFrameworkCore;

namespace hotellisting.api.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options): base(options)
        {
          
        }
    }
}
