using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IUserRepository
    {
        User FindByLogin(string login);
        
    }
}
