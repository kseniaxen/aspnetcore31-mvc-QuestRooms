using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace QuestRooms.Models
{
    public class QuestRoom
    {
        public long QuestRoomID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }
        public int MinimumPeople { get; set; }
        public int MaximumPeople { get; set; }
        public int MinimumAgePeople { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public int Rating { get; set; }
        public int LevelFear { get; set; }
        public int LevelСomplexity { get; set; }
        public string Logo { get; set; }
        public string GalleryPhotos { get; set; }
        
    }
}