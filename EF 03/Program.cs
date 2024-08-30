using EF_03.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EF_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using EnterpriseDbContext dbContext = new EnterpriseDbContext();
            #region Without Loading
            //var Employee = (from E in dbContext.employees
            //               where E.EmpId == 1
            //               select E).FirstOrDefault();
            //Console.WriteLine($" {Employee?.Name?? "Not Found"} :: { Employee?.Department?.Name?? "Not Found"}");
            ////By Default Navigational Property Doesnit Load

            //var Department = (from D in dbContext.departments
            //                  where D.DeptId == 30
            //                  select D).FirstOrDefault();
            //Console.WriteLine($"Department Name = {Department?.Name?? "Not Found"}" );
            #endregion


            #region With Loading
            #region  Explicit Loading
            //Explicit Loading

            // var Employee = (from E in dbContext.employees
            //               where E.EmpId == 1
            //               select E).FirstOrDefault();
            //dbContext.Entry(Employee).Reference(E => E.Department).Load();

            //Console.WriteLine($" {Employee?.Name ?? "Not Found"} :: {Employee?.Department?.Name ?? "Not Found"}");

            //var Department = (from D in dbContext.departments
            //                  where D.DeptId == 30
            //                 select D).FirstOrDefault();
            //dbContext.Entry(Department).Collection(D => D.employees).Load();

            // Console.WriteLine($"Department Name = {Department?.Name ?? "Not Found"}");
            // Console.WriteLine("=====================================");
            // foreach (var Employee in Department.employees)
            // {
            //    Console.WriteLine(Employee.Name);
            // } 
            #endregion

            #region Egar Loading
            //var Employee = (from E in dbContext.employees.Include(E => E.Department)
            //               where E.EmpId == 1
            //               select E).FirstOrDefault();

            //Console.WriteLine($" {Employee?.Name?? "Not Found"} :: { Employee?.Department?.Name?? "Not Found"}");

            //var Department = (from D in dbContext.departments.Include(D=>D.employees)
            //                  where D.DeptId == 30
            //                  select D).FirstOrDefault();

            //Console.WriteLine($"Department Name = {Department?.Name ?? "Not Found"}");
            //foreach (var Employee in Department.employees)
            //{
            //    Console.WriteLine(Employee.Name);
            //}



            #endregion




            #region Lazy Loading

            //var Employee = (from E in dbContext.employees
            //               where E.EmpId == 1
            //               select E).FirstOrDefault();
            //Console.WriteLine($" {Employee?.Name?? "Not Found"} :: { Employee?.Department?.Name?? "Not Found"}");
            ////By Default Navigational Property Doesnit Load

            //var Department = (from D in dbContext.departments
            //                  where D.DeptId == 30
            //                  select D).FirstOrDefault();
            //Console.WriteLine($"Department Name = {Department?.Name?? "Not Found"}" );
            // foreach (var Employee in Department.employees)
            // {
            //    Console.WriteLine(Employee.Name);
            // } 
            #endregion

            #endregion

        }
    }
}
