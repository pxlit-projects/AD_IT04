using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace finah_desktop_CSharp
{
    [DataContract]
    public class Vragenlijst
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Beschrijving { get; set; }

        [DataMember]
        public int Dokter_Id { get; set; }
    }
}
