using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public DataResult<List<Customer>> GetAll()
        {
            //Business Codes
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public Result Add(Customer customer)
        {
            //Business Codes
            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public Result Delete(Customer customer)
        {
            //Business Codes
            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public Result Update(Customer customer)
        {
            //Business Codes
            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}