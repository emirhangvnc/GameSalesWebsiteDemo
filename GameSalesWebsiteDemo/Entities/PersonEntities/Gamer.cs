using GameSalesWebsiteDemo.Interfeces;
using System;
using System.Windows.Media.Imaging;

namespace GameSalesWebsiteDemo.Entities.PersonEntities
{
    public class Gamer:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime BirthYear { get; set; }
        public DateTime MembershipDate { get; set; }
        public BitmapImage Image { get; set; }
    }
}
