using ElrahmaForms.App.Classes;
using ElrahmaForms.App.Forms;
using ElrahmaForms.App.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            BtnSave.Visible = false;

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
            groupBoxgender.ForeColor = ThemeColor.SecondaryColor;
            groupBoxjobs.ForeColor = ThemeColor.SecondaryColor;

            if (xclsemp.XclsDb.Check() == true)
            {
                xclsemp.Get();
                CbxSearch.DataSource = xclsemp.Dt_Get;
                CbxSearch.ValueMember = "EmpId";
                CbxSearch.DisplayMember = "EmpName";
            }
        }



        private void btnNewEmp_Click(object sender, EventArgs e)
        {
            int a = 0;

            if (xclsemp.XclsDb.Check() == true)
            {
                DataTable dt = new DataTable();
                xclsemp.XclsDb.Select("SELECT  MAX(EmpID)\r\nFROM employees ", null, dt);

                DataRow LastEmpId = dt.Rows[0];

                a = (int)LastEmpId.ItemArray[0];
            }



            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                    txtname.Focus();
                }

            }

            btnNewEmp.Visible = false;
            BtnEdit.Visible = false;
            BtnSave.Visible = true;
            BtnShowEmp.Enabled = false;
            CbxSearch.Enabled = false;
            txtEndDate.Enabled = false;
            dtpHiredate.Value = DateTime.Now;
            txtnum.Text = a.ToString();


         
          



        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           
            CheckData();
            string Dept = Department();


            MemoryStream stream = new MemoryStream();
            picboxemp.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();



            #region عمليات الادخال في قاعدة البيانات


            ///////////////////////    Command 1  To Store New Emp In DataBase
            string SqlCommand1 = "insert into Employees" +
                "(IsActive,EmpName,Address,Phone,BirthDay," +
                "HourPrice,CardID,Qualification,Hiring_Date,Gender,EmpImage)" +
                "values" +
                "(@IsActive,@EmpName,@Address,@Phone,@BirthDay," +
                "@HourPrice,@CardID,@Qualification,@Hiring_Date,@Gender,@EmpImage)";
            SqlParameter[] par = new SqlParameter[11];

            par[0] = new SqlParameter("IsActive", MySqlDbType.Bit) { Value = checkBoxActive.Checked };
            par[1] = new SqlParameter("EmpName", MySqlDbType.VarChar) { Value = txtname.Text.ToString() };
            par[2] = new SqlParameter("Address", MySqlDbType.VarChar) { Value = txtaddress.Text.ToString() };
            par[3] = new SqlParameter("Phone", MySqlDbType.VarChar) { Value = txtphone.Text.ToString() };
            par[4] = new SqlParameter("BirthDay", MySqlDbType.Date) { Value = dtpBirthday.Value.ToString("yyyy-MM-dd") };
            par[5] = new SqlParameter("HourPrice", MySqlDbType.Decimal) { Value = Convert.ToDecimal(txthour.Text) };
            par[6] = new SqlParameter("CardID", MySqlDbType.VarChar) { Value = txtcardid.Text.ToString() };
            par[7] = new SqlParameter("Qualification", MySqlDbType.VarChar) { Value = txtQualification.Text.ToString() };
            par[8] = new SqlParameter("Hiring_Date", MySqlDbType.Date) { Value = dtpHiredate.Value.ToString("yyyy-MM-dd") };
            par[9] = new SqlParameter("Gender", MySqlDbType.VarChar) { Value = Gender() };
            par[10] = new SqlParameter("EmpImage", MySqlDbType.Byte) { Value = pic };
            


            /////////////////////////////////Command 2 To Store Employee Department
            ///



            string SqlCommand2 = "insert into Departments (DeptName,Empid) " +
                  "values" +
                  $"('{Dept}',{int.Parse(txtnum.Text)})";






            ///////////////////  Excute The Two Command Of New Employee

            try
            {
                if (xclsemp.XclsDb.Check())
                {

                    xclsemp.XclsDb.Excute(SqlCommand1, par);

                    xclsemp.XclsDb.Excute(SqlCommand2, null);



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }
            #endregion




            btnNewEmp.Visible = true;
            BtnEdit.Visible = true;
            BtnSave.Visible = false;
            BtnShowEmp.Enabled = true;
            CbxSearch.Enabled = true;
            txtEndDate.Enabled = true;
            MessageBox.Show(" تم حفظ بيانات الموظف الجديد");

        }

        private void BtnShowEmp_Click(object sender, EventArgs e)
        {
            DataView xdv = new DataView(xclsemp.Dt_Get);
            xdv.RowFilter = "EmpId = " + CbxSearch.SelectedValue;
            txtnum.Text = xdv[0]["empid"].ToString();
            txtname.Text = xdv[0]["empname"].ToString();
            txtaddress.Text = xdv[0]["Address"].ToString();
            txtphone.Text = xdv[0]["Phone"].ToString();
            txthour.Text = xdv[0]["HourPrice"].ToString();
            txtcardid.Text = xdv[0]["CardID"].ToString();
            dtpBirthday.Value = Convert.ToDateTime(xdv[0]["BirthDay"]);
            dtpHiredate.Value = Convert.ToDateTime(xdv[0]["Hiring_Date"]);
            txtEndDate.Text = xdv[0]["End_Date"].ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }



        string Department()
        {
            if (rdodoctors.Checked)
                return "الأطباء";

            else if (rdonurse.Checked)
                return "التمريض";

            else
                return "الموظفين";

        }
        string Gender()
        {

            if (RdoMale.Checked)
                return "ذكر";
            else
                return "أنثي";
        }
        void CheckData()
        {
            if (txtname.Text == string.Empty)
                MessageBox.Show("يرجي إدخال الأسم بشكل صحيح");
            if (txtaddress.Text == string.Empty)
                MessageBox.Show("يرجي إدخال العنوان بشكل صحيح");
            if (txtphone.Text == string.Empty)       
                MessageBox.Show("يرجي إدخال رقم التليفون بشكل صحيح");
            if (txthour.Text == string.Empty)       
                MessageBox.Show("يرجي إدخال سعر الساعة بشكل صحيح");
            if (txtcardid.Text == string.Empty)      
                MessageBox.Show("يرجي إدخال رقم البطاقة بشكل صحيح");
            if (txtQualification.Text == string.Empty)       
                MessageBox.Show("يرجي إدخال المؤهل الدراسي بشكل صحيح");
            if (dtpBirthday.Value.ToString() == "1/1/2000 12:00:00 AM")
                MessageBox.Show("يرجي اختيار تاريخ الميلاد");

            try
            {
                decimal.Parse(txthour.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("سعر الساعة يجب أن يكون رقم");
                MessageBox.Show(ex.Message);
                return;
            }


            if (rdoadmins.Checked == false && rdodoctors.Checked == false && rdonurse.Checked == false)
                MessageBox.Show("يرجي أختيار الوظيفة");
            if(RdoMale.Checked == false && rdofemal.Checked ==false)
                MessageBox.Show("يرجي أختيار النوع");

            


        }

  






    }
}
