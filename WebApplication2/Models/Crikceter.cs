using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Cricketer
    {        
        public int ID { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength = 4)] 
        public string Name { get; set; }

        [Required]
        [Range(1, 500)]
        public int ODI { get; set; }

        [Required]
        [Range(1, 200)] 
        public int Test { get; set; }

        public string Grade { get; set; } 
    }
    public class CricketerDBContext : DbContext
    {
        public DbSet<Cricketer> Cricketers { get; set; }
    }
}
