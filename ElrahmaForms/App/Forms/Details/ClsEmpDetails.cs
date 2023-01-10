using ElrahmaForms.App.Classes;
using ElrahmaForms.App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElrahmaForms.App.Forms
{
     class ClsEmpDetails
    {
        
        public DataTable Dt_Get;
        public ClsDB XclsDb = new ClsDB();
        

        public void Get()
        {
            string SqlCommand = "SELECT  * FROM employees e left outer join Departments d on e.deptno = d.deptno";
            Dt_Get = new DataTable();
            XclsDb.Select(SqlCommand,null,Dt_Get);
         

        }




    }
}
