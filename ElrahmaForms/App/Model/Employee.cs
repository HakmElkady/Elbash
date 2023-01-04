using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElrahmaForms.App.Model
{
    public class Employee
    {

        //المعلومات الاساسية عن كل الموظفين
        public int EmpId { get; set; }

        public string EmpName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public decimal LoggedHours { get; set; }
        public decimal HourPrice { get; set; }

        public decimal Salary_Discount { get; set; }

        public decimal Internet { get; set; }
        public decimal Bouns { get; set; }

        public decimal Advance_Salary { get; set; }

        public int CardID { get; set; }
        public DateTime BirthDay { get; set; }

        public DateTime Hiring_Date { get; set; }

        public DateTime End_Date { get; set; }

        public bool IsActive { get; set; }

        public string Qualification { get; set; }


        // public string Image { get; set; }

    }
}
