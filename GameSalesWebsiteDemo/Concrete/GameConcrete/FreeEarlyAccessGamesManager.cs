using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.GameEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.GameConcrete
{
    public class FreeEarlyAccessGamesManager
    {
        public void Add(FreeEarlyAccessGames freeEarlyAccess)
        {
            GameData.freeEarlyAccessGames.Add(freeEarlyAccess);
        }
        public void Update(FreeEarlyAccessGames freeEarlyAccess)
        {
            var obj = GameData.freeEarlyAccessGames.Where(f => f.Id == freeEarlyAccess.Id);
            for (int i = 0; i < freeEarlyAccess.CategoryId.Count; i++)
            {
                obj.First().CategoryId[i] = freeEarlyAccess.CategoryId[i];
            }
            for (int i = 0; i < freeEarlyAccess.PlatformId.Count; i++)
            {
                obj.First().PlatformId[i] = freeEarlyAccess.PlatformId[i];
            }
            obj.First().GamePublisherId = freeEarlyAccess.GamePublisherId;
            for (int i = 0; i < freeEarlyAccess.DeveloperId.Count; i++)
            {
                obj.First().DeveloperId[i] = freeEarlyAccess.DeveloperId[i];
            }
            obj.First().GameName = freeEarlyAccess.GameName;
            obj.First().ReleaseDate = freeEarlyAccess.ReleaseDate;

        }
        public void Delete(FreeEarlyAccessGames freeEarlyAccess)
        {
            GameData.freeEarlyAccessGames.Remove(freeEarlyAccess);
        }
    }
}
