using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Interfaces;
using PruebaTecnica.Models;
using PruebaTecnica.Utilities;

namespace PruebaTecnica.Services
{
    public class UserService : IUserService
    {

        private readonly PruebaTecnicaDbContext _context;

        public UserService(PruebaTecnicaDbContext context)
        {
            _context = context;
        }

        public async Task<User?> registerUser(User user)
        {
            if (_context.Users is not null)
            {
                var checkExist = await _context.Users.FirstOrDefaultAsync(x => x.UserEmail == user.UserEmail);
                if (checkExist != null)
                {
                    return null;
                }
                if (user.UserPassword is not null)
                    user.UserPassword = PasswordEncrypt.GetSHA256(user.UserPassword);
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return user;
            }
            return null;
        }
    }
}
