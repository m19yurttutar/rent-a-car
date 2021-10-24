using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        DataResult<List<Rental>> GetAll();
        Result Add(Rental rental);
        Result Delete(Rental rental);
        Result Update(Rental rental);
    }
}