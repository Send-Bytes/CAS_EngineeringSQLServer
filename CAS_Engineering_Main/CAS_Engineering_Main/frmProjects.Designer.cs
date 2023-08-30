namespace CAS_Engineering_Main
{
    partial class frmProjects
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblDisplayStartDate = new System.Windows.Forms.Label();
            this.lblDisplayEndDate = new System.Windows.Forms.Label();
            this.txtPDescrip = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPStatus = new System.Windows.Forms.TextBox();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date and Completion Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(51, 169);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // lblDisplayStartDate
            // 
            this.lblDisplayStartDate.AutoSize = true;
            this.lblDisplayStartDate.Location = new System.Drawing.Point(307, 201);
            this.lblDisplayStartDate.Name = "lblDisplayStartDate";
            this.lblDisplayStartDate.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayStartDate.TabIndex = 7;
            this.lblDisplayStartDate.Text = "label7";
            // 
            // lblDisplayEndDate
            // 
            this.lblDisplayEndDate.AutoSize = true;
            this.lblDisplayEndDate.Location = new System.Drawing.Point(310, 245);
            this.lblDisplayEndDate.Name = "lblDisplayEndDate";
            this.lblDisplayEndDate.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayEndDate.TabIndex = 8;
            this.lblDisplayEndDate.Text = "label8";
            // 
            // txtPDescrip
            // 
            this.txtPDescrip.Location = new System.Drawing.Point(133, 75);
            this.txtPDescrip.Name = "txtPDescrip";
            this.txtPDescrip.Size = new System.Drawing.Size(129, 20);
            this.txtPDescrip.TabIndex = 9;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(606, 33);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 10;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(606, 92);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 11;
            // 
            // txtPStatus
            // 
            this.txtPStatus.Location = new System.Drawing.Point(606, 161);
            this.txtPStatus.Name = "txtPStatus";
            this.txtPStatus.Size = new System.Drawing.Size(100, 20);
            this.txtPStatus.TabIndex = 12;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(121, 13);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(121, 21);
            this.cmbClient.TabIndex = 13;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(580, 307);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(75, 23);
            this.btnAddProject.TabIndex = 14;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            // 
            // frmProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.txtPStatus);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtPDescrip);
            this.Controls.Add(this.lblDisplayEndDate);
            this.Controls.Add(this.lblDisplayStartDate);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProjects";
            this.Text = "Add Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblDisplayStartDate;
        private System.Windows.Forms.Label lblDisplayEndDate;
        private System.Windows.Forms.TextBox txtPDescrip;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPStatus;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Button btnAddProject;
    }
}