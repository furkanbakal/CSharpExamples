using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManagementDemo.Entity
{
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }
        public DateTime CampaignTime { get; set; }
    }
}
