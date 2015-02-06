namespace CampaignerStatistics.Services
{
    using System.Collections.Generic;

    using CampaignerStatistics.Contracts.DataProviders;
    using CampaignerStatistics.Contracts.Services;
    using CampaignerStatistics.Models.InputModels;
    using CampaignerStatistics.Models.ViewModels;
      
    public class CampaignsServices : ICampaignServices
    {
        private ICampaignRepository campaignRepository;
        private ICampaignRecipientsRepository campaignRecipientsRepository;

        public CampaignsServices(
            ICampaignRepository campaignRepository, 
            ICampaignRecipientsRepository campaignRecipientsRepository)
        {
            this.campaignRepository = campaignRepository;
            this.campaignRecipientsRepository = campaignRecipientsRepository;
        }

        public ICollection<CampaignViewModel> GetCampaignsData(TearsheetInputModel tearsheet)
        {
            // Use the repositories to get the data.
            // Map to the final view model.
            // Return the result.

            throw new System.NotImplementedException();
        }
    }
}
