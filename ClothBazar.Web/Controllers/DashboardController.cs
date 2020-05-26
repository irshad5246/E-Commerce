using ClothBazar.Services;
using ClothBazar.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothBazar.Web.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            DashboardViewModel model = new DashboardViewModel();

            model.CategoryCount = DashboardService.Instance.GetCategoriesCount();
            model.ProductCount = DashboardService.Instance.GetProductCount();
            model.OrderCount = DashboardService.Instance.GetOrderCount();
            return View(model);
        }
    }
}