using GameSalesWebsiteDemo.Entities.CompanyEntities;
using GameSalesWebsiteDemo.Entities.GameEntities;
using GameSalesWebsiteDemo.Entities.GeneralEntities;
using GameSalesWebsiteDemo.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesWebsiteDemo.Data
{
    public static class GameData
    {
        public static IncreaseId increaseId = new IncreaseId();

        #region Id Üretme
        public static int paidGameId = 1, freeGameId = 1, freeEarlyGamesId = 1, paidEarlyGamesId = 1, upComingGamesId = 1;
        #endregion

        #region Listeler
        public static List<PaidGames> paidGames = new List<PaidGames>();
        public static List<FreeGames> freeGames = new List<FreeGames>();

        public static List<FreeEarlyAccessGames> freeEarlyAccessGames = new List<FreeEarlyAccessGames>();
        public static List<PaidEarlyAccessGames> paidEarlyAccessGames = new List<PaidEarlyAccessGames>();
        public static List<UpComingGames> upComingGames = new List<UpComingGames>();
        #endregion

        static GameData()
        {
            #region Çıkmış Ücretli Oyunlar
            //paidGames.Add(new PaidGames()
            //{
            //    Id = paidGameId,
            //    GameName = "ÜcretsizOyunŞablon",
            //    CategoryId = new List<Category> { GameUsedData.categories[0], GameUsedData.categories[1] },
            //    DeveloperId = new List<Developer> { CompanyData.developers[0], CompanyData.developers[1] },
            //    GamePublisherId = CompanyData.gamePublishers[0],
            //    PlatformId = new List<IPlatform> { PlatformData.personalComputers[0] },//Birden Çok Platforma Çıkacaksa new List<>{}
            //    Price = 20
            //});
            //increaseId.GeneratingId(ref paidGameId);
            #endregion

            #region Çıkmış Ücretsiz Oyunlar
            //freeGames.Add(new FreeGames()
            //{
            //    Id = freeGameId,
            //    GameName = "ÜcretsizOyunŞablon",
            //    CategoryId = new List<Category> { GameUsedData.categories[0], GameUsedData.categories[1] },
            //    DeveloperId = new List<Developer> { CompanyData.developers[0], CompanyData.developers[1] },
            //    GamePublisherId = CompanyData.gamePublishers[0],
            //    PlatformId = new List<IPlatform> { PlatformData.personalComputers[0] },
            //});
            //increaseId.GeneratingId(ref freeGameId);
            #endregion

            #region Erken Erişim Ücretsiz Oyunlar
            //freeEarlyAccessGames.Add(new FreeEarlyAccessGames()
            //{
            //    Id = freeEarlyGamesId,
            //    GameName = "ErkenErişimÜcretsizŞablon",
            //    CategoryId = new List<Category> { GameUsedData.categories[0], GameUsedData.categories[1] },
            //    DeveloperId = new List<Developer> { CompanyData.developers[0], CompanyData.developers[1] },
            //    GamePublisherId = CompanyData.gamePublishers[0],
            //    PlatformId = new List<IPlatform> { PlatformData.personalComputers[0] },
            //    ReleaseDate = new DateTime(2023, 01, 01)
            //});
            //increaseId.GeneratingId(ref freeEarlyGamesId);
            #endregion

            #region Erken Erişim Ücretli Oyunlar
            //paidEarlyAccessGames.Add(new PaidEarlyAccessGames()
            //{
            //    Id = paidEarlyGamesId,
            //    GameName = "ErkenErişimÜcretsizŞablon",
            //    CategoryId = new List<Category> { GameUsedData.categories[0], GameUsedData.categories[1] },
            //    DeveloperId = new List<Developer> { CompanyData.developers[0], CompanyData.developers[1] },
            //    GamePublisherId = CompanyData.gamePublishers[0],
            //    PlatformId = new List<IPlatform> { PlatformData.personalComputers[0] },
            //    ReleaseDate = new DateTime(2023, 01, 01),
            //    Price = 25
            //});
            //increaseId.GeneratingId(ref paidEarlyGamesId);
            #endregion

            #region Yakında Çıkacak Oyunlar
            //upComingGames.Add(new UpComingGames()
            //{
            //    Id = upComingGamesId,
            //    GameName = "YakındaÇıkacakOyunlar",
            //    CategoryId = new List<Category> { GameUsedData.categories[0], GameUsedData.categories[1] },
            //    DeveloperId = new List<Developer> { CompanyData.developers[0], CompanyData.developers[1] },
            //    GamePublisherId = CompanyData.gamePublishers[0],
            //    PlatformId = new List<IPlatform> { PlatformData.personalComputers[0] },
            //});
            //increaseId.GeneratingId(ref upComingGamesId);
            #endregion
        }
    }
}
