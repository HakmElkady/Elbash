using ElrahmaForms.App.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElrahmaForms.App.Forms
{
    internal class ClsAttendReport
    {


        public DataTable Dt_Get;
        public ClsDB XclsDb = new ClsDB();

        public string GetCurrentMonth()
        {
            string SqlCommand = $"select max(month) from Current_month ";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand, null, Dt_Get);

            string CurrentMonth = Dt_Get.Rows[0][0].ToString();  
            return CurrentMonth;    

        }


        public void Get(string year)
        {

            string SqlCommand = $"select e.empid,empname,deptname,bouns,salary_discount,\r\ninternet,advance_salary,totalhours,hourprice,TotalSalary\r\nfrom Employees e ,Emp_Month_TotalSal em,Departments d\r\nwhere\r\ne.EmpId =em.EmpID and e.DeptNo = d.DeptNo and \r\nem.Month_Year ='{year}'";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand, null, Dt_Get);


        }



        public void GetMonths()
        {
            string SqlCommand = "select * from Current_Month";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand, null, Dt_Get);


        }



        //public void GetFilter(int Empid , DateTime From , DateTime To)
        //{

        //    string SqlCommand = $"select e.EmpId,EmpName,c.ID,c.checkin,\r\nc.checkout,logged_Mins,HourPrice\r\nfrom \r\nEmployees e, Checkinout c\r\nwhere e.EmpId = {Empid} and checkin between '{From}' and '{To}'\r\n\r\n";
        //    Dt_Get = new DataTable();
        //    XclsDb.Select(SqlCommand,null,Dt_Get);


        //}



        public void AddSubHire(string Column,decimal Value,decimal TotalValue ,int ID)
        {
            string SqlCommand1 = $"update Emp_Month_TotalSal set {Column} = {Value} , TotalSalary = {TotalValue}  where EmpID = {ID}";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand1, null, Dt_Get);

        }



        public void RefreshGrid(DataGridView gridView , string year)
        {



            foreach (DataGridViewRow item in gridView.Rows)
            {
               if(item.Index +1 <= gridView.Rows.Count)
                { 
                decimal TotalHoursPrice = 0;

                decimal.TryParse(item.Cells[8].Value.ToString(), out decimal Hprice);
                decimal.TryParse(item.Cells[7].Value.ToString(), out decimal Hcount);

                decimal.TryParse(item.Cells[3].Value.ToString(), out decimal Bouns);
                decimal.TryParse(item.Cells[5].Value.ToString(), out decimal net);

                decimal.TryParse(item.Cells[4].Value.ToString(), out decimal Advance);
                decimal.TryParse(item.Cells[6].Value.ToString(), out decimal Discount);


                TotalHoursPrice = ((Hprice * Hcount) + Bouns) - (Advance + Discount + net);

                item.Cells[9].Value = TotalHoursPrice.ToString("0.00");
                string SqlCommand = $"update Emp_Month_TotalSal set TotalSalary = {TotalHoursPrice} where EmpID = {item.Cells[0].Value} and Month_Year = '{year}'";
                XclsDb.Excute(SqlCommand, null);

                }
            }


        }



        public void InsertMonth(int month,int year)
        {
            string a =  month.ToString() + "-" + year.ToString();
            string SqlCommand = $"insert into Current_Month (Month) values('{a}')";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand, null, Dt_Get);


        }




    }
}
