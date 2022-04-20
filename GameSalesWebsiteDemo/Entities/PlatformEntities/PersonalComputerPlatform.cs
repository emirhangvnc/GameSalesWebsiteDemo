using GameSalesWebsiteDemo.Entities.GeneralEntities;
using GameSalesWebsiteDemo.Interfeces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesWebsiteDemo.Entities.PlatformEntities
{
    public class PersonalComputerPlatform:IPlatform
    {
        public int Id { get; set; }
        public List<Platforms> PlatformId { get ; set; }
        public string PCOSName { get; set; }
    }
}
