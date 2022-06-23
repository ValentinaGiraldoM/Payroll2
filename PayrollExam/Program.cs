using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PayrollExam
{ 
    internal class Program
    {

        Data data = new Data();
        public void DataEmploye()

        {
           
            try
            {
                    double SubTransport1 = 117.172;

                Console.WriteLine("Dates Emplooyed");
                Console.WriteLine("Insert Document: ");
                data.Document1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Insert First Name: ");
                data.FirstName1 = Console.ReadLine();
                Console.WriteLine("Insert Last Name: ");
                data.LastName1 = Console.ReadLine();
                Console.WriteLine("Insert Salary: ");
                data.Salary1 = double.Parse(Console.ReadLine());
                
              
                    Console.WriteLine("Insert Worked Days");
                    data.WorkedDays1 = double.Parse(Console.ReadLine());
               

            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid data.\nEnter the correct data", e);
                Console.ReadKey();
            }

            if (data.WorkedDays1 <= 2000000)
            { data.ResultTotal1 = data.Salary1 + data.SubTransport1; }
            else
            { data.ResultTotal1 = data.Salary1; }

            data.Accrued1 = data.ResultTotal1 * data.WorkedDays1 / 30;

            data.Heald1 = data.Accrued1 - 0.04;
            data.Pension1 = data.Accrued1 - 0.04;

        }

        public void ConsoleData()
        {
            try
            {
                Console.WriteLine("Document: " + data.Document1);
                Console.WriteLine("First Name: " + data.FirstName1);
                Console.WriteLine("Last Name: " + data.LastName1);
                Console.WriteLine("Salary: " + data.Salary1);
                Console.WriteLine("Worked Days: " + data.WorkedDays1);
                Console.WriteLine("Accrued: " + data.Accrued1);
                Console.WriteLine("Health: " + data.Heald1);
                Console.WriteLine("Pension: " + data.Pension1);
            }catch (FormatException e)
            
                {
                    Console.WriteLine("Invalid data.\nEnter the correct data", e);
                    Console.ReadKey();
            }

        }

        public void FileData()
        {
            TextWriter File = new StreamWriter("Payroll.txt", true);

            File.WriteLine($"\n----------New Employee----------");
            File.WriteLine("Document: " + data.Document1);
            File.WriteLine("First Name: " + data.FirstName1);
            File.WriteLine("Last Name: " + data.LastName1);
            File.WriteLine("Salary: " + data.Salary1);
            File.WriteLine("Worked Days: " + data.WorkedDays1);
            File.WriteLine("Accrued: " + data.Accrued1);
            File.WriteLine("Health: " + data.Heald1);
            File.WriteLine("Pension: " + data.Pension1);

            File.Close();
        }

    }
}