namespace CampaignerStatistics.Models.InputModels
{
    using System;

    using CampaignerStatistics.Models.InputModels.Base;

    public class TearsheetInputModel : AuthenticationBaseInputModel
    {
        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }
    }
}
