using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class CustomVragenlijst
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Titel")]
        [Required]
        public String Beschrijving { get; set; }

        public Vraag[] Vragen { get; set; }
    }
}