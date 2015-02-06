namespace CampaignerStatistics.Repositories.Base
{
    using CampaignerStatistics.Contracts.Parsers;
    using CampaignerStatistics.Contracts.Repositories;
    using CampaignerStatistics.Constants.XConnectAPI;

    public abstract class RepositoryBase : IBaseRepository
    {
        protected IXConnectParser xmlParser;

        public RepositoryBase(IXConnectParser xmlParser)
        {
            this.xmlParser = xmlParser;
        }

        public string MakeXMLRequest(string requestString)
        {
            string requestUrl = XConnectApiConstants.ApiURL;

            // Make request with WebRequest.
            // Return the response XML as string.

            throw new System.NotImplementedException();
        }
    }
}
