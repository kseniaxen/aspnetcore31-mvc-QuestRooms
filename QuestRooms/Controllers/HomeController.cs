using Microsoft.AspNetCore.Mvc;
using QuestRooms.Models;
using System.Collections.Generic;
namespace QuestRooms.Controllers
{
    public class HomeController : Controller
    {
        private IRoomsRepository repository;
        public HomeController(IRoomsRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.QuestRooms);
        }

    }
}
