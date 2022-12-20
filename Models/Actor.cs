using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Etickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePicURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        public string  Bio { get; set; }

        //Relationiships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
