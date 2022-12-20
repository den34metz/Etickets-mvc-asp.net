﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Etickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }

        public string ProfilePicURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
