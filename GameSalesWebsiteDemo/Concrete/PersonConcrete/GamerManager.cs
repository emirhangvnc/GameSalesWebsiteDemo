using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.PersonEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.PersonConcrete
{
    public class GamerManager
    {
        public void Add(Gamer gamer)
        {
            PersonData.gamers.Add(gamer);
        }
        public void Update(Gamer gamer)
        {
            var obj = PersonData.gamers.Where(c => c.Id == gamer.Id);
            obj.First().FirstName = gamer.FirstName;
            obj.First().LastName = gamer.LastName;
            obj.First().BirthYear = gamer.BirthYear;
            obj.First().Image = gamer.Image;
            obj.First().Mail = gamer.Mail;
            obj.First().MembershipDate = gamer.MembershipDate;
            obj.First().NickName = gamer.NickName;
            obj.First().Password = gamer.Password;
        }
        public void Delete(Gamer gamer)
        {
            PersonData.gamers.Remove(gamer);
        }
    }
}
