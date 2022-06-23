using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PayrollExam
{
    internal class Data
    {
        private double Document;
        private string FirstName;
        private string LastName;
        private double Salary;
        private double WorkedDays;
        private double Accrued;
        private double Heald;
        private double Pension;
        private double ResultTotal;
        private double SubTransport;


        public double Document1 { get => Document; set => Document = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public double WorkedDays1 { get => WorkedDays; set => WorkedDays = value; }
        public double Accrued1 { get => Accrued; set => Accrued = value; }
        public double Heald1 { get => Heald; set => Heald = value; }
        public double Pension1 { get => Pension; set => Pension = value; }
        public double ResultTotal1 { get => ResultTotal; set => ResultTotal = value; }
        public double SubTransport1 { get => SubTransport; set => SubTransport = value; }
    }
}
