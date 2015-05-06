using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finah_desktop_CSharp
{
    public class Vraag
    {

        public string Beschrijving { get; set; }

        public int Id { get; set; }

        public int Vragenlijst_Id { get; set; }

        /*private int id;
        private string beschrijving;
        private int vragenlijstId;

       /* public Vraag(int id, string beschrijving, int vragenlijstId) 
        {
            this.id = id;
            this.beschrijving = beschrijving;
            this.vragenlijstId = vragenlijstId;
        }

        public int setId
        {
            get { return id; }
            set { id = value; }
        }

        public string setBeschrijving
        {
            get { return beschrijving; }
            set { beschrijving = value; }
        }

        public int setvragenlijstId
        {
            get { return vragenlijstId; }
            set { vragenlijstId = value; }
        }

        public String toString()
        {
            return id + ": " + beschrijving;
        }*/

    }
}
