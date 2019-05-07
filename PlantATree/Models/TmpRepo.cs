using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Models
{
    public class TmpRepo : IUserRepository
    {
        private List<UserAccount> _accList;

        public TmpRepo()
        { 
            _accList = new List<UserAccount>()
            {
                new UserAccount(){id = 1, username = "hamish", password = "password", fname  = "Hamish", lname = "Kendall", address = "ur mums home", email="email@email.com"},
                new UserAccount(){id = 2, username = "jamie", password = "password", fname  = "Jamie", lname = "Stewart", address = "Under a bridge", email="email@email.com"},
                new UserAccount(){id = 3, username = "test", password = "test", fname  = "Test", lname = "Account", address = "Test", email="email@email.com"}
            };
        }

        public IEnumerable<UserAccount> GetAllUsers()
        {
            return _accList;
        }

        public UserAccount GetUser(int id)
        {
            return _accList.FirstOrDefault(e => e.id == id);
        }

        public UserAccount AddUser(UserAccount user)
        {
            try
            {
                user.id = _accList.Max(e => e.id) + 1;
            }
            catch(InvalidOperationException)
            {
                user.id = 1;
            }
            
            _accList.Add(user);
            return user;
        }

        public IEnumerable<UserAccount> RemoveUser(int id)
        {
            UserAccount acc = _accList.First<UserAccount>(e => e.id == id);
            _accList.Remove(acc);
            return _accList;
        }
    }
}
