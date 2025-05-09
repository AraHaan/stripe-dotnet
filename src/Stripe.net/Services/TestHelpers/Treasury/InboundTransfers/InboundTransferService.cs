// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe.Treasury;

    public class InboundTransferService : Service
    {
        public InboundTransferService()
        {
        }

        internal InboundTransferService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public InboundTransferService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Transitions a test mode created InboundTransfer to the <c>failed</c> status. The
        /// InboundTransfer must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.InboundTransfer Fail(string id, InboundTransferFailOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/inbound_transfers/{WebUtility.UrlEncode(id)}/fail", options, requestOptions);
        }

        /// <summary>
        /// <p>Transitions a test mode created InboundTransfer to the <c>failed</c> status. The
        /// InboundTransfer must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.InboundTransfer> FailAsync(string id, InboundTransferFailOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/inbound_transfers/{WebUtility.UrlEncode(id)}/fail", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Marks the test mode InboundTransfer object as returned and links the InboundTransfer
        /// to a ReceivedDebit. The InboundTransfer must already be in the <c>succeeded</c>
        /// state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.InboundTransfer ReturnInboundTransfer(string id, InboundTransferReturnInboundTransferOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/inbound_transfers/{WebUtility.UrlEncode(id)}/return", options, requestOptions);
        }

        /// <summary>
        /// <p>Marks the test mode InboundTransfer object as returned and links the InboundTransfer
        /// to a ReceivedDebit. The InboundTransfer must already be in the <c>succeeded</c>
        /// state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.InboundTransfer> ReturnInboundTransferAsync(string id, InboundTransferReturnInboundTransferOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/inbound_transfers/{WebUtility.UrlEncode(id)}/return", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Transitions a test mode created InboundTransfer to the <c>succeeded</c> status. The
        /// InboundTransfer must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Stripe.Treasury.InboundTransfer Succeed(string id, InboundTransferSucceedOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Stripe.Treasury.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/inbound_transfers/{WebUtility.UrlEncode(id)}/succeed", options, requestOptions);
        }

        /// <summary>
        /// <p>Transitions a test mode created InboundTransfer to the <c>succeeded</c> status. The
        /// InboundTransfer must already be in the <c>processing</c> state.</p>.
        /// </summary>
        public virtual Task<Stripe.Treasury.InboundTransfer> SucceedAsync(string id, InboundTransferSucceedOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Stripe.Treasury.InboundTransfer>(BaseAddress.Api, HttpMethod.Post, $"/v1/test_helpers/treasury/inbound_transfers/{WebUtility.UrlEncode(id)}/succeed", options, requestOptions, cancellationToken);
        }
    }
}
