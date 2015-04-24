using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    class Antwoord
    {
        private int id;
        private int vraagId;
        private int rapportId;
        private int antwoord;
        private int extraAntwoord;
        private Boolean verzorger;

        public int setVraagId
        {
            get { return vraagId; }
            set { vraagId = value; }
        }

        public int setRapportId
        {
            get { return rapportId; }
            set { rapportId = value; }
        }

        public int setAntwoord
        {
            get { return antwoord; }
            set { antwoord = value; }
        }

        public int setExtraAntwoord
        {
            get { return extraAntwoord; }
            set { extraAntwoord = value; }
        }

        public Boolean setVerzorger
        {
            get { return verzorger; }
            set { verzorger = value; }
        }

        public String toString()
        {
            return id + ":" + vraagId + "," + rapportId + "," + antwoord + "," + extraAntwoord + " verzorger:" + verzorger;
        }
    }
}
