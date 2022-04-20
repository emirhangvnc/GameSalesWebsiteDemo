using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.PlatformEntities;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.PlatformConcrete
{
    public class ConsolePlatformManager
    {
        public IncreaseId increase = new IncreaseId();
        public void Add(ConsolePlatform consolePlatform)
        {
            PlatformData.consoles.Add(consolePlatform);
            increase.GeneratingId(ref PlatformData.consoleId);
        }
        public void Update(ConsolePlatform consolePlatform)
        {
            var obj = PlatformData.consoles.Where(p => p.Id == consolePlatform.Id);
            obj.First().Id = consolePlatform.Id;
            obj.First().ConsoleName = consolePlatform.ConsoleName;
            for (int i = 0; i < consolePlatform.PlatformId.Count; i++)
            {
                obj.First().PlatformId[i] = consolePlatform.PlatformId[i];
            }
        }
        public void Delete(ConsolePlatform consolePlatform)
        {
            PlatformData.consoles.Remove(consolePlatform);
        }
    }
}
