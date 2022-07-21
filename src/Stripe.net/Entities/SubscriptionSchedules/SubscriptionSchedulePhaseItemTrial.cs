// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionSchedulePhaseItemTrial : StripeEntity<SubscriptionSchedulePhaseItemTrial>, IHasId
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Details of a different price, quantity, or both, to bill your customer for during a paid
        /// trial.
        /// </summary>
        [JsonProperty("paid")]
        public SubscriptionSchedulePhaseItemTrialPaid Paid { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}