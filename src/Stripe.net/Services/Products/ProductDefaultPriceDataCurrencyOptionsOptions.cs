// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ProductDefaultPriceDataCurrencyOptionsOptions : INestedOptions
    {
        /// <summary>
        /// When set, provides configuration for the amount to be adjusted by the customer during
        /// Checkout Sessions and Payment Links.
        /// </summary>
        [JsonProperty("custom_unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_unit_amount")]
#endif
        public ProductDefaultPriceDataCurrencyOptionsCustomUnitAmountOptions CustomUnitAmount { get; set; }

        /// <summary>
        /// Only required if a <a
        /// href="https://stripe.com/docs/tax/products-prices-tax-categories-tax-behavior#setting-a-default-tax-behavior-(recommended)">default
        /// tax behavior</a> was not provided in the Stripe Tax settings. Specifies whether the
        /// price is considered inclusive of taxes or exclusive of taxes. One of <c>inclusive</c>,
        /// <c>exclusive</c>, or <c>unspecified</c>. Once specified as either <c>inclusive</c> or
        /// <c>exclusive</c>, it cannot be changed.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_behavior")]
#endif
        public string TaxBehavior { get; set; }

        /// <summary>
        /// Each element represents a pricing tier. This parameter requires <c>billing_scheme</c> to
        /// be set to <c>tiered</c>. See also the documentation for <c>billing_scheme</c>.
        /// </summary>
        [JsonProperty("tiers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tiers")]
#endif
        public List<ProductDefaultPriceDataCurrencyOptionsTierOptions> Tiers { get; set; }

        /// <summary>
        /// A positive integer in cents (or local equivalent) (or 0 for a free price) representing
        /// how much to charge.
        /// </summary>
        [JsonProperty("unit_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount")]
#endif
        public long? UnitAmount { get; set; }

        /// <summary>
        /// Same as <c>unit_amount</c>, but accepts a decimal value in cents (or local equivalent)
        /// with at most 12 decimal places. Only one of <c>unit_amount</c> and
        /// <c>unit_amount_decimal</c> can be set.
        /// </summary>
        [JsonProperty("unit_amount_decimal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_amount_decimal")]
#endif
        public decimal? UnitAmountDecimal { get; set; }
    }
}
