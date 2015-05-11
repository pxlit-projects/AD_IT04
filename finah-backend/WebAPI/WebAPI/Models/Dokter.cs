using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Dokter
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Voornaam")]
        public String Vnaam { get; set; }

        [Required]
        [Display(Name = "Achternaam")]
        public String Anaam { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }
    }
}