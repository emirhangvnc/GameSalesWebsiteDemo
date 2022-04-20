using System.Collections.Generic;
using System.Linq;

namespace GameSalesWebsiteDemo.Entities.GeneralEntities
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public List<City> Cities { get { return Data.GeneralData.cities.Where(x => x.CountryId == this).ToList(); } }
    }
}
