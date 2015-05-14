using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace finah_desktop_CSharp
{
    [DataContract]
    public class Vraag
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Beschrijving { get; set; }   

        [DataMember]
        int Vragenlijst_Id { get; set; }
    }
}
