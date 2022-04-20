using GameSalesWebsiteDemo.Entities.GeneralEntities;
using GameSalesWebsiteDemo.Entities.PlatformEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesWebsiteDemo.Data
{
    public static class PlatformData
    {
        public static IncreaseId increaseId = new IncreaseId();

        public static int platformId = 1, PCId = 1, consoleId = 1, mobileId = 1;

        #region Listeler
        public static List<Platforms> platforms = new List<Platforms>();
        public static List<ConsolePlatform> consoles = new List<ConsolePlatform>();
        public static List<PersonalComputerPlatform> personalComputers = new List<PersonalComputerPlatform>();
        public static List<MobilePlatform> mobiles = new List<MobilePlatform>();

        #endregion

        static PlatformData()
        {
            #region Platform [0]=Pc --- [1]=Console --- [2]=Mobile
            platforms.Add(new Platforms()
            {
                Id = platformId,
                PlatformName = "Personal Computer"
            });
            increaseId.GeneratingId(ref platformId);

            platforms.Add(new Platforms()
            {
                Id = platformId,
                PlatformName = "Console"
            });
            increaseId.GeneratingId(ref platformId);

            platforms.Add(new Platforms()
            {
                Id = platformId,
                PlatformName = "Mobile"
            });
            increaseId.GeneratingId(ref platformId);
            #endregion

            #region PC
            personalComputers.Add(new PersonalComputerPlatform()
            {
                Id = PCId,
                PCOSName = "Windows",
                PlatformId = new List<Platforms> {platforms[0] }
            });
            increaseId.GeneratingId(ref PCId);

            personalComputers.Add(new PersonalComputerPlatform()
            {
                PCOSName = "MacOS",
                PlatformId = new List<Platforms> { platforms[0] }
            });
            increaseId.GeneratingId(ref PCId);
            #endregion

            #region Console
            consoles.Add(new ConsolePlatform()
            {
                Id = consoleId,
                ConsoleName = "Play Station",
                PlatformId = new List<Platforms> { platforms[1] }
            });
            increaseId.GeneratingId(ref consoleId);

            consoles.Add(new ConsolePlatform()
            {
                Id = consoleId,
                ConsoleName = "Nintendo",
                PlatformId = new List<Platforms> { platforms[1] }
            });
            increaseId.GeneratingId(ref consoleId);
            #endregion

            #region Mobile
            mobiles.Add(new MobilePlatform()
            {
                Id = mobileId,
                MobilOSName = "Android",
                PlatformId = new List<Platforms> { platforms[2] }
            });
            increaseId.GeneratingId(ref mobileId);

            mobiles.Add(new MobilePlatform()
            {
                Id = mobileId,
                MobilOSName = "IOS",
                PlatformId = new List<Platforms> { platforms[2] }
            });
            increaseId.GeneratingId(ref mobileId);
            #endregion
        }
    }
}
