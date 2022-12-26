﻿using System.ComponentModel.DataAnnotations;

namespace Movies_Service.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Biography { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
