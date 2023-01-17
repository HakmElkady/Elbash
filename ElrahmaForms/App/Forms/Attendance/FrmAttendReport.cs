using ElrahmaForms.App.Classes;
using ElrahmaForms.App.Forms.Attendance;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            LoadTheme();
       
            if (clsAttendReport.XclsDb.Check())
            {
                clsAttendReport.GetMonths();
                cbxMonth.DataSource = clsAttendReport.Dt_Get;
                cbxMonth.ValueMember = "ID";
                cbxMonth.DisplayMember = "Month";
                cbxMonth.SelectedIndex = cbxMonth.Items.Count - 1;


                clsAttendReport.Get(cbxMonth.GetItemText(cbxMonth.SelectedItem));

                //clsAttendReport.Get(clsAttendReport.GetCurrentMonth());
                dgvattendperuser.AutoGenerateColumns = false;
                dgvattendperuser.DataSource = clsAttendReport.Dt_Get;
                cbxEmpName.DataSource = clsAttendReport.Dt_Get;
                cbxEmpName.ValueMember = "EmpId";
                cbxEmpName.DisplayMember = "EmpName";
                clsAttendReport.RefreshGrid(dgvattendperuser, cbxMonth.GetItemText(cbxMonth.SelectedItem));


            }



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
                btngo.BackColor = ThemeColor.PrimaryColor;
                btngo.ForeColor = Color.White;
                btngo.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            }
          //  lblheader.ForeColor = ThemeColor.PrimaryColor;
        }

    

        private void dgvattendperuser_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {



          


            decimal TotalHoursPrice = 0;

            decimal.TryParse(dgvattendperuser.Rows[dgvattendperuser.SelectedCells[0].RowIndex].Cells[8].Value.ToString(), out decimal Hprice);
            decimal.TryParse(dgvattendperuser.Rows[dgvattendperuser.SelectedCells[0].RowIndex].Cells[7].Value.ToString(), out decimal Hcount);

            decimal.TryParse(dgvattendperuser.Rows[dgvattendperuser.SelectedCells[0].RowIndex].Cells[3].Value.ToString(), out decimal Bouns);
            decimal.TryParse(dgvattendperuser.Rows[dgvattendperuser.SelectedCells[0].RowIndex].Cells[5].Value.ToString(), out decimal net);
        
            decimal.TryParse(dgvattendperuser.Rows[dgvattendperuser.SelectedCells[0].RowIndex].Cells[6].Value.ToString(), out decimal Advance);
            decimal.TryParse(dgvattendperuser.Rows[dgvattendperuser.SelectedCells[0].RowIndex].Cells[4].Value.ToString(), out decimal Discount);
        
        
            TotalHoursPrice = ((Hprice * Hcount) + Bouns ) - (Advance + Discount + net);
        
            dgvattendperuser.Rows[dgvattendperuser.SelectedCells[0].RowIndex].Cells[9].Value = TotalHoursPrice.ToString("0.00");





            

            /////////Editing Columns 
            ///


            int.TryParse(dgvattendperuser.Rows[dgvattendperuser.SelectedCells[0].RowIndex].Cells[0].Value.ToString(), out int ID);
            string SQLCommand = $"update Emp_Month_TotalSal set Bouns = @Bouns , Salary_Discount = @Salary_Discount , Internet = @Internet ," +
                $"Advance_Salary = @Advance_Salary , TotalHours = @TotalHours , TotalSalary = @TotalSalary where EmpID = {ID} and Month_Year = '{cbxMonth.GetItemText(cbxMonth.SelectedItem)}'";

            SqlParameter[] par = new SqlParameter[6];

            par[0] = new SqlParameter("Bouns", MySqlDbType.Decimal) { Value = Bouns };
            par[1] = new SqlParameter("Salary_Discount", MySqlDbType.Decimal) { Value = Discount };
            par[2] = new SqlParameter("Internet", MySqlDbType.Decimal) { Value = net };
            par[3] = new SqlParameter("Advance_Salary", MySqlDbType.Decimal) { Value = Advance };
            par[4] = new SqlParameter("TotalHours", MySqlDbType.Decimal) { Value = Hcount };
            par[5] = new SqlParameter("TotalSalary", MySqlDbType.Decimal) { Value = TotalHoursPrice };


            if(clsAttendReport.XclsDb.Check())
            clsAttendReport.XclsDb.Excute(SQLCommand, par);
            clsAttendReport.Get(cbxMonth.SelectedValue.ToString());
            dgvattendperuser.Refresh();
            dgvattendperuser.Update();





        }

        private void dgvattendperuser_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        
        {
            decimal dec;
            decimal.TryParse(dgvattendperuser.SelectedCells[0].Value.ToString(), out dec);

            dgvattendperuser.SelectedCells[0].Value = dec;
        }

        private void btngo_Click(object sender, EventArgs e)
        {
           

        }

        private void btnBegain_Click(object sender, EventArgs e)
        {

            DialogResult = MessageBox.Show("إذا كنت متأكد من بداية الشهر الجديد .\n يرجي تسجيل خروج لكل الموظفيين الموجوديين الأن ", "Hakam",MessageBoxButtons.OKCancel);
            if(DialogResult == DialogResult.OK)
            { 
            try
            {
                    if (txtmonth.Text == string.Empty || txtyear.Text == string.Empty)
                    {
                        MessageBox.Show("أدخل رقم السنة ورقم الشهر","Hakam",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                        return;
                    }

                int.TryParse(txtmonth.Text, out int mon);
                int.TryParse(txtyear.Text, out int year);
                clsAttendReport.InsertMonth(mon, year);
                MessageBox.Show("تم بدأية شهر جديد.","Hakam",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("ادخل الشهر والسنة بشكل صحيح !", "Hakam", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }else
            {
                MessageBox.Show("تم الغاء العملية","Hakam",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }



        }

        private void txtyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void cbxMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            clsAttendReport.Get(cbxMonth.GetItemText(cbxMonth.SelectedItem));
            dgvattendperuser.DataSource = clsAttendReport.Dt_Get;
            dgvattendperuser.Refresh();
            dgvattendperuser.Update();

        }



        private void dgvattendperuser_Click(object sender, EventArgs e)
        {
            clsAttendReport.RefreshGrid(dgvattendperuser, cbxMonth.GetItemText(cbxMonth.SelectedItem));

        }
    }
}
