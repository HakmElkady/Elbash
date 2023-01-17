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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAttendReport));
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
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.cbxEmpName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBegain = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvattendperuser)).BeginInit();
            this.DategroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvattendperuser
            // 
            this.dgvattendperuser.AllowUserToAddRows = false;
            this.dgvattendperuser.AllowUserToDeleteRows = false;
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
            this.dgvattendperuser.Location = new System.Drawing.Point(268, 183);
            this.dgvattendperuser.Name = "dgvattendperuser";
            this.dgvattendperuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvattendperuser.RowHeadersWidth = 51;
            this.dgvattendperuser.RowTemplate.Height = 26;
            this.dgvattendperuser.Size = new System.Drawing.Size(1248, 617);
            this.dgvattendperuser.TabIndex = 0;
            this.dgvattendperuser.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvattendperuser_CellBeginEdit);
            this.dgvattendperuser.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvattendperuser_CellEndEdit);
            this.dgvattendperuser.Click += new System.EventHandler(this.dgvattendperuser_Click);
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
            this.DategroupBox.Controls.Add(this.cbxMonth);
            this.DategroupBox.Controls.Add(this.label2);
            this.DategroupBox.Location = new System.Drawing.Point(838, 95);
            this.DategroupBox.Name = "DategroupBox";
            this.DategroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DategroupBox.Size = new System.Drawing.Size(336, 73);
            this.DategroupBox.TabIndex = 6;
            this.DategroupBox.TabStop = false;
            this.DategroupBox.Text = "الفترة ";
            // 
            // cbxMonth
            // 
            this.cbxMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Location = new System.Drawing.Point(25, 33);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(249, 24);
            this.cbxMonth.TabIndex = 8;
            this.cbxMonth.SelectedValueChanged += new System.EventHandler(this.cbxMonth_SelectedValueChanged);
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
            // btnBegain
            // 
            this.btnBegain.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegain.Location = new System.Drawing.Point(427, 138);
            this.btnBegain.Name = "btnBegain";
            this.btnBegain.Size = new System.Drawing.Size(105, 40);
            this.btnBegain.TabIndex = 8;
            this.btnBegain.Text = "إبدأ شهر جديد";
            this.btnBegain.UseVisualStyleBackColor = true;
            this.btnBegain.Click += new System.EventHandler(this.btnBegain_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "شهر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "السنة";
            // 
            // txtmonth
            // 
            this.txtmonth.Location = new System.Drawing.Point(14, 49);
            this.txtmonth.MaxLength = 2;
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.Size = new System.Drawing.Size(21, 24);
            this.txtmonth.TabIndex = 21;
            this.txtmonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyear_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "-";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(60, 48);
            this.txtyear.MaxLength = 4;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(65, 24);
            this.txtyear.TabIndex = 19;
            this.txtyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtyear_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtyear);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtmonth);
            this.groupBox2.Location = new System.Drawing.Point(268, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(153, 83);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "إختر الشهر";
            // 
            // FrmAttendReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1558, 766);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBegain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DategroupBox);
            this.Controls.Add(this.dgvattendperuser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAttendReport";
            this.Text = "FrmAttendReport";
            this.Load += new System.EventHandler(this.FrmAttendReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvattendperuser)).EndInit();
            this.DategroupBox.ResumeLayout(false);
            this.DategroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvattendperuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.GroupBox DategroupBox;
        private System.Windows.Forms.ComboBox cbxEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.Button btnBegain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}