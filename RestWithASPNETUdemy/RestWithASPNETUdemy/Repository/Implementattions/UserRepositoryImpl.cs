using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;

namespace RestWithASPNETUdemy.Repository.Implementattions
{
    public class UserRepositoryImpl : IUserRepository
    {
        private MySQLContext _context;
        private volatile int count = 0;

        public UserRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }
        
        public User FindByLogin(string login)
        {
            return _context.Users.SingleOrDefault(p => p.Login.Equals(login));
        }
    }
}
