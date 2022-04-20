using GameSalesWebsiteDemo.Entities.EventEntities;
using System;
using System.Collections.Generic;

namespace GameSalesWebsiteDemo.Data
{
    public static class EventData
    {
        private static IncreaseId increaseId = new IncreaseId();

        #region Id Üretme
        public static int criticizedGameId = 1, AwaradId = 1;
        #endregion

        #region Listeler
        public static List<CriticizedGame> criticizedGames = new List<CriticizedGame>();
        public static List<AwardWinningGame> awardWinningGames = new List<AwardWinningGame>();
        #endregion

        static EventData()
        {
            #region Eleştirilen Oyunlar
            criticizedGames.Add(new CriticizedGame()
            {
                Id = criticizedGameId,
                CriticId = PersonData.critics[0],
                Game = GameData.freeEarlyAccessGames[0],
                Point = 87,
                CritiqueTitle = "Harika Bir Oyun",
                CritiqueWrite = "Kesinlikle Oynayın"
            });
            increaseId.GeneratingId(ref criticizedGameId);
            #endregion

            #region Ödül Alan Oyunlar
            awardWinningGames.Add(new AwardWinningGame()
            {
                Id = AwaradId,
                AwardName = "Altın Portakal",
                Company = "dersim",
                Game = GameData.freeGames[0]
            });
            increaseId.GeneratingId(ref AwaradId);
            #endregion
        }
    }
}
