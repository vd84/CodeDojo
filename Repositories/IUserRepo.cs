using Models;
using System.Collections.Generic;

namespace Repos {
  interface IUserRepo {
    public User GetUser(int id);
    public List<User> GetAllUser();
    public List<User> GetUserForOneArende(int arendeId);
    
  }
}