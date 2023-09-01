namespace CAS_Engineering_Main.Dash
{
    partial class frmDashPM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pnlAdminV = new System.Windows.Forms.Panel();
            this.pnlProject = new System.Windows.Forms.Panel();
            this.pnlProjectV = new System.Windows.Forms.Panel();
            this.pnlEquip = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlEquipV = new System.Windows.Forms.Panel();
            this.pnlPay = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlPayV = new System.Windows.Forms.Panel();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblHolder = new System.Windows.Forms.Label();
            this.btnAddUsr = new System.Windows.Forms.Button();
            this.btnRemoveUsr = new System.Windows.Forms.Button();
            this.btnUpdateUsr = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.btnUpdateP = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnAddEmpP = new System.Windows.Forms.Button();
            this.btnAddE = new System.Windows.Forms.Button();
            this.btnUpdateE = new System.Windows.Forms.Button();
            this.btnAllocateE = new System.Windows.Forms.Button();
            this.btnDeleteE = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.pnlAdminV.SuspendLayout();
            this.pnlProject.SuspendLayout();
            this.pnlProjectV.SuspendLayout();
            this.pnlEquip.SuspendLayout();
            this.pnlEquipV.SuspendLayout();
            this.pnlPay.SuspendLayout();
            this.pnlPayV.SuspendLayout();
            this.pnlReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrator Panel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(400, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Request Reports";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pnlAdmin);
            this.flowLayoutPanel1.Controls.Add(this.pnlAdminV);
            this.flowLayoutPanel1.Controls.Add(this.pnlProject);
            this.flowLayoutPanel1.Controls.Add(this.pnlProjectV);
            this.flowLayoutPanel1.Controls.Add(this.pnlEquip);
            this.flowLayoutPanel1.Controls.Add(this.pnlEquipV);
            this.flowLayoutPanel1.Controls.Add(this.pnlPay);
            this.flowLayoutPanel1.Controls.Add(this.pnlPayV);
            this.flowLayoutPanel1.Controls.Add(this.pnlReports);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(313, 165);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(918, 526);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAdmin.Controls.Add(this.label2);
            this.pnlAdmin.Location = new System.Drawing.Point(3, 3);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(880, 100);
            this.pnlAdmin.TabIndex = 18;
            this.pnlAdmin.Click += new System.EventHandler(this.panel1_Click);
            this.pnlAdmin.MouseLeave += new System.EventHandler(this.pnlAdmin_MouseLeave);
            this.pnlAdmin.MouseHover += new System.EventHandler(this.pnlAdmin_MouseHover);
            // 
            // pnlAdminV
            // 
            this.pnlAdminV.BackColor = System.Drawing.SystemColors.Info;
            this.pnlAdminV.Controls.Add(this.btnUpdateUsr);
            this.pnlAdminV.Controls.Add(this.btnRemoveUsr);
            this.pnlAdminV.Controls.Add(this.btnAddUsr);
            this.pnlAdminV.Location = new System.Drawing.Point(3, 109);
            this.pnlAdminV.Name = "pnlAdminV";
            this.pnlAdminV.Size = new System.Drawing.Size(880, 100);
            this.pnlAdminV.TabIndex = 19;
            this.pnlAdminV.Visible = false;
            // 
            // pnlProject
            // 
            this.pnlProject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlProject.Controls.Add(this.label1);
            this.pnlProject.Location = new System.Drawing.Point(3, 215);
            this.pnlProject.Name = "pnlProject";
            this.pnlProject.Size = new System.Drawing.Size(880, 100);
            this.pnlProject.TabIndex = 20;
            this.pnlProject.Click += new System.EventHandler(this.pnlProject_Click);
            this.pnlProject.MouseLeave += new System.EventHandler(this.pnlProject_MouseLeave);
            this.pnlProject.MouseHover += new System.EventHandler(this.pnlProject_MouseHover);
            // 
            // pnlProjectV
            // 
            this.pnlProjectV.BackColor = System.Drawing.SystemColors.Info;
            this.pnlProjectV.Controls.Add(this.btnAddEmpP);
            this.pnlProjectV.Controls.Add(this.btnDeleteP);
            this.pnlProjectV.Controls.Add(this.btnUpdateP);
            this.pnlProjectV.Controls.Add(this.btnAddP);
            this.pnlProjectV.Location = new System.Drawing.Point(3, 321);
            this.pnlProjectV.Name = "pnlProjectV";
            this.pnlProjectV.Size = new System.Drawing.Size(880, 100);
            this.pnlProjectV.TabIndex = 21;
            this.pnlProjectV.Visible = false;
            // 
            // pnlEquip
            // 
            this.pnlEquip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEquip.Controls.Add(this.label18);
            this.pnlEquip.Location = new System.Drawing.Point(3, 427);
            this.pnlEquip.Name = "pnlEquip";
            this.pnlEquip.Size = new System.Drawing.Size(880, 100);
            this.pnlEquip.TabIndex = 22;
            this.pnlEquip.Click += new System.EventHandler(this.pnlEquip_Click);
            this.pnlEquip.MouseLeave += new System.EventHandler(this.pnlEquip_MouseLeave);
            this.pnlEquip.MouseHover += new System.EventHandler(this.pnlEquip_MouseHover);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(418, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Equipment Panel";
            // 
            // pnlEquipV
            // 
            this.pnlEquipV.BackColor = System.Drawing.SystemColors.Info;
            this.pnlEquipV.Controls.Add(this.btnDeleteE);
            this.pnlEquipV.Controls.Add(this.btnAllocateE);
            this.pnlEquipV.Controls.Add(this.btnUpdateE);
            this.pnlEquipV.Controls.Add(this.btnAddE);
            this.pnlEquipV.Location = new System.Drawing.Point(3, 533);
            this.pnlEquipV.Name = "pnlEquipV";
            this.pnlEquipV.Size = new System.Drawing.Size(880, 100);
            this.pnlEquipV.TabIndex = 23;
            this.pnlEquipV.Visible = false;
            // 
            // pnlPay
            // 
            this.pnlPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPay.Controls.Add(this.label19);
            this.pnlPay.Location = new System.Drawing.Point(3, 639);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(880, 100);
            this.pnlPay.TabIndex = 24;
            this.pnlPay.Click += new System.EventHandler(this.pnlPay_Click);
            this.pnlPay.MouseLeave += new System.EventHandler(this.pnlPay_MouseLeave);
            this.pnlPay.MouseHover += new System.EventHandler(this.pnlPay_MouseHover);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(371, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Payment Panel";
            // 
            // pnlPayV
            // 
            this.pnlPayV.BackColor = System.Drawing.SystemColors.Info;
            this.pnlPayV.Controls.Add(this.btnPayment);
            this.pnlPayV.Location = new System.Drawing.Point(3, 745);
            this.pnlPayV.Name = "pnlPayV";
            this.pnlPayV.Size = new System.Drawing.Size(880, 100);
            this.pnlPayV.TabIndex = 25;
            this.pnlPayV.Visible = false;
            this.pnlPayV.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // pnlReports
            // 
            this.pnlReports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlReports.Controls.Add(this.label13);
            this.pnlReports.Location = new System.Drawing.Point(3, 851);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(880, 100);
            this.pnlReports.TabIndex = 26;
            this.pnlReports.MouseLeave += new System.EventHandler(this.pnlReports_MouseLeave);
            this.pnlReports.MouseHover += new System.EventHandler(this.pnlReports_MouseHover);
            // 
            // lblHolder
            // 
            this.lblHolder.AutoSize = true;
            this.lblHolder.Location = new System.Drawing.Point(12, 9);
            this.lblHolder.Name = "lblHolder";
            this.lblHolder.Size = new System.Drawing.Size(13, 13);
            this.lblHolder.TabIndex = 18;
            this.lblHolder.Text = "[]";
            this.lblHolder.Visible = false;
            // 
            // btnAddUsr
            // 
            this.btnAddUsr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsr.Location = new System.Drawing.Point(137, 27);
            this.btnAddUsr.Name = "btnAddUsr";
            this.btnAddUsr.Size = new System.Drawing.Size(147, 48);
            this.btnAddUsr.TabIndex = 19;
            this.btnAddUsr.Text = "Add User";
            this.btnAddUsr.UseVisualStyleBackColor = true;
            // 
            // btnRemoveUsr
            // 
            this.btnRemoveUsr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoveUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUsr.Location = new System.Drawing.Point(374, 27);
            this.btnRemoveUsr.Name = "btnRemoveUsr";
            this.btnRemoveUsr.Size = new System.Drawing.Size(147, 48);
            this.btnRemoveUsr.TabIndex = 20;
            this.btnRemoveUsr.Text = "Remove User";
            this.btnRemoveUsr.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUsr
            // 
            this.btnUpdateUsr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUsr.Location = new System.Drawing.Point(619, 27);
            this.btnUpdateUsr.Name = "btnUpdateUsr";
            this.btnUpdateUsr.Size = new System.Drawing.Size(147, 48);
            this.btnUpdateUsr.TabIndex = 21;
            this.btnUpdateUsr.Text = "Update User";
            this.btnUpdateUsr.UseVisualStyleBackColor = true;
            // 
            // btnAddP
            // 
            this.btnAddP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddP.Location = new System.Drawing.Point(88, 30);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(147, 48);
            this.btnAddP.TabIndex = 20;
            this.btnAddP.Text = "Add Project";
            this.btnAddP.UseVisualStyleBackColor = true;
            // 
            // btnUpdateP
            // 
            this.btnUpdateP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateP.Location = new System.Drawing.Point(270, 30);
            this.btnUpdateP.Name = "btnUpdateP";
            this.btnUpdateP.Size = new System.Drawing.Size(147, 48);
            this.btnUpdateP.TabIndex = 21;
            this.btnUpdateP.Text = "Update Project";
            this.btnUpdateP.UseVisualStyleBackColor = true;
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteP.Location = new System.Drawing.Point(464, 30);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(147, 48);
            this.btnDeleteP.TabIndex = 22;
            this.btnDeleteP.Text = "Delete Project";
            this.btnDeleteP.UseVisualStyleBackColor = true;
            // 
            // btnAddEmpP
            // 
            this.btnAddEmpP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddEmpP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmpP.Location = new System.Drawing.Point(653, 30);
            this.btnAddEmpP.Name = "btnAddEmpP";
            this.btnAddEmpP.Size = new System.Drawing.Size(147, 48);
            this.btnAddEmpP.TabIndex = 23;
            this.btnAddEmpP.Text = "Add Employee to Project";
            this.btnAddEmpP.UseVisualStyleBackColor = true;
            // 
            // btnAddE
            // 
            this.btnAddE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddE.Location = new System.Drawing.Point(88, 34);
            this.btnAddE.Name = "btnAddE";
            this.btnAddE.Size = new System.Drawing.Size(147, 48);
            this.btnAddE.TabIndex = 20;
            this.btnAddE.Text = "Add Equipment";
            this.btnAddE.UseVisualStyleBackColor = true;
            // 
            // btnUpdateE
            // 
            this.btnUpdateE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateE.Location = new System.Drawing.Point(270, 34);
            this.btnUpdateE.Name = "btnUpdateE";
            this.btnUpdateE.Size = new System.Drawing.Size(147, 48);
            this.btnUpdateE.TabIndex = 21;
            this.btnUpdateE.Text = "Update Equipment";
            this.btnUpdateE.UseVisualStyleBackColor = true;
            // 
            // btnAllocateE
            // 
            this.btnAllocateE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAllocateE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllocateE.Location = new System.Drawing.Point(464, 34);
            this.btnAllocateE.Name = "btnAllocateE";
            this.btnAllocateE.Size = new System.Drawing.Size(147, 48);
            this.btnAllocateE.TabIndex = 22;
            this.btnAllocateE.Text = "Allocate Equipment";
            this.btnAllocateE.UseVisualStyleBackColor = true;
            // 
            // btnDeleteE
            // 
            this.btnDeleteE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteE.Location = new System.Drawing.Point(653, 34);
            this.btnDeleteE.Name = "btnDeleteE";
            this.btnDeleteE.Size = new System.Drawing.Size(147, 48);
            this.btnDeleteE.TabIndex = 23;
            this.btnDeleteE.Text = "Delete Equipment";
            this.btnDeleteE.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Location = new System.Drawing.Point(391, 29);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(147, 48);
            this.btnPayment.TabIndex = 20;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // frmDashPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 888);
            this.Controls.Add(this.lblHolder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmDashPM";
            this.Text = "Project Manager DashBoard";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.pnlAdminV.ResumeLayout(false);
            this.pnlProject.ResumeLayout(false);
            this.pnlProject.PerformLayout();
            this.pnlProjectV.ResumeLayout(false);
            this.pnlEquip.ResumeLayout(false);
            this.pnlEquip.PerformLayout();
            this.pnlEquipV.ResumeLayout(false);
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            this.pnlPayV.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.pnlReports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel pnlAdminV;
        private System.Windows.Forms.Panel pnlProject;
        private System.Windows.Forms.Panel pnlProjectV;
        private System.Windows.Forms.Panel pnlEquip;
        private System.Windows.Forms.Panel pnlEquipV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlPay;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Panel pnlPayV;
        private System.Windows.Forms.Label lblHolder;
        private System.Windows.Forms.Button btnUpdateUsr;
        private System.Windows.Forms.Button btnRemoveUsr;
        private System.Windows.Forms.Button btnAddUsr;
        private System.Windows.Forms.Button btnAddEmpP;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.Button btnUpdateP;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Button btnDeleteE;
        private System.Windows.Forms.Button btnAllocateE;
        private System.Windows.Forms.Button btnUpdateE;
        private System.Windows.Forms.Button btnAddE;
        private System.Windows.Forms.Button btnPayment;
    }
}