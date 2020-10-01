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

        public void CreateQuestRoom(QuestRoom p)
        {
            context.Add(p);
            context.SaveChanges();
        }
        public void DeleteQuestRoom(QuestRoom p)
        {
            context.Remove(p);
            context.SaveChanges();
        }
        public void SaveQuestRoom(QuestRoom p)
        {
            context.SaveChanges();
        }
    }
}