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
        public int VraagId { get; set; }

        [Required]
        public int RapportId { get; set; }

        [Required]
        public int AntwoordInt { get; set; }

        [Required]
        public int AntwoordExtra { get; set; }

        [Required]
        public Boolean Verzorger { get; set; }
    }
}