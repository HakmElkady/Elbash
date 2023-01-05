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
            btncancel.Visible = false;

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
            LoadTheme();
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
            BtnShowEmp.Enabled = false;
            CbxSearch.Enabled = false;
            txtEndDate.Enabled = false;
            BtnSave.Visible = true;
            btncancel.Visible = true;
            dtpHiredate.Value = DateTime.Now;
            rdoadmins.Checked = false;
            rdodoctors.Checked = false;
            rdonurse.Checked = false;
            rdofemal.Checked = false;
            RdoMale.Checked = false;
           


         
          



        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (!CheckData())
                return;

            int Dept = Department();
            string Type = Gender();
            byte[] pic = Imge();

          



            #region عمليات الادخال في قاعدة البيانات


            ///////////////////////    Command 1  To Store New Emp In DataBase
            string SqlCommand1 = "insert into Employees" +
                "(IsActive,EmpName,Address,Phone,BirthDay," +
                "HourPrice,CardID,Qualification,Hiring_Date,Gender,EmpImage,DeptNo)" +
                "values" +
                "(@IsActive,@EmpName,@Address,@Phone,@BirthDay," +
                "@HourPrice,@CardID,@Qualification,@Hiring_Date,@Gender,@EmpImage,@DeptNo)";
            SqlParameter[] par = new SqlParameter[12];

            par[0] = new SqlParameter("IsActive", MySqlDbType.Bit) { Value = checkBoxActive.Checked };
            par[1] = new SqlParameter("EmpName", MySqlDbType.VarChar) { Value = txtname.Text.ToString() };
            par[2] = new SqlParameter("Address", MySqlDbType.VarChar) { Value = txtaddress.Text.ToString() };
            par[3] = new SqlParameter("Phone", MySqlDbType.VarChar) { Value = txtphone.Text.ToString() };
            par[4] = new SqlParameter("BirthDay", MySqlDbType.Date) { Value = dtpBirthday.Value.ToString("yyyy-MM-dd") };
            par[5] = new SqlParameter("HourPrice", MySqlDbType.Decimal) { Value = Convert.ToDecimal(txthour.Text) };
            par[6] = new SqlParameter("CardID", MySqlDbType.VarChar) { Value = txtcardid.Text.ToString() };
            par[7] = new SqlParameter("Qualification", MySqlDbType.VarChar) { Value = txtQualification.Text.ToString() };
            par[8] = new SqlParameter("Hiring_Date", MySqlDbType.Date) { Value = dtpHiredate.Value.ToString("yyyy-MM-dd") };
            par[9] = new SqlParameter("Gender", MySqlDbType.VarChar) { Value = Type };
            par[10] = new SqlParameter("EmpImage", MySqlDbType.Byte) { Value = pic };
            par[11] = new SqlParameter("DeptNo", MySqlDbType.Int32) { Value = Dept };






            ///////////////////  Excute The Two Command Of New Employee

            try
            {
                if (xclsemp.XclsDb.Check())
                {

                    xclsemp.XclsDb.Excute(SqlCommand1, par);

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
            txtQualification.Text= xdv[0]["Qualification"].ToString();

            ///////////  image
          
            byte[] img =  xdv[0][16] as byte[];
            MemoryStream ms = new MemoryStream(img);
            picboxemp.Image = Image.FromStream(ms);
            
            ///////// Gender Rdo
            if (xdv[0]["Gender"].ToString().Trim()== "ذكر")
                RdoMale.Checked= true;
            else
                rdofemal.Checked= true;
            /////////Dept Rdo
            if (xdv[0]["DeptName"].ToString().Trim() == "الأطباء")
                rdodoctors.Checked = true;
            else if (xdv[0]["DeptName"].ToString().Trim() == "التمريض")
                rdonurse.Checked = true;
            else if (xdv[0]["DeptName"].ToString().Trim() == "الموظفين")
                rdoadmins.Checked = true;
            else
            { 
                MessageBox.Show("Note=> \n هذا الموظف غير مدرج في أي قسم" + "\n"+ "\tبرجاء التعديل");
                //rdoadmins.Checked = false;
                //rdodoctors.Checked = false;
                //rdonurse.Checked = false;
            }




        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }



        private void BtnImgSelect_Click(object sender, EventArgs e)
        {
            ofd.Title = "إختر صورة الموظف";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
           
            if(ofd.ShowDialog() == DialogResult.OK)
            picboxemp.Image = Image.FromFile(ofd.FileName);
        }



        int Department()
        {
            if (rdodoctors.Checked)
                return 1;

            else if (rdonurse.Checked)
                return 2;

            else if (rdoadmins.Checked)
                return 3;
            else
                return 4;


        }
        string Gender()
        {

            if (RdoMale.Checked)
                return "ذكر";
            else
                return "أنثي";
        }
        bool CheckData()
        {

            decimal number;


            if (txtname.Text == string.Empty)
            {
                MessageBox.Show("يرجي إدخال الأسم بشكل صحيح");
                txtname.Focus();
                return false;
            }
            else if (txtaddress.Text == string.Empty)
            {
                MessageBox.Show("يرجي إدخال العنوان بشكل صحيح");
                txtaddress.Focus();
                return false;
            }
            else if (txtphone.Text == string.Empty)
            {
                MessageBox.Show("يرجي إدخال رقم التليفون بشكل صحيح");
                txtphone.Focus();
                return false;

            }
            else if (txthour.Text == string.Empty)
            {
                MessageBox.Show("يرجي إدخال سعر الساعة بشكل صحيح");
                txthour.Focus();
                return false;
            }
            else if (txtcardid.Text == string.Empty)
            {
                MessageBox.Show("يرجي إدخال رقم البطاقة بشكل صحيح");
                txtcardid.Focus();
                return false;

            }
            else if (txtQualification.Text == string.Empty)
            {
                MessageBox.Show("يرجي إدخال المؤهل الدراسي بشكل صحيح");
                txtQualification.Focus();
                return false;

            }
            else if (dtpBirthday.Value.ToString() == "1/1/2000 12:00:00 AM")
            {
                MessageBox.Show("يرجي اختيار تاريخ الميلاد");
                return false;
            }
            else if (rdoadmins.Checked == false && rdodoctors.Checked == false && rdonurse.Checked == false)
            {
                MessageBox.Show("يرجي أختيار الوظيفة");
                return false;
            }
            else if (RdoMale.Checked == false && rdofemal.Checked == false)
            {
                MessageBox.Show("يرجي أختيار النوع");
                return false;
            }
            else if (!Decimal.TryParse(txthour.Text, out number))
            {
                MessageBox.Show("سعر الساعة يجب أن يكون رقم");
                return false;
            }
            else
                return true;
                





        }

        byte[] Imge()
        {
            try
            {
                MemoryStream stream = new MemoryStream();
                picboxemp.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = stream.ToArray();
                return data;
            }
            catch (Exception)
            {

                MessageBox.Show("يرجي اختيار الصورة");
                byte[] data2 = null;
                return data2;
            }
           
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
            btnNewEmp.Visible = true;
            BtnEdit.Visible = true;
            BtnSave.Visible = false;
            btncancel.Visible = false;
            BtnShowEmp.Enabled = true;
            CbxSearch.Enabled = true;
            txtEndDate.Enabled = true;

        }
    }
}
