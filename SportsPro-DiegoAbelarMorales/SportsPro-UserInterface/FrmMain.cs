using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsPro_UserInterface
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void displayOpenIncidentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmOpenIncidents   frmOpenIncidents = new FrmOpenIncidents();
            frmOpenIncidents.Show();
            frmOpenIncidents.MdiParent = this;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void displayOpenIncidentsByTechnicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmTechnicianIncidents frmTechIncidents = new FrmTechnicianIncidents();
            frmTechIncidents.Show();
            frmTechIncidents.MdiParent = this;
        }

        private void mantainRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantainRegistration frmMantainRegistration = new FrmMantainRegistration();
            frmMantainRegistration.Show();
            frmMantainRegistration.MdiParent = this;
        }
    }
}
