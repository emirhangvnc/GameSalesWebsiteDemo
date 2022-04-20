using GameSalesWebsiteDemo.Entities.PersonEntities;
using GameSalesWebsiteDemo.Interfeces;

namespace GameSalesWebsiteDemo.Entities.EventEntities
{
    public class CriticizedGame : IRating
    {
        public int Id { get; set; }
        public Critic CriticId { get; set; }
        public IGame Game { get; set; }
        public int Point { get; set; }
        public string CritiqueTitle { get; set; }
        public string CritiqueWrite { get; set; }
    }

}
