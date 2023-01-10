using ElrahmaForms.App.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElrahmaForms.App.Forms
{
    internal class ClsAttendReport
    {


        public DataTable Dt_Get;
        public ClsDB XclsDb = new ClsDB();

        public void GetCurrentMonth()
        {
            string SqlCommand = $"select * from Current_month where id = (select max(id) from current_month)";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand, null, Dt_Get);


        }


        public void Get()
        {
            //TimeSpan timeSpan = DateTime.Now.AddMonths(1) - DateTime.Now;
            string SqlCommand = "select e.empid,empname,deptname,bouns,salary_discount,\r\ninternet,advance_salary,totalhours,hourprice,TotalSalary\r\nfrom Employees e ,Emp_Month_TotalSal em,Departments d\r\nwhere\r\ne.EmpId =em.EmpID and e.DeptNo = d.DeptNo and \r\nem.Month_Year ='1-2023'";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand, null, Dt_Get);


        }


        public void GetFilter(int Empid , DateTime From , DateTime To)
        {

            string SqlCommand = $"select e.EmpId,EmpName,c.ID,c.checkin,\r\nc.checkout,logged_Mins,HourPrice\r\nfrom \r\nEmployees e, Checkinout c\r\nwhere e.EmpId = {Empid} and checkin between '{From}' and '{To}'\r\n\r\n";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand,null,Dt_Get);


        }



        public void AddSubHire(string Column,decimal Value,decimal TotalValue ,int ID)
        {
            string SqlCommand1 = $"update Emp_Month_TotalSal set {Column} = {Value} , TotalSalary = {TotalValue}  where EmpID = {ID}";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand1, null, Dt_Get);

        }

    }
}
