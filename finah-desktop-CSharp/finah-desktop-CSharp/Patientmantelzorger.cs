using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finah_desktop_CSharp
{
    public class Patientmantelzorger
    {
        public int Id { get; set; }
        public String Vnaam { get; set; }
        public String Anaam { get; set; }
        public String Email { get; set; }
        public Boolean Verzorger { get; set; }
        public int Dokter_SId { get; set; }
    }
}
