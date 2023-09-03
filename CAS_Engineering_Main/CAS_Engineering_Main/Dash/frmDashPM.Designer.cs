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
            this.btnUpdateUsr = new System.Windows.Forms.Button();
            this.btnRemoveUsr = new System.Windows.Forms.Button();
            this.btnAddUsr = new System.Windows.Forms.Button();
            this.pnlProject = new System.Windows.Forms.Panel();
            this.pnlProjectV = new System.Windows.Forms.Panel();
            this.btnAddEmpP = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnUpdateP = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.pnlEquip = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.pnlEquipV = new System.Windows.Forms.Panel();
            this.btnDeleteE = new System.Windows.Forms.Button();
            this.btnAllocateE = new System.Windows.Forms.Button();
            this.btnUpdateE = new System.Windows.Forms.Button();
            this.btnAddE = new System.Windows.Forms.Button();
            this.pnlPay = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlPayV = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblHolder = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(557, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrator Panel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(533, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 16);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(417, 203);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1224, 647);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAdmin.Controls.Add(this.label2);
            this.pnlAdmin.Location = new System.Drawing.Point(4, 4);
            this.pnlAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(1173, 123);
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
            this.pnlAdminV.Location = new System.Drawing.Point(4, 135);
            this.pnlAdminV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAdminV.Name = "pnlAdminV";
            this.pnlAdminV.Size = new System.Drawing.Size(1173, 123);
            this.pnlAdminV.TabIndex = 19;
            this.pnlAdminV.Visible = false;
            // 
            // btnUpdateUsr
            // 
            this.btnUpdateUsr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUsr.Location = new System.Drawing.Point(825, 33);
            this.btnUpdateUsr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateUsr.Name = "btnUpdateUsr";
            this.btnUpdateUsr.Size = new System.Drawing.Size(196, 59);
            this.btnUpdateUsr.TabIndex = 21;
            this.btnUpdateUsr.Text = "Update User";
            this.btnUpdateUsr.UseVisualStyleBackColor = true;
            // 
            // btnRemoveUsr
            // 
            this.btnRemoveUsr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoveUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUsr.Location = new System.Drawing.Point(499, 33);
            this.btnRemoveUsr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveUsr.Name = "btnRemoveUsr";
            this.btnRemoveUsr.Size = new System.Drawing.Size(196, 59);
            this.btnRemoveUsr.TabIndex = 20;
            this.btnRemoveUsr.Text = "Remove User";
            this.btnRemoveUsr.UseVisualStyleBackColor = true;
            // 
            // btnAddUsr
            // 
            this.btnAddUsr.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsr.Location = new System.Drawing.Point(183, 33);
            this.btnAddUsr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddUsr.Name = "btnAddUsr";
            this.btnAddUsr.Size = new System.Drawing.Size(196, 59);
            this.btnAddUsr.TabIndex = 19;
            this.btnAddUsr.Text = "Add User";
            this.btnAddUsr.UseVisualStyleBackColor = true;
            // 
            // pnlProject
            // 
            this.pnlProject.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlProject.Controls.Add(this.label1);
            this.pnlProject.Location = new System.Drawing.Point(4, 266);
            this.pnlProject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlProject.Name = "pnlProject";
            this.pnlProject.Size = new System.Drawing.Size(1173, 123);
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
            this.pnlProjectV.Location = new System.Drawing.Point(4, 397);
            this.pnlProjectV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlProjectV.Name = "pnlProjectV";
            this.pnlProjectV.Size = new System.Drawing.Size(1173, 123);
            this.pnlProjectV.TabIndex = 21;
            this.pnlProjectV.Visible = false;
            // 
            // btnAddEmpP
            // 
            this.btnAddEmpP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddEmpP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmpP.Location = new System.Drawing.Point(871, 37);
            this.btnAddEmpP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmpP.Name = "btnAddEmpP";
            this.btnAddEmpP.Size = new System.Drawing.Size(196, 59);
            this.btnAddEmpP.TabIndex = 23;
            this.btnAddEmpP.Text = "Add Employee to Project";
            this.btnAddEmpP.UseVisualStyleBackColor = true;
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteP.Location = new System.Drawing.Point(619, 37);
            this.btnDeleteP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(196, 59);
            this.btnDeleteP.TabIndex = 22;
            this.btnDeleteP.Text = "Delete Project";
            this.btnDeleteP.UseVisualStyleBackColor = true;
            // 
            // btnUpdateP
            // 
            this.btnUpdateP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateP.Location = new System.Drawing.Point(360, 37);
            this.btnUpdateP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateP.Name = "btnUpdateP";
            this.btnUpdateP.Size = new System.Drawing.Size(196, 59);
            this.btnUpdateP.TabIndex = 21;
            this.btnUpdateP.Text = "Update Project";
            this.btnUpdateP.UseVisualStyleBackColor = true;
            // 
            // btnAddP
            // 
            this.btnAddP.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddP.Location = new System.Drawing.Point(117, 37);
            this.btnAddP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(196, 59);
            this.btnAddP.TabIndex = 20;
            this.btnAddP.Text = "Add Project";
            this.btnAddP.UseVisualStyleBackColor = true;
            // 
            // pnlEquip
            // 
            this.pnlEquip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlEquip.Controls.Add(this.label18);
            this.pnlEquip.Location = new System.Drawing.Point(4, 528);
            this.pnlEquip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEquip.Name = "pnlEquip";
            this.pnlEquip.Size = new System.Drawing.Size(1173, 123);
            this.pnlEquip.TabIndex = 22;
            this.pnlEquip.Click += new System.EventHandler(this.pnlEquip_Click);
            this.pnlEquip.MouseLeave += new System.EventHandler(this.pnlEquip_MouseLeave);
            this.pnlEquip.MouseHover += new System.EventHandler(this.pnlEquip_MouseHover);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(557, 39);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 16);
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
            this.pnlEquipV.Location = new System.Drawing.Point(4, 659);
            this.pnlEquipV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlEquipV.Name = "pnlEquipV";
            this.pnlEquipV.Size = new System.Drawing.Size(1173, 123);
            this.pnlEquipV.TabIndex = 23;
            this.pnlEquipV.Visible = false;
            // 
            // btnDeleteE
            // 
            this.btnDeleteE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteE.Location = new System.Drawing.Point(871, 42);
            this.btnDeleteE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteE.Name = "btnDeleteE";
            this.btnDeleteE.Size = new System.Drawing.Size(196, 59);
            this.btnDeleteE.TabIndex = 23;
            this.btnDeleteE.Text = "Delete Equipment";
            this.btnDeleteE.UseVisualStyleBackColor = true;
            // 
            // btnAllocateE
            // 
            this.btnAllocateE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAllocateE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllocateE.Location = new System.Drawing.Point(619, 42);
            this.btnAllocateE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAllocateE.Name = "btnAllocateE";
            this.btnAllocateE.Size = new System.Drawing.Size(196, 59);
            this.btnAllocateE.TabIndex = 22;
            this.btnAllocateE.Text = "Allocate Equipment";
            this.btnAllocateE.UseVisualStyleBackColor = true;
            // 
            // btnUpdateE
            // 
            this.btnUpdateE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateE.Location = new System.Drawing.Point(360, 42);
            this.btnUpdateE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateE.Name = "btnUpdateE";
            this.btnUpdateE.Size = new System.Drawing.Size(196, 59);
            this.btnUpdateE.TabIndex = 21;
            this.btnUpdateE.Text = "Update Equipment";
            this.btnUpdateE.UseVisualStyleBackColor = true;
            // 
            // btnAddE
            // 
            this.btnAddE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddE.Location = new System.Drawing.Point(117, 42);
            this.btnAddE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddE.Name = "btnAddE";
            this.btnAddE.Size = new System.Drawing.Size(196, 59);
            this.btnAddE.TabIndex = 20;
            this.btnAddE.Text = "Add Equipment";
            this.btnAddE.UseVisualStyleBackColor = true;
            // 
            // pnlPay
            // 
            this.pnlPay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlPay.Controls.Add(this.label19);
            this.pnlPay.Location = new System.Drawing.Point(4, 790);
            this.pnlPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(1173, 123);
            this.pnlPay.TabIndex = 24;
            this.pnlPay.Click += new System.EventHandler(this.pnlPay_Click);
            this.pnlPay.MouseLeave += new System.EventHandler(this.pnlPay_MouseLeave);
            this.pnlPay.MouseHover += new System.EventHandler(this.pnlPay_MouseHover);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(495, 52);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 16);
            this.label19.TabIndex = 18;
            this.label19.Text = "Payment Panel";
            // 
            // pnlPayV
            // 
            this.pnlPayV.BackColor = System.Drawing.SystemColors.Info;
            this.pnlPayV.Controls.Add(this.btnPayment);
            this.pnlPayV.Location = new System.Drawing.Point(4, 921);
            this.pnlPayV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPayV.Name = "pnlPayV";
            this.pnlPayV.Size = new System.Drawing.Size(1173, 123);
            this.pnlPayV.TabIndex = 25;
            this.pnlPayV.Visible = false;
            this.pnlPayV.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Location = new System.Drawing.Point(521, 36);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(196, 59);
            this.btnPayment.TabIndex = 20;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // pnlReports
            // 
            this.pnlReports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlReports.Controls.Add(this.label13);
            this.pnlReports.Location = new System.Drawing.Point(4, 1052);
            this.pnlReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(1173, 123);
            this.pnlReports.TabIndex = 26;
            this.pnlReports.MouseLeave += new System.EventHandler(this.pnlReports_MouseLeave);
            this.pnlReports.MouseHover += new System.EventHandler(this.pnlReports_MouseHover);
            // 
            // lblHolder
            // 
            this.lblHolder.AutoSize = true;
            this.lblHolder.Location = new System.Drawing.Point(16, 11);
            this.lblHolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHolder.Name = "lblHolder";
            this.lblHolder.Size = new System.Drawing.Size(15, 16);
            this.lblHolder.TabIndex = 18;
            this.lblHolder.Text = "[]";
            this.lblHolder.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 64);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 66);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDashPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblHolder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDashPM";
            this.Text = "Project Manager DashBoard";
            this.Load += new System.EventHandler(this.frmDashPM_Load);
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
        public System.Windows.Forms.Label lblHolder;
        private System.Windows.Forms.Button btnClose;
    }
}