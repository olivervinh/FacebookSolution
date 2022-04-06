using Facebook.Domain.Base.Interfaces;
using Facebook.Domain.Users.Models;
using Market.Domain.Users.DTO.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Application.Services.UserServices
{
  
    public class UserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> UserRegisterAsync(RegisterRequest registerRequest)
        {
            var countEmailExist = _unitOfWork.Users.Conditions(x=>x.Email==registerRequest.Email).Count();
            if (countEmailExist == 0)
            {
                var user = new User
                {
                    Address = registerRequest.Address,
                    Birthday = registerRequest.Birthday,
                    CreatedDate = DateTime.Now,
                    Email = registerRequest.Email,
                    FirstName = registerRequest.FirstName,
                    IsDeleted = false,
                    LastName = registerRequest.LastName,
                    Password = registerRequest.Password,
                    UpdatedDate = null,
                };
                _unitOfWork.Users.Add(user);
                await _unitOfWork.CommitAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
