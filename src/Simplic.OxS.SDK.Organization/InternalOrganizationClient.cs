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
    public class InternalOrganizationClient : IInternalOrganizationClient
    {
        private __InternalOrganizationClient _internalClient;
        private Simplic.OxS.SDK.ExceptionFactory _exceptionFactory = (name, response) => null;

        public InternalOrganizationClient(string host, string? authorization = null)
        {
            if (authorization != null)
            {
                _internalClient = new __InternalOrganizationClient(new Configuration
                {
                    BasePath = $"{host}/organization-api/v1",
                    DefaultHeaders = { { "Authorization", authorization } }
                });
            }
            else
            {
                _internalClient = new __InternalOrganizationClient(new Configuration
                {
                    BasePath = $"{host}/organization-api/v1",
                });
            }
        }

        public InternalOrganizationClient(Environment env, string? authorization = null)
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
        /// Gets a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;OrganizationMemberModel&gt;</returns>
        public List<OrganizationMemberModel> GetAll(int operationIndex = 0)
        {
            try
            {
                return _internalClient.GetAll(operationIndex);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <summary>
        /// Gets a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;OrganizationMemberModel&gt;</returns>
        public Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>> GetAllWithHttpInfo(int operationIndex = 0)
        {
            try
            {
                return _internalClient.GetAllWithHttpInfo(operationIndex);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        } 

        /// <summary>
        /// Gets a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;OrganizationMemberModel&gt;</returns>
        public System.Threading.Tasks.Task<List<OrganizationMemberModel>> GetAllAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            try
            {
                return _internalClient.GetAllAsync(operationIndex, cancellationToken);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <summary>
        /// Gets a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;OrganizationMemberModel&gt;)</returns>
        public System.Threading.Tasks.Task<Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>>> GetAllWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            try
            {
                return _internalClient.GetAllWithHttpInfoAsync(operationIndex, cancellationToken);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }    
        /// <summary>
        /// Gets a list of all users of an organization. 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;OrganizationMemberModel&gt;</returns>
        public List<OrganizationMemberModel> GetUsers(int operationIndex = 0)
        {
            try
            {
                return _internalClient.GetUsers(operationIndex);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <summary>
        /// Gets a list of all users of an organization. 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;OrganizationMemberModel&gt;</returns>
        public Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>> GetUsersWithHttpInfo(int operationIndex = 0)
        {
            try
            {
                return _internalClient.GetUsersWithHttpInfo(operationIndex);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        } 

        /// <summary>
        /// Gets a list of all users of an organization. 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;OrganizationMemberModel&gt;</returns>
        public System.Threading.Tasks.Task<List<OrganizationMemberModel>> GetUsersAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            try
            {
                return _internalClient.GetUsersAsync(operationIndex, cancellationToken);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <summary>
        /// Gets a list of all users of an organization. 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;OrganizationMemberModel&gt;)</returns>
        public System.Threading.Tasks.Task<Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>>> GetUsersWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            try
            {
                return _internalClient.GetUsersWithHttpInfoAsync(operationIndex, cancellationToken);
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
    public interface IInternalOrganizationClientSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets a list of organizations that belongs to the current user
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;OrganizationMemberModel&gt;</returns>
        List<OrganizationMemberModel> GetAll(int operationIndex = 0);

        /// <summary>
        /// Gets a list of organizations that belongs to the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;OrganizationMemberModel&gt;</returns>
        ApiResponse<List<OrganizationMemberModel>> GetAllWithHttpInfo(int operationIndex = 0);
        /// <summary>
        /// Gets a list of all users of an organization.
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;OrganizationMemberModel&gt;</returns>
        List<OrganizationMemberModel> GetUsers(int operationIndex = 0);

        /// <summary>
        /// Gets a list of all users of an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;OrganizationMemberModel&gt;</returns>
        ApiResponse<List<OrganizationMemberModel>> GetUsersWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInternalOrganizationClientAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Gets a list of organizations that belongs to the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;OrganizationMemberModel&gt;</returns>
        System.Threading.Tasks.Task<List<OrganizationMemberModel>> GetAllAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets a list of organizations that belongs to the current user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;OrganizationMemberModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OrganizationMemberModel>>> GetAllWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a list of all users of an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;OrganizationMemberModel&gt;</returns>
        System.Threading.Tasks.Task<List<OrganizationMemberModel>> GetUsersAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Gets a list of all users of an organization.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;OrganizationMemberModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<OrganizationMemberModel>>> GetUsersWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInternalOrganizationClient : IInternalOrganizationClientSync, IInternalOrganizationClientAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    internal partial class __InternalOrganizationClient : IInternalOrganizationClient
    {
        private Simplic.OxS.SDK.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="__InternalOrganizationClient"/> class.
        /// </summary>
        /// <returns></returns>
        public __InternalOrganizationClient() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="__InternalOrganizationClient"/> class.
        /// </summary>
        /// <returns></returns>
        public __InternalOrganizationClient(string basePath)
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
        /// Initializes a new instance of the <see cref="__InternalOrganizationClient"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public __InternalOrganizationClient(Simplic.OxS.SDK.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="__InternalOrganizationClient"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public __InternalOrganizationClient(Simplic.OxS.SDK.ISynchronousClient client, Simplic.OxS.SDK.IAsynchronousClient asyncClient, Simplic.OxS.SDK.IReadableConfiguration configuration)
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
        /// Gets a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;OrganizationMemberModel&gt;</returns>
        public List<OrganizationMemberModel> GetAll(int operationIndex = 0)
        {
            Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>> localVarResponse = GetAllWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;OrganizationMemberModel&gt;</returns>
        public Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>> GetAllWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "InternalOrganizationClient.InternalInternalOrganizationGetAllGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<OrganizationMemberModel>>("/internal/InternalOrganization/get-all", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InternalInternalOrganizationGetAllGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;OrganizationMemberModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<OrganizationMemberModel>> GetAllAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>> localVarResponse = await GetAllWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of organizations that belongs to the current user 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;OrganizationMemberModel&gt;)</returns>
        public async System.Threading.Tasks.Task<Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>>> GetAllWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "InternalOrganizationClient.InternalInternalOrganizationGetAllGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<OrganizationMemberModel>>("/internal/InternalOrganization/get-all", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InternalInternalOrganizationGetAllGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets a list of all users of an organization. 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>List&lt;OrganizationMemberModel&gt;</returns>
        public List<OrganizationMemberModel> GetUsers(int operationIndex = 0)
        {
            Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>> localVarResponse = GetUsersWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of all users of an organization. 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of List&lt;OrganizationMemberModel&gt;</returns>
        public Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>> GetUsersWithHttpInfo(int operationIndex = 0)
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


            localVarRequestOptions.Operation = "InternalOrganizationClient.InternalInternalOrganizationGetUsersGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<List<OrganizationMemberModel>>("/internal/InternalOrganization/get-users", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InternalInternalOrganizationGetUsersGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Gets a list of all users of an organization. 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;OrganizationMemberModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<OrganizationMemberModel>> GetUsersAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>> localVarResponse = await GetUsersWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of all users of an organization. 
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;OrganizationMemberModel&gt;)</returns>
        public async System.Threading.Tasks.Task<Simplic.OxS.SDK.ApiResponse<List<OrganizationMemberModel>>> GetUsersWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            localVarRequestOptions.Operation = "InternalOrganizationClient.InternalInternalOrganizationGetUsersGet";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<List<OrganizationMemberModel>>("/internal/InternalOrganization/get-users", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("InternalInternalOrganizationGetUsersGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}