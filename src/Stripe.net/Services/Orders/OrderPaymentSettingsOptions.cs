// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderPaymentSettingsOptions : INestedOptions
    {
        /// <summary>
        /// The amount of the application fee (if any) that will be requested to be applied to the
        /// payment and transferred to the application owner's Stripe account.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        /// <summary>
        /// PaymentMethod-specific configuration to provide to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("payment_method_options")]
        public OrderPaymentSettingsPaymentMethodOptionsOptions PaymentMethodOptions { get; set; }

        /// <summary>
        /// The list of <a href="https://stripe.com/docs/payments/payment-methods/overview">payment
        /// method types</a> to provide to the order's PaymentIntent. Do not include this attribute
        /// if you prefer to manage your payment methods from the <a
        /// href="https://dashboard.stripe.com/settings/payment_methods">Stripe Dashboard</a>.
        /// </summary>
        [JsonProperty("payment_method_types")]
        public List<string> PaymentMethodTypes { get; set; }

        /// <summary>
        /// The URL to redirect the customer to after they authenticate their payment.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// For non-card charges, you can use this value as the complete description that appears on
        /// your customers' statements. Must contain at least one letter, maximum 22 characters.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card payment that customers see on their statements.
        /// Concatenated with the prefix (shortened descriptor) or statement descriptor that’s set
        /// on the account to form the complete statement descriptor. Maximum 22 characters for the
        /// concatenated descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// Provides configuration for completing a transfer for the order after it is paid.
        /// </summary>
        [JsonProperty("transfer_data")]
        public OrderPaymentSettingsTransferDataOptions TransferData { get; set; }
    }
}