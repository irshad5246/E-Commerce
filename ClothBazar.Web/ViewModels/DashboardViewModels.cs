using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothBazar.Web.ViewModels
{
    public class DashboardViewModel
    {
        public int UserCount { get; set; }
        public int RoleCount { get; set; }
        public int CategoryCount { get; set; }
        public int ProductCount { get; set; }

        public int OrderCount { get; set; }

    }
}