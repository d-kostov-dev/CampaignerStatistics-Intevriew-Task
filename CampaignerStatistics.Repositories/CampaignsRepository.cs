namespace CampaignerStatistics.Repositories
{
    using System.Collections.Generic;

    using CampaignerStatistics.Contracts.DataProviders;
    using CampaignerStatistics.Models.InputModels;
    using CampaignerStatistics.Models.Models;
    using CampaignerStatistics.Contracts.Parsers;
    using CampaignerStatistics.Repositories.Base;

    public class CampaignsRepository : RepositoryBase, ICampaignRepository
    {

        public CampaignsRepository(IXConnectParser xmlParser)
            : base(xmlParser)
        {
        }

        public ICollection<Campaign> GetCampaignsInDateRange(TearsheetInputModel input)
        {
            string requestString = this.BuildRequestString(input);
            string responseString = this.MakeXMLRequest(requestString);

            return this.xmlParser.ParseCampaignsXML(responseString);
        }

        private string BuildRequestString(TearsheetInputModel input)
        {
            // Use the XML provided and fill in the options tags.
            throw new System.NotImplementedException();
        }
    }
}
