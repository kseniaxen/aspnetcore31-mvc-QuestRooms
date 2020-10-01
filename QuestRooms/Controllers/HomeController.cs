using Microsoft.AspNetCore.Mvc;
using QuestRooms.Models;
using System.Linq;
using System.Collections.Generic;
using QuestRooms.Models.ViewModels;
namespace QuestRooms.Controllers
{
    public class HomeController : Controller
    {
        private IRoomsRepository repository;
        public int PageSize = 3;
        public HomeController(IRoomsRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(int roomPage = 1) => View(new RoomsListViewModel
            {
                QuestRooms = repository.QuestRooms
                    .OrderBy(p => p.QuestRoomID)
                    .Skip((roomPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = roomPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.QuestRooms.Count()
                }
            });
        public ViewResult Room(int questId) => View(repository.QuestRooms.First(r => r.QuestRoomID == questId));

    }
}
