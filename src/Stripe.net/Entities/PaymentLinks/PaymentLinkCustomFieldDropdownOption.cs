// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkCustomFieldDropdownOption : StripeEntity<PaymentLinkCustomFieldDropdownOption>
    {
        /// <summary>
        /// The label for the option, displayed to the customer. Up to 100 characters.
        /// </summary>
        [JsonProperty("label")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("label")]
#endif
        public string Label { get; set; }

        /// <summary>
        /// The value for this option, not displayed to the customer, used by your integration to
        /// reconcile the option selected by the customer. Must be unique to this option,
        /// alphanumeric, and up to 100 characters.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
