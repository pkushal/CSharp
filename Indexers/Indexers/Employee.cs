using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

    }
    public class Company
    {
        private List<Employee> listEmployee;
        public Company()
        {
            listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { EmployeeId = 1, Name = "Kushal", Gender = "Male" });
            listEmployee.Add(new Employee() { EmployeeId = 2, Name = "Aman", Gender = "Male" });
        }

        // we are creating the indexer here
        public string this[int employeeId]
        {
            get
            {
                return listEmployee.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployee.FirstOrDefault(emp => emp.EmployeeId == employeeId).Name = value;
            }
        }
        public string this[string Gender]
        {
            get
            {
                return listEmployee.Count(emp => emp.Gender == Gender).ToString();
            }
            set
            {
                foreach (Employee employee in listEmployee)
                {
                    if (employee.Gender == Gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }
    }
}
