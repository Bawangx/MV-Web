using MV-API.Models;
using System.Linq.Expressions;

namespace MV-API.Repository.IRepostiory
{
    public interface IVillaRepository : IRepository<Villa>
    {
      
        Task<Villa> UpdateAsync(Villa entity);
  
    }
}
