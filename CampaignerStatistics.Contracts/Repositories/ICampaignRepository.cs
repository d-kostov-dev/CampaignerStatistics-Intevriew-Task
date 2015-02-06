namespace CampaignerStatistics.Contracts.DataProviders
{
    using System.Collections.Generic;

    using CampaignerStatistics.Models.InputModels;
    using CampaignerStatistics.Models.Models;

    public interface ICampaignRepository
    {
        // Note: May also be returned as "IQueryable" for future filtering and ordering.
        ICollection<Campaign> GetCampaignsInDateRange(TearsheetInputModel input);

        // Other additional methods for the Campaigns will be added here
    }
}
