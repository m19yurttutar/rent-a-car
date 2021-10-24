using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public DataResult<List<Color>> GetAll()
        {
            //Business codes
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public Result Add(Color color)
        {
            //Business codes
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public Result Delete(Color color)
        {
            //Business codes
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public Result Update(Color color)
        {
            //Business codes
            _colorDal.Update(color);
            return new SuccessResult();
        }
    }
}