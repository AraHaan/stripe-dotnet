// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountCapabilitiesOptions : INestedOptions
    {
        /// <summary>
        /// The acss_debit_payments capability.
        /// </summary>
        [JsonProperty("acss_debit_payments")]
        public AccountCapabilitiesAcssDebitPaymentsOptions AcssDebitPayments { get; set; }

        /// <summary>
        /// The affirm_payments capability.
        /// </summary>
        [JsonProperty("affirm_payments")]
        public AccountCapabilitiesAffirmPaymentsOptions AffirmPayments { get; set; }

        /// <summary>
        /// The afterpay_clearpay_payments capability.
        /// </summary>
        [JsonProperty("afterpay_clearpay_payments")]
        public AccountCapabilitiesAfterpayClearpayPaymentsOptions AfterpayClearpayPayments { get; set; }

        /// <summary>
        /// The alma_payments capability.
        /// </summary>
        [JsonProperty("alma_payments")]
        public AccountCapabilitiesAlmaPaymentsOptions AlmaPayments { get; set; }

        /// <summary>
        /// The amazon_pay_payments capability.
        /// </summary>
        [JsonProperty("amazon_pay_payments")]
        public AccountCapabilitiesAmazonPayPaymentsOptions AmazonPayPayments { get; set; }

        /// <summary>
        /// The au_becs_debit_payments capability.
        /// </summary>
        [JsonProperty("au_becs_debit_payments")]
        public AccountCapabilitiesAuBecsDebitPaymentsOptions AuBecsDebitPayments { get; set; }

        /// <summary>
        /// The bacs_debit_payments capability.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
        public AccountCapabilitiesBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        /// <summary>
        /// The bancontact_payments capability.
        /// </summary>
        [JsonProperty("bancontact_payments")]
        public AccountCapabilitiesBancontactPaymentsOptions BancontactPayments { get; set; }

        /// <summary>
        /// The bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("bank_transfer_payments")]
        public AccountCapabilitiesBankTransferPaymentsOptions BankTransferPayments { get; set; }

        /// <summary>
        /// The blik_payments capability.
        /// </summary>
        [JsonProperty("blik_payments")]
        public AccountCapabilitiesBlikPaymentsOptions BlikPayments { get; set; }

        /// <summary>
        /// The boleto_payments capability.
        /// </summary>
        [JsonProperty("boleto_payments")]
        public AccountCapabilitiesBoletoPaymentsOptions BoletoPayments { get; set; }

        /// <summary>
        /// The card_issuing capability.
        /// </summary>
        [JsonProperty("card_issuing")]
        public AccountCapabilitiesCardIssuingOptions CardIssuing { get; set; }

        /// <summary>
        /// The card_payments capability.
        /// </summary>
        [JsonProperty("card_payments")]
        public AccountCapabilitiesCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// The cartes_bancaires_payments capability.
        /// </summary>
        [JsonProperty("cartes_bancaires_payments")]
        public AccountCapabilitiesCartesBancairesPaymentsOptions CartesBancairesPayments { get; set; }

        /// <summary>
        /// The cashapp_payments capability.
        /// </summary>
        [JsonProperty("cashapp_payments")]
        public AccountCapabilitiesCashappPaymentsOptions CashappPayments { get; set; }

        /// <summary>
        /// The eps_payments capability.
        /// </summary>
        [JsonProperty("eps_payments")]
        public AccountCapabilitiesEpsPaymentsOptions EpsPayments { get; set; }

        /// <summary>
        /// The fpx_payments capability.
        /// </summary>
        [JsonProperty("fpx_payments")]
        public AccountCapabilitiesFpxPaymentsOptions FpxPayments { get; set; }

        /// <summary>
        /// The gb_bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("gb_bank_transfer_payments")]
        public AccountCapabilitiesGbBankTransferPaymentsOptions GbBankTransferPayments { get; set; }

        /// <summary>
        /// The giropay_payments capability.
        /// </summary>
        [JsonProperty("giropay_payments")]
        public AccountCapabilitiesGiropayPaymentsOptions GiropayPayments { get; set; }

        /// <summary>
        /// The grabpay_payments capability.
        /// </summary>
        [JsonProperty("grabpay_payments")]
        public AccountCapabilitiesGrabpayPaymentsOptions GrabpayPayments { get; set; }

        /// <summary>
        /// The ideal_payments capability.
        /// </summary>
        [JsonProperty("ideal_payments")]
        public AccountCapabilitiesIdealPaymentsOptions IdealPayments { get; set; }

        /// <summary>
        /// The india_international_payments capability.
        /// </summary>
        [JsonProperty("india_international_payments")]
        public AccountCapabilitiesIndiaInternationalPaymentsOptions IndiaInternationalPayments { get; set; }

        /// <summary>
        /// The jcb_payments capability.
        /// </summary>
        [JsonProperty("jcb_payments")]
        public AccountCapabilitiesJcbPaymentsOptions JcbPayments { get; set; }

        /// <summary>
        /// The jp_bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("jp_bank_transfer_payments")]
        public AccountCapabilitiesJpBankTransferPaymentsOptions JpBankTransferPayments { get; set; }

        /// <summary>
        /// The kakao_pay_payments capability.
        /// </summary>
        [JsonProperty("kakao_pay_payments")]
        public AccountCapabilitiesKakaoPayPaymentsOptions KakaoPayPayments { get; set; }

        /// <summary>
        /// The klarna_payments capability.
        /// </summary>
        [JsonProperty("klarna_payments")]
        public AccountCapabilitiesKlarnaPaymentsOptions KlarnaPayments { get; set; }

        /// <summary>
        /// The konbini_payments capability.
        /// </summary>
        [JsonProperty("konbini_payments")]
        public AccountCapabilitiesKonbiniPaymentsOptions KonbiniPayments { get; set; }

        /// <summary>
        /// The kr_card_payments capability.
        /// </summary>
        [JsonProperty("kr_card_payments")]
        public AccountCapabilitiesKrCardPaymentsOptions KrCardPayments { get; set; }

        /// <summary>
        /// The legacy_payments capability.
        /// </summary>
        [JsonProperty("legacy_payments")]
        public AccountCapabilitiesLegacyPaymentsOptions LegacyPayments { get; set; }

        /// <summary>
        /// The link_payments capability.
        /// </summary>
        [JsonProperty("link_payments")]
        public AccountCapabilitiesLinkPaymentsOptions LinkPayments { get; set; }

        /// <summary>
        /// The mobilepay_payments capability.
        /// </summary>
        [JsonProperty("mobilepay_payments")]
        public AccountCapabilitiesMobilepayPaymentsOptions MobilepayPayments { get; set; }

        /// <summary>
        /// The multibanco_payments capability.
        /// </summary>
        [JsonProperty("multibanco_payments")]
        public AccountCapabilitiesMultibancoPaymentsOptions MultibancoPayments { get; set; }

        /// <summary>
        /// The mx_bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("mx_bank_transfer_payments")]
        public AccountCapabilitiesMxBankTransferPaymentsOptions MxBankTransferPayments { get; set; }

        /// <summary>
        /// The naver_pay_payments capability.
        /// </summary>
        [JsonProperty("naver_pay_payments")]
        public AccountCapabilitiesNaverPayPaymentsOptions NaverPayPayments { get; set; }

        /// <summary>
        /// The oxxo_payments capability.
        /// </summary>
        [JsonProperty("oxxo_payments")]
        public AccountCapabilitiesOxxoPaymentsOptions OxxoPayments { get; set; }

        /// <summary>
        /// The p24_payments capability.
        /// </summary>
        [JsonProperty("p24_payments")]
        public AccountCapabilitiesP24PaymentsOptions P24Payments { get; set; }

        /// <summary>
        /// The pay_by_bank_payments capability.
        /// </summary>
        [JsonProperty("pay_by_bank_payments")]
        public AccountCapabilitiesPayByBankPaymentsOptions PayByBankPayments { get; set; }

        /// <summary>
        /// The payco_payments capability.
        /// </summary>
        [JsonProperty("payco_payments")]
        public AccountCapabilitiesPaycoPaymentsOptions PaycoPayments { get; set; }

        /// <summary>
        /// The paynow_payments capability.
        /// </summary>
        [JsonProperty("paynow_payments")]
        public AccountCapabilitiesPaynowPaymentsOptions PaynowPayments { get; set; }

        /// <summary>
        /// The promptpay_payments capability.
        /// </summary>
        [JsonProperty("promptpay_payments")]
        public AccountCapabilitiesPromptpayPaymentsOptions PromptpayPayments { get; set; }

        /// <summary>
        /// The revolut_pay_payments capability.
        /// </summary>
        [JsonProperty("revolut_pay_payments")]
        public AccountCapabilitiesRevolutPayPaymentsOptions RevolutPayPayments { get; set; }

        /// <summary>
        /// The samsung_pay_payments capability.
        /// </summary>
        [JsonProperty("samsung_pay_payments")]
        public AccountCapabilitiesSamsungPayPaymentsOptions SamsungPayPayments { get; set; }

        /// <summary>
        /// The sepa_bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("sepa_bank_transfer_payments")]
        public AccountCapabilitiesSepaBankTransferPaymentsOptions SepaBankTransferPayments { get; set; }

        /// <summary>
        /// The sepa_debit_payments capability.
        /// </summary>
        [JsonProperty("sepa_debit_payments")]
        public AccountCapabilitiesSepaDebitPaymentsOptions SepaDebitPayments { get; set; }

        /// <summary>
        /// The sofort_payments capability.
        /// </summary>
        [JsonProperty("sofort_payments")]
        public AccountCapabilitiesSofortPaymentsOptions SofortPayments { get; set; }

        /// <summary>
        /// The swish_payments capability.
        /// </summary>
        [JsonProperty("swish_payments")]
        public AccountCapabilitiesSwishPaymentsOptions SwishPayments { get; set; }

        /// <summary>
        /// The tax_reporting_us_1099_k capability.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_k")]
        public AccountCapabilitiesTaxReportingUs1099KOptions TaxReportingUs1099K { get; set; }

        /// <summary>
        /// The tax_reporting_us_1099_misc capability.
        /// </summary>
        [JsonProperty("tax_reporting_us_1099_misc")]
        public AccountCapabilitiesTaxReportingUs1099MiscOptions TaxReportingUs1099Misc { get; set; }

        /// <summary>
        /// The transfers capability.
        /// </summary>
        [JsonProperty("transfers")]
        public AccountCapabilitiesTransfersOptions Transfers { get; set; }

        /// <summary>
        /// The treasury capability.
        /// </summary>
        [JsonProperty("treasury")]
        public AccountCapabilitiesTreasuryOptions Treasury { get; set; }

        /// <summary>
        /// The twint_payments capability.
        /// </summary>
        [JsonProperty("twint_payments")]
        public AccountCapabilitiesTwintPaymentsOptions TwintPayments { get; set; }

        /// <summary>
        /// The us_bank_account_ach_payments capability.
        /// </summary>
        [JsonProperty("us_bank_account_ach_payments")]
        public AccountCapabilitiesUsBankAccountAchPaymentsOptions UsBankAccountAchPayments { get; set; }

        /// <summary>
        /// The us_bank_transfer_payments capability.
        /// </summary>
        [JsonProperty("us_bank_transfer_payments")]
        public AccountCapabilitiesUsBankTransferPaymentsOptions UsBankTransferPayments { get; set; }

        /// <summary>
        /// The zip_payments capability.
        /// </summary>
        [JsonProperty("zip_payments")]
        public AccountCapabilitiesZipPaymentsOptions ZipPayments { get; set; }
    }
}
