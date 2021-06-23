using System.Threading.Tasks;

namespace Cs_Assignment.DAL
{
    interface IUsers<TModel, in Tkey> where TModel : class
    {
        public Task<TModel> CreateAsyncUser(TModel model);
    }

}
