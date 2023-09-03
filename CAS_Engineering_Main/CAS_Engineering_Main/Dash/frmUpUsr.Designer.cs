namespace CAS_Engineering_Main.Dash
{
    partial class frmUpUsr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpUsr));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUPUsr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbUpUsr = new System.Windows.Forms.GroupBox();
            this.txtUPass = new System.Windows.Forms.TextBox();
            this.cboR = new System.Windows.Forms.ComboBox();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbUpUsr.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1072, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblH.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(56, 46);
            this.lblH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(183, 32);
            this.lblH.TabIndex = 1;
            this.lblH.Text = "Update User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // btnUPUsr
            // 
            this.btnUPUsr.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUPUsr.Font = new System.Drawing.Font("Goudy Old Style", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPUsr.Location = new System.Drawing.Point(277, 477);
            this.btnUPUsr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUPUsr.Name = "btnUPUsr";
            this.btnUPUsr.Size = new System.Drawing.Size(169, 51);
            this.btnUPUsr.TabIndex = 4;
            this.btnUPUsr.Text = "Update User";
            this.btnUPUsr.UseVisualStyleBackColor = false;
            this.btnUPUsr.Click += new System.EventHandler(this.btnUPUsr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(688, 185);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "User ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 95);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 44);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(63, 306);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(383, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter By:";
            // 
            // gbUpUsr
            // 
            this.gbUpUsr.Controls.Add(this.txtUPass);
            this.gbUpUsr.Controls.Add(this.cboR);
            this.gbUpUsr.Controls.Add(this.txtUID);
            this.gbUpUsr.Controls.Add(this.label5);
            this.gbUpUsr.Controls.Add(this.label2);
            this.gbUpUsr.Controls.Add(this.label1);
            this.gbUpUsr.Location = new System.Drawing.Point(543, 306);
            this.gbUpUsr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUpUsr.Name = "gbUpUsr";
            this.gbUpUsr.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbUpUsr.Size = new System.Drawing.Size(491, 206);
            this.gbUpUsr.TabIndex = 10;
            this.gbUpUsr.TabStop = false;
            this.gbUpUsr.Text = "Update User";
            // 
            // txtUPass
            // 
            this.txtUPass.Location = new System.Drawing.Point(143, 127);
            this.txtUPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUPass.Name = "txtUPass";
            this.txtUPass.Size = new System.Drawing.Size(177, 22);
            this.txtUPass.TabIndex = 5;
            // 
            // cboR
            // 
            this.cboR.FormattingEnabled = true;
            this.cboR.Location = new System.Drawing.Point(143, 84);
            this.cboR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboR.Name = "cboR";
            this.cboR.Size = new System.Drawing.Size(160, 24);
            this.cboR.TabIndex = 4;
            // 
            // txtUID
            // 
            this.txtUID.Location = new System.Drawing.Point(143, 31);
            this.txtUID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(177, 22);
            this.txtUID.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rank:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // frmUpUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gbUpUsr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUPUsr);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUpUsr";
            this.Text = "Update User";
            this.Load += new System.EventHandler(this.frmUpUsr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUpUsr.ResumeLayout(false);
            this.gbUpUsr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUPUsr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbUpUsr;
        private System.Windows.Forms.TextBox txtUPass;
        private System.Windows.Forms.ComboBox cboR;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}