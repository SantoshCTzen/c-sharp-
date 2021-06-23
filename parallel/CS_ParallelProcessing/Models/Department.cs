using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ParallelProcessing.Models
{

	public abstract class Model
	{ }


    public class Employee : Model
	{
		public int EmpNo { get; set; }
		public string EmpName { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public string DeptName { get; set; }
        public decimal Tax { get; set; }

        
    }

	

}
