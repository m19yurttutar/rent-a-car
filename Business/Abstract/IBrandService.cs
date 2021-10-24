using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        DataResult<List<Brand>> GetAll();
        Result Add(Brand brand);
        Result Delete(Brand brand);
        Result Update(Brand brand);
    }
}