namespace CampaignerStatistics.Parsers
{
    using System;
    using System.Collections.Generic;

    using CampaignerStatistics.Contracts.Parsers;
    using CampaignerStatistics.Models.Models;

    // TODO: Research XML Serialize/Deserialize and don't hardcode stuff.

    public class XConnectParser : IXConnectParser
    {
        public ICollection<Campaign> ParseCampaignsXML(string input)
        {
            throw new NotImplementedException();
        }

        public ICollection<LinkRecipient> ParseCampaignRecipentsXML(string input)
        {
            throw new NotImplementedException();
        }
    }
}
