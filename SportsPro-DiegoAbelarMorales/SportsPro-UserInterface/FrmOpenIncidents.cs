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
    public partial class FrmOpenIncidents : Form
    {
        public FrmOpenIncidents()
        {
            InitializeComponent();
        }

        private void dgrOpenIncidents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //IncidentDB anIncidentDB = new IncidentDB();
            //try
            //{
            //    dgrOpenIncidents.DataSource = anIncidentDB.GetOpenIncidents();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            //}

        }

        private void FrmOpenIncidents_Load(object sender, EventArgs e)
        {
            IncidentDB anIncidentDB = new IncidentDB();
            try
            {
                dgrOpenIncidents.DataSource = anIncidentDB.GetOpenIncidents();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
