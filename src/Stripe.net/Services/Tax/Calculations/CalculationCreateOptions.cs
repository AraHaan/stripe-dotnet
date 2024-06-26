// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CalculationCreateOptions : BaseOptions
    {
        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The ID of an existing customer to use for this calculation. If provided, the customer's
        /// address and tax IDs are copied to <c>customer_details</c>.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Details about the customer, including address and tax IDs.
        /// </summary>
        [JsonProperty("customer_details")]
        public CalculationCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// A list of items the customer is purchasing.
        /// </summary>
        [JsonProperty("line_items")]
        public List<CalculationLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Details about the address from which the goods are being shipped.
        /// </summary>
        [JsonProperty("ship_from_details")]
        public CalculationShipFromDetailsOptions ShipFromDetails { get; set; }

        /// <summary>
        /// Shipping cost details to be used for the calculation.
        /// </summary>
        [JsonProperty("shipping_cost")]
        public CalculationShippingCostOptions ShippingCost { get; set; }

        /// <summary>
        /// Timestamp of date at which the tax rules and rates in effect applies for the
        /// calculation. Measured in seconds since the Unix epoch. Can be up to 48 hours in the
        /// past, and up to 48 hours in the future.
        /// </summary>
        [JsonProperty("tax_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TaxDate { get; set; }
    }
}
