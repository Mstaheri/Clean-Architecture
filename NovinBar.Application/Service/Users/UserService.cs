using NovinBar.Domain;
using NovinBar.Domain.Entities.Users;
using NovinBar.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Application.Service.Users
{
    public class UserService
    {
        private readonly IUser _user;
        public UserService(IUser user)
        {
            _user = user;
        }
        public async Task<OperationResult> UserInsertAsync(User user)
        {
            var result2 = _user.FindUserName(user.UserName);
            if (result2.Success == true)
            {
                if (result2.Data == null)
                {
                    var result = await _user.InsertAsync(user);
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
                            Message = ConstMessages.ErorInDB
                        };
                    }
                }
                else if (result2.Data.IsDelete == true)
                {
                    return new OperationResult
                    {
                        Success = false,
                        Message = "این نام کاربری قبلا حذف شده میخواهید بازگردانده شود ؟"
                    };
                }
                else
                {
                    return new OperationResult
                    {
                        Success = false,
                        Message = "این نام کاربری قبلا وارد شده"
                    };
                }
            }
            else
            {
                return new OperationResult
                {
                    Success = false,
                    Message = ConstMessages.ErorInDB
                };
            }


        }
        public async Task<OperationResult> UserUpdateAsync(User user)
        {
            var result = await _user.UpdateAsync(user);
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
                    Message = ConstMessages.ErorInDB
                };
            }
        }
        public OperationResult<List<User>> UserSelect(string UserName = "")
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
                    Message = ConstMessages.ErorInDB
                };
            }
        }
        public async Task<OperationResult> UserDeleteAsync(string UserName)
        {
            var result = await _user.DeleteAsync(UserName);
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
                    Message = ConstMessages.ErorInDB
                };
            }
        }
        public async Task<OperationResult> UserRecoveryAsync(string UserName)
        {
            var result = await _user.RecoveryAsync(UserName);
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
                    Message = ConstMessages.ErorInDB
                };
            }
        }
    }
}
