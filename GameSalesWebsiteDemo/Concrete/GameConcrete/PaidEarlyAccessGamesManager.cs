using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.GameEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.GameConcrete
{
    public class PaidEarlyAccessGamesManager
    {
        public void Add(PaidEarlyAccessGames paidGames)
        {
            GameData.paidEarlyAccessGames.Add(paidGames);
        }
        public void Update(PaidEarlyAccessGames paidEarlyAccess)
        {
            var obj = GameData.paidEarlyAccessGames.Where(p => p.Id == paidEarlyAccess.Id);
            for (int i = 0; i < paidEarlyAccess.CategoryId.Count; i++)
            {
                obj.First().CategoryId[i] = paidEarlyAccess.CategoryId[i];
            }
            for (int i = 0; i < paidEarlyAccess.PlatformId.Count; i++)
            {
                obj.First().PlatformId[i] = paidEarlyAccess.PlatformId[i];
            }
            obj.First().GamePublisherId = paidEarlyAccess.GamePublisherId;
            for (int i = 0; i < paidEarlyAccess.DeveloperId.Count; i++)
            {
                obj.First().DeveloperId[i] = paidEarlyAccess.DeveloperId[i];
            }
            obj.First().GameName = paidEarlyAccess.GameName;
            obj.First().Price = paidEarlyAccess.Price;
            obj.First().ReleaseDate = paidEarlyAccess.ReleaseDate;
        }
        public void Delete(PaidEarlyAccessGames paidEarlyAccess)
        {
            GameData.paidEarlyAccessGames.Remove(paidEarlyAccess);
        }
    }
}
