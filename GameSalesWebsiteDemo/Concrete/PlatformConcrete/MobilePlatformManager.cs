using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.PlatformEntities;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.PlatformConcrete
{
    public class MobilePlatformManager
    {
        public IncreaseId increase = new IncreaseId();
        public void Add(MobilePlatform mobilePlatform)
        {
            PlatformData.mobiles.Add(mobilePlatform);
            increase.GeneratingId(ref PlatformData.mobileId);
        }
        public void Update(MobilePlatform mobilePlatform)
        {
            var obj = PlatformData.mobiles.Where(p => p.Id == mobilePlatform.Id);
            obj.First().Id = mobilePlatform.Id;
            obj.First().MobilOSName = mobilePlatform.MobilOSName;
            for (int i = 0; i < mobilePlatform.PlatformId.Count; i++)
            {
                obj.First().PlatformId[i] = mobilePlatform.PlatformId[i];
            }
        }
        public void Delete(MobilePlatform mobilePlatform)
        {
            PlatformData.mobiles.Remove(mobilePlatform);
        }
    }
}
