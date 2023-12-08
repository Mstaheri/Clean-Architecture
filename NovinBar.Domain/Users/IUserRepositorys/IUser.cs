using NovinBar.Domain.OperationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Users.IUserRepositorys
{
    public interface IUser
    {
        public OperationResult Insert(User user);
        public OperationResult Update(User user);
        public OperationResult Delete(string userName);
        public OperationResult Recovery(string userName);
        public OperationResult<List<User>> Select(string searchUserName = "");
    }
}
