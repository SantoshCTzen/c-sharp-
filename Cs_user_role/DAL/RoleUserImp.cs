using Cs_Assignment.Models;
using System;
using System.Threading.Tasks;

namespace Cs_Assignment.DAL
{
    public class RoleUserImp : IRole<Roles, int>
    {
        DbContextClass context;
        public RoleUserImp()
        {
            context = new DbContextClass();
        }
        public async Task<Roles> CreateRoleAsync(Roles entity)
        {
            try
            {
                var res = await context.Roles.AddAsync(entity);
                await context.SaveChangesAsync();
                return res.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool checkingRolesName(Roles role)
        {
            if (role.RoleName != null)
            {
                return true;
            }
            if (role.RoleName == "^[A-Z]")
            {
                return true;
            }
            return false;
        }

    }
}
