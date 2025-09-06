using EF03.Contexts;

namespace EF03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();    
        }
    }
}
