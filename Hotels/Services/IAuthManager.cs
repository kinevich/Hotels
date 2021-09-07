using Hotels.Models;
using System.Threading.Tasks;

namespace Hotels.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO userDTO);

        Task<string> CreateToken();
    }
}
