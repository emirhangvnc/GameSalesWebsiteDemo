using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.CompanyEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.CompanyConcrete
{
    public class DeveloperManager
    {
        public void Add(Developer developer)
        {
            CompanyData.developers.Add(developer);
        }
        public void Update(Developer developer)
        {
            var obj = CompanyData.developers.Where(d => d.Id == developer.Id);
            obj.First().CityId = developer.CityId;
            obj.First().DeveloperName = developer.DeveloperName;
        }
        public void Delete(Developer developer)
        {
            CompanyData.developers.Remove(developer);
        }
    }
}
