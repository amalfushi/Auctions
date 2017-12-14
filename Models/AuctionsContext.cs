using Microsoft.EntityFrameworkCore;

namespace Auctions.Models
{
    public class AuctionsContext : DbContext
    {
        public AuctionsContext(DbContextOptions<AuctionsContext> options) : base(options) {}

        public DbSet<User> Users { get; set;}

        public DbSet<Auction> Auctions { get; set;}
        public DbSet<Bid> Bids { get; set; }
    }
}