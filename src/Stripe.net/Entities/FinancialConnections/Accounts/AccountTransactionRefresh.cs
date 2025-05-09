// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountTransactionRefresh : StripeEntity<AccountTransactionRefresh>, IHasId
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
        /// The time at which the last refresh attempt was initiated. Measured in seconds since the
        /// Unix epoch.
        /// </summary>
        [JsonProperty("last_attempted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last_attempted_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime LastAttemptedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the next transaction refresh can be initiated. This value will be
        /// <c>null</c> when <c>status</c> is <c>pending</c>. Measured in seconds since the Unix
        /// epoch.
        /// </summary>
        [JsonProperty("next_refresh_available_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("next_refresh_available_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? NextRefreshAvailableAt { get; set; }

        /// <summary>
        /// The status of the last refresh attempt.
        /// One of: <c>failed</c>, <c>pending</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
