using BkBabyStore.Data.Concrete;
using BkBabyStore.Data;
using BkBabyStore.Entities;

using BkBabyStore.Service.Abstract;

namespace BkBabyStore.Service.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(DatabaseContext _context) : base(_context)
        {
        }
    }
}
