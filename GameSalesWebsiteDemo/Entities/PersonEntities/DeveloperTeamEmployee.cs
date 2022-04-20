using GameSalesWebsiteDemo.Entities.CompanyEntities;
using GameSalesWebsiteDemo.Interfeces;
using System;
using System.Windows.Media.Imaging;

namespace GameSalesWebsiteDemo.Entities.PersonEntities
{
    public class DeveloperTeamEmployee:IPerson
    {
        public int Id { get; set; }
        public Developer DeveloperId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthYear { get; set; }
        public BitmapImage Image { get; set; }
        public int Salary { get; set; }
    }
}
