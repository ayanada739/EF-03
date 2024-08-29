using Part_02_Inheritance.DbContexts;
using Part_02_Inheritance.Entities;

namespace Part_02_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                Name = "Aya" ,
                Address = "Street-City" ,
                Age = 25 ,
                Salary = 20000 ,
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

            //dbContext.SaveChanges(); //Add Remotly (DB)

            //var FTEmployee = from FTE in dbContext.FullTimeEmployees
            //                 select FTE;
            //var PTEmployee = from PTE in dbContext.PartTimeEmployees
            //                 select PTE;

            //foreach (var employee in FTEmployee)
            //    Console.WriteLine($"{employee.Name} :: {employee.Salary}");

            //Console.WriteLine("=======================");
            //foreach (var employee in PTEmployee)
            //    Console.WriteLine($"{employee.Name} :: {employee.HourRate}");



        }
    }
}
