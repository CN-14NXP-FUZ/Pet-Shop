using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Shop.model
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; } 
        public string Species { get; set; }
        public string Breed { get; set; } 
        public int Age { get; set; } 
        public string Gender { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } 
        public string ImageUrl { get; set; } 
        public bool IsAvailable { get; set; }
    }

}