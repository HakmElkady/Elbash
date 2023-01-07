namespace ElrahmaForms.App.Forms
{
    partial class FrmAttendReport
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
            this.dgvattendperuser = new System.Windows.Forms.DataGridView();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logged_Mins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DategroupBox = new System.Windows.Forms.GroupBox();
            this.cbxEmpName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvattendperuser)).BeginInit();
            this.DategroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvattendperuser
            // 
            this.dgvattendperuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvattendperuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpId,
            this.EmpName,
            this.ID,
            this.checkin,
            this.checkout,
            this.logged_Mins,
            this.HourPrice,
            this.total});
            this.dgvattendperuser.Location = new System.Drawing.Point(188, 183);
            this.dgvattendperuser.Name = "dgvattendperuser";
            this.dgvattendperuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvattendperuser.RowHeadersWidth = 51;
            this.dgvattendperuser.RowTemplate.Height = 26;
            this.dgvattendperuser.Size = new System.Drawing.Size(1328, 617);
            this.dgvattendperuser.TabIndex = 0;
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "الرقم";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.Width = 70;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "الأسم";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.Width = 195;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "رقم الحركة";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 110;
            // 
            // checkin
            // 
            this.checkin.DataPropertyName = "checkin";
            this.checkin.HeaderText = "تاريخ الدخول";
            this.checkin.MinimumWidth = 6;
            this.checkin.Name = "checkin";
            this.checkin.Width = 150;
            // 
            // checkout
            // 
            this.checkout.DataPropertyName = "checkout";
            this.checkout.HeaderText = "تاريخ الخروج";
            this.checkout.MinimumWidth = 6;
            this.checkout.Name = "checkout";
            this.checkout.Width = 150;
            // 
            // logged_Mins
            // 
            this.logged_Mins.DataPropertyName = "logged_Mins";
            this.logged_Mins.HeaderText = "عدد الساعات";
            this.logged_Mins.MinimumWidth = 6;
            this.logged_Mins.Name = "logged_Mins";
            this.logged_Mins.Width = 125;
            // 
            // HourPrice
            // 
            this.HourPrice.DataPropertyName = "HourPrice";
            this.HourPrice.HeaderText = "سعر الساعة";
            this.HourPrice.MinimumWidth = 6;
            this.HourPrice.Name = "HourPrice";
            this.HourPrice.Width = 125;
            // 
            // total
            // 
            this.total.DataPropertyName = "Total";
            this.total.HeaderText = "الأجمالي";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 160;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 24);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(36, 73);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(222, 24);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "من";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "الي";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DategroupBox
            // 
            this.DategroupBox.Controls.Add(this.dateTimePicker1);
            this.DategroupBox.Controls.Add(this.dateTimePicker2);
            this.DategroupBox.Controls.Add(this.label2);
            this.DategroupBox.Controls.Add(this.label1);
            this.DategroupBox.Location = new System.Drawing.Point(1179, 55);
            this.DategroupBox.Name = "DategroupBox";
            this.DategroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DategroupBox.Size = new System.Drawing.Size(336, 113);
            this.DategroupBox.TabIndex = 6;
            this.DategroupBox.TabStop = false;
            this.DategroupBox.Text = "الفترة ";
            // 
            // cbxEmpName
            // 
            this.cbxEmpName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEmpName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEmpName.FormattingEnabled = true;
            this.cbxEmpName.Location = new System.Drawing.Point(27, 73);
            this.cbxEmpName.Name = "cbxEmpName";
            this.cbxEmpName.Size = new System.Drawing.Size(287, 24);
            this.cbxEmpName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "الأسم : -";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxEmpName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(767, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(336, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أختر الموظف";
            // 
            // FrmAttendReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1558, 766);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DategroupBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvattendperuser);
            this.Name = "FrmAttendReport";
            this.Text = "FrmAttendReport";
            this.Load += new System.EventHandler(this.FrmAttendReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvattendperuser)).EndInit();
            this.DategroupBox.ResumeLayout(false);
            this.DategroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvattendperuser;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox DategroupBox;
        private System.Windows.Forms.ComboBox cbxEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn logged_Mins;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}