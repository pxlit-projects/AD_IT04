using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace finah_desktop_CSharp
{
    [DataContract]
    public class Patientmantelzorger
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Vnaam { get; set; }

        [DataMember]
        public String Anaam { get; set; }

        [DataMember]
        public String Email { get; set; }

        [DataMember]
        public Boolean Verzorger { get; set; }

        [DataMember]
        public int Dokter_Id { get; set; }

        public string FullName
        {
            get
            {
                return Vnaam + " " + Anaam;
            }
        }
    }
}
