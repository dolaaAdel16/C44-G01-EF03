using DB_First_Using_EF_Core_Power_Tools.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DB_First_Using_EF_Core_Power_Tools
{
    internal class Program
    {
        static void Main()
        {

            //NorthwindDbContext context = new NorthwindDbContext();

            //var result = context.Categories.ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}

            // Run SQL Query
            // 1. Select statmnet : FromSqlRaw() , FromSqlInterploated()

            //var result =  context.Categories.FromSqlRaw("Select * From Categories");
            ////var result =  context.Categories.FromSqlRaw("Select * From Products where UnitsInStock = 0");

            // int Price = 10;

            ////var result =  context.Categories.FromSqlRaw("Select * From Products where UnitPrice > {0}",Price);
            ////var result =  context.Categories.FromSqlInterpolated($"Select * From Products where UnitPrice > {Price}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}

            // 2. DML Statements [Update , insert , delete ] : ExecuteSqlRaw() , ExecuteSqlInterploated()

            //Int Id = 1;

            //context.Database.ExecuteSqlRaw("Delete From Products where ProductID =  {0}",Id);
            //context.Database.ExecuteSqlRaw($"Delete From Products where ProductID =  {Id}");
            //context.Database.ExecuteSqlInterpolated("Delete From Products where ProductID =  {Id}");

            //context.Database.ExecuteSqlRaw("Update Product Set UnitsInStock = 40 Where ProductID = 1");

        }
    }
}
