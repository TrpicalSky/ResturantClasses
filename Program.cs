using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesResturant
{
    internal class Employee
    {
        public string role 
        {
            get { return role; }
            set { role = value; }
        }
        public string firstName 
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string lastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string dateOfHire
        {
            get { return dateOfHire; }
            set { dateOfHire = value; }
        }

        public int id { 
            get { return id; } 
            set { id = value; }
        }
        public float salary { 
            get { return salary; } 
            set { salary = value; }
        }
        
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
        public Employee(string role,string firstName,string lastName,string dateOfHire,float salary) 
        {
            this.role = role;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfHire = dateOfHire;
            this.salary = salary;
            this.id = 0;
        }
    }

    internal class Resturant
    {
        private List<Employee> employees;

        public List<Employee> AddEmployee(Employee employee)
        {
            employee.id = employees.Count + 1;
            employees.Add(employee);
            return employees;
        }

        public Employee GetEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].id == id) return employees[i];
            }
            return null;
        }

        public void DisplayEmployees()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($@"
                    {employee.firstName} {employee.lastName}:
                    Salary: {employee.salary}
                    Role: {employee.role}
                    Date of Hire: {employee.dateOfHire} 
                ");
            }
        }

        public void RaiseByPercentage(float percent)
        {
            foreach (Employee employee in employees)
            {
                float percentage = employee.salary * (percent/100);
                employee.salary = employee.salary + percentage;
            }
        }

        public Employee findEmployeeByRole(string roleName)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].role.ToLower() == roleName.ToLower())
                {
                    return employees[i];
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        public List<Employee> RemoveEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].id == id)
                {
                    employees.RemoveAt(i);
                    return employees;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = { };
            Resturant resturant = new Resturant();
        }
    }
}
