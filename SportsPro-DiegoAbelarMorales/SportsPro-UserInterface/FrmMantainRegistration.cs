using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsPro_BusinessClassLibrary;

namespace SportsPro_UserInterface
{
    public partial class FrmMantainRegistration : Form
    {
        public FrmMantainRegistration()
        {
            InitializeComponent();
        }

        CustomerDB custDB = new CustomerDB();
        ProductDB prodDB = new ProductDB();

        RegistrationDB regDB = new RegistrationDB();



        private void FrmMantainRegistration_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxes();
        }

        private void LoadComboBoxes()

        {
            try
            {

                cBoxCustName.DataSource = custDB.GetCustomerList();
                cBoxCustName.DisplayMember = "Name";
                cBoxCustName.ValueMember = "CustomerID";
                cBoxCustName.SelectedIndex = -1;

                cBoxProduct.DataSource = prodDB.GetProductsList();
                cBoxProduct.DisplayMember = "Name";
                cBoxProduct.ValueMember = "ProductCode";
                cBoxProduct.SelectedIndex = -1;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {   

           

            string productID = Convert.ToString(cBoxProduct.SelectedValue);

            

              int customerID = Convert.ToInt32(cBoxCustName.SelectedValue);


            try
            {

                RegistrationDB regDB = new RegistrationDB();




                if (regDB.ProductRegistration(customerID,productID))
                {
                    MessageBox.Show("Registration Exists","Registration",MessageBoxButtons.OK,MessageBoxIcon.Information);



                 }

                else
                {
                    Registration aRegistration = new Registration();

                    DateTime myDateTime = DateTime.Now;
                    string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

                    aRegistration.RegistrationDate = myDateTime;
                    
                    regDB.AddRegistration(aRegistration);


                    MessageBox.Show("Registrationd Added", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }







        }

        
    }


}
