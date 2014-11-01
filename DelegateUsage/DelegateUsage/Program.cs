using System;
using System.Collections.Generic;


namespace DelegateUsage
{
    delegate bool IsPromotable(Employee empl);
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set;}

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
        {
            foreach(Employee employee in employeeList){
                if(IsEligibleToPromote(employee)){
                    Console.WriteLine(employee.Name+ " Promoted");
                }
            }
            
        }
        
     
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee(){ID=101,Name="Mary",Salary=5000,Experience=4});
            empList.Add(new Employee(){ID=102,Name="Jane",Salary=3000,Experience=5});
            empList.Add(new Employee(){ID=103,Name="Rob",Salary=5000,Experience=6});
            empList.Add(new Employee(){ID=104,Name="Percival",Salary=5000,Experience=2});
            empList.Add(new Employee(){ID=105,Name="Jon",Salary=7000,Experience=3});
            empList.Add(new Employee(){ID=106,Name="Dave",Salary=53000,Experience=7});
            empList.Add(new Employee(){ID=107,Name="Chris",Salary=5000,Experience=4});
            IsPromotable promotable = new IsPromotable(Promote);
                
            Employee.PromoteEmployee(empList,promotable);
            Console.ReadLine();

        }

        
        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
                return false;
        }
    }
}
