// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCreateOptions : BaseOptions
    {
        /// <summary>
        /// Time at which the Tax Registration becomes active. It can be either <c>now</c> to
        /// indicate the current time, or a future timestamp measured in seconds since the Unix
        /// epoch.
        /// </summary>
        [JsonProperty("active_from")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active_from")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, RegistrationActiveFrom> ActiveFrom { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// Specific options for a registration in the specified <c>country</c>.
        /// </summary>
        [JsonProperty("country_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country_options")]
#endif
        public RegistrationCountryOptionsOptions CountryOptions { get; set; }

        /// <summary>
        /// If set, the Tax Registration stops being active at this time. If not set, the Tax
        /// Registration will be active indefinitely. Timestamp measured in seconds since the Unix
        /// epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ExpiresAt { get; set; }
    }
}
