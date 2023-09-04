using CAS_Engineering_Main.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            Color startColor = Color.FromArgb(0, 122, 204);
            Color endColor = Color.FromArgb(23, 162, 184);
            LinearGradientMode gradientMode = LinearGradientMode.Vertical;

            Rectangle rect = new Rectangle(0, 0, pnlPayV.Width, pnlPayV.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, startColor, endColor, gradientMode))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
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

        private void pnlAdmin_MouseHover(object sender, EventArgs e)
        {
            pnlAdmin.BackColor = Color.Green;
        }

        private void pnlProject_MouseHover(object sender, EventArgs e)
        {
            pnlProject.BackColor = Color.Green;
        }

        private void pnlEquip_MouseHover(object sender, EventArgs e)
        {
            pnlEquip.BackColor = Color.Green;
        }

        private void pnlPay_MouseHover(object sender, EventArgs e)
        {
            pnlPay.BackColor = Color.Green;
        }

        private void pnlReports_MouseHover(object sender, EventArgs e)
        {
            pnlReports.BackColor = Color.Green;
        }

        private void pnlAdmin_MouseLeave(object sender, EventArgs e)
        {
            pnlAdmin.BackColor = Color.LightBlue;
        }

        private void pnlProject_MouseLeave(object sender, EventArgs e)
        {
            pnlProject.BackColor = Color.LightBlue;
        }

        private void pnlEquip_MouseLeave(object sender, EventArgs e)
        {
            pnlEquip.BackColor = Color.LightBlue;
        }

        private void pnlPay_MouseLeave(object sender, EventArgs e)
        {
            pnlPay.BackColor = Color.LightBlue;
        }

        private void pnlReports_MouseLeave(object sender, EventArgs e)
        {
            pnlReports.BackColor = Color.LightBlue;
        }

        private void frmDashPM_Load(object sender, EventArgs e)
        {
            if(lblHolder.Text == "P")
            {
                pnlAdmin.Visible = false;
                btnAddE.Visible = false;
                btnAddEmpP.Visible = false;
                btnAddP.Visible = false;
                btnAddUsr.Visible = false;
                btnAllocateE.Visible = false;
                btnDeleteE.Visible = false; 
                btnDeleteP.Visible = false;
                btnRemoveUsr.Visible = false;
                btnUpdateUsr.Visible = false;
                pnlPay.Visible = false;
                pnlReports.Visible = false;
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
        }

        private void btnAddUsr_Click(object sender, EventArgs e)
        {
            frmAddUsr frmAddUsr = new frmAddUsr();
            frmAddUsr.ShowDialog();
        }

        private void btnRemoveUsr_Click(object sender, EventArgs e)
        {
            frmDelUsr frmDelUsr = new frmDelUsr();
            frmDelUsr.ShowDialog();
        }

        private void btnUpdateUsr_Click(object sender, EventArgs e)
        {
            frmUpUsr frmUpUsr = new frmUpUsr();
            frmUpUsr.ShowDialog();
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            frmProjects frmProjects = new frmProjects();
            frmProjects.ShowDialog();
        }

        private void btnUpdateP_Click(object sender, EventArgs e)
        {
            frmProjUpdate frmProj = new frmProjUpdate();
            frmProj.ShowDialog();
        }

        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            frmDelProj frmDelProj = new frmDelProj();
            frmDelProj.ShowDialog();
        }

        private void btnAddEmpP_Click(object sender, EventArgs e)
        {
            frmAllocateEmps frmAllocateEmps = new frmAllocateEmps();
            frmAllocateEmps.ShowDialog();
        }

        private void btnAddE_Click(object sender, EventArgs e)
        {
            frmAddEquip frmAddEquip = new frmAddEquip();
            frmAddEquip.ShowDialog();
        }

        private void btnUpdateE_Click(object sender, EventArgs e)
        {
            frmUpEquip frmUpEquip = new frmUpEquip();
            frmUpEquip.ShowDialog();
        }

        private void btnAllocateE_Click(object sender, EventArgs e)
        {
            frmProjEquip frmProjEquip = new frmProjEquip();
            frmProjEquip.ShowDialog();
        }

        private void btnDeleteE_Click(object sender, EventArgs e)
        {
            frmDelEquip frmDelEquip = new frmDelEquip();
            frmDelEquip.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            frmPayment frmPayment = new frmPayment();
            frmPayment.ShowDialog();
        }

        private void pnlReports_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlAdminV_Paint(object sender, PaintEventArgs e)
        {
            Color startColor = Color.FromArgb(0, 122, 204); 
            Color endColor = Color.FromArgb(23, 162, 184); 
            LinearGradientMode gradientMode = LinearGradientMode.Vertical;

            Rectangle rect = new Rectangle(0, 0, pnlAdminV.Width, pnlAdminV.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, startColor, endColor, gradientMode))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void pnlProjectV_Paint(object sender, PaintEventArgs e)
        {
            Color startColor = Color.FromArgb(0, 122, 204);
            Color endColor = Color.FromArgb(23, 162, 184);
            LinearGradientMode gradientMode = LinearGradientMode.Vertical;

            Rectangle rect = new Rectangle(0, 0, pnlProjectV.Width, pnlProjectV.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, startColor, endColor, gradientMode))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void pnlEquipV_Paint(object sender, PaintEventArgs e)
        {
            Color startColor = Color.FromArgb(0, 122, 204);
            Color endColor = Color.FromArgb(23, 162, 184);
            LinearGradientMode gradientMode = LinearGradientMode.Vertical;

            Rectangle rect = new Rectangle(0, 0, pnlEquipV.Width, pnlEquipV.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, startColor, endColor, gradientMode))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void btnAddUsr_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnRemoveUsr_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnUpdateUsr_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGreet_Click(object sender, EventArgs e)
        {

        }
    }
}
