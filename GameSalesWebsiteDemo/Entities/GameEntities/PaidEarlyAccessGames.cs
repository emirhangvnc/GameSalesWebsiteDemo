﻿using GameSalesWebsiteDemo.Entities.CompanyEntities;
using GameSalesWebsiteDemo.Entities.GeneralEntities;
using GameSalesWebsiteDemo.Interfeces;
using System;
using System.Collections.Generic;

namespace GameSalesWebsiteDemo.Entities.GameEntities
{
    public class PaidEarlyAccessGames : IGame, IEarlyAccessGamesService, IPaidGame
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public List<Category> CategoryId { get; set; }
        public List<IPlatform> PlatformId { get; set; }
        public GamePublisher GamePublisherId { get; set; }
        public List<Developer> DeveloperId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Price { get; set; }
    }
}
