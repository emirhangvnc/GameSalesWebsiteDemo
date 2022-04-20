using GameSalesWebsiteDemo.Data;
using GameSalesWebsiteDemo.Entities.GeneralEntities;
using System;
using System.Linq;

namespace GameSalesWebsiteDemo.Concrete.GeneralConcrete
{
    public class CategoryManager
    {
        public void Add(Category category)
        {
            GameUsedData.categories.Add(category);
        }

        public void Update(Category category)
        {
            var obj = GameUsedData.categories.Where(c => c.Id == category.Id);
            obj.First().CategoryName = category.CategoryName;
        }

        public void Delete(Category category)
        {
            GameUsedData.categories.Remove(category);
        }
    }
}
