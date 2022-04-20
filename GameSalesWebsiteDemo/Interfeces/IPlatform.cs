using GameSalesWebsiteDemo.Entities.GeneralEntities;
using System.Collections.Generic;

namespace GameSalesWebsiteDemo.Interfeces
{
    public interface IPlatform
    {
        public int Id { get; set; }
        public List<Platforms> PlatformId { get; set; }
    }
}
