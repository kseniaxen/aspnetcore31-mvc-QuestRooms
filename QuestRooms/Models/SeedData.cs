using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace QuestRooms.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            RoomsDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<RoomsDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.QuestRooms.Any())
            {
                context.QuestRooms.AddRange(
               new QuestRoom
               {
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
                   GalleryPhotos = "sherlok1.jpg sherlok2.jpg sherlok3.jpg"
               },
               new QuestRoom
               {
                   Name = "Name1",
                   Description = "Description1",
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
                   GalleryPhotos = "sherlok1.jpg sherlok2.jpg sherlok3.jpg"
               },
                new QuestRoom
               {
                   Name = "Name2",
                   Description = "Description2",
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
                   GalleryPhotos = "sherlok1.jpg sherlok2.jpg sherlok3.jpg"
               }
                );
                context.SaveChanges();
            }
        }
    }
}