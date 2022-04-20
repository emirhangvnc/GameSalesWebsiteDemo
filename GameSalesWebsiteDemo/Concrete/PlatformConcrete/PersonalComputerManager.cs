using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.PlatformEntities;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.PlatformConcrete
{
    public class PersonalComputerManager
    {
        public IncreaseId increase = new IncreaseId();
        public void Add(PersonalComputerPlatform personalComputer)
        {
            PlatformData.personalComputers.Add(personalComputer);
            increase.GeneratingId(ref PlatformData.PCId);
        }
        public void Update(PersonalComputerPlatform personalComputer)
        {
            var obj = PlatformData.personalComputers.Where(p => p.Id == personalComputer.Id);
            obj.First().Id = personalComputer.Id;
            obj.First().PCOSName = personalComputer.PCOSName;
            for (int i = 0; i < personalComputer.PlatformId.Count; i++)
            {
                obj.First().PlatformId[i] = personalComputer.PlatformId[i];
            }           
        }
        public void Delete(PersonalComputerPlatform personalComputer)
        {
            PlatformData.personalComputers.Remove(personalComputer);
        }
    }
}
