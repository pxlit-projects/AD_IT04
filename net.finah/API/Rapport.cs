using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    class Rapport
    {
        private int id; 
        private int patientId;
        private int mantelzorgerId;
        private DateTime date;
        private int VragenlijstId;

        public int setId
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime setDate
        {
            get { return date; }
            set { date = value; }
        }

        public int setVragenlijstId
        {
            get { return VragenlijstId; }
            set { VragenlijstId = value; }
        }
        
       public String toString() {
           return id + ":" + patientId + "," + mantelzorgerId + "-" + date + "(" + vragenlijstId + ")";
	    }   

    }
}
