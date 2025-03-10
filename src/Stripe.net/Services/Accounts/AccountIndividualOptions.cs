// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccountIndividualOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// The individual's primary address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The Kana variation of the individual's primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kana")]
        public AddressJapanOptions AddressKana { get; set; }

        /// <summary>
        /// The Kanji variation of the individual's primary address (Japan only).
        /// </summary>
        [JsonProperty("address_kanji")]
        public AddressJapanOptions AddressKanji { get; set; }

        /// <summary>
        /// The individual's date of birth.
        /// </summary>
        [JsonProperty("dob")]
        public DobOptions Dob { get; set; }

        /// <summary>
        /// The individual's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The individual's first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The Kana variation of the individual's first name (Japan only).
        /// </summary>
        [JsonProperty("first_name_kana")]
        public string FirstNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the individual's first name (Japan only).
        /// </summary>
        [JsonProperty("first_name_kanji")]
        public string FirstNameKanji { get; set; }

        /// <summary>
        /// A list of alternate names or aliases that the individual is known by.
        /// </summary>
        [JsonProperty("full_name_aliases")]
        public List<string> FullNameAliases { get; set; }

        /// <summary>
        /// The individual's gender.
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// The government-issued ID number of the individual, as appropriate for the
        /// representative's country. (Examples are a Social Security Number in the U.S., or a
        /// Social Insurance Number in Canada). Instead of the number itself, you can also provide a
        /// <a href="https://stripe.com/js/tokens/create_token?type=pii">PII token created with
        /// Stripe.js</a>.
        /// </summary>
        [JsonProperty("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// The government-issued secondary ID number of the individual, as appropriate for the
        /// representative's country, will be used for enhanced verification checks. In Thailand,
        /// this would be the laser code found on the back of an ID card. Instead of the number
        /// itself, you can also provide a <a
        /// href="https://stripe.com/js/tokens/create_token?type=pii">PII token created with
        /// Stripe.js</a>.
        /// </summary>
        [JsonProperty("id_number_secondary")]
        public string IdNumberSecondary { get; set; }

        /// <summary>
        /// The individual's last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The Kana variation of the individual's last name (Japan only).
        /// </summary>
        [JsonProperty("last_name_kana")]
        public string LastNameKana { get; set; }

        /// <summary>
        /// The Kanji variation of the individual's last name (Japan only).
        /// </summary>
        [JsonProperty("last_name_kanji")]
        public string LastNameKanji { get; set; }

        /// <summary>
        /// The individual's maiden name.
        /// </summary>
        [JsonProperty("maiden_name")]
        public string MaidenName { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The individual's phone number.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Indicates if the person or any of their representatives, family members, or other
        /// closely related persons, declares that they hold or have held an important public job or
        /// function, in any jurisdiction.
        /// One of: <c>existing</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("political_exposure")]
        public string PoliticalExposure { get; set; }

        /// <summary>
        /// The individual's registered address.
        /// </summary>
        [JsonProperty("registered_address")]
        public AddressOptions RegisteredAddress { get; set; }

        /// <summary>
        /// Describes the person’s relationship to the account.
        /// </summary>
        [JsonProperty("relationship")]
        public AccountIndividualRelationshipOptions Relationship { get; set; }

        /// <summary>
        /// The last four digits of the individual's Social Security Number (U.S. only).
        /// </summary>
        [JsonProperty("ssn_last_4")]
        public string SsnLast4 { get; set; }

        /// <summary>
        /// The individual's verification document information.
        /// </summary>
        [JsonProperty("verification")]
        public AccountIndividualVerificationOptions Verification { get; set; }
    }
}
