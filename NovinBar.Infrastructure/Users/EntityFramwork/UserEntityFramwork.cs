using NovinBar.Domain.OperationResults;
using NovinBar.Domain.Users;
using NovinBar.Domain.Users.IUserRepositorys;
using NovinBar.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Infrastructure.Users.Files
{
    internal class UserEntityFramwork : IUser
    {
        public string _ConnectionString { get; set; }
        public UserEntityFramwork(string connectionString)
        {
            _ConnectionString = connectionString;
        }
        public OperationResult Insert(User user)
        {
            try
            {
                DbContextEF db = new DbContextEF(_ConnectionString);
                db.User.Add(user);
                db.SaveChanges();
                return new OperationResult
                {
                    Success = true
                };
            }
            catch (Exception)
            {
                return new OperationResult
                {
                    Success = false
                };
            }
            
        }

        public OperationResult<List<User>> Select(string SearchUserName = "")
        {
            try
            {
                DbContextEF db = new DbContextEF(_ConnectionString);
                var query = db.User.Where(p => p.UserName.Contains(SearchUserName))
                    .OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToList();
                return new OperationResult<List<User>>
                {
                    Data = query,
                    Success = true
                };
            }
            catch (Exception)
            {
                return new OperationResult<List<User>>
                {
                    Success = false
                };
            }
            
        }

        public OperationResult Update(User user)
        {
            try
            {
                DbContextEF db = new DbContextEF(_ConnectionString);
                var query = db.User.Where(p => p.UserName == user.UserName).FirstOrDefault();
                query.UpdateUser(user.FirstName, user.LastName, user.PassWord, user.PhoneNumber);
                db.SaveChanges();
            }
            catch (Exception)
            {

            }
        }

        public OperationResult Delete(string userName)
        {
            
        }

        public OperationResult Recovery(string userName)
        {
            
        }
    }
}
