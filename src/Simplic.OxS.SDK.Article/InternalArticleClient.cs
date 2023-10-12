/*
 * Simplic.OxS.Article
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;

namespace Simplic.OxS.SDK.Article
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInternalArticleClientSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.Article.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ArticleModel</returns>
        ArticleModel GetBy(Guid? id = default(Guid?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.Article.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ArticleModel</returns>
        ApiResponse<ArticleModel> GetByWithHttpInfo(Guid? id = default(Guid?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInternalArticleClientAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.Article.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ArticleModel</returns>
        System.Threading.Tasks.Task<ArticleModel> GetByAsync(Guid? id = default(Guid?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.Article.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ArticleModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<ArticleModel>> GetByWithHttpInfoAsync(Guid? id = default(Guid?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInternalArticleClient : IInternalArticleClientSync, IInternalArticleClientAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class InternalArticleClient : IInternalArticleClient
    {
        private Simplic.OxS.SDK.Article.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalArticleClient"/> class.
        /// </summary>
        /// <returns></returns>
        public InternalArticleClient() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalArticleClient"/> class.
        /// </summary>
        /// <returns></returns>
        public InternalArticleClient(string basePath)
        {
            this.Configuration = Simplic.OxS.SDK.Article.Configuration.MergeConfigurations(
                Simplic.OxS.SDK.Article.GlobalConfiguration.Instance,
                new Simplic.OxS.SDK.Article.Configuration { BasePath = basePath }
            );
            this.Client = new Simplic.OxS.SDK.Article.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Simplic.OxS.SDK.Article.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Simplic.OxS.SDK.Article.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalArticleClient"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public InternalArticleClient(Simplic.OxS.SDK.Article.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Simplic.OxS.SDK.Article.Configuration.MergeConfigurations(
                Simplic.OxS.SDK.Article.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Simplic.OxS.SDK.Article.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Simplic.OxS.SDK.Article.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Simplic.OxS.SDK.Article.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalArticleClient"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public InternalArticleClient(Simplic.OxS.SDK.Article.ISynchronousClient client, Simplic.OxS.SDK.Article.IAsynchronousClient asyncClient, Simplic.OxS.SDK.Article.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Simplic.OxS.SDK.Article.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Simplic.OxS.SDK.Article.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Simplic.OxS.SDK.Article.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Simplic.OxS.SDK.Article.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Simplic.OxS.SDK.Article.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.Article.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ArticleModel</returns>
        public ArticleModel GetBy(Guid? id = default(Guid?), int operationIndex = 0)
        {
            Simplic.OxS.SDK.Article.ApiResponse<ArticleModel> localVarResponse = GetByWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.Article.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ArticleModel</returns>
        public Simplic.OxS.SDK.Article.ApiResponse<ArticleModel> GetByWithHttpInfo(Guid? id = default(Guid?), int operationIndex = 0)
        {
            Simplic.OxS.SDK.Article.RequestOptions localVarRequestOptions = new Simplic.OxS.SDK.Article.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Simplic.OxS.SDK.Article.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Simplic.OxS.SDK.Article.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Simplic.OxS.SDK.Article.ClientUtils.ParameterToMultiMap("", "id", id));
            }

            localVarRequestOptions.Operation = "InternalArticleClient.GetBy";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ArticleModel>("/internal/InternalArticle/get-by-id", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBy", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.Article.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ArticleModel</returns>
        public async System.Threading.Tasks.Task<ArticleModel> GetByAsync(Guid? id = default(Guid?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Simplic.OxS.SDK.Article.ApiResponse<ArticleModel> localVarResponse = await GetByWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.Article.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ArticleModel)</returns>
        public async System.Threading.Tasks.Task<Simplic.OxS.SDK.Article.ApiResponse<ArticleModel>> GetByWithHttpInfoAsync(Guid? id = default(Guid?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Simplic.OxS.SDK.Article.RequestOptions localVarRequestOptions = new Simplic.OxS.SDK.Article.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Simplic.OxS.SDK.Article.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Simplic.OxS.SDK.Article.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Simplic.OxS.SDK.Article.ClientUtils.ParameterToMultiMap("", "id", id));
            }

            localVarRequestOptions.Operation = "InternalArticleClient.GetBy";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ArticleModel>("/internal/InternalArticle/get-by-id", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetBy", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
