using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsPro_BusinessClassLibrary
{
    public class Registration
    {

        private int customerID;

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        private String productCode;

        public String ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }


        private DateTime registrationDate;

        public DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }


        public Registration () { }








    }
}
