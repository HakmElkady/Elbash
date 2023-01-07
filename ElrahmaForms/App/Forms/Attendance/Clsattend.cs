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
        {                                                                                                                                                       ///
            string SqlCommand = "select EmpName,checkin,checkout,ID,e.empid from checkinout c inner join employees e\r\non e.empid=c.empid\r\nwhere checkout is null and IsActive = 'true' ";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand, null, Dt_Get);



        }

        private bool Get4Check(int EmpID)
        {                                                                                                                                                       ///
            string SqlCommand = $"select IsActive from Employees\r\nwhere EmpId = {EmpID}";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand, null, Dt_Get);   

           string str = Dt_Get.Rows[0][0].ToString().ToLower();

            if (str == "false")
                return false;
            else
                return true;


        }


        public void CheckIn(int EmpID)
        {

            if (Get4Check(EmpID))
            {


                Get();
                string SqlCommand = $"insert into checkinout (checkin,empid) values ('{DateTime.Now}',{EmpID}) ";
                XclsDb.Excute(SqlCommand, null);
            }
            else
            {
                MessageBox.Show("برجاء تفعيل الموظف لتسجيل الدخول");
                return;
            }


        }

        public void CheckOut(int EmpID,int Checkno,TimeSpan ts) 
        {
            string SqlCommand = $"update Checkinout\r\nset checkout='{DateTime.Now}', logged_Mins='{ts.TotalMinutes}'\r\nwhere empid={EmpID} and id = {Checkno}";
            XclsDb.Excute(SqlCommand,null);
        
        
        }
        

    }
}
