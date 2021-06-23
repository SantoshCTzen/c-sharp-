using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp9.Models;
namespace ConsoleApp9.validator
{
    public static class InputValidator
    {
        public static List<string> DeptValidator(Department department)
        {
            List<string> errors = new List<string>();

            if (department.DeptNo == String.Empty)
                errors.Add("DeptNo is Must");

            return errors;
        }
    }
}
