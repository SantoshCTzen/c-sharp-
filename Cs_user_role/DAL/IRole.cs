using System.Threading.Tasks;

namespace Cs_Assignment.DAL
{
    interface IRole<TModel, in TKey> where TModel : class
    {
        public Task<TModel> CreateRoleAsync(TModel model);

    }
}
