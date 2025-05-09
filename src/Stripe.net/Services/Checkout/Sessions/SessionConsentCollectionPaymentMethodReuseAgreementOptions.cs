// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionConsentCollectionPaymentMethodReuseAgreementOptions : INestedOptions
    {
        /// <summary>
        /// Determines the position and visibility of the payment method reuse agreement in the UI.
        /// When set to <c>auto</c>, Stripe's defaults will be used. When set to <c>hidden</c>, the
        /// payment method reuse agreement text will always be hidden in the UI.
        /// One of: <c>auto</c>, or <c>hidden</c>.
        /// </summary>
        [JsonProperty("position")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("position")]
#endif
        public string Position { get; set; }
    }
}
