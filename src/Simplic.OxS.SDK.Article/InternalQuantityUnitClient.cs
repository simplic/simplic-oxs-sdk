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

// -- Custom --
using System.Threading;
using System.Threading.Tasks;
// -^ Custom ^-

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Article
{
    // ------------------------- Custom -------------------------------
//: Interface
    
/// <summary>
/// Client to interact with the API endpoints of the article service.
/// </summary>
public interface IInternalQuantityUnitClient
{
    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    string GetBasePath();


    /// <summary>
    ///  
    /// </summary>
    /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id"> (optional)</param>
    /// <returns>QuantityUnitModel</returns>
    QuantityUnitModel GetById(Guid? id = default(Guid?));

    /// <summary>
    ///  
    /// </summary>
    /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id"> (optional)</param>
    /// <returns>ApiResponse of QuantityUnitModel</returns>
    ApiResponse<QuantityUnitModel> GetByIdWithHttpInfo(Guid? id = default(Guid?));
        
    /// <summary>
    ///  
    /// </summary>
    /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id"> (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of QuantityUnitModel</returns>
    Task<QuantityUnitModel> GetByIdAsync(Guid? id = default(Guid?), CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    ///  
    /// </summary>
    /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
    /// <param name="id"> (optional)</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (QuantityUnitModel)</returns>
    Task<ApiResponse<QuantityUnitModel>> GetByIdWithHttpInfoAsync(Guid? id = default(Guid?), CancellationToken cancellationToken = default(CancellationToken));

}


//: Implementation

    /// <summary>
    /// Client to interact with the API endpoints of the article service.
    /// </summary>
    public class InternalQuantityUnitClient : IInternalQuantityUnitClient
    {
        private __InternalQuantityUnitClient _internalClient;
        private Simplic.OxS.SDK.ExceptionFactory _exceptionFactory = (name, response) => null;

        public InternalQuantityUnitClient(string host, string? authorization = null)
        {
            if (authorization != null)
            {
                _internalClient = new __InternalQuantityUnitClient(new Configuration
                {
                    BasePath = $"{host}/article-api/v1",
                    DefaultHeaders = { { "Authorization", authorization } }
                });
            }
            else
            {
                _internalClient = new __InternalQuantityUnitClient(new Configuration
                {
                    BasePath = $"{host}/article-api/v1",
                });
            }
        }

        public InternalQuantityUnitClient(Environment env, string? authorization = null)
            : this(
                env == Environment.Development
                    ? "https://dev-oxs.simplic.io"
                    : "https://oxs.simplic.io",
                authorization
            ) { }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath() => _internalClient.GetBasePath();

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Simplic.OxS.SDK.IReadableConfiguration Configuration
        {
            get => _internalClient.Configuration;
            set
            {
                _internalClient.Configuration = value;
            }
        }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Simplic.OxS.SDK.ExceptionFactory ExceptionFactory
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
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>QuantityUnitModel</returns>
        public QuantityUnitModel GetById(Guid? id = default(Guid?))
        {
            try
            {
                return _internalClient.GetById(id);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>ApiResponse of QuantityUnitModel</returns>
        public Simplic.OxS.SDK.ApiResponse<QuantityUnitModel> GetByIdWithHttpInfo(Guid? id = default(Guid?))
        {
            try
            {
                return _internalClient.GetByIdWithHttpInfo(id);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        } 

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of QuantityUnitModel</returns>
        public System.Threading.Tasks.Task<QuantityUnitModel> GetByIdAsync(Guid? id = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            try
            {
                return _internalClient.GetByIdAsync(id, cancellationToken: cancellationToken);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (QuantityUnitModel)</returns>
        public System.Threading.Tasks.Task<Simplic.OxS.SDK.ApiResponse<QuantityUnitModel>> GetByIdWithHttpInfoAsync(Guid? id = default(Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            try
            {
                return _internalClient.GetByIdWithHttpInfoAsync(id, cancellationToken: cancellationToken);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }    

        private string FormatErrorMessage(string message, int errorCode) => $"<{errorCode} - {(HttpStatusCode)errorCode}> {message}";
    }

// ------------------------^ Custom ^------------------------------


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    internal interface __IInternalQuantityUnitClientSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>QuantityUnitModel</returns>
        QuantityUnitModel GetById(Guid? id = default(Guid?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of QuantityUnitModel</returns>
        ApiResponse<QuantityUnitModel> GetByIdWithHttpInfo(Guid? id = default(Guid?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    internal interface __IInternalQuantityUnitClientAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of QuantityUnitModel</returns>
        System.Threading.Tasks.Task<QuantityUnitModel> GetByIdAsync(Guid? id = default(Guid?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (QuantityUnitModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<QuantityUnitModel>> GetByIdWithHttpInfoAsync(Guid? id = default(Guid?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    internal interface __IInternalQuantityUnitClient : __IInternalQuantityUnitClientSync, __IInternalQuantityUnitClientAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    internal /*partial*/ class __InternalQuantityUnitClient : __IInternalQuantityUnitClient
    {
        private Simplic.OxS.SDK.ExceptionFactory _exceptionFactory = (name, response) => null;

        /*
        /// <summary>
        /// Initializes a new instance of the <see cref="__InternalQuantityUnitClient"/> class.
        /// </summary>
        /// <returns></returns>
        public __InternalQuantityUnitClient() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="__InternalQuantityUnitClient"/> class.
        /// </summary>
        /// <returns></returns>
        public __InternalQuantityUnitClient(string basePath)
        {
            this.Configuration = Simplic.OxS.SDK.Configuration.MergeConfigurations(
                Simplic.OxS.SDK.GlobalConfiguration.Instance,
                new Simplic.OxS.SDK.Configuration { BasePath = basePath }
            );
            this.Client = new Simplic.OxS.SDK.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Simplic.OxS.SDK.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Simplic.OxS.SDK.Configuration.DefaultExceptionFactory;
        }
        */

        /// <summary>
        /// Initializes a new instance of the <see cref="__InternalQuantityUnitClient"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public __InternalQuantityUnitClient(Simplic.OxS.SDK.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Simplic.OxS.SDK.Configuration.MergeConfigurations(
                Simplic.OxS.SDK.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Simplic.OxS.SDK.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Simplic.OxS.SDK.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Simplic.OxS.SDK.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="__InternalQuantityUnitClient"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public __InternalQuantityUnitClient(Simplic.OxS.SDK.ISynchronousClient client, Simplic.OxS.SDK.IAsynchronousClient asyncClient, Simplic.OxS.SDK.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Simplic.OxS.SDK.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Simplic.OxS.SDK.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Simplic.OxS.SDK.ISynchronousClient Client { get; set; }

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
        public Simplic.OxS.SDK.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Simplic.OxS.SDK.ExceptionFactory ExceptionFactory
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
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>QuantityUnitModel</returns>
        public QuantityUnitModel GetById(Guid? id = default(Guid?), int operationIndex = 0)
        {
            Simplic.OxS.SDK.ApiResponse<QuantityUnitModel> localVarResponse = GetByIdWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of QuantityUnitModel</returns>
        public Simplic.OxS.SDK.ApiResponse<QuantityUnitModel> GetByIdWithHttpInfo(Guid? id = default(Guid?), int operationIndex = 0)
        {
            Simplic.OxS.SDK.RequestOptions localVarRequestOptions = new Simplic.OxS.SDK.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Simplic.OxS.SDK.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Simplic.OxS.SDK.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Simplic.OxS.SDK.ClientUtils.ParameterToMultiMap("", "id", id));
            }

            localVarRequestOptions.Operation = "InternalQuantityUnitClient.InternalInternalQuantityUnitGetByIdGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<QuantityUnitModel>("/internal/InternalQuantityUnit/get-by-id", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InternalInternalQuantityUnitGetByIdGet", localVarResponse);
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
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of QuantityUnitModel</returns>
        public async System.Threading.Tasks.Task<QuantityUnitModel> GetByIdAsync(Guid? id = default(Guid?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Simplic.OxS.SDK.ApiResponse<QuantityUnitModel> localVarResponse = await GetByIdWithHttpInfoAsync(id, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (QuantityUnitModel)</returns>
        public async System.Threading.Tasks.Task<Simplic.OxS.SDK.ApiResponse<QuantityUnitModel>> GetByIdWithHttpInfoAsync(Guid? id = default(Guid?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Simplic.OxS.SDK.RequestOptions localVarRequestOptions = new Simplic.OxS.SDK.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Simplic.OxS.SDK.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Simplic.OxS.SDK.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Simplic.OxS.SDK.ClientUtils.ParameterToMultiMap("", "id", id));
            }

            localVarRequestOptions.Operation = "InternalQuantityUnitClient.InternalInternalQuantityUnitGetByIdGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<QuantityUnitModel>("/internal/InternalQuantityUnit/get-by-id", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InternalInternalQuantityUnitGetByIdGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
