using GameSalesWebsiteDemo.Entities.CompanyEntities;
using GameSalesWebsiteDemo.Entities.GeneralEntities;
using System.Collections.Generic;

namespace GameSalesWebsiteDemo.Interfeces
{
    public interface IGame
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public List<Category> CategoryId { get; set; }
        public List<IPlatform> PlatformId { get; set; }
        public GamePublisher GamePublisherId { get; set; }
        public List<Developer> DeveloperId { get; set; }
    }
}
