using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsPro_BusinessClassLibrary
{
    public class Incident
    {
        public String ProductCode { get; set; }
        
        public DateTime DateOpened { get; set; }
        public String CustomerName { get; set; }
        public String TechName { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public int IncidentID { get; set; }
        public int CustomerID { get; set; }
        public String ProductName { get; }
        
        

        private int? techID;

        public int? TechID
        {
            get
            {
                if (techID.HasValue)
                    return techID;
                else
                    return null;
            }
            set
            {
                techID = value;
            }
        }



        private DateTime? dateClosed;

        public DateTime? DateClosed
        {
            get
            {
                if (dateClosed.HasValue)
                    return dateClosed;
                else
                    return null;
            }

            set { dateClosed = value; }
        }


        public Incident() { }





    }
}
