namespace CampaignerStatistics.Models.InputModels
{
    using CampaignerStatistics.Models.InputModels.Base;

    public class RecipientsInputModel : AuthenticationBaseInputModel
    {
        public int CampaignId { get; set; }
    }
}
