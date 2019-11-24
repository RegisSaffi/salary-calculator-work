using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, id, position;
            var type=0;
            double gs = 0;
            
            Console.WriteLine("Enter employee id: ");
            id = Console.ReadLine();
            Console.WriteLine("Enter employee name: ");
            name= Console.ReadLine();
            Console.WriteLine("Enter employee position: ");
            position = Console.ReadLine();
            
            Console.WriteLine("Enter employee gross salary: ");
            try
            {
                gs = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter valid gross salary");
            }

            Console.WriteLine("SELECT EMPLOYEE TYPE:\n");

            Console.WriteLine("1 for monthly employee\n");
            Console.WriteLine("2 for hourly employee\n");
            Console.WriteLine("3 for one time employee\n");
            
            try
            {
                type =Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter valid gross salary");
            }
            
            var calculator=new SalaryCalculator(id,name,position);
            
            switch (type)
            {
                case 1:
                {
                    var sal = SalaryCalculator.CalculateSalary(gs);
                    Console.WriteLine($"ID: {calculator.Id}\n");
                    Console.WriteLine($"Name: {calculator.Name}\n");
                    Console.WriteLine($"Position: {calculator.Position}\n");
                
                    Console.WriteLine($"Monthly salary: {sal}\n");
                    break;
                }
                case 2:
                {
                    var hours=0;
                    Console.WriteLine("Enter hours this employee worked.");
                
                    try
                    {
                        hours=Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Please enter valid hours");
                    }
                
                    var sal = SalaryCalculator.CalculateSalary(gs,hours);
                
                    Console.WriteLine($"ID: {calculator.Id}\n");
                    Console.WriteLine($"Name: {calculator.Name}\n");
                    Console.WriteLine($"Position: {calculator.Position}\n");
                
                    Console.WriteLine($"Hourly salary is: {sal}\n");
                    break;
                }
                case 3:
                {
                    var sal = SalaryCalculator.CalculateSalary(Convert.ToInt32(gs));
                    Console.WriteLine($"ID: {calculator.Id}\n");
                    Console.WriteLine($"Name: {calculator.Name}\n");
                    Console.WriteLine($"Position: {calculator.Position}\n");
                
                    Console.WriteLine($"One time salary is: {sal}\n");
                    break;
                }
                default:
                    Console.WriteLine("Unknown option selected.");
                    break;
            }
            
            
        }
    }
}