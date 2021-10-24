using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        DataResult<List<Customer>> GetAll();
        Result Add(Customer customer);
        Result Delete(Customer customer);
        Result Update(Customer customer);
    }
}