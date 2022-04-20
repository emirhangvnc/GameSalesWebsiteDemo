using GameSalesWebsiteDemo.Entities.PersonEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;

namespace GameSalesWebsiteDemo.Data
{
    public static class PersonData
    {
        private static IncreaseId increaseId = new IncreaseId();

        #region Id Üretme
        public static int criticsId = 1, gamersId = 1, devEmployeeId = 1;
        #endregion

        #region Listeler
        public static List<Critic> critics = new List<Critic>();
        public static List<Gamer> gamers = new List<Gamer>();
        public static List<DeveloperTeamEmployee> devTeamEmployees = new List<DeveloperTeamEmployee>();
        #endregion

        static PersonData()
        {
            #region Eleştirmen Veri
            critics.Add(new Critic()
            {
                Id = criticsId,
                FirstName = "Temel",
                LastName = "Yüksel",
                BirthYear = new DateTime(1987, 03, 27),
                Image = new BitmapImage(new Uri("/Images/PersonImages/Males/A02.png", UriKind.Relative))
            }); //[0] Temel Yüksel
            increaseId.GeneratingId(ref criticsId);

            critics.Add(new Critic()
            {
                Id = criticsId,
                FirstName = "Aslı",
                LastName = "Ortaşeker",
                BirthYear = new DateTime(1980, 05, 14),
                Image = new BitmapImage(new Uri("/Images/PersonImages/Females/FA02.png", UriKind.Relative))
            }); //[1] Aslı Ortaşeker
            increaseId.GeneratingId(ref criticsId);

            critics.Add(new Critic()
            {
                Id = criticsId,
                FirstName = "Hasan",
                LastName = "Hasanoğlu",
                BirthYear = new DateTime(2000, 01, 13),
                Image = new BitmapImage(new Uri("/Images/PersonImages/Males/A05.png", UriKind.Relative))
            }); //[2] Hasan Hasanoğlu
            increaseId.GeneratingId(ref criticsId);

            critics.Add(new Critic()
            {
                Id = criticsId,
                FirstName = "Cem",
                LastName = "Kısa",
                BirthYear = new DateTime(1990, 06, 23),
                Image = new BitmapImage(new Uri("/Images/PersonImages/Males/G05.png", UriKind.Relative))
            }); //[3] Hasan Hasanoğlu
            increaseId.GeneratingId(ref criticsId);

            critics.Add(new Critic()
            {
                Id = criticsId,
                FirstName = "Zeynep",
                LastName = "Yılmaz",
                BirthYear = new DateTime(1993, 10, 07),
                Image = new BitmapImage(new Uri("/Images/PersonImages/Females/FB01.png", UriKind.Relative))
            }); //[4] Zeynep Yılmaz
            increaseId.GeneratingId(ref criticsId);
            #endregion

            #region Oyuncu Veri

            gamers.Add(new Gamer()
            {
                Id = gamersId,
                FirstName = "Okan",
                LastName = "Buruk",
                NickName = "Son Anda Muslera",
                BirthYear = new DateTime(2000, 04, 25),
                MembershipDate = new DateTime(2017, 04, 19),
                Mail = "okanburuk34@gmail.com",
                Password = "okanburuk",
                Image = new BitmapImage(new Uri("/Images/PersonImages/Males/D05.png", UriKind.Relative))
            });
            increaseId.GeneratingId(ref gamersId);

            gamers.Add(new Gamer()
            {
                Id = gamersId,
                FirstName = "Yağmur",
                LastName = "Koçuk",
                NickName = "Prenses Elena",
                BirthYear = new DateTime(2005, 10, 05),
                MembershipDate = new DateTime(2019, 01, 20),
                Mail = "yagmuruzn43@gmail.com",
                Password = "yagmurkocuk",
                Image = new BitmapImage(new Uri("/Images/PersonImages/Females/FA04.png", UriKind.Relative))
            });
            increaseId.GeneratingId(ref gamersId);

            gamers.Add(new Gamer()
            {
                Id = gamersId,
                FirstName = "Mehmet",
                LastName = "Uzun",
                NickName = "Çıgın Oyuncu",
                BirthYear = new DateTime(2010, 04, 25),
                MembershipDate = new DateTime(2022, 01, 29),
                Mail = "mehmetoyun@gmail.com",
                Password = "mehmetuzun",
                Image = new BitmapImage(new Uri("/Images/PersonImages/Males/C02.png", UriKind.Relative))
            });
            increaseId.GeneratingId(ref gamersId);

            gamers.Add(new Gamer()
            {
                Id = gamersId,
                FirstName = "Ahmet",
                LastName = "Sonuç",
                NickName = "Cahrein",
                BirthYear = new DateTime(1979, 12, 17),
                MembershipDate = new DateTime(2015, 10, 10),
                Mail = "ahmetsonuc64@gmail.com",
                Password = "ahmetsonuc",
                Image = new BitmapImage(new Uri("/Images/PersonImages/Males/H01.png", UriKind.Relative))
            });
            increaseId.GeneratingId(ref gamersId);
            #endregion

            #region Geliştirici Çalışanları
            devTeamEmployees.Add(new DeveloperTeamEmployee()
            {
                Id = devEmployeeId,
                FirstName = "Ali",
                LastName = "Güneş",
                BirthYear = new DateTime(2000, 11, 13),
                Salary = 5000,
                Image = new BitmapImage(new Uri("/Images/PersonImages/Males/N04.png", UriKind.Relative)),
                DeveloperId = CompanyData.developers[0]
            });
            increaseId.GeneratingId(ref devEmployeeId);

            devTeamEmployees.Add(new DeveloperTeamEmployee()
            {
                Id = devEmployeeId,
                FirstName = "Ahmet",
                LastName = "Okuyan",
                BirthYear = new DateTime(1987, 04, 27),
                Salary = 6500,
                Image = new BitmapImage(new Uri("/Images/PersonImages/Males/A05.png", UriKind.Relative)),
                DeveloperId = CompanyData.developers[0]
            });
            increaseId.GeneratingId(ref devEmployeeId);

            devTeamEmployees.Add(new DeveloperTeamEmployee()
            {
                Id = devEmployeeId,
                FirstName = "Ayşe",
                LastName = "Kısa",
                BirthYear = new DateTime(1998, 07, 05),
                Salary = 8200,
                Image = new BitmapImage(new Uri("/Images/PersonImages/Females/FB01.png", UriKind.Relative)),
                DeveloperId = CompanyData.developers[0]
            });
            increaseId.GeneratingId(ref devEmployeeId);

            devTeamEmployees.Add(new DeveloperTeamEmployee()
            {
                Id = devEmployeeId,
                FirstName = "Ecem",
                LastName = "Kiraz",
                BirthYear = new DateTime(1999, 10, 01),
                Salary = 10000,
                Image = new BitmapImage(new Uri("/Images/PersonImages/Males/FH05.png", UriKind.Relative)),
                DeveloperId = CompanyData.developers[0]
            });
            increaseId.GeneratingId(ref devEmployeeId);

            #endregion
        }
    }
}
