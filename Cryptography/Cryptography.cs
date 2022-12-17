using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;

namespace Cryptography
{
    public class Cryptography : ICryptography
    {
        public static int ConnectionCount = 0;
        private static List<User> _users = new List<User>();
        private User _user;

        class User
        { 
            public IClientCallback Callback;
            public User(IClientCallback clientCallback)
            { 
                this.Callback = clientCallback;
            }
        }

        public string EncryptToMD5(string input)
        {
            MD5 hasher = MD5.Create();
            var buffer = Encoding.Default.GetBytes(input);
            var data = hasher.ComputeHash(buffer);
            return BytesConvertor(data);
        }

        public string EncryptToSHA1(string input)
        {
            SHA1 hasher = SHA1.Create();
            var buffer = Encoding.Default.GetBytes(input);
            var data = hasher.ComputeHash(buffer);
            return BytesConvertor(data);
        }

        public string EncryptToSHA256(string input)
        {
            SHA256 hasher = SHA256.Create();
            var buffer = Encoding.Default.GetBytes(input);
            var data = hasher.ComputeHash(buffer);
            return BytesConvertor(data);
        }

        public string EncryptToSHA512(string input)
        {
            SHA512 hasher = SHA512.Create();
            var buffer = Encoding.Default.GetBytes(input);
            var data = hasher.ComputeHash(buffer);
            return BytesConvertor(data);
        }

        public void Connection()
        {
            ConnectionCount++;
            IClientCallback clientCallback = OperationContext.Current.GetCallbackChannel<IClientCallback>();
            User user = new User(clientCallback);
            _user = user;
            _users.Add(user);

            foreach (var x in _users)
                x.Callback.Count(ConnectionCount);
        }

        public void Disconnection()
        {
            ConnectionCount--;
            _users.Remove(_user);

            foreach (var x in _users)
                x.Callback.Count(ConnectionCount);
        }

        private string BytesConvertor(byte[] data)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var element in data)
                stringBuilder.Append(element.ToString("x2"));
            return stringBuilder.ToString();
        }

        public void WriteResult(string result)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(result);
            Console.ResetColor();
        }
    }
}
