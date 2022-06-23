using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PayrollExam
{
    internal class Menu
    {
        public int NumberEmployee = 1;

        public static void Main(string[] args)
        {
            Menu menu = new Menu();
            Console.WriteLine("Welcome to the Employee Payroll");
            Program program = new Program();
            Data data = new Data();

            int Option = 1;
            try
            {
                do
            {
                Console.WriteLine("1) To add a employee");
                Console.WriteLine("2) Exit the program");
                Option = int.Parse(Console.ReadLine());
                

                    switch (Option)
                    {



                        case 1:
                            {
                                Console.WriteLine("Employee:" + menu.NumberEmployee);
                                try
                                {
                                    program.DataEmploye();
                                    if (data.Salary1 <= 0)
                                    {
                                        Console.WriteLine("Error, el salario no puede ser menor a 0");

                                    }
                                    else
                                    {
                                        program.ConsoleData();
                                        program.FileData();
                                    }
                                }
                               
                                catch (FormatException e)
                                {
                                    Console.WriteLine("Invalid data.\nEnter the correct data", e);
                                    Console.ReadKey();
                                }
                            
                                break;

                            }
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("Completed program");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Insert a correct number");
                                break;
                            }

                            Console.WriteLine("°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°\n\n");
                            Console.Clear();
                    }
                    menu.NumberEmployee++;
              
            } while (Option != 2) ;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid data.\nEnter the correct data", e);
                Console.ReadKey();
            }
        }
    }
}
