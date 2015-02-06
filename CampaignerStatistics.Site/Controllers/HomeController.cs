namespace CampaignerStatistics.Site.Controllers
{
    using System.Web.Mvc;

    using CampaignerStatistics.Contracts.Services;
    using CampaignerStatistics.Models.InputModels;
    
    public class HomeController : Controller
    {
        private ICampaignServices campaignServices;

        // I'll use DI
        public HomeController(ICampaignServices campaignServices)
        {
            this.campaignServices = campaignServices;
        }

        public ActionResult Index()
        {
            // Welcome screen with authentication data form
            return this.View();
        }

        // On Form Submit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(TearsheetInputModel input)
        {
            if (ModelState.IsValid)
            {
                // I'use Grid.MVC to visualise the information
                // Bootrap for UI
                return this.PartialView("CampaignGridView", this.campaignServices.GetCampaignsData(input));
            }

            return this.View(input);
        }
    }
}