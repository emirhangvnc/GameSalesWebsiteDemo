using GameSalesWebsiteDemo.Entities.GeneralEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesWebsiteDemo.Data
{
    public static class GeneralData
    {
        private static IncreaseId increaseId = new IncreaseId();

        #region Id Üretme
        public static int countryId = 1, cityId = 1;
        #endregion

        #region Listeler
        public static List<City> cities = new List<City>();
        public static List<Country> countries = new List<Country>();
        #endregion

        static GeneralData()
        {
            //[0]=Japonya
            //[1]=Amerika
            //[2]=Çin
            //[3]=Freansa
            //[4]=Turkey
            //[5]=boş
            #region Ülkeler
            countries.Add(new Country()
            {
                Id = countryId,
                CountryName = "JAPAN"
            });
            increaseId.GeneratingId(ref countryId);

            countries.Add(new Country()
            {
                Id = countryId,
                CountryName = "UNİTED STATES OF AMERICA"
            });
            increaseId.GeneratingId(ref countryId);

            countries.Add(new Country()
            {
                Id = countryId,
                CountryName = "CHINA"
            });
            increaseId.GeneratingId(ref countryId);

            countries.Add(new Country()
            {
                Id = countryId,
                CountryName = "FRANCE"
            });
            increaseId.GeneratingId(ref countryId);

            countries.Add(new Country()
            {
                Id = countryId,
                CountryName = "TURKEY"
            });
            increaseId.GeneratingId(ref countryId);
            #endregion //

            //[0]-[2] Japonya
            //[3]-[6] Amerika
            //[7]-[9] Çin
            //[10]-[11] Fransa
            //[12] Türkiye
            #region Şehirler

            #region Japonya Şehirleri 3 tane
            cities.Add(new City()
            {
                Id = cityId,
                CityName = "TOKYO",
                CountryId = GeneralData.countries[0]
            });
            increaseId.GeneratingId(ref cityId);

            cities.Add(new City()
            {
                Id = cityId,
                CityName = "KYOTO",
                CountryId = GeneralData.countries[0]
            });
            increaseId.GeneratingId(ref cityId);

            cities.Add(new City()
            {
                Id = cityId,
                CityName = "OSAKA",
                CountryId = GeneralData.countries[0]
            });
            increaseId.GeneratingId(ref cityId);
            #endregion

            #region Amerikanın Şehirleri 4 tane
            cities.Add(new City()
            {
                Id = cityId,
                CityName = "SAN FRANCISCO",
                CountryId = GeneralData.countries[1]
            });
            increaseId.GeneratingId(ref cityId);

            cities.Add(new City()
            {
                Id = cityId,
                CityName = "LOS ANGELES",
                CountryId = GeneralData.countries[1]
            });
            increaseId.GeneratingId(ref cityId);

            cities.Add(new City()
            {
                Id = cityId,
                CityName = "CALIFORNIA",
                CountryId = GeneralData.countries[1]
            });
            increaseId.GeneratingId(ref cityId);

            cities.Add(new City()
            {
                Id = cityId,
                CityName = "TEKSAS",
                CountryId = Data.GeneralData.countries[1]
            });
            increaseId.GeneratingId(ref cityId);
            #endregion

            #region Çin Şehirleri 3 tane
            cities.Add(new City()
            {
                Id = cityId,
                CityName = "PEKIN",
                CountryId = GeneralData.countries[2]
            });
            increaseId.GeneratingId(ref cityId);

            cities.Add(new City()
            {
                Id = cityId,
                CityName = "GUANGZHOU",
                CountryId = GeneralData.countries[2]
            });
            increaseId.GeneratingId(ref cityId);

            cities.Add(new City()
            {
                Id = cityId,
                CityName = "VUHAN",
                CountryId = GeneralData.countries[2]
            });
            increaseId.GeneratingId(ref cityId);
            #endregion

            #region Fransa Şehirleri 2 tane
            cities.Add(new City()
            {
                Id = cityId,
                CityName = "PARIS",
                CountryId = GeneralData.countries[3]
            });
            increaseId.GeneratingId(ref cityId);

            cities.Add(new City()
            {
                Id = cityId,
                CityName = "MARSILYA",
                CountryId = GeneralData.countries[3]
            });
            increaseId.GeneratingId(ref cityId);
            #endregion

            #region Türkiye Şehirleri 1 tane
            cities.Add(new City()
            {
                Id = cityId,
                CityName = "ISTANBUL",
                CountryId = GeneralData.countries[4]
            });
            increaseId.GeneratingId(ref cityId);
            #endregion
            #endregion
        }
    }
}
