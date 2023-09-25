using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesResturant
{
    

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee bob = new Employee("test","Bob","Smith","12/08/2009",200f);
            Employee joe = new Employee("test", "Joe", "Robert", "12/08/2009", 200f);
            List<Employee> employees = new List<Employee>
            {
                bob,
                joe
            };
            Resturant resturant = new Resturant();
            resturant.addMultipleEmployees(employees);
            resturant.DisplayEmployees();
            Console.ReadKey();
        }
    }
}
