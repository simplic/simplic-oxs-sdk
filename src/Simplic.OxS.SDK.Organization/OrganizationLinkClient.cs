/*
 * Simplic.OxS.Organization
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

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Organization
{
    //--Custom wrapper start
    /// <summary>
    /// Client to interact with the API endpoints of the organization service.
    /// </summary>
    public class OrganizationLinkClient : IOrganizationLinkClient
    {
        private __OrganizationLinkClient _internalClient;
        private Simplic.OxS.SDK.ExceptionFactory _exceptionFactory = (name, response) => null;

        public OrganizationLinkClient(string host, string? authorization = null)
        {
            if (authorization != null)
            {
                _internalClient = new __OrganizationLinkClient(new Configuration
                {
                    BasePath = $"{host}/organization-api/v1",
                    DefaultHeaders = { { "Authorization", authorization } }
                });
            }
            else
            {
                _internalClient = new __OrganizationLinkClient(new Configuration
                {
                    BasePath = $"{host}/organization-api/v1",
                });
            }
        }

        public OrganizationLinkClient(Environment env, string? authorization = null)
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
        /// Returns a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;OrganizationLinkModel&gt;</returns>
        public List<OrganizationLinkModel> GetLinked(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0)
        {
            try
            {
                return _internalClient.GetLinked(module, searchContains, operationIndex);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <summary>
        /// Returns a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;OrganizationLinkModel&gt;</returns>
        public Simplic.OxS.SDK.ApiResponse<List<OrganizationLinkModel>> GetLinkedWithHttpInfo(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0)
        {
            try
            {
                return _internalClient.GetLinkedWithHttpInfo(module, searchContains, operationIndex);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        } 

        /// <summary>
        /// Returns a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;OrganizationLinkModel&gt;</returns>
        public System.Threading.Tasks.Task<List<OrganizationLinkModel>> GetLinkedAsync(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            try
            {
                return _internalClient.GetLinkedAsync(module, searchContains, operationIndex, cancellationToken);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <summary>
        /// Returns a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;OrganizationLinkModel&gt;)</returns>
        public System.Threading.Tasks.Task<Simplic.OxS.SDK.ApiResponse<List<OrganizationLinkModel>>> GetLinkedWithHttpInfoAsync(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            try
            {
                return _internalClient.GetLinkedWithHttpInfoAsync(module, searchContains, operationIndex, cancellationToken);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }    

        private string FormatErrorMessage(string message, int errorCode) => $"<{errorCode} - {(HttpStatusCode)errorCode}> {message}";
    }
    //--Custom wrapper end

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrganizationLinkClientSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns a list of organizations that belongs to the current user
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;OrganizationLinkModel&gt;</returns>
        List<OrganizationLinkModel> GetLinked(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0);

        /// <summary>
        /// Returns a list of organizations that belongs to the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;OrganizationLinkModel&gt;</returns>
        ApiResponse<List<OrganizationLinkModel>> GetLinkedWithHttpInfo(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrganizationLinkClientAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns a list of organizations that belongs to the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;OrganizationLinkModel&gt;</returns>
        System.Threading.Tasks.Task<List<OrganizationLinkModel>> GetLinkedAsync(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Returns a list of organizations that belongs to the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;OrganizationLinkModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OrganizationLinkModel>>> GetLinkedWithHttpInfoAsync(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrganizationLinkClient : IOrganizationLinkClientSync, IOrganizationLinkClientAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    internal partial class __OrganizationLinkClient : IOrganizationLinkClient
    {
        private Simplic.OxS.SDK.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="__OrganizationLinkClient"/> class.
        /// </summary>
        /// <returns></returns>
        public __OrganizationLinkClient() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="__OrganizationLinkClient"/> class.
        /// </summary>
        /// <returns></returns>
        public __OrganizationLinkClient(string basePath)
        {
            this.Configuration = Simplic.OxS.SDK.Configuration.MergeConfigurations(
                Simplic.OxS.SDK.GlobalConfiguration.Instance,
                new Simplic.OxS.SDK.Configuration { BasePath = basePath }
            );
            this.Client = new Simplic.OxS.SDK.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Simplic.OxS.SDK.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Simplic.OxS.SDK.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="__OrganizationLinkClient"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public __OrganizationLinkClient(Simplic.OxS.SDK.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="__OrganizationLinkClient"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public __OrganizationLinkClient(Simplic.OxS.SDK.ISynchronousClient client, Simplic.OxS.SDK.IAsynchronousClient asyncClient, Simplic.OxS.SDK.IReadableConfiguration configuration)
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
        /// Returns a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;OrganizationLinkModel&gt;</returns>
        public List<OrganizationLinkModel> GetLinked(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0)
        {
            Simplic.OxS.SDK.ApiResponse<List<OrganizationLinkModel>> localVarResponse = GetLinkedWithHttpInfo(module, searchContains);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;OrganizationLinkModel&gt;</returns>
        public Simplic.OxS.SDK.ApiResponse<List<OrganizationLinkModel>> GetLinkedWithHttpInfo(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0)
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

            if (module != null)
            {
                localVarRequestOptions.QueryParameters.Add(Simplic.OxS.SDK.ClientUtils.ParameterToMultiMap("", "module", module));
            }
            if (searchContains != null)
            {
                localVarRequestOptions.QueryParameters.Add(Simplic.OxS.SDK.ClientUtils.ParameterToMultiMap("", "searchContains", searchContains));
            }

            localVarRequestOptions.Operation = "OrganizationLinkClient.GetLinked";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<OrganizationLinkModel>>("/OrganizationLink/get-linked", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLinked", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Returns a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;OrganizationLinkModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<OrganizationLinkModel>> GetLinkedAsync(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Simplic.OxS.SDK.ApiResponse<List<OrganizationLinkModel>> localVarResponse = await GetLinkedWithHttpInfoAsync(module, searchContains, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="module"> (optional)</param>
        /// <param name="searchContains"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;OrganizationLinkModel&gt;)</returns>
        public async System.Threading.Tasks.Task<Simplic.OxS.SDK.ApiResponse<List<OrganizationLinkModel>>> GetLinkedWithHttpInfoAsync(string? module = default(string?), string? searchContains = default(string?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (module != null)
            {
                localVarRequestOptions.QueryParameters.Add(Simplic.OxS.SDK.ClientUtils.ParameterToMultiMap("", "module", module));
            }
            if (searchContains != null)
            {
                localVarRequestOptions.QueryParameters.Add(Simplic.OxS.SDK.ClientUtils.ParameterToMultiMap("", "searchContains", searchContains));
            }

            localVarRequestOptions.Operation = "OrganizationLinkClient.GetLinked";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<OrganizationLinkModel>>("/OrganizationLink/get-linked", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetLinked", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}