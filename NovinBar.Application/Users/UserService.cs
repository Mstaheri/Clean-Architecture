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
    public class UserService
    {
        private readonly IUser _user;
        public UserService(IUser user)
        {
            _user = user;
        }
        public Task<OperationResult> UserInsert(User user)
        {
            return Task.Run(() =>
            {
                var result = _user.Insert(user);
                if (result.Success == true)
                {
                    return new OperationResult
                    {
                        Success = true
                    };
                }
                else
                {
                    return new OperationResult
                    {
                        Success = false,
                        Message = "خطا رخ داده"
                    };
                }
            });
        }
        public Task<OperationResult> UserUpdate(User user)
        {
            return Task.Run(() =>
            {
                var result = _user.Update(user);
                if (result.Success == true)
                {
                    return new OperationResult
                    {
                        Success = true
                    };
                }
                else
                {
                    return new OperationResult
                    {
                        Success = false,
                        Message = "خطا رخ داده"
                    };
                }
            });
        }
        public Task<OperationResult<List<User>>> UserSelect(string UserName = "")
        {
            return Task.Run(() =>
            {
                var result = _user.Select(UserName);
                if (result.Success == true)
                {
                    return result;
                }
                else
                {
                    return new OperationResult<List<User>>
                    {
                        Success = false,
                        Message = "خطا رخ داده"
                    };
                }
            });
        }
        public Task<OperationResult> UserDelete(string UserName)
        {
            return Task.Run(() =>
            {
                var result = _user.Delete(UserName);
                if (result.Success == true)
                {
                    return new OperationResult
                    {
                        Success = true
                    };
                }
                else
                {
                    return new OperationResult
                    {
                        Success = false,
                        Message = "خطا رخ داده"
                    };
                }
            });
        }
        public Task<OperationResult> UserRecovery(string UserName)
        {
            return Task.Run(() =>
            {
                var result = _user.Recovery(UserName);
                if (result.Success == true)
                {
                    return new OperationResult
                    {
                        Success = true
                    };
                }
                else
                {
                    return new OperationResult
                    {
                        Success = false,
                        Message = "خطا رخ داده"
                    };
                }
            });
        }
    }
}
