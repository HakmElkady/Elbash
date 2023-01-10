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
            this.deptname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bouns = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advance_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HourPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btngo = new System.Windows.Forms.Button();
            this.DategroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbxEmpName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcurrentMounth = new System.Windows.Forms.Label();
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
            this.deptname,
            this.bouns,
            this.advance_salary,
            this.internet,
            this.salary_discount,
            this.totalhours,
            this.HourPrice,
            this.total});
            this.dgvattendperuser.Location = new System.Drawing.Point(188, 183);
            this.dgvattendperuser.Name = "dgvattendperuser";
            this.dgvattendperuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvattendperuser.RowHeadersWidth = 51;
            this.dgvattendperuser.RowTemplate.Height = 26;
            this.dgvattendperuser.Size = new System.Drawing.Size(1328, 617);
            this.dgvattendperuser.TabIndex = 0;
            this.dgvattendperuser.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvattendperuser_CellBeginEdit);
            this.dgvattendperuser.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvattendperuser_CellEndEdit);
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "الرقم";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            this.EmpId.Width = 65;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "الأسم";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            this.EmpName.Width = 195;
            // 
            // deptname
            // 
            this.deptname.DataPropertyName = "deptname";
            this.deptname.HeaderText = "الفسم";
            this.deptname.MinimumWidth = 6;
            this.deptname.Name = "deptname";
            this.deptname.ReadOnly = true;
            this.deptname.Width = 80;
            // 
            // bouns
            // 
            this.bouns.DataPropertyName = "bouns";
            this.bouns.HeaderText = " مكافأة";
            this.bouns.MinimumWidth = 6;
            this.bouns.Name = "bouns";
            this.bouns.Width = 75;
            // 
            // advance_salary
            // 
            this.advance_salary.DataPropertyName = "advance_salary";
            this.advance_salary.HeaderText = "السلف";
            this.advance_salary.MinimumWidth = 6;
            this.advance_salary.Name = "advance_salary";
            this.advance_salary.Width = 75;
            // 
            // internet
            // 
            this.internet.DataPropertyName = "internet";
            this.internet.HeaderText = "إنترنت";
            this.internet.MinimumWidth = 6;
            this.internet.Name = "internet";
            this.internet.Width = 75;
            // 
            // salary_discount
            // 
            this.salary_discount.DataPropertyName = "salary_discount";
            this.salary_discount.HeaderText = "خصم";
            this.salary_discount.MinimumWidth = 6;
            this.salary_discount.Name = "salary_discount";
            this.salary_discount.Width = 75;
            // 
            // totalhours
            // 
            this.totalhours.DataPropertyName = "totalhours";
            this.totalhours.HeaderText = "عدد الساعات";
            this.totalhours.MinimumWidth = 6;
            this.totalhours.Name = "totalhours";
            this.totalhours.ReadOnly = true;
            this.totalhours.Width = 125;
            // 
            // HourPrice
            // 
            this.HourPrice.DataPropertyName = "HourPrice";
            this.HourPrice.HeaderText = "سعر الساعة";
            this.HourPrice.MinimumWidth = 6;
            this.HourPrice.Name = "HourPrice";
            this.HourPrice.ReadOnly = true;
            this.HourPrice.Width = 125;
            // 
            // total
            // 
            this.total.DataPropertyName = "TotalSalary";
            this.total.HeaderText = "الأجمالي";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "الشهر";
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(27, 23);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(85, 40);
            this.btngo.TabIndex = 5;
            this.btngo.Text = "Go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // DategroupBox
            // 
            this.DategroupBox.Controls.Add(this.comboBox1);
            this.DategroupBox.Controls.Add(this.label2);
            this.DategroupBox.Location = new System.Drawing.Point(838, 95);
            this.DategroupBox.Name = "DategroupBox";
            this.DategroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DategroupBox.Size = new System.Drawing.Size(336, 73);
            this.DategroupBox.TabIndex = 6;
            this.DategroupBox.TabStop = false;
            this.DategroupBox.Text = "الفترة ";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 24);
            this.comboBox1.TabIndex = 9;
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
            this.label3.Location = new System.Drawing.Point(255, 46);
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
            this.groupBox1.Controls.Add(this.btngo);
            this.groupBox1.Location = new System.Drawing.Point(1180, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(336, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أختر الموظف";
            // 
            // lblcurrentMounth
            // 
            this.lblcurrentMounth.AutoSize = true;
            this.lblcurrentMounth.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrentMounth.Location = new System.Drawing.Point(184, 56);
            this.lblcurrentMounth.Name = "lblcurrentMounth";
            this.lblcurrentMounth.Size = new System.Drawing.Size(54, 21);
            this.lblcurrentMounth.TabIndex = 16;
            this.lblcurrentMounth.Text = "label4";
            // 
            // FrmAttendReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1558, 766);
            this.Controls.Add(this.lblcurrentMounth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DategroupBox);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvattendperuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.GroupBox DategroupBox;
        private System.Windows.Forms.ComboBox cbxEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblcurrentMounth;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bouns;
        private System.Windows.Forms.DataGridViewTextBoxColumn advance_salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn internet;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhours;
        private System.Windows.Forms.DataGridViewTextBoxColumn HourPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}