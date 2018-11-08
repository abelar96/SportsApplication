using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsPro_BusinessClassLibrary
{
     public class Technician
    {

        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        private String phone;

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private int techID;

        public int TechID
        {
            get { return techID; }
            set { techID = value; }
        }


        public Technician() { }





    }
}
