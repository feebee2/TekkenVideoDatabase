using System;
using System.ComponentModel.DataAnnotations;

namespace TekkenVideoDatabase.Models
{
    public class VideoLink
    {
        public Guid Id { get; set; }

        
        public string ?Player1 { get; set; }

        
        public string ?Player2 { get; set; }

        [Required]
        public string ?TimeStamp { get; set; }


    }
}
