using System;
namespace Salary
{
    public class SalaryCalculator
    {
        private string name, id, position;
        public SalaryCalculator(string id,string name,string position)
        {
            this.id = id;
            this.name = name;
            this.position = position;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Position
        {
            get => position;
            set => position = value;
        }

        public static double CalculateSalary(double gs)
        {
           
            var salary = gs - (gs * 0.3) - (gs * 0.05) - (gs * 0.03);
            return salary;
        }
        
        public static double CalculateSalary(double rate,int hours)
        {
            var salary = (rate*hours)- (rate * 0.05) - (rate * 0.03);
            return salary;
        }
        
        public static double CalculateSalary(int gs)
        {
            var salary = gs - (gs * 0.3);
            return salary;
        }
    }
}