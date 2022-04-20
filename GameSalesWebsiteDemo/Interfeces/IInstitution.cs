using GameSalesWebsiteDemo.Entities.GeneralEntities;

namespace GameSalesWebsiteDemo.Interfeces
{
    public interface IInstitution //Kurum
    {
        public int Id { get; set; }
        public City CityId { get; set; }
    }
}
