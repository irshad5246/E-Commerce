using ClothBazar.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Services
{

    public class DashboardService
    {
        #region Singleton
        public static DashboardService Instance
        {
            get
            {
                if (instance == null) instance = new DashboardService();

                return instance;
            }
        }
        private static DashboardService instance { get; set; }

        private DashboardService()
        {
        }
        #endregion

        //public int GetUserCount()
        //{
        //    CBContext context = new CBContext();

        //    return context.Users.Count();
        //}
        //public int GetRoleCount()
        //{
        //    CBContext context = new CBContext();

        //    return context.Roles.Count();
        //}
        public int GetCategoriesCount()
        {
            CBContext context = new CBContext();

            return context.Categories.Count();
        }
        public int GetProductCount()
        {
            CBContext context = new CBContext();

            return context.Products.Count();
        }
        public int GetOrderCount()
        {
            CBContext context = new CBContext();

            return context.Orders.Count();
        }
    }
}