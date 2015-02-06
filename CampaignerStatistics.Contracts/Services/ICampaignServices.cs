namespace CampaignerStatistics.Contracts.Services
{
    using System.Collections.Generic;

    using CampaignerStatistics.Models.InputModels;
    using CampaignerStatistics.Models.ViewModels;
    
    public interface ICampaignServices
    {
        ICollection<CampaignViewModel> GetCampaignsData(TearsheetInputModel input);
    }
}
