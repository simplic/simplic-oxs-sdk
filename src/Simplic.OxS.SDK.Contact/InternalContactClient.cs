// <auto-generated>
/*
 * Simplic.OxS.Contact
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Contact
{
    //--Custom wrapper start
    /// <summary>
    /// Client to interact with the API endpoints of the contact service.
    /// </summary>
    public interface IInternalContactClient
    {
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        string GetBasePath();

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        //IReadableConfiguration Configuration;

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ContactModel</returns>
        ContactModel GetById(Guid id = default(Guid));

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <returns>ApiResponse of ContactModel</returns>
        ApiResponse<ContactModel> GetByIdWithHttpInfo(Guid id = default(Guid));
         
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ContactModel</returns>
        Task<ContactModel> GetByIdAsync(Guid id = default(Guid), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ContactModel)</returns>
        Task<ApiResponse<ContactModel>> GetByIdWithHttpInfoAsync(Guid id = default(Guid), CancellationToken cancellationToken = default(CancellationToken));

    }

    /// <inheritdoc cref="IInternalContactClient">
    public class InternalContactClient : IInternalContactClient
    {
        private __InternalContactClient _internalClient;
        private HttpClient _httpClient;

        public InternalContactClient(string host, string? authorization = null)
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri($"{host}/contact-api/v1") };
            var jsonSerializerOptions = new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
            var jsonSerializerOptionsProvider = new JsonSerializerOptionsProvider(jsonSerializerOptions);
            var events = new InternalContactClientEvents();
            if (authorization is null)
            {
                _internalClient = new __InternalContactClient(_httpClient, jsonSerializerOptionsProvider, events, new NullTokenProvider<ApiKeyToken>());
            }
            else
            {
                var token = new ApiKeyToken(authorization, "Authorization", "");
                _internalClient = new __InternalContactClient(_httpClient, jsonSerializerOptionsProvider, events, new ApiKeyTokenProvider(new[] { token }));
            }
        }

        public InternalContactClient(Environment env, string? authorization = null)
            : this(
                env == Environment.Development
                    ? "https://dev-oxs.simplic.io"
                    : "https://oxs.simplic.io",
                authorization
            ) { }

        /// <inheritdoc />
        public string GetBasePath() => _httpClient.BaseAddress.ToString();

        /// <inheritdoc />
        public ContactModel GetById(Guid id = default(Guid))
        {
            try
            {
                var response = _internalClient.GetByIdAsync(id).GetAwaiter().GetResult();
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                return response.Ok();
                
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <inheritdoc />
        public ApiResponse<ContactModel> GetByIdWithHttpInfo(Guid id = default(Guid))
        {
            try
            {
                var response = _internalClient.GetByIdAsync(id).GetAwaiter().GetResult();
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                
                return new ApiResponse<ContactModel>(response.StatusCode, response.Headers.ToMultimap(), response.Ok(), response.RawContent);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        } 

        /// <inheritdoc />
        public async Task<ContactModel> GetByIdAsync(Guid id = default(Guid), CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await _internalClient.GetByIdAsync(id, cancellationToken);
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
            
                return response.Ok();
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        }

        /// <inheritdoc />
        public async Task<ApiResponse<ContactModel>> GetByIdWithHttpInfoAsync(Guid id = default(Guid), CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await _internalClient.GetByIdAsync(id, cancellationToken);
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                
                return new ApiResponse<ContactModel>(response.StatusCode, response.Headers.ToMultimap(), response.Ok(), response.RawContent);
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
    /// This class is registered as transient.
    /// </summary>
    internal interface __IInternalContactClient : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        InternalContactClientEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__InternalContactClient.IInternalContactClientInternalInternalContactGetByIdGetApiResponse"/>&gt;</returns>
        Task<__InternalContactClient.IInternalContactClientInternalInternalContactGetByIdGetApiResponse> GetByIdAsync(Option<Guid> id = default, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__InternalContactClient.IInternalContactClientInternalInternalContactGetByIdGetApiResponse"/>?&gt;</returns>
        Task<__InternalContactClient.IInternalContactClientInternalInternalContactGetByIdGetApiResponse?> GetByIdOrDefaultAsync(Option<Guid> id = default, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InternalContactClientEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnInternalInternalContactGetByIdGet;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorInternalInternalContactGetByIdGet;

        internal void ExecuteOnInternalInternalContactGetByIdGet(__InternalContactClient.InternalContactClientInternalInternalContactGetByIdGetApiResponse apiResponse)
        {
            OnInternalInternalContactGetByIdGet?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorInternalInternalContactGetByIdGet(Exception exception)
        {
            OnErrorInternalInternalContactGetByIdGet?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    internal sealed partial class __InternalContactClient : __IInternalContactClient
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public InternalContactClientEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalContactClient"/> class.
        /// </summary>
        /// <returns></returns>
        public __InternalContactClient(
            HttpClient httpClient,
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            InternalContactClientEvents internalContactClientEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider
        )
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            HttpClient = httpClient;
            Events = internalContactClientEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatInternalInternalContactGetByIdGet(ref Option<Guid> id);

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="id"></param>
        private void AfterInternalInternalContactGetByIdGetDefaultImplementation(__InternalContactClient.IInternalContactClientInternalInternalContactGetByIdGetApiResponse apiResponseLocalVar, Option<Guid> id)
        {
            bool suppressDefaultLog = false;
            AfterInternalInternalContactGetByIdGet(ref suppressDefaultLog, apiResponseLocalVar, id);
            //if (!suppressDefaultLog)
            //    Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="id"></param>
        partial void AfterInternalInternalContactGetByIdGet(ref bool suppressDefaultLog, __InternalContactClient.IInternalContactClientInternalInternalContactGetByIdGetApiResponse apiResponseLocalVar, Option<Guid> id);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        private void OnErrorInternalInternalContactGetByIdGetDefaultImplementation(Exception exception, string pathFormat, string path, Option<Guid> id)
        {
            bool suppressDefaultLog = false;
            OnErrorInternalInternalContactGetByIdGet(ref suppressDefaultLog, exception, pathFormat, path, id);
            //if (!suppressDefaultLog)
            //    Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="id"></param>
        partial void OnErrorInternalInternalContactGetByIdGet(ref bool suppressDefaultLog, Exception exception, string pathFormat, string path, Option<Guid> id);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__InternalContactClient.IInternalContactClientInternalInternalContactGetByIdGetApiResponse"/>&gt;</returns>
        public async Task<__InternalContactClient.IInternalContactClientInternalInternalContactGetByIdGetApiResponse?> GetByIdOrDefaultAsync(Option<Guid> id = default, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetByIdAsync(id, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__InternalContactClient.IInternalContactClientInternalInternalContactGetByIdGetApiResponse"/>&gt;</returns>
        public async Task<__InternalContactClient.IInternalContactClientInternalInternalContactGetByIdGetApiResponse> GetByIdAsync(Option<Guid> id = default, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                FormatInternalInternalContactGetByIdGet(ref id);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.PathAndQuery + "/internal/InternalContact/get-by-id";

                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);

                    if (id.IsSet)
                        parseQueryStringLocalVar["id"] = id.Value.ToString();

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    if (ApiKeyProvider.HasTokens)
                    {
                        ApiKeyToken apiKeyTokenLocalVar;
                        apiKeyTokenLocalVar = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellation: cancellationToken).ConfigureAwait(false);
                        tokenBaseLocalVars.Add(apiKeyTokenLocalVar);
                        //apiKeyTokenLocalVar.UseInHeader(httpRequestMessageLocalVar, "Authorization");
                        apiKeyTokenLocalVar.UseInHeader(httpRequestMessageLocalVar);
                    }
                    

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "text/plain",
                        "application/json",
                        "text/json"
                    };

                    string? acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));
                    httpRequestMessageLocalVar.Method = new HttpMethod("GET");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        InternalContactClientInternalInternalContactGetByIdGetApiResponse apiResponseLocalVar = new InternalContactClientInternalInternalContactGetByIdGetApiResponse(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/internal/InternalContact/get-by-id", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterInternalInternalContactGetByIdGetDefaultImplementation(apiResponseLocalVar, id);

                        Events.ExecuteOnInternalInternalContactGetByIdGet(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorInternalInternalContactGetByIdGetDefaultImplementation(e, "/internal/InternalContact/get-by-id", uriBuilderLocalVar.Path, id);
                Events.ExecuteOnErrorInternalInternalContactGetByIdGet(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="IInternalContactClientInternalInternalContactGetByIdGetApiResponse"/>
        /// </summary>
        internal interface IInternalContactClientInternalInternalContactGetByIdGetApiResponse : Simplic.OxS.SDK.__IApiResponse, IOk<ContactModel>, IUnauthorized<ProblemDetails>, IBadRequest<ProblemDetails>
        {
            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            bool IsOk { get; }
    
            /// <summary>
            /// Returns true if the response is 401 Unauthorized
            /// </summary>
            /// <returns></returns>
            bool IsUnauthorized { get; }
    
            /// <summary>
            /// Returns true if the response is 400 BadRequest
            /// </summary>
            /// <returns></returns>
            bool IsBadRequest { get; }
        }

        /// <summary>
        /// The <see cref="InternalContactClientInternalInternalContactGetByIdGetApiResponse"/>
        /// </summary>
        internal partial class InternalContactClientInternalInternalContactGetByIdGetApiResponse : Simplic.OxS.SDK.__ApiResponse, IInternalContactClientInternalInternalContactGetByIdGetApiResponse
        {
            /// <summary>
            /// The <see cref="InternalContactClientInternalInternalContactGetByIdGetApiResponse"/>
            /// </summary>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public InternalContactClientInternalInternalContactGetByIdGetApiResponse(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok.
            /// Throws <see cref="ApiException"> otherwise.
            /// </summary>
            /// <returns></returns>
            public ContactModel Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<ContactModel>(RawContent, _jsonSerializerOptions)
                    : throw new ApiException((int)StatusCode, ReasonPhrase ?? "", StatusCode, Headers.ToMultimap());
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out ContactModel result)
            {
                result = default;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return IsOk;
            }

            /// <summary>
            /// Returns true if the response is 401 Unauthorized
            /// </summary>
            /// <returns></returns>
            public bool IsUnauthorized => 401 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 401 Unauthorized.
            /// Throws <see cref="ApiException"> otherwise.
            /// </summary>
            /// <returns></returns>
            public ProblemDetails Unauthorized()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsUnauthorized
                    ? System.Text.Json.JsonSerializer.Deserialize<ProblemDetails>(RawContent, _jsonSerializerOptions)
                    : throw new ApiException((int)StatusCode, ReasonPhrase ?? "", StatusCode, Headers.ToMultimap());
            }

            /// <summary>
            /// Returns true if the response is 401 Unauthorized and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryUnauthorized(out ProblemDetails result)
            {
                result = default;

                try
                {
                    result = Unauthorized();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)401);
                }

                return IsUnauthorized;
            }

            /// <summary>
            /// Returns true if the response is 400 BadRequest
            /// </summary>
            /// <returns></returns>
            public bool IsBadRequest => 400 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 400 BadRequest.
            /// Throws <see cref="ApiException"> otherwise.
            /// </summary>
            /// <returns></returns>
            public ProblemDetails BadRequest()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsBadRequest
                    ? System.Text.Json.JsonSerializer.Deserialize<ProblemDetails>(RawContent, _jsonSerializerOptions)
                    : throw new ApiException((int)StatusCode, ReasonPhrase ?? "", StatusCode, Headers.ToMultimap());
            }

            /// <summary>
            /// Returns true if the response is 400 BadRequest and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryBadRequest(out ProblemDetails result)
            {
                result = default;

                try
                {
                    result = BadRequest();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)400);
                }

                return IsBadRequest;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                //if (!suppressDefaultLog)
                //    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}
