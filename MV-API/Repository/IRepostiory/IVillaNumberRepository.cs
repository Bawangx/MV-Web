using MV-API.Models;
using System.Linq.Expressions;

namespace MV-API.Repository.IRepostiory
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
      
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
  
    }
}
