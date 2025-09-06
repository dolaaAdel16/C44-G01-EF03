using InheiratenceExample.Contexts;
using InheiratenceExample.Models;

namespace InheiratenceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using AppDbContext context = new AppDbContext();

            //FullTimeEmployee fulltime01 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Ali",
            //    Address = "Cairo",
            //    Email = " AhmedAli@gmail.com",
            //    Salary = 120000

            //};



            //FullTimeEmployee fulltime02 = new FullTimeEmployee()
            //{
            //    Name = "Mariam khalid",
            //    Address = "Alex",
            //    Email = " MariamKhaled@gmail.com",
            //    Salary = 140000

            //};

            //FullTimeEmployee fulltime03 = new FullTimeEmployee()
            //{
            //    Name = "Sherif Samy",
            //    Address = "Giza",
            //    Email = " SherifSamy@gmail.com",
            //    Salary = 150000

            //};

            //context.FullTimeEmployees.Add(fulltime01);
            //context.FullTimeEmployees.Add(fulltime02);
            //context.SaveChanges();


            //PartTimeEmployee parttime01 = new PartTimeEmployee()
            //{
            //    Name = "Mohammed Ali",
            //    Address = "Cairo",
            //    Email = " Mohammed@gmail.com",
            //    HourRate = 140,
            //    HoursWorked = 220

            //};



            //PartTimeEmployee parttime02 = new PartTimeEmployee()
            //{
            //    Name = "Amr khalid",
            //    Address = "Alex",
            //    Email = " AmrKhalid@gmail.com",
            //    HourRate = 142,
            //    HoursWorked = 240

            //};

            //PartTimeEmployee parttime03 = new PartTimeEmployee()
            //{
            //    Name = "Gamal Samy",
            //    Address = "Giza",
            //    Email = "Gamal@gmail.com",
            //    HourRate = 148,
            //    HoursWorked = 280

            //};

            //context.PartTimeEmployees.Add(parttime03);


            //context.SaveChanges();

            //var result = context.Employees.OfType<PartTimeEmployee>();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //foreach (var item in context.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //var result = context.FullTimeEmployees.FirstOrDefault(e => e.Id ==1 );

            //Console.WriteLine(result.Name); 
        }
    }
}
