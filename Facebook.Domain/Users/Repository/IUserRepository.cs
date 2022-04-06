
using Facebook.Domain.Base.Interfaces;
using Facebook.Domain.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Domain.Users.Repository
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
