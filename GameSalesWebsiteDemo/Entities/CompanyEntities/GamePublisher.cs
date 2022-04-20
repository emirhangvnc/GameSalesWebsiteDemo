using GameSalesWebsiteDemo.Entities.GeneralEntities;
using GameSalesWebsiteDemo.Interfeces;

namespace GameSalesWebsiteDemo.Entities.CompanyEntities
{
    public class GamePublisher : IInstitution //Yayıncı
    {
        public int Id { get; set; }
        public City CityId { get; set; }
        public string PublisherName { get; set; }
    }
}
