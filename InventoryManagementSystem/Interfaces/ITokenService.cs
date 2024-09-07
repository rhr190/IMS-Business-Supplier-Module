using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services
{
    public interface ITokenService
    {
        string createToken(AppUser user);
    }
}
