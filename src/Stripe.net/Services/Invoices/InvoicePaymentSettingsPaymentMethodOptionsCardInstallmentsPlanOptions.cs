// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptionsCardInstallmentsPlanOptions : INestedOptions
    {
        /// <summary>
        /// For <c>fixed_count</c> installment plans, this is required. It represents the number of
        /// installment payments your customer will make to their credit card.
        /// </summary>
        [JsonProperty("count")]
        public long? Count { get; set; }

        /// <summary>
        /// For <c>fixed_count</c> installment plans, this is required. It represents the interval
        /// between installment payments your customer will make to their credit card. One of
        /// <c>month</c>.
        /// </summary>
        [JsonProperty("interval")]
        public string Interval { get; set; }

        /// <summary>
        /// Type of installment plan, one of <c>fixed_count</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
