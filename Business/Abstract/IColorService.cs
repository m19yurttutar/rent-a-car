using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        DataResult<List<Color>> GetAll();
        Result Add(Color color);
        Result Delete(Color color);
        Result Update(Color color);
    }
}