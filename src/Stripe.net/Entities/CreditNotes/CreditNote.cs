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

    /// <summary>
    /// Issue a credit note to adjust an invoice's amount after the invoice is finalized.
    ///
    /// Related guide: <a href="https://stripe.com/docs/billing/invoices/credit-notes">Credit
    /// notes</a>.
    /// </summary>
#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class CreditNote : StripeEntity<CreditNote>, IHasId, IHasMetadata, IHasObject
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
        /// The integer amount in cents (or local equivalent) representing the total amount of the
        /// credit note, including tax.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// This is the sum of all the shipping amounts.
        /// </summary>
        [JsonProperty("amount_shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_shipping")]
#endif
        public long AmountShipping { get; set; }

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

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        #region Expandable Customer

        /// <summary>
        /// (ID of the Customer)
        /// ID of the customer.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CustomerId
        {
            get => this.InternalCustomer?.Id;
            set => this.InternalCustomer = SetExpandableFieldId(value, this.InternalCustomer);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the customer.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Customer Customer
        {
            get => this.InternalCustomer?.ExpandedObject;
            set => this.InternalCustomer = SetExpandableFieldObject(value, this.InternalCustomer);
        }

        [JsonProperty("customer")]
        [JsonConverter(typeof(ExpandableFieldConverter<Customer>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Customer>))]
#endif
        internal ExpandableField<Customer> InternalCustomer { get; set; }
        #endregion

        #region Expandable CustomerBalanceTransaction

        /// <summary>
        /// (ID of the CustomerBalanceTransaction)
        /// Customer balance transaction related to this credit note.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string CustomerBalanceTransactionId
        {
            get => this.InternalCustomerBalanceTransaction?.Id;
            set => this.InternalCustomerBalanceTransaction = SetExpandableFieldId(value, this.InternalCustomerBalanceTransaction);
        }

        /// <summary>
        /// (Expanded)
        /// Customer balance transaction related to this credit note.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public CustomerBalanceTransaction CustomerBalanceTransaction
        {
            get => this.InternalCustomerBalanceTransaction?.ExpandedObject;
            set => this.InternalCustomerBalanceTransaction = SetExpandableFieldObject(value, this.InternalCustomerBalanceTransaction);
        }

        [JsonProperty("customer_balance_transaction")]
        [JsonConverter(typeof(ExpandableFieldConverter<CustomerBalanceTransaction>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance_transaction")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<CustomerBalanceTransaction>))]
#endif
        internal ExpandableField<CustomerBalanceTransaction> InternalCustomerBalanceTransaction { get; set; }
        #endregion

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the total amount of
        /// discount that was credited.
        /// </summary>
        [JsonProperty("discount_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amount")]
#endif
        public long DiscountAmount { get; set; }

        /// <summary>
        /// The aggregate amounts calculated per discount for all line items.
        /// </summary>
        [JsonProperty("discount_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amounts")]
#endif
        public List<CreditNoteDiscountAmount> DiscountAmounts { get; set; }

        /// <summary>
        /// The date when this credit note is in effect. Same as <c>created</c> unless overwritten.
        /// When defined, this value replaces the system-generated 'Date of issue' printed on the
        /// credit note PDF.
        /// </summary>
        [JsonProperty("effective_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("effective_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? EffectiveAt { get; set; }

        #region Expandable Invoice

        /// <summary>
        /// (ID of the Invoice)
        /// ID of the invoice.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string InvoiceId
        {
            get => this.InternalInvoice?.Id;
            set => this.InternalInvoice = SetExpandableFieldId(value, this.InternalInvoice);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the invoice.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Invoice Invoice
        {
            get => this.InternalInvoice?.ExpandedObject;
            set => this.InternalInvoice = SetExpandableFieldObject(value, this.InternalInvoice);
        }

        [JsonProperty("invoice")]
        [JsonConverter(typeof(ExpandableFieldConverter<Invoice>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Invoice>))]
#endif
        internal ExpandableField<Invoice> InternalInvoice { get; set; }
        #endregion

        /// <summary>
        /// Line items that make up the credit note.
        /// </summary>
        [JsonProperty("lines")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lines")]
#endif
        public StripeList<CreditNoteLineItem> Lines { get; set; }

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
        /// Customer-facing text that appears on the credit note PDF.
        /// </summary>
        [JsonProperty("memo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("memo")]
#endif
        public string Memo { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A unique number that identifies this particular credit note and appears on the PDF of
        /// the credit note and its associated invoice.
        /// </summary>
        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif
        public string Number { get; set; }

        /// <summary>
        /// Amount that was credited outside of Stripe.
        /// </summary>
        [JsonProperty("out_of_band_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("out_of_band_amount")]
#endif
        public long? OutOfBandAmount { get; set; }

        /// <summary>
        /// The link to download the PDF of the credit note.
        /// </summary>
        [JsonProperty("pdf")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pdf")]
#endif
        public string Pdf { get; set; }

        /// <summary>
        /// The amount of the credit note that was refunded to the customer, credited to the
        /// customer's balance, credited outside of Stripe, or any combination thereof.
        /// </summary>
        [JsonProperty("post_payment_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("post_payment_amount")]
#endif
        public long PostPaymentAmount { get; set; }

        /// <summary>
        /// The amount of the credit note by which the invoice's <c>amount_remaining</c> and
        /// <c>amount_due</c> were reduced.
        /// </summary>
        [JsonProperty("pre_payment_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pre_payment_amount")]
#endif
        public long PrePaymentAmount { get; set; }

        /// <summary>
        /// The pretax credit amounts (ex: discount, credit grants, etc) for all line items.
        /// </summary>
        [JsonProperty("pretax_credit_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pretax_credit_amounts")]
#endif
        public List<CreditNotePretaxCreditAmount> PretaxCreditAmounts { get; set; }

        /// <summary>
        /// Reason for issuing this credit note, one of <c>duplicate</c>, <c>fraudulent</c>,
        /// <c>order_change</c>, or <c>product_unsatisfactory</c>.
        /// One of: <c>duplicate</c>, <c>fraudulent</c>, <c>order_change</c>, or
        /// <c>product_unsatisfactory</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        /// <summary>
        /// Refunds related to this credit note.
        /// </summary>
        [JsonProperty("refunds")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refunds")]
#endif
        public List<CreditNoteRefund> Refunds { get; set; }

        /// <summary>
        /// The details of the cost of shipping, including the ShippingRate applied to the invoice.
        /// </summary>
        [JsonProperty("shipping_cost")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping_cost")]
#endif
        public CreditNoteShippingCost ShippingCost { get; set; }

        /// <summary>
        /// Status of this credit note, one of <c>issued</c> or <c>void</c>. Learn more about <a
        /// href="https://stripe.com/docs/billing/invoices/credit-notes#voiding">voiding credit
        /// notes</a>.
        /// One of: <c>issued</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the amount of the credit
        /// note, excluding exclusive tax and invoice level discounts.
        /// </summary>
        [JsonProperty("subtotal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subtotal")]
#endif
        public long Subtotal { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the amount of the credit
        /// note, excluding all tax and invoice level discounts.
        /// </summary>
        [JsonProperty("subtotal_excluding_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subtotal_excluding_tax")]
#endif
        public long? SubtotalExcludingTax { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the total amount of the
        /// credit note, including tax and all discount.
        /// </summary>
        [JsonProperty("total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total")]
#endif
        public long Total { get; set; }

        /// <summary>
        /// The integer amount in cents (or local equivalent) representing the total amount of the
        /// credit note, excluding tax, but including discounts.
        /// </summary>
        [JsonProperty("total_excluding_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_excluding_tax")]
#endif
        public long? TotalExcludingTax { get; set; }

        /// <summary>
        /// The aggregate tax information for all line items.
        /// </summary>
        [JsonProperty("total_taxes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_taxes")]
#endif
        public List<CreditNoteTotalTax> TotalTaxes { get; set; }

        /// <summary>
        /// Type of this credit note, one of <c>pre_payment</c> or <c>post_payment</c>. A
        /// <c>pre_payment</c> credit note means it was issued when the invoice was open. A
        /// <c>post_payment</c> credit note means it was issued when the invoice was paid.
        /// One of: <c>mixed</c>, <c>post_payment</c>, or <c>pre_payment</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The time that the credit note was voided.
        /// </summary>
        [JsonProperty("voided_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("voided_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? VoidedAt { get; set; }
    }
}
