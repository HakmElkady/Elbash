using ElrahmaForms.App.Classes;
using ElrahmaForms.App.Forms;

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
    public partial class Details : Form
    {
        
        ClsEmpDetails xclsemp = new ClsEmpDetails();
        public Details()
        {
            
            InitializeComponent();
            LoadTheme();
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
            lblheader.ForeColor = ThemeColor.PrimaryColor;
        }
        private void Details_Load(object sender, EventArgs e)
        {
            if (xclsemp.XclsDb.Check() == true)
            {
                xclsemp.Get();
                CbxSearch.DataSource = xclsemp.Dt_Get;
                CbxSearch.ValueMember = "EmpId";
                CbxSearch.DisplayMember= "EmpName";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView xdv = new DataView(xclsemp.Dt_Get);
            xdv.RowFilter = "EmpId = " + CbxSearch.SelectedValue;
            txtnum.Text = xdv[0]["empid"].ToString();
            txtname.Text= xdv[0]["empname"].ToString();
            txtaddress.Text= xdv[0]["Address"].ToString();
            txtphone.Text= xdv[0]["Phone"].ToString();
            txthour.Text= xdv[0]["HourPrice"].ToString();
            txtcardid.Text= xdv[0]["CardID"].ToString();
            txtbirthday.Text= xdv[0]["BirthDay"].ToString();
            txthiredate.Text= xdv[0]["Hiring_Date"].ToString();

        }

      
    }
}
