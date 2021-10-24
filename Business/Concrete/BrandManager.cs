using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public DataResult<List<Brand>> GetAll()
        {
            //Business codes
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public Result Add(Brand brand)
        {
            //Business codes
            _brandDal.Add(brand);
            return new SuccessResult();
        }

        public Result Delete(Brand brand)
        {
            //Business codes
            _brandDal.Delete(brand);
            return new SuccessResult();
        }

        public Result Update(Brand brand)
        {
            //Business codes
            _brandDal.Update(brand);
            return new SuccessResult();
        }
    }
}