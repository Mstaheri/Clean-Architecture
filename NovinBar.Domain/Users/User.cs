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
            CheckUser.CheckUserFirstName(firstName);
            CheckUser.CheckUserLastName(lastName);
            CheckUser.CheckUserUserName(userName);
            CheckUser.CheckUserPassword(passWord);
            CheckUser.CheckPhoneNumber(phoneNumber);
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            PassWord = passWord;
            PhoneNumber = phoneNumber;
        }
        public void UpdateUserFirstName(string firstName)
        {
            CheckUser.CheckUserFirstName(firstName);
            FirstName = firstName;
        }
        public void UpdateUserLastName(string lastName)
        {
            CheckUser.CheckUserLastName(lastName);
            LastName = lastName;
        } 
        public void UpdateUserPassWord(string passWord)
        {
            CheckUser.CheckUserPassword(passWord);
            PassWord = passWord;
        }
        public void UpdateUserPhoneNumber(string phoneNumber)
        {
            CheckUser.CheckPhoneNumber(phoneNumber);
            PhoneNumber = phoneNumber;
        }
    }
}
