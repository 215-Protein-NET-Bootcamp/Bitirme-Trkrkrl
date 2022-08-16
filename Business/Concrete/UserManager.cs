﻿using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public Result Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        public Result Delete(User user)
        {
           _userDal.Delete(user);   
            return new Result(true, Messages.UserDeleted);
        }
        public Result Update(User user)
        {
            _userDal.Update(user);
            return new Result(true);
        }


        public DataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.GetAll(u => u.Email == email).FirstOrDefault());
        }

        public DataResult<User> GetByUserName(string userName)
        {
            return new SuccessDataResult<User>(_userDal.GetAll(u => u.UserName == userName).FirstOrDefault());
        }
        public DataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.GetAll(u => u.UserId == userId).FirstOrDefault());
        }


        public Result UpdatePassword(UserPasswordUpdateDto userPasswordUpdateDto, int userId)
        {
            var user = (GetById(userId)).Data;
            if (!HashingHelper.VerifyPasswordHash(userPasswordUpdateDto.OldPassword, user.passwordHash, user.passwordSalt))
            {
                return new ErrorResult(Messages.OldPasswordIsWrong);

            }
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userPasswordUpdateDto.NewPassword, out passwordHash, out passwordSalt);


            user.passwordHash = passwordHash;
            user.passwordSalt = passwordSalt;
            user.Status = "active";
            _userDal.Update(user);


            return new SuccessDataResult<User>(user, Messages.PasswordUpdated);
        }
        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }


    }
}
