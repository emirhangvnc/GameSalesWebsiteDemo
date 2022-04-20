using GameSalesWebsiteDemo.Interfeces;
using System;
using System.Windows.Media.Imaging;

namespace GameSalesWebsiteDemo.Entities.PersonEntities
{
    public class Critic:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthYear { get; set; }
        public BitmapImage Image { get; set; }
    }
}
