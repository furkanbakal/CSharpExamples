using GameManagementDemo.Abstract;
using GameManagementDemo.Concrete;
using GameManagementDemo.Entity;
using System;

namespace GameManagementDemo
{
    class Program
    {
    

        static void Main(string[] args)
        {
            Game game1 = new Game { Id = 1, Name = "COD", Price = "250 TL" };
            Gamer gamer1 = new Gamer { DateOfBirth = 1997, FirstName = "FURKAN", LastName = "BAKAL", Id = 1, NationalityId = 12345678 };

            IGameService gameManager = new GameManager(new GamerCheckManager());
            gameManager.Add(game1, gamer1);

            Console.WriteLine("Hello World!");
        }
    }
}
