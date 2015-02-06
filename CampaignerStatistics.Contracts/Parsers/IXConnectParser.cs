namespace CampaignerStatistics.Contracts.Parsers
{
    using System.Collections.Generic;

    using CampaignerStatistics.Models.Models;

    public interface IXConnectParser
    {
        ICollection<Campaign> ParseCampaignsXML(string input);

        ICollection<LinkRecipient> ParseCampaignRecipentsXML(string input);
    }
}
