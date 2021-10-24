using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public DataResult<List<Car>> GetAll()
        {
            //Business codes
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public DataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            //Business codes
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.BrandId == brandId));
        }
        
        public DataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            //Business codes
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.ColorId == colorId));
        }

        public DataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public Result Add(Car car)
        {
            //Business codes
            _carDal.Add(car);
            return new SuccessResult();
        }

        public Result Delete(Car car)
        {
            //Business codes
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public Result Update(Car car)
        {
            //Business codes
            _carDal.Update(car);
            return new SuccessResult();
        }
    }
}