using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameConsole.Data
{
    public class UserDb
    {
        private static List<User> users = new List<User>();
        public static User RegisterUser(string name, string uName, string password)
        {
            if (users.Any(u => u.Username == uName))
            {
                try
                {
                    throw new InvalidOperationException("the user exists already");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("the user exists already");
                    Console.ResetColor();
                }


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("user registered successfully");
                Console.ResetColor();
            }
            User newus = new User(name, uName, password);
            users.Add(newus);
            return newus;

        }
        public static User Login(string username, string password)
        {
            if (users.FirstOrDefault(u => u.Username == username && u.Password == password) == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("no such user exists");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("user logined successfully");
                Console.ResetColor();
            }
            return users.FirstOrDefault(u => u.Username == username && u.Password == password);



        }
        public static void Update(User u)
        {
            if (users.Any(user => user.Username == u.Username))
            {
                users.Where(user => user.Username == u.Username).ToList().FirstOrDefault().Password = u.Password;
                users.Where(user => user.Username == u.Username).ToList().FirstOrDefault().Username = u.Username;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("user registered successfully");
                Console.ResetColor();
            }
            else
            {
                try
                {
                    throw new InvalidOperationException("the user exists already");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("the user exists already");
                    Console.ResetColor();
                }
            }

        }
    }
}


