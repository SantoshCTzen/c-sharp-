using System;
using System.Collections.Generic;
using Core_Code_First.Models;
namespace Core_Code_First
{
    class Program
    {
        static void Main(string[] args)
        {


            using (var context = new DBContextClass())
            {
                var cat = new Customer()
                {
                    CustomerId= "Cat-006",
                    CustomerName = "Food",
                    CustomerRowId = 10,
                    
                };

                var ctx = new DBContextClass();
                ctx.Customers.Add(cat);
                ctx.SaveChanges();
                Console.ReadLine();

            }
        }
    }
}