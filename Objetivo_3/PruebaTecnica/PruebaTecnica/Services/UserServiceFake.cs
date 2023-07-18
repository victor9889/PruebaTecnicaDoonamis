using Microsoft.AspNetCore.SignalR;
using PruebaTecnica.Interfaces;
using PruebaTecnica.Models;
using PruebaTecnica.Utilities;

namespace PruebaTecnica.Services
{
    public class UserServiceFake : IUserService
    {
        private List<User> UsersContextFake =  new();

        public UserServiceFake()
        {
            UsersContextFake.Add(new User() { UserId = 1, UserEmail = "prueba1@gmail.com", UserPassword = "test", UserName = "Usuario de Prueba" });
            UsersContextFake.Add(new User() { UserId = 2, UserEmail = "prueba2@gmail.com", UserPassword = "test2", UserName = "Usuario de Prueba 2" });
        }
        public async Task<User?> registerUser(User user)
        {
            if (UsersContextFake is not null)
            {
                var checkExist =  UsersContextFake.FirstOrDefault(x => x.UserEmail == user.UserEmail);
                if(checkExist != null)
                {
                    return null;
                }
                if(user.UserPassword is not null)
                    user.UserPassword = PasswordEncrypt.GetSHA256(user.UserPassword);
                UsersContextFake.Add(user);
                return await Task.FromResult(user);
            }
            return null;
        }

        
    }
}
