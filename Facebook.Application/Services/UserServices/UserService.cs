using Facebook.Domain.Base.Interfaces;
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
            
        }
    }
}
