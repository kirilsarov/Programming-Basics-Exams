using System;

namespace CharityCampaign
{
    class CharityCampaign
    {
        static void Main(string[] args)
        {
            var campaigneDays = int.Parse(Console.ReadLine());
            var shefs = int.Parse(Console.ReadLine());
            var cackes = int.Parse(Console.ReadLine());
            var wafers = int.Parse(Console.ReadLine());
            var pancackes = int.Parse(Console.ReadLine());
            var cackesProfit = cackes * 45;
            var wafersProfit = wafers * 5.80;
            var pancackesProfit = pancackes * 3.20;
            var allProfit = (cackesProfit + wafersProfit + pancackesProfit) * shefs;
            var allProfitCampaigne = allProfit * campaigneDays;
            var costs = 0.125 * allProfitCampaigne;
            var result = allProfitCampaigne - costs;
            Console.WriteLine($"{result:f2}");
        }
    }
}
