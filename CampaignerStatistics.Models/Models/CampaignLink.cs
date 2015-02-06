namespace CampaignerStatistics.Models.Models
{
    using System.Collections.Generic;

    // Not all information is needed for the current task, but "the client will be adding more and more features"
    public class CampaignLink
    {
        public CampaignLink()
        {
            this.Recipients = new HashSet<LinkRecipient>();
        }

        public string Target { get; set; }

        public int TotalClicks { get; set; }

        public ICollection<LinkRecipient> Recipients { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            CampaignLink other = obj as CampaignLink;

            if ((System.Object)other == null)
            {
                return false;
            }

            return this.Target == other.Target;
        }

        public override int GetHashCode()
        {
            return this.Target.GetHashCode();
        }
    }
}
