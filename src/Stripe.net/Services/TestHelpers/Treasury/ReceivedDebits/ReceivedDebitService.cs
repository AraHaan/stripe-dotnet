// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class ReceivedDebitService : Service
    {
        public ReceivedDebitService()
        {
        }

        internal ReceivedDebitService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ReceivedDebitService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Use this endpoint to simulate a test mode ReceivedDebit initiated by a third party.
        /// In live mode, you can’t directly create ReceivedDebits initiated by third parties.</p>.
        /// </summary>
        public virtual Stripe.Treasury.ReceivedDebit Create(ReceivedDebitCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.ReceivedDebit>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/received_debits", options, requestOptions);
        }

        /// <summary>
        /// <p>Use this endpoint to simulate a test mode ReceivedDebit initiated by a third party.
        /// In live mode, you can’t directly create ReceivedDebits initiated by third parties.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.ReceivedDebit> CreateAsync(ReceivedDebitCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.ReceivedDebit>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/received_debits", options, requestOptions, cancellationToken);
        }
    }
}
