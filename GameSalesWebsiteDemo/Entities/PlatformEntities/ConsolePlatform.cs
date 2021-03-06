using GameSalesWebsiteDemo.Entities.GeneralEntities;
using GameSalesWebsiteDemo.Interfeces;
using System.Collections.Generic;

namespace GameSalesWebsiteDemo.Entities.PlatformEntities
{
    public class ConsolePlatform:IPlatform
    {
        public string ConsoleName { get; set; }
        public int Id { get; set; }
        public List<Platforms> PlatformId { get; set; }
    }
}
