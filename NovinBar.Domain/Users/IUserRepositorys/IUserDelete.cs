using NovinBar.Domain.OperationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Users.IUserRepositorys
{
    public interface IUserDelete
    {
        public OperationResult Delete(string userName);
    }
}
