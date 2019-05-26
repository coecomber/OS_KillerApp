using Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Logic.Interfaces.ILogic
{
    public interface IAccountContainerLogic
    {
        Account Login(string username, string password);
        void Register(Account account);
        string GetMd5Hash(MD5 md5Hash, string input);
        bool VerifyMd5Hash(MD5 md5Hash, string input, string hash);
    }
}
