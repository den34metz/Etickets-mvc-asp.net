using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Etickets.Models
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }

        public string Logo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
