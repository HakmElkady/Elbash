using ElrahmaForms.App.Classes;
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
    internal class Clsattend
    {

        public DataTable Dt_Get;
        public ClsDB XclsDb = new ClsDB();




        public void Get()
        {                                                                                                                                                       
            string SqlCommand = "select EmpName,checkin,checkout,ID,e.empid from checkinout c inner join employees e\r\non e.empid=c.empid\r\nwhere checkout is null and IsActive = 'true' ";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand, null, Dt_Get);



        }

        private bool Get4Check(int EmpID)
        {                                                                                                                                                       
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

            string Sqlcommand2 = "select max(id) from Current_month";
            Dt_Get = new DataTable();
            XclsDb.Select(Sqlcommand2, null, Dt_Get);
            int MonthId = (int)Dt_Get.Rows[0][0];

            if (Get4Check(EmpID))
            {


                Get();
                string SqlCommand = $"insert into checkinout (checkin,empid,MonthId) values ('{DateTime.Now}',{EmpID},{MonthId}) ";
                XclsDb.Excute(SqlCommand, null);

                
            }
            else
            {
                MessageBox.Show("برجاء تفعيل الموظف لتسجيل الدخول");
                return;
            }


        }



        bool CheckMonth()
        {
            string Sqlcommand1 = "select max(month_year) from Emp_month_TotalSal";
            Dt_Get = new DataTable();
            XclsDb.Select(Sqlcommand1, null, Dt_Get);
            string str1 = Dt_Get.Rows[0][0].ToString().ToLower();


            string Sqlcommand2 = "select max(month) from Current_month";
            Dt_Get = new DataTable();
            XclsDb.Select(Sqlcommand2, null, Dt_Get);
            string str2 = Dt_Get.Rows[0][0].ToString().ToLower();

            if(str1 == str2)
                return
                    true;
            else
                return false;



        }


        public void CheckOut(int EmpID,int Checkno,TimeSpan ts) 
        {
            /////convert Total Mins to Hours and update The Employee in Emp_Month_TotalSal table
            ///
                                                                            
            string Sqlcommand1 = $"select max(Month_Year) from Emp_Month_TotalSal where empid={EmpID}";
            Dt_Get = new DataTable();
            XclsDb.Select(Sqlcommand1, null, Dt_Get);
            string str1 = Dt_Get.Rows[0][0].ToString().ToLower();


            string Sqlcommand2 = "select max(month) from Current_month";
            Dt_Get = new DataTable();
            XclsDb.Select(Sqlcommand2, null, Dt_Get);
            string str2 = Dt_Get.Rows[0][0].ToString().ToLower();



            decimal hours = 0;                                                               //where month= (current)month
            string Sqlcommand = $"select totalhours from Emp_Month_TotalSal where empid = {EmpID}  and  Month_Year = '{str2}' ";
            Dt_Get.Dispose();
            Dt_Get = new DataTable();
            XclsDb.Select(Sqlcommand, null, Dt_Get);

            bool a = true;

            try
            {
                hours = Convert.ToDecimal(Dt_Get.Rows[0][0].ToString());
            }
            catch (Exception)
            {
                a= false;
                MessageBox.Show("أول تسجيل دخول في شهر" + str2);
            }
      

                

          







            if (CheckMonth() && a )
            {

                hours += Convert.ToDecimal((ts.TotalMinutes) / 60);

                hours = decimal.Round(hours, 2);

                string sqlcommand0 = $"update Emp_Month_TotalSal\r\nset totalhours = {hours} \r\nwhere empid = {EmpID}";
                XclsDb.Excute(sqlcommand0, null);


                string SqlCommand1 = $"update Checkinout\r\nset checkout='{DateTime.Now}', logged_Mins='{ts.TotalMinutes}'\r\nwhere empid={EmpID} and id = {Checkno}";

                XclsDb.Excute(SqlCommand1, null);

            }
            else
            {

                decimal hours2 = Convert.ToDecimal((ts.TotalMinutes) / 60);

                hours2 = decimal.Round(hours2, 2);

                string sqlcommand2 = $"insert into Emp_Month_TotalSal\r\n(month_year,empid,totalhours)\r\nvalues\r\n('{str2}',{EmpID},{hours2});";


                XclsDb.Excute(sqlcommand2, null);


                string SqlCommand3 = $"update Checkinout\r\nset checkout='{DateTime.Now}', logged_Mins='{ts.TotalMinutes}'\r\nwhere empid={EmpID} and id = {Checkno}";

                XclsDb.Excute(SqlCommand3, null);


            }
        
        
        
        }
        

    }
}
