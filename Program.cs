using System; 
using Course.Entities;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client() { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client() { Name = "Alex", Email = "maria@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}