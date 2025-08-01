// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A list of prices and quantities that will generate invoice items appended to the next
        /// invoice for this subscription. You may pass up to 20 items.
        /// </summary>
        [JsonProperty("add_invoice_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("add_invoice_items")]
#endif
        public List<SubscriptionAddInvoiceItemOptions> AddInvoiceItems { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of the subscription invoice total that will be transferred to
        /// the application owner's Stripe account. The request must be made by a platform account
        /// on a connected account in order to set an application fee percentage. For more
        /// information, see the application fees <a
        /// href="https://stripe.com/docs/connect/subscriptions#collecting-fees-on-subscriptions">documentation</a>.
        /// </summary>
        [JsonProperty("application_fee_percent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_fee_percent")]
#endif
        public decimal? ApplicationFeePercent { get; set; }

        /// <summary>
        /// Automatic tax settings for this subscription. We recommend you only include this
        /// parameter when the existing value is being changed.
        /// </summary>
        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif
        public SubscriptionAutomaticTaxOptions AutomaticTax { get; set; }

        /// <summary>
        /// Either <c>now</c> or <c>unchanged</c>. Setting the value to <c>now</c> resets the
        /// subscription's billing cycle anchor to the current time (in UTC). For more information,
        /// see the billing cycle <a
        /// href="https://stripe.com/docs/billing/subscriptions/billing-cycle">documentation</a>.
        /// One of: <c>now</c>, or <c>unchanged</c>.
        /// </summary>
        [JsonProperty("billing_cycle_anchor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cycle_anchor")]
#endif
        public SubscriptionBillingCycleAnchor BillingCycleAnchor { get; set; }

        /// <summary>
        /// Define thresholds at which an invoice will be sent, and the subscription advanced to a
        /// new billing period. When updating, pass an empty string to remove previously-defined
        /// thresholds.
        /// </summary>
        [JsonProperty("billing_thresholds")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_thresholds")]
#endif
        public SubscriptionBillingThresholdsOptions BillingThresholds { get; set; }

        /// <summary>
        /// A timestamp at which the subscription should cancel. If set to a date before the current
        /// period ends, this will cause a proration if prorations have been enabled using
        /// <c>proration_behavior</c>. If set during a future period, this will always cause a
        /// proration for that period.
        /// </summary>
        [JsonProperty("cancel_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancel_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CancelAt { get; set; }

        /// <summary>
        /// Indicate whether this subscription should cancel at the end of the current period
        /// (<c>current_period_end</c>). Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("cancel_at_period_end")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancel_at_period_end")]
#endif
        public bool? CancelAtPeriodEnd { get; set; }

        /// <summary>
        /// Details about why this subscription was cancelled.
        /// </summary>
        [JsonProperty("cancellation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancellation_details")]
#endif
        public SubscriptionCancellationDetailsOptions CancellationDetails { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>. When charging automatically,
        /// Stripe will attempt to pay this subscription at the end of the cycle using the default
        /// source attached to the customer. When sending an invoice, Stripe will email your
        /// customer an invoice with payment instructions and mark the subscription as
        /// <c>active</c>. Defaults to <c>charge_automatically</c>.
        /// One of: <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("collection_method")]
#endif
        public string CollectionMethod { get; set; }

        /// <summary>
        /// Number of days a customer has to pay invoices generated by this subscription. Valid only
        /// for subscriptions where <c>collection_method</c> is set to <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("days_until_due")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("days_until_due")]
#endif
        public long? DaysUntilDue { get; set; }

        /// <summary>
        /// ID of the default payment method for the subscription. It must belong to the customer
        /// associated with the subscription. This takes precedence over <c>default_source</c>. If
        /// neither are set, invoices will use the customer's <a
        /// href="https://stripe.com/docs/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// or <a
        /// href="https://stripe.com/docs/api/customers/object#customer_object-default_source">default_source</a>.
        /// </summary>
        [JsonProperty("default_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_payment_method")]
#endif
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// ID of the default payment source for the subscription. It must belong to the customer
        /// associated with the subscription and be in a chargeable state. If
        /// <c>default_payment_method</c> is also set, <c>default_payment_method</c> will take
        /// precedence. If neither are set, invoices will use the customer's <a
        /// href="https://stripe.com/docs/api/customers/object#customer_object-invoice_settings-default_payment_method">invoice_settings.default_payment_method</a>
        /// or <a
        /// href="https://stripe.com/docs/api/customers/object#customer_object-default_source">default_source</a>.
        /// </summary>
        [JsonProperty("default_source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_source")]
#endif
        public string DefaultSource { get; set; }

        /// <summary>
        /// The tax rates that will apply to any subscription item that does not have
        /// <c>tax_rates</c> set. Invoices created will have their <c>default_tax_rates</c>
        /// populated from the subscription. Pass an empty string to remove previously-defined tax
        /// rates.
        /// </summary>
        [JsonProperty("default_tax_rates")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_tax_rates")]
#endif
        public List<string> DefaultTaxRates { get; set; }

        /// <summary>
        /// The subscription's description, meant to be displayable to the customer. Use this field
        /// to optionally store an explanation of the subscription for rendering in Stripe surfaces
        /// and certain local payment methods UIs.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The coupons to redeem into discounts for the subscription. If not specified or empty,
        /// inherits the discount from the subscription's customer.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public List<SubscriptionDiscountOptions> Discounts { get; set; }

        /// <summary>
        /// All invoices will be billed using the specified settings.
        /// </summary>
        [JsonProperty("invoice_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_settings")]
#endif
        public SubscriptionInvoiceSettingsOptions InvoiceSettings { get; set; }

        /// <summary>
        /// A list of up to 20 subscription items, each with an attached price.
        /// </summary>
        [JsonProperty("items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("items")]
#endif
        public List<SubscriptionItemOptions> Items { get; set; }

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
        /// Indicates if a customer is on or off-session while an invoice payment is attempted.
        /// Defaults to <c>false</c> (on-session).
        /// </summary>
        [JsonProperty("off_session")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("off_session")]
#endif
        public bool? OffSession { get; set; }

        /// <summary>
        /// The account on behalf of which to charge, for each of the subscription's invoices.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        /// <summary>
        /// If specified, payment collection for this subscription will be paused. Note that the
        /// subscription status will be unchanged and will not be updated to <c>paused</c>. Learn
        /// more about <a href="https://stripe.com/docs/billing/subscriptions/pause-payment">pausing
        /// collection</a>.
        /// </summary>
        [JsonProperty("pause_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pause_collection")]
#endif
        public SubscriptionPauseCollectionOptions PauseCollection { get; set; }

        /// <summary>
        /// Use <c>allow_incomplete</c> to transition the subscription to <c>status=past_due</c> if
        /// a payment is required but cannot be paid. This allows you to manage scenarios where
        /// additional user actions are needed to pay a subscription's invoice. For example, SCA
        /// regulation may require 3DS authentication to complete payment. See the <a
        /// href="https://stripe.com/docs/billing/migration/strong-customer-authentication">SCA
        /// Migration Guide</a> for Billing to learn more. This is the default behavior.
        ///
        /// Use <c>default_incomplete</c> to transition the subscription to <c>status=past_due</c>
        /// when payment is required and await explicit confirmation of the invoice's payment
        /// intent. This allows simpler management of scenarios where additional user actions are
        /// needed to pay a subscription’s invoice. Such as failed payments, <a
        /// href="https://stripe.com/docs/billing/migration/strong-customer-authentication">SCA
        /// regulation</a>, or collecting a mandate for a bank debit payment method.
        ///
        /// Use <c>pending_if_incomplete</c> to update the subscription using <a
        /// href="https://stripe.com/docs/billing/subscriptions/pending-updates">pending
        /// updates</a>. When you use <c>pending_if_incomplete</c> you can only pass the parameters
        /// <a
        /// href="https://stripe.com/docs/billing/pending-updates-reference#supported-attributes">supported
        /// by pending updates</a>.
        ///
        /// Use <c>error_if_incomplete</c> if you want Stripe to return an HTTP 402 status code if a
        /// subscription's invoice cannot be paid. For example, if a payment method requires 3DS
        /// authentication due to SCA regulation and further user action is needed, this parameter
        /// does not update the subscription and returns an error instead. This was the default
        /// behavior for API versions prior to 2019-03-14. See the <a
        /// href="https://docs.stripe.com/changelog/2019-03-14">changelog</a> to learn more.
        /// One of: <c>allow_incomplete</c>, <c>default_incomplete</c>, <c>error_if_incomplete</c>,
        /// or <c>pending_if_incomplete</c>.
        /// </summary>
        [JsonProperty("payment_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_behavior")]
#endif
        public string PaymentBehavior { get; set; }

        /// <summary>
        /// Payment settings to pass to invoices created by the subscription.
        /// </summary>
        [JsonProperty("payment_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_settings")]
#endif
        public SubscriptionPaymentSettingsOptions PaymentSettings { get; set; }

        /// <summary>
        /// Specifies an interval for how often to bill for any pending invoice items. It is
        /// analogous to calling <a href="https://stripe.com/docs/api#create_invoice">Create an
        /// invoice</a> for the given subscription at the specified interval.
        /// </summary>
        [JsonProperty("pending_invoice_item_interval")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pending_invoice_item_interval")]
#endif
        public SubscriptionPendingInvoiceItemIntervalOptions PendingInvoiceItemInterval { get; set; }

        /// <summary>
        /// Determines how to handle <a
        /// href="https://stripe.com/docs/billing/subscriptions/prorations">prorations</a> when the
        /// billing cycle changes (e.g., when switching plans, resetting
        /// <c>billing_cycle_anchor=now</c>, or starting a trial), or if an item's <c>quantity</c>
        /// changes. The default value is <c>create_prorations</c>.
        /// One of: <c>always_invoice</c>, <c>create_prorations</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("proration_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_behavior")]
#endif
        public string ProrationBehavior { get; set; }

        /// <summary>
        /// If set, prorations will be calculated as though the subscription was updated at the
        /// given time. This can be used to apply exactly the same prorations that were previewed
        /// with the <a href="https://stripe.com/docs/api/invoices/create_preview">create
        /// preview</a> endpoint. <c>proration_date</c> can also be used to implement custom
        /// proration logic, such as prorating by day instead of by second, by providing the time
        /// that you wish to use for proration calculations.
        /// </summary>
        [JsonProperty("proration_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("proration_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ProrationDate { get; set; }

        /// <summary>
        /// If specified, the funds from the subscription's invoices will be transferred to the
        /// destination and the ID of the resulting transfers will be found on the resulting
        /// charges. This will be unset if you POST an empty value.
        /// </summary>
        [JsonProperty("transfer_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer_data")]
#endif
        public SubscriptionTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// Unix timestamp representing the end of the trial period the customer will get before
        /// being charged for the first time. This will always overwrite any trials that might apply
        /// via a subscribed plan. If set, <c>trial_end</c> will override the default trial period
        /// of the plan the customer is being subscribed to. The <c>billing_cycle_anchor</c> will be
        /// updated to the <c>trial_end</c> value. The special value <c>now</c> can be provided to
        /// end the customer's trial immediately. Can be at most two years from
        /// <c>billing_cycle_anchor</c>.
        /// </summary>
        [JsonProperty("trial_end")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_end")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, SubscriptionTrialEnd> TrialEnd { get; set; }

        /// <summary>
        /// Indicates if a plan's <c>trial_period_days</c> should be applied to the subscription.
        /// Setting <c>trial_end</c> per subscription is preferred, and this defaults to
        /// <c>false</c>. Setting this flag to <c>true</c> together with <c>trial_end</c> is not
        /// allowed. See <a href="https://stripe.com/docs/billing/subscriptions/trials">Using trial
        /// periods on subscriptions</a> to learn more.
        /// </summary>
        [JsonProperty("trial_from_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_from_plan")]
#endif
        public bool? TrialFromPlan { get; set; }

        /// <summary>
        /// Settings related to subscription trials.
        /// </summary>
        [JsonProperty("trial_settings")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("trial_settings")]
#endif
        public SubscriptionTrialSettingsOptions TrialSettings { get; set; }
    }
}
