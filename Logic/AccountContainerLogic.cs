using Models;
using System;
using System.Collections.Generic;
using System.Text;
using Logic.Interfaces.ILogic;
using System.Security.Cryptography;
using System.Diagnostics;
using DataFactory;
using Data.Interfaces.IRepository;

namespace Logic
{
    public class AccountContainerLogic : IAccountContainerLogic
    {
        private IAccountContainerRepository accountContainerRepository = new AccountContainerFactory().GetAccountContainerRepository();
        List<AccountLogic> accountLogics = new List<AccountLogic>();

        public Account Login(string username, string password)
        {
            Account account = new Account();
            account = accountContainerRepository.GetAccount(username, password);

            using (MD5 md5Hash = MD5.Create())
            {
                string hash = GetMd5Hash(md5Hash, password);
                string accountPassword = account.Password;

                //Vergelijkt input password waar die een hash van maakt en de hash in de DB
                if (VerifyMd5Hash(md5Hash, password, accountPassword))
                {
                    Debug.WriteLine("The hashes are the same.");
                    return account;
                }
                else
                {
                    Debug.WriteLine("The hashes are not same.");
                    return new Account();
                }
            }
        }

        //Passing methods to repository
        public void Register(Account account)
        {
            string hashedAccountPassword;
            using (MD5 md5Hash = MD5.Create())
            {
                string accountPassword = account.Password;
                hashedAccountPassword = GetMd5Hash(md5Hash, accountPassword);
            }

            account.Password = hashedAccountPassword;

            accountContainerRepository.InsertAccount(account);
        }


        //Methods that can only be found here
        public string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
