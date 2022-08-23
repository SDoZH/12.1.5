using System;
using System.IO;

namespace _12._1._5
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Users> listUsers = new()
        {
           new Users() { Name = "Григорий", Login = Guid.NewGuid().ToString().Substring(1, 7), IsPremium = true },
           new Users() { Name = "Василий", Login = Guid.NewGuid().ToString().Substring(1, 7), IsPremium = false },
           new Users() { Name = "Милана", Login = Guid.NewGuid().ToString().Substring(1, 7), IsPremium = false },
        };
            foreach (var Prem in listUsers)
            {
                if (!Prem.IsPremium)
                {
                    Console.Write(Prem.Name + " ");
                    Show.ShowAds();
                }
            }
        }
    }
}