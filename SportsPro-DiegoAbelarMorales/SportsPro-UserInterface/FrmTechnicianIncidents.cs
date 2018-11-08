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
using System.Data.SqlClient;

namespace SportsPro_UserInterface
{
    public partial class FrmTechnicianIncidents : Form
    {
        public FrmTechnicianIncidents()
        {
            InitializeComponent();
        }

        private void btnGetIncidents_Click(object sender, EventArgs e)
        {
            IncidentDB anIncidentDB = new IncidentDB();


            try
            {
                   dgrIncidentByTech.DataSource = anIncidentDB.GetOpenTechnicianIncidents(int.Parse(textBoxTechID.Text));
                
                if (dgrIncidentByTech.RowCount < 1 )
                {
                    MessageBox.Show("No records found");


                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTechnicianIncidents_Load(object sender, EventArgs e)
        {

        }

        private void dgrIncidentByTech_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
