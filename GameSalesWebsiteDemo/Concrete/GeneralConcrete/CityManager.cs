using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.GeneralEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.GeneralConcrete
{
    public class CityManager
    {
        public IncreaseId increaseId = new IncreaseId();
        public void Add(City city)
        {
            city.Id = GeneralData.cityId;
            increaseId.GeneratingId(ref GeneralData.cityId);
            GeneralData.cities.Add(city);
        }
        public void Update(City city)
        {
            var obj = GeneralData.cities.Where(c => c.Id == city.Id);
            obj.First().CityName = city.CityName;
            obj.First().CountryId = city.CountryId;
        }
        public void Delete(City city)
        {
            GeneralData.cities.Remove(city);
        }
    }
}
