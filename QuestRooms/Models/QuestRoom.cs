using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace QuestRooms.Models
{
    public class QuestRoom
    {
        public long QuestRoomID { get; set; }

        [Required(ErrorMessage = "Please enter a quest room name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a quest room description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter a quest room time")]
        public string Time { get; set; }
        [Required(ErrorMessage = "Please enter a quest room minimum people")]
        public int MinimumPeople { get; set; }
        [Required(ErrorMessage = "Please enter a quest room maximum people")]
        public int MaximumPeople { get; set; }
        [Required(ErrorMessage = "Please enter a quest room minimum age of people")]
        public int MinimumAgePeople { get; set; }
        [Required(ErrorMessage = "Please enter a quest room address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter a quest room phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter a quest room email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter a quest room company")]
        public string Company { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Please enter rating of quest room")]
        public int Rating { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Please enter level of fear of quest room")]
        public int LevelFear { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Please enter level of complexity of quest room")]
        public int LevelСomplexity { get; set; }
        [Required(ErrorMessage = "Please enter path of logo")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "Please enter path of gallery photos")]
        public string GalleryPhotos { get; set; }

    }
}