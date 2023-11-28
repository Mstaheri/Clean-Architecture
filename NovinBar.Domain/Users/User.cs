using NovinBar.Domain.OperationResults;
using NovinBar.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Domain.Users
{
    public class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string UserName { get; private set; }
        public string PassWord { get; private set; }
        public string PhoneNumber { get; private set; }

        public User(string firstName, string lastName, string userName, string passWord, string phoneNumber)
        {
            var result = CheckUser.CheckUserInInsert(firstName, lastName, userName, passWord, phoneNumber);
            if (result.Success)
            {
                FirstName = firstName;
                LastName = lastName;
                UserName = userName;
                PassWord = passWord;
                PhoneNumber = phoneNumber;
            }
            else
            {
                throw new Exception(result.Message);
            }
        }
        public void UpdateUser(string firstName, string lastName, string passWord, string phoneNumber)
        {
            var result = CheckUser.CheckUserInUpdate(firstName, lastName, passWord, phoneNumber);
            if (result.Success)
            {
                FirstName = firstName;
                LastName = lastName;
                PassWord = passWord;
                PhoneNumber = phoneNumber;
            }
            else
            {
                throw new Exception(result.Message);
            }
        }
        
         

    }
}
