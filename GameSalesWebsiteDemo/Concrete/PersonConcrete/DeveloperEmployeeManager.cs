using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.PersonEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.PersonConcrete
{
    public class DeveloperEmployeeManager
    {
        public void Add(DeveloperTeamEmployee teamEmployee)
        {
            PersonData.devTeamEmployees.Add(teamEmployee);
        }
        public void Update(DeveloperTeamEmployee teamEmployee)
        {
            var obj = PersonData.devTeamEmployees.Where(t => t.Id == teamEmployee.Id);
            obj.First().DeveloperId = teamEmployee.DeveloperId;
            obj.First().FirstName = teamEmployee.FirstName;
            obj.First().LastName = teamEmployee.LastName;
            obj.First().BirthYear = teamEmployee.BirthYear;
            obj.First().Image = teamEmployee.Image;
            obj.First().Salary = teamEmployee.Salary;
        }
        public void Delete(DeveloperTeamEmployee teamEmployee)
        {
            PersonData.devTeamEmployees.Remove(teamEmployee);
        }
    }
}
