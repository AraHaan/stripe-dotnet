// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ProductUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Whether the product is available for purchase.
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool? Active { get; set; }

        /// <summary>
        /// The ID of the <a href="https://stripe.com/docs/api/prices">Price</a> object that is the
        /// default price for this product.
        /// </summary>
        [JsonProperty("default_price")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_price")]
#endif
        public string DefaultPrice { get; set; }

        /// <summary>
        /// The product's description, meant to be displayable to the customer. Use this field to
        /// optionally store a long form explanation of the product being sold for your own
        /// rendering purposes.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// A list of up to 8 URLs of images for this product, meant to be displayable to the
        /// customer.
        /// </summary>
        [JsonProperty("images")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("images")]
#endif
        public List<string> Images { get; set; }

        /// <summary>
        /// A list of up to 15 marketing features for this product. These are displayed in <a
        /// href="https://stripe.com/docs/payments/checkout/pricing-table">pricing tables</a>.
        /// </summary>
        [JsonProperty("marketing_features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("marketing_features")]
#endif
        public List<ProductMarketingFeatureOptions> MarketingFeatures { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The product's name, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The dimensions of this product for shipping purposes.
        /// </summary>
        [JsonProperty("package_dimensions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("package_dimensions")]
#endif
        public ProductPackageDimensionsOptions PackageDimensions { get; set; }

        /// <summary>
        /// Whether this product is shipped (i.e., physical goods).
        /// </summary>
        [JsonProperty("shippable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shippable")]
#endif
        public bool? Shippable { get; set; }

        /// <summary>
        /// An arbitrary string to be displayed on your customer's credit card or bank statement.
        /// While most banks display this information consistently, some may display it incorrectly
        /// or not at all.
        ///
        /// This may be up to 22 characters. The statement description may not include <c>&lt;</c>,
        /// <c>&gt;</c>, <c>\</c>, <c>"</c>, <c>'</c> characters, and will appear on your customer's
        /// statement in capital letters. Non-ASCII characters are automatically stripped. It must
        /// contain at least one letter. May only be set if <c>type=service</c>. Only used for
        /// subscription payments.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// A <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> ID.
        /// </summary>
        [JsonProperty("tax_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax_code")]
#endif
        public string TaxCode { get; set; }

        /// <summary>
        /// A label that represents units of this product. When set, this will be included in
        /// customers' receipts, invoices, Checkout, and the customer portal. May only be set if
        /// <c>type=service</c>.
        /// </summary>
        [JsonProperty("unit_label")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("unit_label")]
#endif
        public string UnitLabel { get; set; }

        /// <summary>
        /// A URL of a publicly-accessible webpage for this product.
        /// </summary>
        [JsonProperty("url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("url")]
#endif
        public string Url { get; set; }
    }
}
