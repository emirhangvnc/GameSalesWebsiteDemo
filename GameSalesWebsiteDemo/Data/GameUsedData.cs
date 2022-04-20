using GameSalesWebsiteDemo.Entities.GeneralEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesWebsiteDemo.Data
{
    public static class GameUsedData //City And Country
    {
        private static IncreaseId increaseId = new IncreaseId();

        #region Id Üretme
        public static int catagoryId = 1;
        #endregion

        #region Listeler
        public static List<Category> categories = new List<Category>();
        #endregion

        static GameUsedData()
        {
            #region Catagoriler

            categories.Add(new Category()
            {
                Id = catagoryId,
                CategoryName = "First Person Shooter"
            });
            increaseId.GeneratingId(ref catagoryId);

            categories.Add(new Category()
            {
                Id = catagoryId,
                CategoryName = "Third Person Shooter"
            });
            increaseId.GeneratingId(ref catagoryId);

            categories.Add(new Category()
            {
                Id = catagoryId,
                CategoryName = "Role Playing Game"
            });
            increaseId.GeneratingId(ref catagoryId);

            categories.Add(new Category()
            {
                Id = catagoryId,
                CategoryName = "Massively Multiplayer Online Role Playing Game"
            });
            increaseId.GeneratingId(ref catagoryId);

            categories.Add(new Category()
            {
                Id = catagoryId,
                CategoryName = "Multiplayer Online Battle Arena"
            });
            increaseId.GeneratingId(ref catagoryId);

            categories.Add(new Category()
            {
                Id = catagoryId,
                CategoryName = "Real Time Strategy"
            });
            increaseId.GeneratingId(ref catagoryId);

            categories.Add(new Category()
            {
                Id = catagoryId,
                CategoryName = "Turn Based Strategy"
            });
            increaseId.GeneratingId(ref catagoryId);

            categories.Add(new Category()
            {
                Id = catagoryId,
                CategoryName = "Adventure"
            });
            increaseId.GeneratingId(ref catagoryId);

            categories.Add(new Category()
            {
                Id = catagoryId,
                CategoryName = "Simulation"
            });
            increaseId.GeneratingId(ref catagoryId);

            #endregion
        }
    }
}
