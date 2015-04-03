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
        public String Vnaam { get; set; }

        [Required]
        public String Anaam { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }
    }
}