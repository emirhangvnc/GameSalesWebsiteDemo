using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.PersonEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.PersonConcrete
{
    public class CriticManager
    {
        public void Add(Critic critic)
        {
            PersonData.critics.Add(critic);
        }

        public void Update(Critic critic)
        {
            var obj = PersonData.critics.Where(c => c.Id == critic.Id);
            obj.First().FirstName = critic.FirstName;
            obj.First().LastName = critic.LastName;
            obj.First().BirthYear = critic.BirthYear;
            obj.First().Image = critic.Image;
        }

        public void Delete(Critic critic)
        {

            PersonData.critics.Remove(critic);
        }
    }
}
