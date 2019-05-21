using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Models
{
    public interface IUserRepository
    {
        UserAccount GetUser(int id);
        IEnumerable<UserAccount> GetAllUsers();
        IEnumerable<UserAccount> RemoveUser(int id);
        UserAccount AddUser(UserAccount user);
    }
}
