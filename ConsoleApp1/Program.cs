using SimpleTrade.Domain.Models;
using SimpleTrade.Domain.Services;
using SimpleTrade.EntityFramework;
using SimpleTrade.EntityFramework.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userService = new GenericDataService<User>(new SimpleTradeDbContextFactory());

            //userService.Create(new User
            //{
            //    Username = "sujuds",
            //    Email = "sujud@bsa.id"
            //}).Wait();

            foreach (var user in userService.GetAll().Result)
            {
                Console.WriteLine($"Username: { user.Username} | Email: { user.Email }");
            }

            Console.ReadLine();
        }

    }
}
