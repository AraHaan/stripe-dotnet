// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a Meter has invalid async usage events.
    /// </summary>
    public class V1BillingMeterErrorReportTriggeredEvent : V2.Event
    {
        /// <summary>
        /// Data for the v1.billing.meter.error_report_triggered event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V1BillingMeterErrorReportTriggeredEventData Data { get; set; }

        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<Billing.Meter> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Billing.Meter>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Billing.Meter FetchRelatedObject()
        {
            return this.FetchRelatedObject<Billing.Meter>(this.RelatedObject);
        }
    }
}
