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
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvattend)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "الحضور و الأنصراف";
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
            this.dgvattend.Location = new System.Drawing.Point(272, 166);
            this.dgvattend.Name = "dgvattend";
            this.dgvattend.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvattend.RowHeadersWidth = 51;
            this.dgvattend.RowTemplate.Height = 26;
            this.dgvattend.Size = new System.Drawing.Size(1096, 492);
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
            this.txtcheckin.Location = new System.Drawing.Point(1106, 698);
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
            this.btncheckin.Location = new System.Drawing.Point(1256, 695);
            this.btncheckin.Name = "btncheckin";
            this.btncheckin.Size = new System.Drawing.Size(112, 28);
            this.btncheckin.TabIndex = 5;
            this.btncheckin.Text = "تسجيل";
            this.btncheckin.UseVisualStyleBackColor = true;
            this.btncheckin.Click += new System.EventHandler(this.btncheckin_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmAttend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1448, 766);
            this.Controls.Add(this.btncheckin);
            this.Controls.Add(this.txtcheckin);
            this.Controls.Add(this.dgvattend);
            this.Controls.Add(this.label1);
            this.Name = "FrmAttend";
            this.Text = "الحضور و الأنصراف";
            this.Load += new System.EventHandler(this.FrmAttend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvattend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}