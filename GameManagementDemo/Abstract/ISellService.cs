using GameManagementDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementDemo.Abstract
{
    public interface ISellService
    {
        void Selling(Gamer gamer, Game game);
        void SellingByCampaign(Gamer gamer, Game game, Campaign campaign);
    }
}
