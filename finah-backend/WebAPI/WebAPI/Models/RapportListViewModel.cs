using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class RapportListViewModel
    {
        [Key]
        public int Id { get; set; }
        public string PatientVnaam { get; set; }
        public string PatientAnaam { get; set; }
        public string MantelzorgerVnaam { get; set; }
        public string MantelzorgerAnaam { get; set; }
        public string VragenlijstBeschrijving { get; set; }
        public DateTime Date { get; set; }
        public Boolean HasAnswers { get; set; }
    }
}