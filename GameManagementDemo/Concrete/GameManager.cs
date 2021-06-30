using GameManagementDemo.Abstract;
using GameManagementDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementDemo.Concrete
{
    public class GameManager : IGameService
    {
        private GamerCheckManager _gamerCheckManager;

      
        public GameManager(GamerCheckManager gamerCheckManager)
        {
            _gamerCheckManager = gamerCheckManager;
        }

       
        public void Add(Game game, Gamer gamer)
        {
            Console.WriteLine(game.Name+ " oyunu" +gamer.FirstName +" kullanıcısına eklendi.");
        }

        public void Delete(Game game, Gamer gamer)
        {
            Console.WriteLine(game.Name + " oyunu" + gamer.FirstName + " kullanıcısından silindi.");
        }
    }
}
