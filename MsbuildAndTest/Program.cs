using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsbuildAndTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.GetDetails();
            emp.Display();
            Console.ReadKey();
        }
    }
}
