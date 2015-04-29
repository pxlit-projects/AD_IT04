using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class VragenlijstVersturenModel
    {
        public PatientMantelzorger[] Patienten { get; set; }
        public PatientMantelzorger[] Mantelzorgers { get; set; }
        public Vragenlijst[] Vragenlijsten { get; set; }
        public int[] Values { get; set; }
    }
}