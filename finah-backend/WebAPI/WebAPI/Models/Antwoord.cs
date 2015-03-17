using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Antwoord
    {
        public int Id { get; set; }

        [Required]
        public int Vraag_Id { get; set; }

        [Required]
        public int Rapport_Id { get; set; }

        [Required]
        public int AntwoordInt { get; set; }

        [Required]
        public int AntwoordExtra { get; set; } 

        [Required]
        public Boolean Verzorger { get; set; }
    }
}