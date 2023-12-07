using NovinBar.Domain.OperationResults;
using NovinBar.Domain.Users;
using NovinBar.Domain.Users.IUserRepositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Application.Users
{
    public class UsersInserts
    {
        private readonly IUserInsert _userInsert;
        public UsersInserts(IUserInsert userInsert)
        {
            _userInsert = userInsert;
        }
        public OperationResult IUserInsert(User user)
        {
            return _userInsert.Insert(user);
        }
    }
}
