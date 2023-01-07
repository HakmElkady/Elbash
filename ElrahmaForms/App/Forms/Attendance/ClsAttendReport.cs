using ElrahmaForms.App.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElrahmaForms.App.Forms
{
    internal class ClsAttendReport
    {


        public DataTable Dt_Get;
        public ClsDB XclsDb = new ClsDB();


        public void Get()
        {
            TimeSpan timeSpan = DateTime.Now.AddMonths(1) - DateTime.Now;
            string SqlCommand = $"select c.EmpId,EmpName,c.ID,c.checkin,\r\nc.checkout,(logged_Mins)/60 as logged_Mins,HourPrice,((logged_Mins)/60)*HourPrice as Total\r\nfrom \r\nEmployees e, Checkinout c\r\nwhere e.empid = c.EmpId\r\nand  checkin between '{DateTime.Now.Subtract(timeSpan)}' and '{DateTime.Now}' order by e.EmpId asc";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand, null, Dt_Get);


        }


        public void GetFilter(int Empid , DateTime From , DateTime To)
        {

            string SqlCommand = $"select e.EmpId,EmpName,c.ID,c.checkin,\r\nc.checkout,logged_Mins,HourPrice\r\nfrom \r\nEmployees e, Checkinout c\r\nwhere e.EmpId = {Empid} and checkin between '{From}' and '{To}'\r\n\r\n";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand,null,Dt_Get);


        }

    }
}
