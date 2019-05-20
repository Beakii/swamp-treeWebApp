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
                new UserAccount(){Id = 1, Username = "hamish", Password = "password", Fname  = "Hamish", Lname = "Kendall", Address = "ur mums home", EMail="email@email.com"},
                new UserAccount(){Id = 2, Username = "jamie", Password = "password", Fname  = "Jamie", Lname = "Stewart", Address = "Under a bridge", EMail="email@email.com"},
                new UserAccount(){Id = 3, Username = "test", Password = "test", Fname  = "Test", Lname = "Account", Address = "Test", EMail="email@email.com"}
            };
        }

        public IEnumerable<UserAccount> GetAllUsers()
        {
            return _accList;
        }

        public UserAccount GetUser(int id)
        {
            return _accList.FirstOrDefault(e => e.Id == id);
        }

        public UserAccount AddUser(UserAccount user)
        {
            try
            {
                user.Id = _accList.Max(e => e.Id) + 1;
            }
            catch(InvalidOperationException)
            {
                user.Id = 1;
            }
            
            _accList.Add(user);
            return user;
        }

        public IEnumerable<UserAccount> RemoveUser(int id)
        {
            UserAccount acc = _accList.First<UserAccount>(e => e.Id == id);
            _accList.Remove(acc);
            return _accList;
        }
    }
}
