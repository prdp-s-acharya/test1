using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsbuildAndTest
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public void GetDetails()
        {
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Address");
            Address = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
        }
    }
}
