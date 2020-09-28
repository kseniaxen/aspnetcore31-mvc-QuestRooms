using System.Linq;
namespace QuestRooms.Models
{
    public class EFRoomsRepository : IRoomsRepository
    {
        private RoomsDbContext context;
        public EFRoomsRepository(RoomsDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<QuestRoom> QuestRooms => context.QuestRooms;
    }
}