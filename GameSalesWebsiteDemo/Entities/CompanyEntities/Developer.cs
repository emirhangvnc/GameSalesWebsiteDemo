using System.Collections.Generic;
using System.Linq;
using GameSalesWebsiteDemo.Interfeces;
using GameSalesWebsiteDemo.Entities.GeneralEntities;
using GameSalesWebsiteDemo.Entities.PersonEntities;

namespace GameSalesWebsiteDemo.Entities.CompanyEntities
{
    public class Developer : IInstitution //Geliştiricisi
    {
        public int Id { get; set; }
        public City CityId { get; set; }
        public string DeveloperName { get; set; }
        public List<DeveloperTeamEmployee> EmployeesId { get { return Data.PersonData.devTeamEmployees.Where(x => x.DeveloperId == this).ToList(); } }
    }
}
