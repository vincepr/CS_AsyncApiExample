using AsyncApiExample.Models;
using Microsoft.EntityFrameworkCore;

namespace AsyncApiExample.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<ListingRequest> ListingRequests => Set<ListingRequest>();
}
