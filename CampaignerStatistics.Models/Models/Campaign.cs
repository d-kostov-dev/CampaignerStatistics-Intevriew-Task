namespace CampaignerStatistics.Models.Models
{
    using System;
    using System.Collections.Generic;

    // Not all information is needed for the current task, but "the client will be adding more and more features"
    public class Campaign
    {
        public Campaign()
        {
            this.ClickersList = new HashSet<LinkRecipient>();
            this.CampaignLinks = new HashSet<CampaignLink>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public int RecipientsCount { get; set; }

        public ICollection<LinkRecipient> ClickersList { get; set; }

        public ICollection<CampaignLink> CampaignLinks { get; set; }

        public string Subject { get; set; }

        public int UniqueViews { get; set; }

        public int Optouts { get; set; }

        public int Undeliverable { get; set; }

        public int Suppressions { get; set; }

        public int Abuse { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
