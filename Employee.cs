using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesResturant
{
    internal class Employee
    {
        public string role;

        public string firstName;

        public string lastName;

        public string dateOfHire;


        public int id;

        public float salary;
        

        public void Promote()
        {
            salary += 100;
        }

        public void Demote()
        {
            salary -= 100;
        }

        public string FullName()
        {
            return firstName + " " + lastName;
        }

        public Employee()
        {
            role = string.Empty;
            firstName = string.Empty;
            lastName = string.Empty;
            id = 0;
            salary = 0;
        }
        public Employee(string role, string firstName, string lastName, string dateOfHire, float salary)
        {
            this.role = role;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfHire = dateOfHire;
            this.salary = salary;
            this.id = 0;
        }
    }
}
