using Part_02_Inheritance.DbContexts;
using Part_02_Inheritance.Entities;

namespace Part_02_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();
            #region  Inheritance Mapping 
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                Name = "Aya",
                Address = "Street-City",
                Age = 25,
                Salary = 20000,
                StartDate = DateTime.Now
            };

            PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            {
                Name = "Omar",
                Address = "Street-City",
                Age = 30,
                CountOfHours = 20,
                HourRate = 100
            };

            //dbContext.FullTimeEmployees.Add(fullTimeEmployee);
            //dbContext.PartTimeEmployees.Add(partTimeEmployee);
            ////Added Localy

            dbContext.SaveChanges(); //Add Remotly (DB)

            var Employee = from FTE in dbContext.Employees
                           select FTE;
            //var PTEmployee = from PTE in dbContext.Employees
            //                select PTE;

            foreach (var employee in Employee.OfType<FullTimeEmployee>())
                Console.WriteLine($"{employee.Name} :: {employee.Salary}");

            Console.WriteLine("=======================");
            foreach (var employee in Employee.OfType<PartTimeEmployee>())
                Console.WriteLine($"{employee.Name} :: {employee.HourRate}");

            #endregion


        }
    }
}
