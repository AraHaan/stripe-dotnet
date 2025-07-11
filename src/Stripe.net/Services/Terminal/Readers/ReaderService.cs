// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReaderService : Service,
        ICreatable<Reader, ReaderCreateOptions>,
        IDeletable<Reader, ReaderDeleteOptions>,
        IListable<Reader, ReaderListOptions>,
        IRetrievable<Reader, ReaderGetOptions>,
        IUpdatable<Reader, ReaderUpdateOptions>
    {
        public ReaderService()
        {
        }

        internal ReaderService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        public ReaderService(IStripeClient client)
            : base(client)
        {
        }

        /// <summary>
        /// <p>Cancels the current reader action.</p>.
        /// </summary>
        public virtual Reader CancelAction(string id, ReaderCancelActionOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/cancel_action", options, requestOptions);
        }

        /// <summary>
        /// <p>Cancels the current reader action.</p>.
        /// </summary>
        public virtual Task<Reader> CancelActionAsync(string id, ReaderCancelActionOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/cancel_action", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Initiates an input collection flow on a Reader.</p>.
        /// </summary>
        public virtual Reader CollectInputs(string id, ReaderCollectInputsOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/collect_inputs", options, requestOptions);
        }

        /// <summary>
        /// <p>Initiates an input collection flow on a Reader.</p>.
        /// </summary>
        public virtual Task<Reader> CollectInputsAsync(string id, ReaderCollectInputsOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/collect_inputs", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Initiates a payment flow on a Reader and updates the PaymentIntent with card details
        /// before manual confirmation.</p>.
        /// </summary>
        public virtual Reader CollectPaymentMethod(string id, ReaderCollectPaymentMethodOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/collect_payment_method", options, requestOptions);
        }

        /// <summary>
        /// <p>Initiates a payment flow on a Reader and updates the PaymentIntent with card details
        /// before manual confirmation.</p>.
        /// </summary>
        public virtual Task<Reader> CollectPaymentMethodAsync(string id, ReaderCollectPaymentMethodOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/collect_payment_method", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Finalizes a payment on a Reader.</p>.
        /// </summary>
        public virtual Reader ConfirmPaymentIntent(string id, ReaderConfirmPaymentIntentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/confirm_payment_intent", options, requestOptions);
        }

        /// <summary>
        /// <p>Finalizes a payment on a Reader.</p>.
        /// </summary>
        public virtual Task<Reader> ConfirmPaymentIntentAsync(string id, ReaderConfirmPaymentIntentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/confirm_payment_intent", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Creates a new <c>Reader</c> object.</p>.
        /// </summary>
        public virtual Reader Create(ReaderCreateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers", options, requestOptions);
        }

        /// <summary>
        /// <p>Creates a new <c>Reader</c> object.</p>.
        /// </summary>
        public virtual Task<Reader> CreateAsync(ReaderCreateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Deletes a <c>Reader</c> object.</p>.
        /// </summary>
        public virtual Reader Delete(string id, ReaderDeleteOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Delete, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Deletes a <c>Reader</c> object.</p>.
        /// </summary>
        public virtual Task<Reader> DeleteAsync(string id, ReaderDeleteOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Delete, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Retrieves a <c>Reader</c> object.</p>.
        /// </summary>
        public virtual Reader Get(string id, ReaderGetOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Get, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Retrieves a <c>Reader</c> object.</p>.
        /// </summary>
        public virtual Task<Reader> GetAsync(string id, ReaderGetOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Get, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of <c>Reader</c> objects.</p>.
        /// </summary>
        public virtual StripeList<Reader> List(ReaderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<StripeList<Reader>>(BaseAddress.Api, HttpMethod.Get, $"/v1/terminal/readers", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of <c>Reader</c> objects.</p>.
        /// </summary>
        public virtual Task<StripeList<Reader>> ListAsync(ReaderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<StripeList<Reader>>(BaseAddress.Api, HttpMethod.Get, $"/v1/terminal/readers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Returns a list of <c>Reader</c> objects.</p>.
        /// </summary>
        public virtual IEnumerable<Reader> ListAutoPaging(ReaderListOptions options = null, RequestOptions requestOptions = null)
        {
            return this.ListRequestAutoPaging<Reader>($"/v1/terminal/readers", options, requestOptions);
        }

        /// <summary>
        /// <p>Returns a list of <c>Reader</c> objects.</p>.
        /// </summary>
        public virtual IAsyncEnumerable<Reader> ListAutoPagingAsync(ReaderListOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.ListRequestAutoPagingAsync<Reader>($"/v1/terminal/readers", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Initiates a payment flow on a Reader.</p>.
        /// </summary>
        public virtual Reader ProcessPaymentIntent(string id, ReaderProcessPaymentIntentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/process_payment_intent", options, requestOptions);
        }

        /// <summary>
        /// <p>Initiates a payment flow on a Reader.</p>.
        /// </summary>
        public virtual Task<Reader> ProcessPaymentIntentAsync(string id, ReaderProcessPaymentIntentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/process_payment_intent", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Initiates a setup intent flow on a Reader.</p>.
        /// </summary>
        public virtual Reader ProcessSetupIntent(string id, ReaderProcessSetupIntentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/process_setup_intent", options, requestOptions);
        }

        /// <summary>
        /// <p>Initiates a setup intent flow on a Reader.</p>.
        /// </summary>
        public virtual Task<Reader> ProcessSetupIntentAsync(string id, ReaderProcessSetupIntentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/process_setup_intent", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Initiates a refund on a Reader</p>.
        /// </summary>
        public virtual Reader RefundPayment(string id, ReaderRefundPaymentOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/refund_payment", options, requestOptions);
        }

        /// <summary>
        /// <p>Initiates a refund on a Reader</p>.
        /// </summary>
        public virtual Task<Reader> RefundPaymentAsync(string id, ReaderRefundPaymentOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/refund_payment", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Sets reader display to show cart details.</p>.
        /// </summary>
        public virtual Reader SetReaderDisplay(string id, ReaderSetReaderDisplayOptions options = null, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/set_reader_display", options, requestOptions);
        }

        /// <summary>
        /// <p>Sets reader display to show cart details.</p>.
        /// </summary>
        public virtual Task<Reader> SetReaderDisplayAsync(string id, ReaderSetReaderDisplayOptions options = null, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}/set_reader_display", options, requestOptions, cancellationToken);
        }

        /// <summary>
        /// <p>Updates a <c>Reader</c> object by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Reader Update(string id, ReaderUpdateOptions options, RequestOptions requestOptions = null)
        {
            return this.Request<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}", options, requestOptions);
        }

        /// <summary>
        /// <p>Updates a <c>Reader</c> object by setting the values of the parameters passed. Any
        /// parameters not provided will be left unchanged.</p>.
        /// </summary>
        public virtual Task<Reader> UpdateAsync(string id, ReaderUpdateOptions options, RequestOptions requestOptions = null, CancellationToken cancellationToken = default)
        {
            return this.RequestAsync<Reader>(BaseAddress.Api, HttpMethod.Post, $"/v1/terminal/readers/{WebUtility.UrlEncode(id)}", options, requestOptions, cancellationToken);
        }
    }
}
