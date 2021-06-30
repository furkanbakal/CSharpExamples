using GameManagementDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementDemo.Abstract
{
    public interface IGameService
    {
        void Add(Game game, Gamer gamer);
        void Delete(Game game, Gamer gamer);
    }
}
