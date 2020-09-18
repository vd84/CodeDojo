using Models;
using System.Collections.Generic;

namespace Repos {
  interface IArendeRepo {
    public Arende getArende(int id);
    public List<Arende> getAllArende();
    public List<Arende> getAllArendeForOneUser(int userId);
    
  }
}