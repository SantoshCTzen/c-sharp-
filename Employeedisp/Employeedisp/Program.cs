using System;
using System.Collections;
using System.Collections.Generic;

namespace Employeedisp
{
    class Program
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>()
        {
             new Employee {ID=101,   Name="Amit  "    , Salary=4000,DEPT_ID=101},
             new Employee {ID=102,   Name="Amit  "    , Salary=3800,DEPT_ID=102},
             new Employee {ID=103,   Name="Salman"    , Salary=3500,DEPT_ID=103},
             new Employee {ID=104,   Name="Ram   "    , Salary=2000,DEPT_ID=101},
             new Employee {ID=105,   Name="Shyam "    , Salary=7000,DEPT_ID=102},
             new Employee {ID=106,   Name="Kishor"    , Salary=5000,DEPT_ID=103},
        };

            List<Department> departments = new List<Department>()
        {
             new Department {DEPT_ID=101,   DEPT_Name="HR        "   },
             new Department {DEPT_ID=102,   DEPT_Name="ACCOUNTS  "   },
             new Department {DEPT_ID=103,   DEPT_Name="SALES     "   },
        };


            Console.WriteLine("Employee Details: ");
            foreach (var e in employees)
            {
                Console.WriteLine("\tID: " + e.ID + ", Name: " + e.Name + ", Salary: " + e.Salary + ", Department: " + e.DeptName);
            }



            Console.WriteLine("Depatment Details: ");
            foreach (var d in departments)
            {
                Console.WriteLine("\t Department Id " +d.DEPT_ID + " Department Name " +d.DEPT_Name);
            }
        }

    }
}