namespace Epass_System
{
    partial class WelcomeUser_Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCityFrom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboToCity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDistrictFrom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboToDistrict = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboNoOfPassangers = new System.Windows.Forms.ComboBox();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.txtDrivingLicance = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAdhar = new System.Windows.Forms.TextBox();
            this.btnGetDetails = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(974, 139);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Journey date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 326);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "City From";
            // 
            // comboCityFrom
            // 
            this.comboCityFrom.FormattingEnabled = true;
            this.comboCityFrom.Items.AddRange(new object[] {
            "Pune",
            "Mumbai",
            "Ahmednagar",
            "Nashik",
            "Jalgaon",
            "Jalna",
            "Satara"});
            this.comboCityFrom.Location = new System.Drawing.Point(137, 382);
            this.comboCityFrom.Name = "comboCityFrom";
            this.comboCityFrom.Size = new System.Drawing.Size(183, 24);
            this.comboCityFrom.TabIndex = 4;
            this.comboCityFrom.SelectedIndexChanged += new System.EventHandler(this.comboCityFrom_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "To City";
            // 
            // comboToCity
            // 
            this.comboToCity.FormattingEnabled = true;
            this.comboToCity.Items.AddRange(new object[] {
            "Ahmednagar",
            "Pune",
            "Satara",
            "Jalna",
            "Jalgaon",
            "Mumbai",
            "Aurangabad"});
            this.comboToCity.Location = new System.Drawing.Point(454, 382);
            this.comboToCity.Name = "comboToCity";
            this.comboToCity.Size = new System.Drawing.Size(209, 24);
            this.comboToCity.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "District From";
            // 
            // comboDistrictFrom
            // 
            this.comboDistrictFrom.FormattingEnabled = true;
            this.comboDistrictFrom.Items.AddRange(new object[] {
            "Aurangabad",
            "Pune",
            "Ahmednagar",
            "Satara",
            "Nashik"});
            this.comboDistrictFrom.Location = new System.Drawing.Point(138, 448);
            this.comboDistrictFrom.Name = "comboDistrictFrom";
            this.comboDistrictFrom.Size = new System.Drawing.Size(182, 24);
            this.comboDistrictFrom.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "To District";
            // 
            // comboToDistrict
            // 
            this.comboToDistrict.FormattingEnabled = true;
            this.comboToDistrict.Items.AddRange(new object[] {
            "Ahmednagar",
            "Jalna",
            "Satara",
            "Aurangabad",
            "Pune"});
            this.comboToDistrict.Location = new System.Drawing.Point(454, 445);
            this.comboToDistrict.Name = "comboToDistrict";
            this.comboToDistrict.Size = new System.Drawing.Size(209, 24);
            this.comboToDistrict.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of Passangers?";
            // 
            // comboNoOfPassangers
            // 
            this.comboNoOfPassangers.FormattingEnabled = true;
            this.comboNoOfPassangers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboNoOfPassangers.Location = new System.Drawing.Point(870, 382);
            this.comboNoOfPassangers.Name = "comboNoOfPassangers";
            this.comboNoOfPassangers.Size = new System.Drawing.Size(121, 24);
            this.comboNoOfPassangers.TabIndex = 12;
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.Location = new System.Drawing.Point(138, 517);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(182, 22);
            this.txtVehicleNumber.TabIndex = 13;
            // 
            // txtDrivingLicance
            // 
            this.txtDrivingLicance.Location = new System.Drawing.Point(454, 517);
            this.txtDrivingLicance.Name = "txtDrivingLicance";
            this.txtDrivingLicance.Size = new System.Drawing.Size(209, 22);
            this.txtDrivingLicance.TabIndex = 14;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(832, 517);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(159, 22);
            this.txtModel.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vehical Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Driving Licence";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(716, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vehicle Model ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(451, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Addhar";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(253, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(145, 22);
            this.txtName.TabIndex = 21;
            // 
            // txtAdhar
            // 
            this.txtAdhar.Location = new System.Drawing.Point(518, 69);
            this.txtAdhar.Name = "txtAdhar";
            this.txtAdhar.Size = new System.Drawing.Size(145, 22);
            this.txtAdhar.TabIndex = 21;
            // 
            // btnGetDetails
            // 
            this.btnGetDetails.Location = new System.Drawing.Point(726, 64);
            this.btnGetDetails.Name = "btnGetDetails";
            this.btnGetDetails.Size = new System.Drawing.Size(103, 32);
            this.btnGetDetails.TabIndex = 22;
            this.btnGetDetails.Text = "Get Details";
            this.btnGetDetails.UseVisualStyleBackColor = true;
            this.btnGetDetails.Click += new System.EventHandler(this.btnGetDetails_Click_1);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(439, 593);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(104, 33);
            this.btnApply.TabIndex = 23;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtRegNo
            // 
            this.txtRegNo.Enabled = false;
            this.txtRegNo.Location = new System.Drawing.Point(465, 298);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(183, 22);
            this.txtRegNo.TabIndex = 24;
            // 
            // WelcomeUser_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 688);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnGetDetails);
            this.Controls.Add(this.txtAdhar);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtDrivingLicance);
            this.Controls.Add(this.txtVehicleNumber);
            this.Controls.Add(this.comboNoOfPassangers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboToDistrict);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboDistrictFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboToCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboCityFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WelcomeUser_Form";
            this.Text = "Welcome User";
            this.Load += new System.EventHandler(this.WelcomeUser_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCityFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboToCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboDistrictFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboToDistrict;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboNoOfPassangers;
        private System.Windows.Forms.TextBox txtVehicleNumber;
        private System.Windows.Forms.TextBox txtDrivingLicance;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAdhar;
        private System.Windows.Forms.Button btnGetDetails;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtRegNo;
    }
}