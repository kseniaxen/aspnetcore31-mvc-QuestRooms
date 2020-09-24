using Microsoft.AspNetCore.Mvc;
using QuestRooms.Models;
using System.Collections.Generic;
namespace QuestRooms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult ListQuestRooms(){
            List<string> listgallery = 
                new List<string>(){
                    "sherlok1.jpg",
                    "sherlok2.jpg",
                    "sherlok3.jpg"
                    };
            Repository.AddQuestRoom(new QuestRoom{
                Name = "Шерлок",
                Description = "Иногда чтобы распутать дело, даже великолепному Шерлоку необходимо заглянуть внутрь себя самого. Особенно, когда в самый неподходящий момент расследование перевернулось с ног на голову. У вас будет ровно час, чтобы разложить всё по полочкам в чертогах разума гениального сыщика Шерлока Холмса и раскрыть-таки злополучное дело!",
                Time = "60 минут",
                MinimumPeople = 3,
                MaximumPeople = 6,
                MinimumAgePeople = 14,
                Address = "б-р Леси Украинки, 24",
                Phone = "+38 098 641 94 34",
                Email = "info@kadroom.com",
                Company = "kadroom",
                Rating = 4,
                LevelFear = 2,
                LevelСomplexity = 4,
                Logo = "kadroom.png",
                GalleryPhotos = listgallery
            });
            return View(Repository.ListQuestRooms);
        }

    }
}
