using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS_Engineering_Main.Dash
{
    public partial class frmDashPM : Form
    {
        public frmDashPM()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (pnlAdminV.Visible == false)
            {
                pnlAdminV.Visible = true;

                pnlEquipV.Visible = false;
                pnlPayV.Visible = false;
                pnlProjectV.Visible = false;
                
            }
            else
            {
                pnlAdminV.Visible = false;
            }

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlProject_Click(object sender, EventArgs e)
        {
            if (pnlProjectV.Visible == false)
            {
                pnlProjectV.Visible = true;

                pnlEquipV.Visible = false;
                pnlPayV.Visible = false;
                pnlAdminV.Visible = false;
            }
            else
            {
                pnlProjectV.Visible = false;
            }
        }

        private void pnlEquip_Click(object sender, EventArgs e)
        {
            if (pnlEquipV.Visible == false)
            {
                pnlEquipV.Visible = true;

                pnlAdminV.Visible = false;
                pnlPayV.Visible = false;
                pnlProjectV.Visible = false;
            }
            else
            {
                pnlEquipV.Visible = false;
            }
        }

        private void pnlPay_Click(object sender, EventArgs e)
        {
            if (pnlPayV.Visible == false)
            {
                pnlPayV.Visible = true;

                pnlEquipV.Visible = false;
                pnlAdminV.Visible = false;
                pnlProjectV.Visible = false;
            }
            else
            {
                pnlPayV.Visible = false;
            }
        }
    }
}
