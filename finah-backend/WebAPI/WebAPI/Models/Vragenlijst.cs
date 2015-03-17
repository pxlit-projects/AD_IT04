using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Vragenlijst
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(450)]
        public String Beschrijving { get; set; }
    }
}