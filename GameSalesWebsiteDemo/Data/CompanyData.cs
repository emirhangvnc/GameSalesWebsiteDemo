using GameSalesWebsiteDemo.Entities.CompanyEntities;
using System;
using System.Collections.Generic;

namespace GameSalesWebsiteDemo.Data
{
    public static class CompanyData
    {
        private static IncreaseId increaseId = new IncreaseId();

        #region Id Üretme
        public static int developerId = 1, gamePublisherId = 1;
        #endregion

        #region Listeler
        public static List<Developer> developers = new List<Developer>();
        public static List<GamePublisher> gamePublishers = new List<GamePublisher>();
        #endregion

        static CompanyData()
        {
            #region Yayıncı
            gamePublishers.Add(new GamePublisher()
            {
                Id = gamePublisherId,
                PublisherName = "Nintendo",
                CityId = GeneralData.cities[0]
            }); //[0] Nintendo 0
            increaseId.GeneratingId(ref gamePublisherId);

            gamePublishers.Add(new GamePublisher()
            {
                Id = gamePublisherId,
                PublisherName = "Bandai/Namco",
                CityId = GeneralData.cities[1]
            }); //[1] Bandai/Namco 1
            increaseId.GeneratingId(ref gamePublisherId);

            gamePublishers.Add(new GamePublisher()
            {
                Id = gamePublisherId,
                PublisherName = "Sony",
                CityId = GeneralData.cities[2]
            });//[2] Sony 2
            increaseId.GeneratingId(ref gamePublisherId);

            gamePublishers.Add(new GamePublisher()
            {
                Id = gamePublisherId,
                PublisherName = "Electronic Arts",
                CityId = GeneralData.cities[3]
            });//[3] EA 3
            increaseId.GeneratingId(ref gamePublisherId);

            gamePublishers.Add(new GamePublisher()
            {
                Id = gamePublisherId,
                PublisherName = "Activis ion Blizzard",
                CityId = GeneralData.cities[3]
            }); //[4] Blizzard 4
            increaseId.GeneratingId(ref gamePublisherId);

            gamePublishers.Add(new GamePublisher()
            {
                Id = gamePublisherId,
                PublisherName = "Microsoft",
                CityId = GeneralData.cities[3]
            }); //[5] Microsoft 3
            increaseId.GeneratingId(ref gamePublisherId);

            gamePublishers.Add(new GamePublisher()
            {
                Id = gamePublisherId,
                PublisherName = "Tencent Games",
                CityId = GeneralData.cities[7]
            }); //[6] Tencent 7
            increaseId.GeneratingId(ref gamePublisherId);

            gamePublishers.Add(new GamePublisher()
            {
                Id = gamePublisherId,
                PublisherName = "Ubisoft",
                CityId = GeneralData.cities[10]
            }); //[7] Ubisoft 10
            increaseId.GeneratingId(ref gamePublisherId);

            gamePublishers.Add(new GamePublisher()
            {
                Id = gamePublisherId,
                PublisherName = "Capcom",
                CityId = GeneralData.cities[0]
            }); //[8] Capcom 0
            increaseId.GeneratingId(ref gamePublisherId);

            gamePublishers.Add(new GamePublisher()
            {
                Id = gamePublisherId,
                PublisherName = "Sega",
                CityId = GeneralData.cities[1]
            }); //[9] Sega 1
            increaseId.GeneratingId(ref gamePublisherId);

            gamePublishers.Add(new GamePublisher()
            {
                Id = gamePublisherId,
                PublisherName = "Peak Games",
                CityId = GeneralData.cities[12]
            }); //[10] Peak 12
            increaseId.GeneratingId(ref gamePublisherId);
            #endregion

            #region Geliştirici

            #region Ana Firma gelişriricileri
            developers.Add(new Developer()
            {
                Id = developerId,
                DeveloperName = "Nintendo",
                CityId = GeneralData.cities[0]
            }); //[0]Nintendo(Geliştirici Olarak)
            increaseId.GeneratingId(ref developerId);

            developers.Add(new Developer()
            {
                Id = developerId,
                DeveloperName = "Bandai/Namco",
                CityId = GeneralData.cities[1]
            }); //[1]Bandai/Namco(Geliştirici Olarak)
            increaseId.GeneratingId(ref developerId);

            developers.Add(new Developer()
            {
                Id = developerId,
                DeveloperName = "Sony",
                CityId = GeneralData.cities[2]
            }); //[2]Sony(Geliştirici Olarak)
            increaseId.GeneratingId(ref developerId);

            developers.Add(new Developer()
            {
                Id = developerId,
                DeveloperName = "Electronic Arts",
                CityId = GeneralData.cities[3]
            }); //[3]Electronic Arts(Geliştirici Olarak)
            increaseId.GeneratingId(ref developerId);

            developers.Add(new Developer()
            {
                Id = developerId,
                DeveloperName = "Blizzard",
                CityId = GeneralData.cities[4]
            }); //[4]Blizzard(Geliştirici Olarak)
            increaseId.GeneratingId(ref developerId);

            developers.Add(new Developer()
            {
                Id = developerId,
                DeveloperName = "Microsoft",
                CityId = GeneralData.cities[3]
            }); //[5]Microsoft(Geliştirici Olarak)
            increaseId.GeneratingId(ref developerId);

            developers.Add(new Developer()
            {
                Id = developerId,
                DeveloperName = "Tencent",
                CityId = GeneralData.cities[7]
            }); //[6]Tencent(Geliştirici Olarak)
            increaseId.GeneratingId(ref developerId);

            developers.Add(new Developer()
            {
                Id = developerId,
                DeveloperName = "Ubisoft",
                CityId = GeneralData.cities[10]
            }); //[7]Ubisoft(Geliştirici Olarak)
            increaseId.GeneratingId(ref developerId);

            developers.Add(new Developer()
            {
                Id = developerId,
                DeveloperName = "Capcom",
                CityId = GeneralData.cities[0]
            }); //[8]Capcom(Geliştirici Olarak)
            increaseId.GeneratingId(ref developerId);

            developers.Add(new Developer()
            {
                Id = developerId,
                DeveloperName = "Sega",
                CityId = GeneralData.cities[1]
            }); //[9]Sega(Geliştirici Olarak)
            increaseId.GeneratingId(ref developerId);

            developers.Add(new Developer()
            {
                Id = developerId,
                DeveloperName = "Peak",
                CityId = GeneralData.cities[12]
            }); //[10]Peak(Geliştirici Olarak)
            increaseId.GeneratingId(ref developerId);

            #endregion

            #region Alt Şirket Geliştiricileri

            #endregion
            #endregion
        }
    }
}
