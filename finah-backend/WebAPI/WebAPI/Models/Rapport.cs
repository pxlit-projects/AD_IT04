﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Rapport
    {
        public int Id { get; set; }

        [Required]
        public int Patient_Id { get; set; }

        [Required]
        public int Mantelzorger_Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Vragenlijst_Id { get; set; }

        [Required]
        public int Dokter_Id { get; set; }

    }
}