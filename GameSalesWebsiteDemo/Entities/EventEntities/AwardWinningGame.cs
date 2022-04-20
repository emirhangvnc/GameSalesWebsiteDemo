using GameSalesWebsiteDemo.Interfeces;

namespace GameSalesWebsiteDemo.Entities.EventEntities
{
    public class AwardWinningGame
    {
        public int Id { get; set; }
        public string AwardName { get; set; }
        public string Company { get; set; }
        public IGame Game { get; set; }
    }
}
