using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public DataResult<List<User>> GetAll()
        {
            //Business Codes
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public Result Add(User user)
        {
            //Business Codes
            _userDal.Add(user);
            return new SuccessResult();
        }

        public Result Delete(User user)
        {
            //Business Codes
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public Result Update(User user)
        {
            //Business Codes
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}