namespace CampaignerStatistics.Models.ViewModels
{
    using System;
    using System.Collections.Generic;

    public class CampaignViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int RecipientsCount { get; set; }

        public int ClicksCount { get; set; }

        public ICollection<CampaignLinkViewModel> CampaignLinksList { get; set; }
    }
}
