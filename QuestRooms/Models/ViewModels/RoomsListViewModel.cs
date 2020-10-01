using System.Collections.Generic;
using QuestRooms.Models;
namespace QuestRooms.Models.ViewModels
{
    public class RoomsListViewModel
    {
        public IEnumerable<QuestRoom> QuestRooms { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}