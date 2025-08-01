// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Snapshot events allow you to track and react to activity in your Stripe integration.
    /// When the state of another API resource changes, Stripe creates an <c>Event</c> object
    /// that contains all the relevant information associated with that action, including the
    /// affected API resource. For example, a successful payment triggers a
    /// <c>charge.succeeded</c> event, which contains the <c>Charge</c> in the event's data
    /// property. Some actions trigger multiple events. For example, if you create a new
    /// subscription for a customer, it triggers both a <c>customer.subscription.created</c>
    /// event and a <c>charge.succeeded</c> event.
    ///
    /// Configure an event destination in your account to listen for events that represent
    /// actions your integration needs to respond to. Additionally, you can retrieve an
    /// individual event or a list of events from the API.
    ///
    /// <a href="https://docs.stripe.com/connect">Connect</a> platforms can also receive event
    /// notifications that occur in their connected accounts. These events include an account
    /// attribute that identifies the relevant connected account.
    ///
    /// You can access events through the <a
    /// href="https://docs.stripe.com/api/events#retrieve_event">Retrieve Event API</a> for 30
    /// days.
    /// </summary>
    [JsonConverter(typeof(EventConverter))]
#if NET6_0_OR_GREATER
    [NoSystemTextJsonAttributesNeeded("Converter is only needed for deserialization inside the Stripe.net SDK")]
#endif
    public class Event : StripeEntity<Event>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The connected account that originates the event.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The Stripe API version used to render <c>data</c> when the event was created. The
        /// contents of <c>data</c> never change, so this value remains static regardless of the API
        /// version currently in use. This property is populated only for events created on or after
        /// October 31, 2014.
        /// </summary>
        [JsonProperty("api_version")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("api_version")]
#endif
        public string ApiVersion { get; set; }

        /// <summary>
        /// Authentication context needed to fetch the event or related object.
        /// </summary>
        [JsonProperty("context")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("context")]
#endif
        public string Context { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif
        public EventData Data { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Number of webhooks that haven't been successfully delivered (for example, to return a
        /// 20x response) to the URLs you specify.
        /// </summary>
        [JsonProperty("pending_webhooks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pending_webhooks")]
#endif
        public long PendingWebhooks { get; set; }

        /// <summary>
        /// Information on the API request that triggers the event.
        /// </summary>
        [JsonProperty("request")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("request")]
#endif
        public EventRequest Request { get; set; }

        /// <summary>
        /// Description of the event (for example, <c>invoice.created</c> or
        /// <c>charge.refunded</c>).
        /// One of: <c>account.application.authorized</c>, <c>account.application.deauthorized</c>,
        /// <c>account.external_account.created</c>, <c>account.external_account.deleted</c>,
        /// <c>account.external_account.updated</c>, <c>account.updated</c>,
        /// <c>application_fee.created</c>, <c>application_fee.refund.updated</c>,
        /// <c>application_fee.refunded</c>, <c>balance.available</c>,
        /// <c>billing.alert.triggered</c>, <c>billing_portal.configuration.created</c>,
        /// <c>billing_portal.configuration.updated</c>, <c>billing_portal.session.created</c>,
        /// <c>capability.updated</c>, <c>cash_balance.funds_available</c>, <c>charge.captured</c>,
        /// <c>charge.dispute.closed</c>, <c>charge.dispute.created</c>,
        /// <c>charge.dispute.funds_reinstated</c>, <c>charge.dispute.funds_withdrawn</c>,
        /// <c>charge.dispute.updated</c>, <c>charge.expired</c>, <c>charge.failed</c>,
        /// <c>charge.pending</c>, <c>charge.refund.updated</c>, <c>charge.refunded</c>,
        /// <c>charge.succeeded</c>, <c>charge.updated</c>,
        /// <c>checkout.session.async_payment_failed</c>,
        /// <c>checkout.session.async_payment_succeeded</c>, <c>checkout.session.completed</c>,
        /// <c>checkout.session.expired</c>, <c>climate.order.canceled</c>,
        /// <c>climate.order.created</c>, <c>climate.order.delayed</c>,
        /// <c>climate.order.delivered</c>, <c>climate.order.product_substituted</c>,
        /// <c>climate.product.created</c>, <c>climate.product.pricing_updated</c>,
        /// <c>coupon.created</c>, <c>coupon.deleted</c>, <c>coupon.updated</c>,
        /// <c>credit_note.created</c>, <c>credit_note.updated</c>, <c>credit_note.voided</c>,
        /// <c>customer.created</c>, <c>customer.deleted</c>, <c>customer.discount.created</c>,
        /// <c>customer.discount.deleted</c>, <c>customer.discount.updated</c>,
        /// <c>customer.source.created</c>, <c>customer.source.deleted</c>,
        /// <c>customer.source.expiring</c>, <c>customer.source.updated</c>,
        /// <c>customer.subscription.created</c>, <c>customer.subscription.deleted</c>,
        /// <c>customer.subscription.paused</c>,
        /// <c>customer.subscription.pending_update_applied</c>,
        /// <c>customer.subscription.pending_update_expired</c>,
        /// <c>customer.subscription.resumed</c>, <c>customer.subscription.trial_will_end</c>,
        /// <c>customer.subscription.updated</c>, <c>customer.tax_id.created</c>,
        /// <c>customer.tax_id.deleted</c>, <c>customer.tax_id.updated</c>, <c>customer.updated</c>,
        /// <c>customer_cash_balance_transaction.created</c>,
        /// <c>entitlements.active_entitlement_summary.updated</c>, <c>file.created</c>,
        /// <c>financial_connections.account.created</c>,
        /// <c>financial_connections.account.deactivated</c>,
        /// <c>financial_connections.account.disconnected</c>,
        /// <c>financial_connections.account.reactivated</c>,
        /// <c>financial_connections.account.refreshed_balance</c>,
        /// <c>financial_connections.account.refreshed_ownership</c>,
        /// <c>financial_connections.account.refreshed_transactions</c>,
        /// <c>identity.verification_session.canceled</c>,
        /// <c>identity.verification_session.created</c>,
        /// <c>identity.verification_session.processing</c>,
        /// <c>identity.verification_session.redacted</c>,
        /// <c>identity.verification_session.requires_input</c>,
        /// <c>identity.verification_session.verified</c>, <c>invoice.created</c>,
        /// <c>invoice.deleted</c>, <c>invoice.finalization_failed</c>, <c>invoice.finalized</c>,
        /// <c>invoice.marked_uncollectible</c>, <c>invoice.overdue</c>, <c>invoice.overpaid</c>,
        /// <c>invoice.paid</c>, <c>invoice.payment_action_required</c>,
        /// <c>invoice.payment_failed</c>, <c>invoice.payment_succeeded</c>, <c>invoice.sent</c>,
        /// <c>invoice.upcoming</c>, <c>invoice.updated</c>, <c>invoice.voided</c>,
        /// <c>invoice.will_be_due</c>, <c>invoice_payment.paid</c>, <c>invoiceitem.created</c>,
        /// <c>invoiceitem.deleted</c>, <c>issuing_authorization.created</c>,
        /// <c>issuing_authorization.request</c>, <c>issuing_authorization.updated</c>,
        /// <c>issuing_card.created</c>, <c>issuing_card.updated</c>,
        /// <c>issuing_cardholder.created</c>, <c>issuing_cardholder.updated</c>,
        /// <c>issuing_dispute.closed</c>, <c>issuing_dispute.created</c>,
        /// <c>issuing_dispute.funds_reinstated</c>, <c>issuing_dispute.funds_rescinded</c>,
        /// <c>issuing_dispute.submitted</c>, <c>issuing_dispute.updated</c>,
        /// <c>issuing_personalization_design.activated</c>,
        /// <c>issuing_personalization_design.deactivated</c>,
        /// <c>issuing_personalization_design.rejected</c>,
        /// <c>issuing_personalization_design.updated</c>, <c>issuing_token.created</c>,
        /// <c>issuing_token.updated</c>, <c>issuing_transaction.created</c>,
        /// <c>issuing_transaction.purchase_details_receipt_updated</c>,
        /// <c>issuing_transaction.updated</c>, <c>mandate.updated</c>,
        /// <c>payment_intent.amount_capturable_updated</c>, <c>payment_intent.canceled</c>,
        /// <c>payment_intent.created</c>, <c>payment_intent.partially_funded</c>,
        /// <c>payment_intent.payment_failed</c>, <c>payment_intent.processing</c>,
        /// <c>payment_intent.requires_action</c>, <c>payment_intent.succeeded</c>,
        /// <c>payment_link.created</c>, <c>payment_link.updated</c>,
        /// <c>payment_method.attached</c>, <c>payment_method.automatically_updated</c>,
        /// <c>payment_method.detached</c>, <c>payment_method.updated</c>, <c>payout.canceled</c>,
        /// <c>payout.created</c>, <c>payout.failed</c>, <c>payout.paid</c>,
        /// <c>payout.reconciliation_completed</c>, <c>payout.updated</c>, <c>person.created</c>,
        /// <c>person.deleted</c>, <c>person.updated</c>, <c>plan.created</c>, <c>plan.deleted</c>,
        /// <c>plan.updated</c>, <c>price.created</c>, <c>price.deleted</c>, <c>price.updated</c>,
        /// <c>product.created</c>, <c>product.deleted</c>, <c>product.updated</c>,
        /// <c>promotion_code.created</c>, <c>promotion_code.updated</c>, <c>quote.accepted</c>,
        /// <c>quote.canceled</c>, <c>quote.created</c>, <c>quote.finalized</c>,
        /// <c>radar.early_fraud_warning.created</c>, <c>radar.early_fraud_warning.updated</c>,
        /// <c>refund.created</c>, <c>refund.failed</c>, <c>refund.updated</c>,
        /// <c>reporting.report_run.failed</c>, <c>reporting.report_run.succeeded</c>,
        /// <c>reporting.report_type.updated</c>, <c>review.closed</c>, <c>review.opened</c>,
        /// <c>setup_intent.canceled</c>, <c>setup_intent.created</c>,
        /// <c>setup_intent.requires_action</c>, <c>setup_intent.setup_failed</c>,
        /// <c>setup_intent.succeeded</c>, <c>sigma.scheduled_query_run.created</c>,
        /// <c>source.canceled</c>, <c>source.chargeable</c>, <c>source.failed</c>,
        /// <c>source.mandate_notification</c>, <c>source.refund_attributes_required</c>,
        /// <c>source.transaction.created</c>, <c>source.transaction.updated</c>,
        /// <c>subscription_schedule.aborted</c>, <c>subscription_schedule.canceled</c>,
        /// <c>subscription_schedule.completed</c>, <c>subscription_schedule.created</c>,
        /// <c>subscription_schedule.expiring</c>, <c>subscription_schedule.released</c>,
        /// <c>subscription_schedule.updated</c>, <c>tax.settings.updated</c>,
        /// <c>tax_rate.created</c>, <c>tax_rate.updated</c>, <c>terminal.reader.action_failed</c>,
        /// <c>terminal.reader.action_succeeded</c>, <c>terminal.reader.action_updated</c>,
        /// <c>test_helpers.test_clock.advancing</c>, <c>test_helpers.test_clock.created</c>,
        /// <c>test_helpers.test_clock.deleted</c>, <c>test_helpers.test_clock.internal_failure</c>,
        /// <c>test_helpers.test_clock.ready</c>, <c>topup.canceled</c>, <c>topup.created</c>,
        /// <c>topup.failed</c>, <c>topup.reversed</c>, <c>topup.succeeded</c>,
        /// <c>transfer.created</c>, <c>transfer.reversed</c>, <c>transfer.updated</c>,
        /// <c>treasury.credit_reversal.created</c>, <c>treasury.credit_reversal.posted</c>,
        /// <c>treasury.debit_reversal.completed</c>, <c>treasury.debit_reversal.created</c>,
        /// <c>treasury.debit_reversal.initial_credit_granted</c>,
        /// <c>treasury.financial_account.closed</c>, <c>treasury.financial_account.created</c>,
        /// <c>treasury.financial_account.features_status_updated</c>,
        /// <c>treasury.inbound_transfer.canceled</c>, <c>treasury.inbound_transfer.created</c>,
        /// <c>treasury.inbound_transfer.failed</c>, <c>treasury.inbound_transfer.succeeded</c>,
        /// <c>treasury.outbound_payment.canceled</c>, <c>treasury.outbound_payment.created</c>,
        /// <c>treasury.outbound_payment.expected_arrival_date_updated</c>,
        /// <c>treasury.outbound_payment.failed</c>, <c>treasury.outbound_payment.posted</c>,
        /// <c>treasury.outbound_payment.returned</c>,
        /// <c>treasury.outbound_payment.tracking_details_updated</c>,
        /// <c>treasury.outbound_transfer.canceled</c>, <c>treasury.outbound_transfer.created</c>,
        /// <c>treasury.outbound_transfer.expected_arrival_date_updated</c>,
        /// <c>treasury.outbound_transfer.failed</c>, <c>treasury.outbound_transfer.posted</c>,
        /// <c>treasury.outbound_transfer.returned</c>,
        /// <c>treasury.outbound_transfer.tracking_details_updated</c>,
        /// <c>treasury.received_credit.created</c>, <c>treasury.received_credit.failed</c>,
        /// <c>treasury.received_credit.succeeded</c>, <c>treasury.received_debit.created</c>,
        /// <c>billing.credit_balance_transaction.created</c>, <c>billing.credit_grant.created</c>,
        /// <c>billing.credit_grant.updated</c>, <c>billing.meter.created</c>,
        /// <c>billing.meter.deactivated</c>, <c>billing.meter.reactivated</c>,
        /// <c>billing.meter.updated</c>, or <c>ping</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
