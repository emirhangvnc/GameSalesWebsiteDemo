using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.GeneralEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.GeneralConcrete
{
    public class CountryManager
    {
        public void Add(Country country)
        {
            GeneralData.countries.Add(country);
        }
        public void Update(Country country)
        {
            var obj = GeneralData.countries.Where(c => c.Id == country.Id);
            obj.First().CountryName = country.CountryName;
        }
        public void Delete(Country country)
        {
            GeneralData.countries.Remove(country);
        }
    }
}
