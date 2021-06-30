using GameManagementDemo.Abstract;
using GameManagementDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementDemo.Concrete
{
    class SellManager : ISellService
    {
        public void Selling(Gamer gamer, Game game)
        {
            Console.WriteLine(game.Name+" "+gamer.FirstName+ " oyuncusuna satıldı.");
        }

        public void SellingByCampaign(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignId+ " kampanyalı oyun "+ game.Name + " " + gamer.FirstName + " oyuncusuna satıldı.");
        }
    }
}
