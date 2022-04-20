using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.GameEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.GameConcrete
{
    public class UpComingGamesManager
    {
        public void Add(UpComingGames upComingGame)
        {
            GameData.upComingGames.Add(upComingGame);
            GameData.increaseId.GeneratingId(ref GameData.upComingGamesId);
        }

        public void Update(UpComingGames upComingGame)
        {
            var obj = GameData.paidEarlyAccessGames.Where(p => p.Id == upComingGame.Id);
            for (int i = 0; i < upComingGame.CategoryId.Count; i++)
            {
                obj.First().CategoryId[i] = upComingGame.CategoryId[i];
            }
            for (int i = 0; i < upComingGame.PlatformId.Count; i++)
            {
                obj.First().PlatformId[i] = upComingGame.PlatformId[i];
            }
            obj.First().GamePublisherId = upComingGame.GamePublisherId;
            for (int i = 0; i < upComingGame.DeveloperId.Count; i++)
            {
                obj.First().DeveloperId[i] = upComingGame.DeveloperId[i];
            }
            obj.First().GameName = upComingGame.GameName;
        }
        public void Delete(UpComingGames upComingGame)
        {
            GameData.upComingGames.Remove(upComingGame);
        }
    }
}
