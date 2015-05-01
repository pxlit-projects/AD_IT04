using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class VragenlijstVersturenModel
    {
        [Display(Name = "Patiënt")]
        public PatientMantelzorger[] Patienten { get; set; }

        [Display(Name = "Mantelzorger")]
        public PatientMantelzorger[] Mantelzorgers { get; set; }

        [Display(Name = "Vragenlijst")]
        public Vragenlijst[] Vragenlijsten { get; set; }

        public int[] Values { get; set; }
    }
}