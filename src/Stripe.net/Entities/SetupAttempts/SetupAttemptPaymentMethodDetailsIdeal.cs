// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

#if NET6_0_OR_GREATER
    [STJS.JsonConverter(typeof(STJMemberSerializationOptIn))]
#endif
    public class SetupAttemptPaymentMethodDetailsIdeal : StripeEntity<SetupAttemptPaymentMethodDetailsIdeal>
    {
        /// <summary>
        /// The customer's bank. Can be one of <c>abn_amro</c>, <c>asn_bank</c>, <c>bunq</c>,
        /// <c>buut</c>, <c>handelsbanken</c>, <c>ing</c>, <c>knab</c>, <c>moneyou</c>, <c>n26</c>,
        /// <c>nn</c>, <c>rabobank</c>, <c>regiobank</c>, <c>revolut</c>, <c>sns_bank</c>,
        /// <c>triodos_bank</c>, <c>van_lanschot</c>, or <c>yoursafe</c>.
        /// One of: <c>abn_amro</c>, <c>asn_bank</c>, <c>bunq</c>, <c>buut</c>,
        /// <c>handelsbanken</c>, <c>ing</c>, <c>knab</c>, <c>moneyou</c>, <c>n26</c>, <c>nn</c>,
        /// <c>rabobank</c>, <c>regiobank</c>, <c>revolut</c>, <c>sns_bank</c>, <c>triodos_bank</c>,
        /// <c>van_lanschot</c>, or <c>yoursafe</c>.
        /// </summary>
        [JsonProperty("bank")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank")]
#endif
        public string Bank { get; set; }

        /// <summary>
        /// The Bank Identifier Code of the customer's bank.
        /// One of: <c>ABNANL2A</c>, <c>ASNBNL21</c>, <c>BITSNL2A</c>, <c>BUNQNL2A</c>,
        /// <c>BUUTNL2A</c>, <c>FVLBNL22</c>, <c>HANDNL2A</c>, <c>INGBNL2A</c>, <c>KNABNL2H</c>,
        /// <c>MOYONL21</c>, <c>NNBANL2G</c>, <c>NTSBDEB1</c>, <c>RABONL2U</c>, <c>RBRBNL21</c>,
        /// <c>REVOIE23</c>, <c>REVOLT21</c>, <c>SNSBNL2A</c>, or <c>TRIONL2U</c>.
        /// </summary>
        [JsonProperty("bic")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bic")]
#endif
        public string Bic { get; set; }

        #region Expandable GeneratedSepaDebit

        /// <summary>
        /// (ID of the PaymentMethod)
        /// The ID of the SEPA Direct Debit PaymentMethod which was generated by this SetupAttempt.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string GeneratedSepaDebitId
        {
            get => this.InternalGeneratedSepaDebit?.Id;
            set => this.InternalGeneratedSepaDebit = SetExpandableFieldId(value, this.InternalGeneratedSepaDebit);
        }

        /// <summary>
        /// (Expanded)
        /// The ID of the SEPA Direct Debit PaymentMethod which was generated by this SetupAttempt.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public PaymentMethod GeneratedSepaDebit
        {
            get => this.InternalGeneratedSepaDebit?.ExpandedObject;
            set => this.InternalGeneratedSepaDebit = SetExpandableFieldObject(value, this.InternalGeneratedSepaDebit);
        }

        [JsonProperty("generated_sepa_debit")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("generated_sepa_debit")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentMethod>))]
#endif
        internal ExpandableField<PaymentMethod> InternalGeneratedSepaDebit { get; set; }
        #endregion

        #region Expandable GeneratedSepaDebitMandate

        /// <summary>
        /// (ID of the Mandate)
        /// The mandate for the SEPA Direct Debit PaymentMethod which was generated by this
        /// SetupAttempt.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public string GeneratedSepaDebitMandateId
        {
            get => this.InternalGeneratedSepaDebitMandate?.Id;
            set => this.InternalGeneratedSepaDebitMandate = SetExpandableFieldId(value, this.InternalGeneratedSepaDebitMandate);
        }

        /// <summary>
        /// (Expanded)
        /// The mandate for the SEPA Direct Debit PaymentMethod which was generated by this
        /// SetupAttempt.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
#if NET6_0_OR_GREATER
        [STJS.JsonIgnore]
#endif
        public Mandate GeneratedSepaDebitMandate
        {
            get => this.InternalGeneratedSepaDebitMandate?.ExpandedObject;
            set => this.InternalGeneratedSepaDebitMandate = SetExpandableFieldObject(value, this.InternalGeneratedSepaDebitMandate);
        }

        [JsonProperty("generated_sepa_debit_mandate")]
        [JsonConverter(typeof(ExpandableFieldConverter<Mandate>))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("generated_sepa_debit_mandate")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<Mandate>))]
#endif
        internal ExpandableField<Mandate> InternalGeneratedSepaDebitMandate { get; set; }
        #endregion

        /// <summary>
        /// Last four characters of the IBAN.
        /// </summary>
        [JsonProperty("iban_last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("iban_last4")]
#endif
        public string IbanLast4 { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by iDEAL directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("verified_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verified_name")]
#endif
        public string VerifiedName { get; set; }
    }
}
