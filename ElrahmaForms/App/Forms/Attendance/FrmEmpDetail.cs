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

namespace ElrahmaForms.App.Forms.Attendance
{
    public partial class FrmEmpDetail : Form
    {


        ClsDB xclsdb = new ClsDB();
        public DataTable Dt_Get;

        public FrmEmpDetail()
        {
            InitializeComponent();
            GetForCombobox();
            comboBox1.DisplayMember = "EmpName";
            comboBox1.ValueMember = "Empid";
            comboBox1.DataSource = Dt_Get;

            Get();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Dt_Get;
            dateTimePicker2.Value = DateTime.Now;


        }

        private void FrmEmpDetail_Load(object sender, EventArgs e)
        {

         

        }


        public void GetFilter(int EmpId,DateTime From , DateTime To)
        {
            string SqlCommand = $"select e.Empid,e.EmpName,c.checkin,c.checkout,\r\nc.logged_Mins,c.ID\r\nfrom Employees e , Checkinout c\r\nwhere e.empid = {EmpId}and e.EmpId =c.EmpId and c.checkin \r\nbetween '{From}' and '{To}'";
            Dt_Get = new DataTable();
            xclsdb.Select(SqlCommand, null, Dt_Get);


        }

        public void Get()
        {

            TimeSpan timeSpan = DateTime.Now.AddMonths(1) - DateTime.Now;
            string SqlCommand = $"select e.Empid,e.empname,c.checkin,c.checkout,\r\nc.logged_Mins,c.ID\r\nfrom Employees e , Checkinout c\r\nwhere e.EmpId =c.EmpId and   c.checkin \r\nbetween '{DateTime.Now.Subtract(timeSpan)}' and '{DateTime.Now}'";
            Dt_Get = new DataTable();
            xclsdb.Select(SqlCommand, null, Dt_Get);


        }
        public void GetForCombobox()
        {

            TimeSpan timeSpan = DateTime.Now.AddMonths(1) - DateTime.Now;
            string SqlCommand = $"select Empid,empname from Employees  ";
            Dt_Get = new DataTable();
            xclsdb.Select(SqlCommand, null, Dt_Get);


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int.TryParse(comboBox1.SelectedValue.ToString(), out int val);
            GetFilter(val,dateTimePicker1.Value,dateTimePicker2.Value);
            dataGridView1.Refresh();
            dataGridView1.DataSource = Dt_Get;
        }
    }
}
