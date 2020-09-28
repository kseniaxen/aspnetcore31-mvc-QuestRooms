using Microsoft.EntityFrameworkCore;
namespace QuestRooms.Models
{
    public class RoomsDbContext : DbContext
    {
        public RoomsDbContext(DbContextOptions<RoomsDbContext> options)
        : base(options) { }
        public DbSet<QuestRoom> QuestRooms { get; set; }
    }
}