
namespace GameSalesWebsiteDemo.Entities.GeneralEntities
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public Country CountryId { get; set; }
    }
}
