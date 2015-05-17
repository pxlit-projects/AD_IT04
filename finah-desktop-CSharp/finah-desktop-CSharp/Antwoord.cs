using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finah_desktop_CSharp
{
    public class Antwoord
    {
        public int Id { get; set; }

        public int Vraag_Id { get; set; }

        public int Rapport_Id { get; set; }

        public int AntwoordInt { get; set; }

        public int AntwoordExtra { get; set; }

        public Boolean Verzorger { get; set; }
    }

}
