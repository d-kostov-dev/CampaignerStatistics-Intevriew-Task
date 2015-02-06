namespace CampaignerStatistics.Repositories
{
    using System;
    using System.Collections.Generic;

    using CampaignerStatistics.Contracts.DataProviders;
    using CampaignerStatistics.Models.InputModels;
    using CampaignerStatistics.Models.Models;
    using CampaignerStatistics.Contracts.Parsers;
    using CampaignerStatistics.Repositories.Base;
    
    public class CampaignRecipientsRepository : RepositoryBase, ICampaignRecipientsRepository
    {
        public CampaignRecipientsRepository(IXConnectParser xmlParser)
            : base(xmlParser)
        {
        }

        public ICollection<LinkRecipient> GetLinkRecipientsByCampaignId(RecipientsInputModel input)
        {
            string requestString = this.BuildRequestString(input);
            string responseString = this.MakeXMLRequest(requestString);

            return this.xmlParser.ParseCampaignRecipentsXML(responseString);
        }

        private string BuildRequestString(RecipientsInputModel input)
        {
            // Use the XML provided and fill in the options tags.
            throw new System.NotImplementedException();
        }
    }
}
