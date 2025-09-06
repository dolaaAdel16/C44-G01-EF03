using EF03.Contexts;
using EF03.Models;

namespace EF03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            //var department = new List<Department>()
            //{
            //    new Department { Name = "HR" },
            //    new Department { Name = "IT" },
            //    new Department { Name = "PR" }
            //};


            //var employees = new List<Employee>()
            //{
            //    new Employee { Name = "Alice Bob", Address = "Cairo" , Age = 29 , Salary = 12000 , DeptId = 100 },
            //    new Employee { Name = "Bob Cody", Address = "Alex" , Age = 27 , Salary = 15000 , DeptId = 100 },
            //    new Employee { Name = "Taylor Durden", Address = "Giza" , Age = 30 , Salary = 18000 , DeptId = 100 },
            //    new Employee { Name = "Ahmed Adel", Address = "Giza" , Age = 24 , Salary = 14000 , DeptId = 200 },
            //    new Employee { Name = "Ahmed Khaled ", Address = "Cairo" , Age = 20 , Salary = 13000 , DeptId = 200 },
            //    new Employee { Name = "Salah Adel", Address = "Alex" , Age = 32 , Salary = 17000 , DeptId = 300 },
            //    new Employee { Name = "Ali Ahmed", Address = "Alex" , Age = 22 , Salary = 15000 , DeptId = 100 },

            //};  

            //context.Departments.AddRange(department);
            //context.Employees.AddRange(employees);

            //context.SaveChanges();

            //var employee = context.Employees.FirstOrDefault(e => e.Id == 10);

            //Console.WriteLine(employee?.Id?? 0 );
            //Console.WriteLine(employee?.Name??"NA" );
            //Console.WriteLine(employee?.Salary?? 0.0f );
            //Console.WriteLine(employee?.Address?? "NA" );
            //Console.WriteLine(employee?.DeptId?? 0 );
            //Console.WriteLine(employee?.HiringDate?? DateTime.Now );
            //Console.WriteLine(employee?.WorkFor?.Name?? "NA" );

            var department = context.Departments.FirstOrDefault(d => d.Id == 100);

            Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}


            // 1. Explicit Loading  
        }
    }
}
