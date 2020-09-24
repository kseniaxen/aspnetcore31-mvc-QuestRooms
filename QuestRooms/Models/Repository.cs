using System.Collections.Generic;
namespace QuestRooms.Models
{
    public static class Repository
    {
        private static List<QuestRoom> listQuestRooms = new List<QuestRoom>();
        public static IEnumerable<QuestRoom> ListQuestRooms => listQuestRooms;
        public static void AddQuestRoom(QuestRoom questRoom)
        {
            listQuestRooms.Add(questRoom);
        }
    }
}