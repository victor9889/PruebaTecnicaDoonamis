using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;

namespace PruebaTecnica.Interfaces
{
    public interface IUserService
    {
        Task<User?> registerUser(User user);
    }
}
