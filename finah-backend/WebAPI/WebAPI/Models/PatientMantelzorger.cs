using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class PatientMantelzorger
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
        [Display(Name = "Email")]
        public String Email { get; set; }

        [Required]
        public Boolean Verzorger { get; set; }

        [Required]
        public int Dokter_Id { get; set; }
    }
}