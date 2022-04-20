using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.CompanyEntities;
using System.Linq;
using System;

namespace GameSalesWebsiteDemo.Concrete.CompanyConcrete
{
    public class GamePublisherManager
    {
        public void Add(GamePublisher gamePublisher)
        {
            CompanyData.gamePublishers.Add(gamePublisher);
        }
        public void Update(GamePublisher gamePublisher)
        {
            var obj = CompanyData.gamePublishers.Where(d => d.Id == gamePublisher.Id);
            obj.First().CityId = gamePublisher.CityId;
            obj.First().PublisherName = gamePublisher.PublisherName;
        }
        public void Delete(GamePublisher gamePublisher)
        {
            CompanyData.gamePublishers.Remove(gamePublisher);
        }
    }
}
