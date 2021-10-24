using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public DataResult<List<Rental>> GetAll()
        {
            //Business Codes
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public Result Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult();
        }

        public Result Delete(Rental rental)
        {
            //Business Codes
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public Result Update(Rental rental)
        {
            //Business Codes
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}