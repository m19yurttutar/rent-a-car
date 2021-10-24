using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, DatabaseContext>, IRentalDal
    {
        
    }
}