﻿using System;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using Schools.Data.Entities;

namespace Schools.Data.Utils
{
    public class SecurityManager
    {
        private const string _alg = "HmacSHA256";
        private const string _salt = "Jnbl0uKbVMjGFIYlGY6E";
        private const int _expirationMinutes = 10;

        public static string GenerateToken(string username, string passwordHash, string ip, string userAgent, long ticks)
        {
            string hash = string.Join(":", new string[] { username, ip, userAgent, ticks.ToString() });
            string hashLeft = "";
            string hashRight = "";
            using (HMAC hmac = HMAC.Create(_alg))
            {
                hmac.Key = Encoding.UTF8.GetBytes(passwordHash);
                hmac.ComputeHash(Encoding.UTF8.GetBytes(hash));
                hashLeft = Convert.ToBase64String(hmac.Hash);
                hashRight = string.Join(":", new string[] { username, ticks.ToString() });
            }
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Join(":", hashLeft, hashRight)));
        }

        public static EmailConfirmationPair GenerateEmailConfirmationCode(string email)
        {
            var code = Guid.NewGuid().ToString().Replace('-', ' ');
            return new EmailConfirmationPair { ValueToSend = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Join(":", new string[] { email, code }))), Code = code };
        }

        public static string GetHashedPassword(string password)
        {
            string key = string.Join(":", new string[] { password, _salt });
            using (HMAC hmac = HMACSHA256.Create(_alg))
            {                
                hmac.Key = Encoding.UTF8.GetBytes(_salt);
                hmac.ComputeHash(Encoding.UTF8.GetBytes(key));
                return Convert.ToBase64String(hmac.Hash);
            }
        }

        public static bool IsTokenValid(string token, string ip, string userAgent, AccountType accountType)
        {
            bool result = false;
            try
            {                
                string key = Encoding.UTF8.GetString(Convert.FromBase64String(token));                
                string[] parts = key.Split(new char[] { ':' });
                if (parts.Length == 3)
                {                    
                    string hash = parts[0];
                    string username = parts[1];
                    long ticks = long.Parse(parts[2]);
                    DateTime timeStamp = new DateTime(ticks);
                    
                    bool expired = Math.Abs((DateTime.UtcNow - timeStamp).TotalMinutes) > _expirationMinutes;
                    if (!expired)
                    {
                        User user;
                        using (var dbContext = new ApplicationDbContext())
                        {
                            if ((user = dbContext.Users.SingleOrDefault(u => u.Email == username)) != null)
                            {
                                if (user.AccountType == accountType || accountType == AccountType.All)
                                {
                                    string computedToken = GenerateToken(username, user.PasswordHash, ip, userAgent, ticks);

                                    result = (token == computedToken && user.EmailConfirmed);
                                }                                
                            }
                        }                        
                    }
                }
            }
            catch
            {
            }
            return result;
        }        
    }
}
