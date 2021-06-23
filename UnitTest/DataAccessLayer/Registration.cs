using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Models;
namespace UnitTest.DataAccessLayer
{
     public class Registration
    {

        private DotnetunittestContext context;

        public Registration()
        {
            context = new DotnetunittestContext();
        }


        public async Task<Roles> CreateAsyncRole(Roles entity)
        {
            try
            {
                var res = await context.Roles.AddAsync(entity);
                await context.SaveChangesAsync();
                return res.Entity; // newly created entity object
            }
            catch (Exception ex)
            {
                // throw
                throw ex;
            }
        }
        public async Task<Users> CreateAsyncUser(Users model)
        {
            try
            {
                
                var result = await context.Users.AddAsync(model);
                await context.SaveChangesAsync();
                return result.Entity; // newly created entity object
            }
            catch (Exception ex)
            {
                // throw
                throw ex;
            }
        }



        
        public async Task<Users> AssignRoleToUser(Users model)
        {
            try
            {

                var result = await context.Users.AddAsync(model);
                await context.SaveChangesAsync();
                return result.Entity; // newly created entity object
            }
            catch (Exception ex)
            {
                // throw
                throw ex;
            }
        }

    }
}
