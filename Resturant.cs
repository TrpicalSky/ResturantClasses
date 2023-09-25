using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesResturant
{
    internal class Resturant
    {
        private List<Employee> employees = new List<Employee>();

            public List<Employee> addMultipleEmployees(List<Employee> e)
            {
                for (int i = 0; i < e.Count; i++)
                {
                    employees.Add(e[i]);
                }
                return employees;
            }

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
                    float percentage = employee.salary * (percent / 100);
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
}
