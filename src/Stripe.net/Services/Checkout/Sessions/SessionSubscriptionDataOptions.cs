// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionSubscriptionDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice total that will be transferred to
        /// the application owner's Stripe account. To use an application fee percent, the request
        /// must be made on behalf of another account, using the <c>Stripe-Account</c> header or an
        /// OAuth key. For more information, see the application fees <a
        /// href="https://stripe.com/docs/connect/subscriptions#collecting-fees-on-subscriptions">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_percent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_percent")]
#endif
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// A future timestamp to anchor the subscription's billing cycle for new subscriptions.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cycle_anchor")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? BillingCycleAnchor { get; set; }

        /// <summary>
        /// Controls how prorations and invoices for subscriptions are calculated and orchestrated.
        /// </summary>
        [JsonProperty("billing_mode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_mode")]
#endif
        public SessionSubscriptionDataBillingModeOptions BillingMode { get; set; }

        /// <summary>
        /// The tax rates that will apply to any subscription item that does not have
        /// <c>tax_rates</c> set. Invoices created will have their <c>default_tax_rates</c>
        /// populated from the subscription.
        /// </summary>
        [JsonProperty("default_tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_tax_rates")]
#endif
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in the <a
        /// href="https://stripe.com/docs/customer-management">customer portal</a>.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_settings")]
#endif
        public SessionSubscriptionDataInvoiceSettingsOptions InvoiceSettings { get; set; }

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
        /// The account on behalf of which to charge, for each of the subscription's invoices.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// Determines how to handle prorations resulting from the <c>billing_cycle_anchor</c>. If
        /// no value is passed, the default is <c>create_prorations</c>.
        /// One of: <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If specified, the funds from the subscription's invoices will be transferred to the
        /// destination and the ID of the resulting transfers will be found on the resulting
        /// charges.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public SessionSubscriptionDataTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// Unix timestamp representing the end of the trial period the customer will get before
        /// being charged for the first time. Has to be at least 48 hours in the future.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_end")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? TrialEnd { get; set; }

        /// <summary>
        /// Integer representing the number of trial period days before the customer is charged for
        /// the first time. Has to be at least 1.
        /// </summary>
        [JsonProperty("trial_period_days")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_period_days")]
#endif
        public long? TrialPeriodDays { get; set; }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_settings")]
#endif
        public SessionSubscriptionDataTrialSettingsOptions TrialSettings { get; set; }
    }
}
