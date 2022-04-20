using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.GameEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.GameConcrete
{
    public class PaidGamesManager
    {
        public void Add(PaidGames paidGames)
        {
            GameData.paidGames.Add(paidGames);
        }
        public void Update(PaidGames paidGames)
        {
            var obj = GameData.paidGames.Where(p => p.Id == paidGames.Id);
            for (int i = 0; i < paidGames.CategoryId.Count; i++)
            {
                obj.First().CategoryId[i] = paidGames.CategoryId[i];
            }
            for (int i = 0; i < paidGames.PlatformId.Count; i++)
            {
                obj.First().PlatformId[i] = paidGames.PlatformId[i];
            }

            obj.First().GamePublisherId = paidGames.GamePublisherId;
            for (int i = 0; i < paidGames.DeveloperId.Count; i++)
            {
                obj.First().DeveloperId[i] = paidGames.DeveloperId[i];
            }
            obj.First().GameName = paidGames.GameName;
            obj.First().Price = paidGames.Price;
        }
        public void Delete(PaidGames paidGames)
        {
            GameData.paidGames.Remove(paidGames);
        }
    }
}
