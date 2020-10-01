using System.Linq;
namespace QuestRooms.Models
{
    public interface IRoomsRepository
    {
        IQueryable<QuestRoom> QuestRooms { get; }
        void SaveQuestRoom(QuestRoom p);
        void CreateQuestRoom(QuestRoom p);
        void DeleteQuestRoom(QuestRoom p);
    }
}