using Facebook.Domain.Base.Interfaces;
using Facebook.Domain.Users.Repository;
using Facebook.Infrastructure.Data.Repositories.UserRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IUserRepository Users { get; private set; }
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
