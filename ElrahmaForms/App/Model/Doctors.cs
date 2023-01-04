using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElrahmaForms.App.Model
{
    internal class Doctors : Employee
    {
        public decimal Rouster { get; set; }

        public decimal NumberOfDays { get; set; }

        public decimal NumberOfPatient { get; set; }


    }
}
