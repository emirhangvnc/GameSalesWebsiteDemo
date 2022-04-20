using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.GameEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.GameConcrete
{
    public class FreeGamesManager
    {
        public void Add(FreeGames freeGames)
        {
            GameData.freeGames.Add(freeGames);
        }
        public void Update(FreeGames freeGames)
        {
            var obj = GameData.freeGames.Where(f => f.Id == freeGames.Id);
            for (int i = 0; i < freeGames.CategoryId.Count; i++)
            {
                obj.First().CategoryId[i] = freeGames.CategoryId[i];
            }
            for (int i = 0; i < freeGames.PlatformId.Count; i++)
            {
                obj.First().PlatformId[i] = freeGames.PlatformId[i];
            }
            obj.First().GamePublisherId = freeGames.GamePublisherId;
            for (int i = 0; i < freeGames.DeveloperId.Count; i++)
            {
                obj.First().DeveloperId[i] = freeGames.DeveloperId[i];
            }
            obj.First().GameName = freeGames.GameName;
        }
        public void Delete(FreeGames freeGames)
        {
            GameData.freeGames.Remove(freeGames);
        }
    }
}
