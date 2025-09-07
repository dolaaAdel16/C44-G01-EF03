using EF03.Contexts;
using EF03.Models;
using Microsoft.EntityFrameworkCore;

namespace EF03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using AppDbContext context = new AppDbContext();

            var department = new List<Department>()
            {
                new Department { Name = "HR" },
                new Department { Name = "IT" },
                new Department { Name = "PR" }
            };


            var employees = new List<Employee>()
            {
                new Employee { Name = "Alice Bob", Address = "Cairo" , Age = 29 , Salary = 12000 , DeptId = 100 },
                new Employee { Name = "Bob Cody", Address = "Alex" , Age = 27 , Salary = 15000 , DeptId = 100 },
                new Employee { Name = "Taylor Durden", Address = "Giza" , Age = 30 , Salary = 18000 , DeptId = 100 },
                new Employee { Name = "Ahmed Adel", Address = "Giza" , Age = 24 , Salary = 14000 , DeptId = 200 },
                new Employee { Name = "Ahmed Khaled ", Address = "Cairo" , Age = 20 , Salary = 13000 , DeptId = 200 },
                new Employee { Name = "Salah Adel", Address = "Alex" , Age = 32 , Salary = 17000 , DeptId = 300 },
                new Employee { Name = "Ali Ahmed", Address = "Alex" , Age = 22 , Salary = 15000 , DeptId = 100 },

            };

            //context.Departments.AddRange(department);
            //context.Employees.AddRange(employees);

            //context.SaveChanges();

            //var employee = context.Employees.FirstOrDefault(e => e.Id == 10);

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");

            // 1. Explicit Loading  

            // var employee = context.Employees.FirstOrDefault(e => e.Id == 10);

            //context.Entry(employee).Reference("WorkFor").Load();

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");

            //var department = context.Departments.FirstOrDefault(d => d.Id == 100);

            //context.Entry(department).Collection(D => D.Employees).Load(); // Explicit 

            ////List or collection >> .Collection , normal >> .Reference

            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            // 2. Eager Loading

            //var employee = context.Employees.Include(E => E.WorkFor).FirstOrDefault(e => e.Id == 10);


            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");


            //var department = context.Departments.Include(D => D.Employees).FirstOrDefault(d => d.Id == 100);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //within the same query - one request (subquery join)


            // 3. Lazy Loading
            // 3.1. install proxies
            // 3.2. Update OnConfiguring() , Use LazyLoadingProxies
            // 3.3. Make all entities public  
            // 3.4. Make all navigational properties virtual


            //var employee = context.Employees.Include(E => E.WorkFor).FirstOrDefault(e => e.Id == 10);


            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.HiringDate ?? DateTime.Now);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");


            //var department = context.Departments.FirstOrDefault(d => d.Id == 100);

            //Console.WriteLine(department.Name); 

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Jopin Operators


            // Fluent Syntax
            //var result = context.Employees.Join(context.Departments, E => E.DeptId, D => D.Id, (E, D) => new
            //{
            //    EmpId = E.Id,
            //    EmpName = E.Name,
            //    DeptId = D.Id,
            //    DeptName = D.Name 

            //});

            // Query Expression

            //result = from E in context.Employees
            //         join D in context.Departments
            //         on E.DeptId equals D.Id
            //         where D.Name == "HR"
            //         select new
            //         {
            //             EmpId = E.Id,
            //             EmpName = E.Name,
            //             DeptId = D.Id,
            //             DeptName = D.Name
            //         };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Tracking Vs NoTracking
            using AppDbContext context = new AppDbContext();

            var result = context.Employees.AsNoTracking().FirstOrDefault(E => E.Id ==10);

            Console.WriteLine(context.Entry(result).State);

            result.Name = "Ali";

            Console.WriteLine(context.Entry(result).State);


            Console.WriteLine(result.Name);



        }
    }
}
