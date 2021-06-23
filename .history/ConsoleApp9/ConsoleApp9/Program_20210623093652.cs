using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp9.Models;
using ConsoleApp9.services;
using ConsoleApp9.validator;

namespace ConsoleApp9
{
    class Program
    {
        static IService<Department, int> dserv = new DepartmentService();
        static IService<Employee, int> eserv = new EmployeeService();
        static async Task Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Select CRUD Operation");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Add Department");
                Console.WriteLine("2.Get All Department");
                Console.WriteLine("3. Delete Department");
                Console.WriteLine("4. Add Employee");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Update Employee");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the Department Id");
                        int deptid = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the Department Number");
                        string dno = Console.ReadLine();
                        Console.WriteLine("Enter the Department Name");
                        string dname = Console.ReadLine();
                        Console.WriteLine("Enter the Department Location");
                        string location = Console.ReadLine();


                        await dserv.CreateAsync(new Department() { DeptUniqueId = deptid, DeptNo = dno, DeptName = dname, Location = location });
                        Console.WriteLine("Department added successfully");
                        break;



                    case 2:
                        Console.WriteLine("All Departments are Displaying");
                        var depts = await dserv.GetAsync();

                       foreach (var item in depts.ToList())
                        {
                          Console.WriteLine($"{item.DeptUniqueId} {item.DeptNo} {item.DeptName} {item.Location}");
                       }
                        break;

                    case 3:
                        Console.WriteLine("Enter the Department ID for delete");
                        int depid = Convert.ToInt32(Console.ReadLine());
                        await dserv.DeleteAsync(depid);
                        Console.WriteLine("Department deleted successfully");
                        break;

                    case 4:
                        Console.WriteLine("Enter the Employee ID");
                        int empid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Employee No");
                        string eno = Console.ReadLine();
                        Console.WriteLine("Enter the Employee Name");
                        string ename = Console.ReadLine();
                        Console.WriteLine("Enter the Employee Designation");
                        string edesg = Console.ReadLine();
                        Console.WriteLine("Enter the Employee Salary");
                        int sal = Convert.ToInt32(Console.ReadLine());
                      
                        Console.WriteLine("Enter the Department uniqid");
                        int depID = Convert.ToInt32(Console.ReadLine());

                       await eserv.CreateAsync(new Employee() { EmpUniqueId = empid,EmpNo=eno, EmpName = ename, Designation=edesg, Salary = sal, DeptUniqueId=depID});

                        Console.WriteLine("Employee Added Successfully");
                        break;


                    case 5:
                        Console.WriteLine("Enter the Employee ID which you want to delete");
                        int emId = Convert.ToInt32(Console.ReadLine());
                        if (emId != 0)
                        {
                           await eserv.DeleteAsync(emId);
                            Console.WriteLine("Employee Deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("You have entered invalid ID");
                        }
                        break;


                    case 6:
                        Console.WriteLine("Enter the Employee id which want to udpdate");
                        emId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name  employee");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the Employee Designation");
                        string edesgna = Console.ReadLine();
                        await eserv.UpdateAsync(emId, new Employee() { EmpName = name, Designation = edesgna });
                        break;

                }


                //    // 1. Printing all records
                //    try
                //    {

                //        var depts = await serv.GetAsync();

                //        foreach (var item in depts.ToList())
                //        {
                //            Console.WriteLine($"{item.DeptUniqueId} {item.DeptNo} {item.DeptName} {item.Location}");
                //        }

                //        var newDept = new Department()
                //        {
                //            DeptUniqueId = 3,
                //            DeptNo = "Dept-30",
                //            DeptName = "SALES",
                //            Location = "Mumbai-Dadar-West"
                //        };
                //        if (InputValidator.DeptValidator(newDept).Count == 0)
                //        {

                //        }
                //        //newDept = await serv.CreateAsync(newDept);

                //        //Console.WriteLine("After adding new Record");

                //        // await serv.UpdateAsync(newDept.DeptUniqueId, newDept);


                //        await serv.DeleteAsync(newDept.DeptUniqueId);


                //        depts = await serv.GetAsync();

                //        foreach (var item in depts.ToList())
                //        {
                //            Console.WriteLine($"{item.DeptUniqueId} {item.DeptNo} {item.DeptName} {item.Location}");
                //        }

                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine($"Error Occured {ex.Message}");
                //    }

                //    Console.ReadLine();
            }
        }
    }
}