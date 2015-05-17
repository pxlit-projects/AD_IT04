using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finah_desktop_CSharp
{
     public class Rapport
    {
        public int Id { get; set; }
        public int Patient_Id { get; set; }
        public int Mantelzorger_Id { get; set; }
        public DateTime Date { get; set; }
        public int Vragenlijst_Id { get; set; }
        public int Dokter_Id { get; set; }
    }
}
