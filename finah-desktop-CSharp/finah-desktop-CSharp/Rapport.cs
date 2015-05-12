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
        public int MantelzorgerId { get; set; }
        public DateTime Date { get; set; }
        public int VragenlijstId { get; set; }

        /*private int id; 
        private int patientId;
        private int mantelzorgerId;
        private DateTime date;
        private int vragenlijstId;

        public Rapport(int id, int patientId, int mantelzorgerId, DateTime date, int vragenlijstId)
        {
            this.id = id;
            this.patientId = patientId;
            this.mantelzorgerId = mantelzorgerId;
            this.date = date;
            this.vragenlijstId = vragenlijstId;
        }

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
            get { return vragenlijstId; }
            set { vragenlijstId = value; }
        }
        
       public String toString() {
           return id + ":" + patientId + "," + mantelzorgerId + "-" + date + "(" + vragenlijstId + ")";
	    }   */

    }
}
