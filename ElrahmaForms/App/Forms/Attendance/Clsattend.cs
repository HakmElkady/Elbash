using ElrahmaForms.App.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElrahmaForms.App.Forms
{
    internal class Clsattend
    {

        public DataTable Dt_Get;
        public ClsDB XclsDb = new ClsDB();


        public void Get()
        {
            string SqlCommand = "select EmpName,checkin,checkout,ID,e.empid from checkinout c inner join employees e\r\non e.empid=c.empid\r\nwhere checkout is null  ";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand, null, Dt_Get);



        }

        public void CheckIn(int EmpID)
        {

            
            string SqlCommand = $"insert into checkinout (checkin,empid) values ('{DateTime.Now}',{EmpID})";
            XclsDb.Excute(SqlCommand, null);


        }

        public void CheckOut(int EmpID,int Checkno,TimeSpan ts) 
        {
            string SqlCommand = $"update Checkinout\r\nset checkout='{DateTime.Now}', logged_Mins='{ts.TotalMinutes}'\r\nwhere empid={EmpID} and id = {Checkno}";
            XclsDb.Excute(SqlCommand,null);
        
        
        }
        

    }
}
