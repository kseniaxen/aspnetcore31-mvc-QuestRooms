using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using QuestRooms.Controllers;
using QuestRooms.Models;
using Xunit;
namespace QuestRooms.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var controller = new HomeController();

            List<string> listgallery =
               new List<string>(){
                    "sherlok1.jpg",
                    "sherlok2.jpg",
                    "sherlok3.jpg"
                   };

            QuestRoom[] questRooms = new QuestRoom[] {
                new QuestRoom{
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
                }
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
            // Act
            var model = Repository.ListQuestRooms;
            // Assert
            Assert.Equal(questRooms, model,
            Comparer.Get<QuestRoom>((p1, p2) => 
            p1.Name == p2.Name
            && p1.Description == p2.Description 
            && p1.Time == p2.Time
            && p1.MinimumPeople == p2.MinimumPeople
            && p1.MaximumPeople == p2.MaximumPeople
            && p1.Address == p2.Address
            && p1.Phone == p2.Phone
            && p1.Email == p2.Email
            && p1.Company == p2.Company
            && p1.Rating == p2.Rating
            && p1.LevelFear == p2.LevelFear
            && p1.LevelСomplexity == p2.LevelСomplexity
            && p1.Logo == p2.Logo
            && p1.GalleryPhotos == p2.GalleryPhotos));
        }
    }
}