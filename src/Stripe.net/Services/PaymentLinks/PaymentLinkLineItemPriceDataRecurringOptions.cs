// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkLineItemPriceDataRecurringOptions : INestedOptions
    {
        /// <summary>
        /// Specifies billing frequency. Either <c>day</c>, <c>week</c>, <c>month</c> or
        /// <c>year</c>.
        /// One of: <c>day</c>, <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval")]
#endif
        public string Interval { get; set; }

        /// <summary>
        /// The number of intervals between subscription billings. For example,
        /// <c>interval=month</c> and <c>interval_count=3</c> bills every 3 months. Maximum of three
        /// years interval allowed (3 years, 36 months, or 156 weeks).
        /// </summary>
        [JsonProperty("interval_count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("interval_count")]
#endif
        public long? IntervalCount { get; set; }
    }
}
