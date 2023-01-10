namespace ElrahmaForms.App.Forms
{
    partial class FrmAttend
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
            this.components = new System.ComponentModel.Container();
            this.dgvattend = new System.Windows.Forms.DataGridView();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourcount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcheckin = new System.Windows.Forms.TextBox();
            this.btncheckin = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.btnempreport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvattend)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvattend
            // 
            this.dgvattend.AllowUserToAddRows = false;
            this.dgvattend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvattend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvattend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpName,
            this.checkin,
            this.checkout,
            this.hourcount,
            this.ID,
            this.empid});
            this.dgvattend.GridColor = System.Drawing.SystemColors.Control;
            this.dgvattend.Location = new System.Drawing.Point(269, 100);
            this.dgvattend.Name = "dgvattend";
            this.dgvattend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvattend.RowHeadersWidth = 51;
            this.dgvattend.RowTemplate.Height = 26;
            this.dgvattend.Size = new System.Drawing.Size(1097, 505);
            this.dgvattend.TabIndex = 3;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "أسم الموظف";
            this.EmpName.MinimumWidth = 150;
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            this.EmpName.Width = 200;
            // 
            // checkin
            // 
            this.checkin.DataPropertyName = "checkin";
            this.checkin.HeaderText = "وقت الدخول";
            this.checkin.MinimumWidth = 100;
            this.checkin.Name = "checkin";
            this.checkin.ReadOnly = true;
            this.checkin.Width = 150;
            // 
            // checkout
            // 
            this.checkout.DataPropertyName = "checkout";
            this.checkout.HeaderText = "وقت الخروج";
            this.checkout.MinimumWidth = 100;
            this.checkout.Name = "checkout";
            this.checkout.ReadOnly = true;
            this.checkout.Width = 150;
            // 
            // hourcount
            // 
            this.hourcount.HeaderText = "عدد الساعات";
            this.hourcount.MinimumWidth = 100;
            this.hourcount.Name = "hourcount";
            this.hourcount.ReadOnly = true;
            this.hourcount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hourcount.Width = 130;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "رقم الحركة";
            this.ID.MinimumWidth = 100;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 130;
            // 
            // empid
            // 
            this.empid.DataPropertyName = "empid";
            this.empid.HeaderText = "رقم الموظف";
            this.empid.MinimumWidth = 6;
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            this.empid.Width = 125;
            // 
            // txtcheckin
            // 
            this.txtcheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcheckin.Location = new System.Drawing.Point(1137, 67);
            this.txtcheckin.Name = "txtcheckin";
            this.txtcheckin.Size = new System.Drawing.Size(112, 24);
            this.txtcheckin.TabIndex = 4;
            this.txtcheckin.Tag = "";
            this.txtcheckin.Text = "أدخل رقم الموظف";
            this.txtcheckin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcheckin.Enter += new System.EventHandler(this.txtcheckin_Enter);
            // 
            // btncheckin
            // 
            this.btncheckin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncheckin.Location = new System.Drawing.Point(1254, 61);
            this.btncheckin.Name = "btncheckin";
            this.btncheckin.Size = new System.Drawing.Size(112, 33);
            this.btncheckin.TabIndex = 5;
            this.btncheckin.Text = "تسجيل";
            this.btncheckin.UseVisualStyleBackColor = true;
            this.btncheckin.Click += new System.EventHandler(this.btncheckin_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1214, 669);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 47);
            this.button2.TabIndex = 30;
            this.button2.Text = "تقرير الأطباء";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnempreport
            // 
            this.btnempreport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnempreport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempreport.Location = new System.Drawing.Point(1037, 669);
            this.btnempreport.Name = "btnempreport";
            this.btnempreport.Size = new System.Drawing.Size(152, 47);
            this.btnempreport.TabIndex = 31;
            this.btnempreport.Text = "تقرير الموظفين";
            this.btnempreport.UseVisualStyleBackColor = true;
            this.btnempreport.Click += new System.EventHandler(this.btnempreport_Click);
            // 
            // FrmAttend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1446, 810);
            this.Controls.Add(this.btnempreport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncheckin);
            this.Controls.Add(this.txtcheckin);
            this.Controls.Add(this.dgvattend);
            this.Name = "FrmAttend";
            this.Text = "الحضور و الأنصراف";
            this.Load += new System.EventHandler(this.FrmAttend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvattend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvattend;
        private System.Windows.Forms.TextBox txtcheckin;
        private System.Windows.Forms.Button btncheckin;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourcount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnempreport;
    }
}