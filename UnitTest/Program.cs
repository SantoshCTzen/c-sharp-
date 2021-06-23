using System;
using System.Threading.Tasks;
using UnitTest.DataAccessLayer;
using UnitTest.Models;
using UnitTest.Validator;

namespace UnitTest
{
    public class Program
    {
        static Registration reg = new Registration();
        static Users user = new Users();
        static async Task Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please select below Menu");
                Console.WriteLine("1. Create Role");
                Console.WriteLine("2. Register User");


                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        //Console.WriteLine("Enter the Employee ID");
                        //int empid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Role Name");
                        string ename = Console.ReadLine();

                        var role = await reg.CreateAsyncRole(new Roles() { RoleName = ename });


                        Console.WriteLine("Role Added Successfully");
                        break;
                    case 2:
                        Console.WriteLine("Enter Username: ");
                        string uname = Console.ReadLine();

                       
             
                        Console.WriteLine("Enter the email");
                        string email = Console.ReadLine();
                       // InputValidator.checkemail(email);


                        Console.WriteLine("Enter Password: ");
                        string password1 = Console.ReadLine();
                        Console.WriteLine("Enter the confirm Password");
                        string password2 = Console.ReadLine();
                        
                        
                        Console.WriteLine("Enter the Role Id");
                        int roleid = Convert.ToInt32(Console.ReadLine());

                        
                            var user = await reg.CreateAsyncUser(new Users() { UserName = uname, Email = email, Password = password1, RoleId = roleid });
                        
                        Console.WriteLine("User Added Successfully");

                        break;

                }
                }
        }
    }
}
