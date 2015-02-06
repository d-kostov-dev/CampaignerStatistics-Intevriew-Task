namespace CampaignerStatistics.Models.Models
{
    using System;
    using System.Collections.Generic;

    // Not all information is needed for the current task, but "the client will be adding more and more features"
    public class LinkRecipient
    {
        public LinkRecipient()
        {
            this.ClickedLinks = new Dictionary<CampaignLink, int>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public IDictionary<CampaignLink, int> ClickedLinks { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            LinkRecipient other = obj as LinkRecipient;

            if ((System.Object)other == null)
            {
                return false;
            }

            return this.Email == other.Email;
        }

        public override int GetHashCode()
        {
            return this.Email.GetHashCode();
        }
    }
}
