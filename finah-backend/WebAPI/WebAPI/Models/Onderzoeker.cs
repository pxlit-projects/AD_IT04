using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Onderzoeker
    {
        [Required]
        public String Email { get; set; }
    }
}