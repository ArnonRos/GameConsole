using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class UserDetails : Base.Screen
    {
        public UserDetails() : base("USER DETAILS PAGE")
        {

        }

        public override void Show()
        {
            base.Show();
            Models.User us = App.ConsoleGameApp.user;
            CenterText("USER DETAILS");
            CenterText($"Username: {us.Username}");
            CenterText($"Password: {us.Password}");
            Console.ReadKey();
        }
        public void updateDetails(string user, string passwor)
        {
            Data.UserDb.Update(new Models.User("", user, passwor));

        }
    }
}
