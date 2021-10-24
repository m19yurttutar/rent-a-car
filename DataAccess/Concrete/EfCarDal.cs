using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using DatabaseContext context = new DatabaseContext();
            var result = from car in context.Cars
                join brand in context.Brands on car.BrandId equals brand.Id
                join color in context.Colors on car.ColorId equals color.Id
                select new CarDetailDto
                {
                    CarName = car.CarName, BrandName = brand.Name, ColorName = color.Name, DailyPrice = car.DailyPrice
                };
            return result.ToList();
        }
    }
}