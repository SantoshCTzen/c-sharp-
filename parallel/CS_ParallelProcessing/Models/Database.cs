using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ParallelProcessing.Models
{
   

    public class EmployeesDb : List<Employee>
	{
		public EmployeesDb()
		{
			Add(new Employee() { EmpNo=101,EmpName="Mahesh", Designation= "Manager", Salary =23000, DeptName = "IT" });
			Add(new Employee() { EmpNo = 102, EmpName = "Vikram", Designation= "Lead", Salary = 33000, DeptName = "SL" });
			Add(new Employee() { EmpNo = 103, EmpName = "Suprotim", Designation= "Engineer", Salary = 53003, DeptName = "Warehouse" });
			Add(new Employee() { EmpNo = 104, EmpName = "Subodh", Designation= "Lead", Salary = 28004, DeptName = "TR" });
			Add(new Employee() { EmpNo = 105, EmpName = "Vikas", Designation="Programming", Salary = 49005, DeptName = "SYS" });
			Add(new Employee() { EmpNo = 106, EmpName = "Manish", Designation= "Engineer", Salary = 56006, DeptName = "SL" });
			Add(new Employee() { EmpNo = 107, EmpName = "Tejas", Designation = "lecture", Salary = 32007, DeptName = "Warehouse" });
			Add(new Employee() { EmpNo = 108, EmpName = "Gajanan", Designation= "Lead", Salary = 89008, DeptName = "SYS" });
			Add(new Employee() { EmpNo = 109, EmpName = "Deepak", Designation= "Manager", Salary = 45009, DeptName = "HR" });
			Add(new Employee() { EmpNo = 110, EmpName = "Nitin", Designation= "Engineer", Salary = 54001, DeptName = "IT" });
			Add(new Employee() { EmpNo = 111, EmpName = "Ajay", Designation= "Lead", Salary = 78002, DeptName = "SYS" });
			Add(new Employee() { EmpNo = 112, EmpName = "Suraj", Designation= "Engineer", Salary = 87003, DeptName = "TR" });
			Add(new Employee() { EmpNo = 113, EmpName = "Akash", Designation= "Programming", Salary = 16004, DeptName = "TR" });
			Add(new Employee() { EmpNo = 114, EmpName = "Mukesh", Designation= "Engineer", Salary = 96004, DeptName = "IT" });
			Add(new Employee() { EmpNo = 115, EmpName = "Vivek", Designation= "Programming", Salary = 69006, DeptName = "TR" });
			Add(new Employee() { EmpNo = 116, EmpName = "Satish", Designation= "Manager", Salary = 47007, DeptName = "IT" });
		}
	}
		
}
