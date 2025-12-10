using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class ViewDetails : MenuScreen

    {
        public ViewDetails() : base("USER DETAILS PAGE")
        {

        }

        public override void Show()
        {
            base.Show();
            var us = App.ConsoleGameApp.user;
            CenterText("USER DETAILS");
            CenterText($"Username: {us.Username}");
            CenterText($"Password: {us.Password}");
            Console.ReadKey();
        }
    }
 }

