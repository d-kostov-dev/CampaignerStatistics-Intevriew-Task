namespace CampaignerStatistics.Contracts.DataProviders
{
    using System.Collections.Generic;

    using CampaignerStatistics.Models.InputModels;
    using CampaignerStatistics.Models.Models;

    public interface ICampaignRecipientsRepository
    {
        // Note: May also be returned as "IQueryable" for future filtering and ordering.
        ICollection<LinkRecipient> GetLinkRecipientsByCampaignId(RecipientsInputModel input);

        // Other additional methods for the LinkRecipients will be added here
    }
}
