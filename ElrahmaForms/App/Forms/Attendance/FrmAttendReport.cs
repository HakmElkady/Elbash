using ElrahmaForms.App.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElrahmaForms.App.Forms
{
    public partial class FrmAttendReport : Form
    {
        ClsAttendReport clsAttendReport = new ClsAttendReport();
        public FrmAttendReport()
        {
            InitializeComponent();
            
        }

        private void FrmAttendReport_Load(object sender, EventArgs e)
        {
            clsAttendReport.Get();
            dgvattendperuser.DataSource = clsAttendReport.Dt_Get;
            cbxEmpName.DataSource = clsAttendReport.Dt_Get;
            cbxEmpName.ValueMember = "EmpId";
            cbxEmpName.DisplayMember = "EmpName";

        }



        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
          //  lblheader.ForeColor = ThemeColor.PrimaryColor;
        }






    }
}
