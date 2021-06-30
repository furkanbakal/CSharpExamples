using GameManagementDemo.Abstract;
using GameManagementDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementDemo.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {

        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.FirstName.Equals("Furkan"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
