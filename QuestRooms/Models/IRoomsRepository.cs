using System.Linq;
namespace QuestRooms.Models
{
    public interface IRoomsRepository
    {
        IQueryable<QuestRoom> QuestRooms { get; }
    }
}