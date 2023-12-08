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
    public class User
    {
        private readonly IUser _user;
        public User(IUser user)
        {
            _user = user;
        }
        public Task<OperationResult> UserInsert(User user)
        {
            return Task.Run(() =>
            {
                var p = _user.Insert(user);
            });
            
        }
        public Task<OperationResult> UserUpdate(User user)
        {
            return Task.Run(() =>
            {
                var p = _user.Update(user);
            });
        }
        public Task<OperationResult> UserSelect(string UserName = "")
        {
            return Task.Run(() =>
            {
                var p = _user.Select();
            });
        }
    }
}
