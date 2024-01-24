// <auto-generated>
/*
 * Simplic.OxS.Logistics
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

namespace Simplic.OxS.SDK.Logistics
{
    //--Custom wrapper start
    /// <summary>
    /// Client to interact with the API endpoints of the logistics service.
    /// </summary>
    public interface IHookDefinitionClient
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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>HookDefinitionResponse</returns>
        HookDefinitionResponse Get();

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
                /// <returns>ApiResponse of HookDefinitionResponse</returns>
        ApiResponse<HookDefinitionResponse> GetWithHttpInfo();
         
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of HookDefinitionResponse</returns>
        Task<HookDefinitionResponse> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Simplic.OxS.SDK.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (HookDefinitionResponse)</returns>
        Task<ApiResponse<HookDefinitionResponse>> GetWithHttpInfoAsync(CancellationToken cancellationToken = default(CancellationToken));

    }

    /// <inheritdoc cref="IHookDefinitionClient">
    public class HookDefinitionClient : IHookDefinitionClient
    {
        private __HookDefinitionClient _internalClient;
        private HttpClient _httpClient;

        public HookDefinitionClient(string host, string? authorization = null)
        {
            _httpClient = new HttpClient() { BaseAddress = new Uri($"{host}/logistics-api/v1") };
            var jsonSerializerOptions = new JsonSerializerOptions { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };
            var jsonSerializerOptionsProvider = new JsonSerializerOptionsProvider(jsonSerializerOptions);
            var events = new HookDefinitionClientEvents();
            if (authorization is null)
            {
                _internalClient = new __HookDefinitionClient(_httpClient, jsonSerializerOptionsProvider, events, new NullTokenProvider<ApiKeyToken>());
            }
            else
            {
                var token = new ApiKeyToken(authorization, "Authorization", "");
                _internalClient = new __HookDefinitionClient(_httpClient, jsonSerializerOptionsProvider, events, new ApiKeyTokenProvider(new[] { token }));
            }
        }

        public HookDefinitionClient(Environment env, string? authorization = null)
            : this(
                env == Environment.Development
                    ? "https://dev-oxs.simplic.io"
                    : "https://oxs.simplic.io",
                authorization
            ) { }

        /// <inheritdoc />
        public string GetBasePath() => _httpClient.BaseAddress.ToString();

        /// <inheritdoc />
        public HookDefinitionResponse Get()
        {
            try
            {
                var response = _internalClient.GetAsync().GetAwaiter().GetResult();
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
        public ApiResponse<HookDefinitionResponse> GetWithHttpInfo()
        {
            try
            {
                var response = _internalClient.GetAsync().GetAwaiter().GetResult();
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                
                return new ApiResponse<HookDefinitionResponse>(response.StatusCode, response.Headers.ToMultimap(), response.Ok(), response.RawContent);
            }
            catch (ApiException e)
            {
                throw new ApiException(e.ErrorCode, FormatErrorMessage(e.Message, e.ErrorCode), e.ErrorContent, e.Headers);
            }
        } 

        /// <inheritdoc />
        public async Task<HookDefinitionResponse> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await _internalClient.GetAsync(cancellationToken);
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
        public async Task<ApiResponse<HookDefinitionResponse>> GetWithHttpInfoAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                var response = await _internalClient.GetAsync(cancellationToken);
                if (!response.IsSuccessStatusCode)
                    throw new ApiException((int)response.StatusCode, response.ReasonPhrase, response.StatusCode, response.Headers.ToMultimap());
                
                
                return new ApiResponse<HookDefinitionResponse>(response.StatusCode, response.Headers.ToMultimap(), response.Ok(), response.RawContent);
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
    internal interface __IHookDefinitionClient : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        HookDefinitionClientEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__HookDefinitionClient.IHookDefinitionClientHookDefinitionGetApiResponse"/>&gt;</returns>
        Task<__HookDefinitionClient.IHookDefinitionClientHookDefinitionGetApiResponse> GetAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__HookDefinitionClient.IHookDefinitionClientHookDefinitionGetApiResponse"/>?&gt;</returns>
        Task<__HookDefinitionClient.IHookDefinitionClientHookDefinitionGetApiResponse?> GetOrDefaultAsync(System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HookDefinitionClientEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs>? OnHookDefinitionGet;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs>? OnErrorHookDefinitionGet;

        internal void ExecuteOnHookDefinitionGet(__HookDefinitionClient.HookDefinitionClientHookDefinitionGetApiResponse apiResponse)
        {
            OnHookDefinitionGet?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorHookDefinitionGet(Exception exception)
        {
            OnErrorHookDefinitionGet?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    internal sealed partial class __HookDefinitionClient : __IHookDefinitionClient
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public HookDefinitionClientEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="HookDefinitionClient"/> class.
        /// </summary>
        /// <returns></returns>
        public __HookDefinitionClient(
            HttpClient httpClient,
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            HookDefinitionClientEvents hookDefinitionClientEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider
        )
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            HttpClient = httpClient;
            Events = hookDefinitionClientEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        private void AfterHookDefinitionGetDefaultImplementation(__HookDefinitionClient.IHookDefinitionClientHookDefinitionGetApiResponse apiResponseLocalVar)
        {
            bool suppressDefaultLog = false;
            AfterHookDefinitionGet(ref suppressDefaultLog, apiResponseLocalVar);
            //if (!suppressDefaultLog)
            //    Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        partial void AfterHookDefinitionGet(ref bool suppressDefaultLog, __HookDefinitionClient.IHookDefinitionClientHookDefinitionGetApiResponse apiResponseLocalVar);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        private void OnErrorHookDefinitionGetDefaultImplementation(Exception exception, string pathFormat, string path)
        {
            bool suppressDefaultLog = false;
            OnErrorHookDefinitionGet(ref suppressDefaultLog, exception, pathFormat, path);
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
        partial void OnErrorHookDefinitionGet(ref bool suppressDefaultLog, Exception exception, string pathFormat, string path);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__HookDefinitionClient.IHookDefinitionClientHookDefinitionGetApiResponse"/>&gt;</returns>
        public async Task<__HookDefinitionClient.IHookDefinitionClientHookDefinitionGetApiResponse?> GetOrDefaultAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetAsync(cancellationToken).ConfigureAwait(false);
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
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="__HookDefinitionClient.IHookDefinitionClientHookDefinitionGetApiResponse"/>&gt;</returns>
        public async Task<__HookDefinitionClient.IHookDefinitionClientHookDefinitionGetApiResponse> GetAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress!.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = HttpClient.BaseAddress.PathAndQuery + "/HookDefinition";

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

                        HookDefinitionClientHookDefinitionGetApiResponse apiResponseLocalVar = new HookDefinitionClientHookDefinitionGetApiResponse(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/HookDefinition", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterHookDefinitionGetDefaultImplementation(apiResponseLocalVar);

                        Events.ExecuteOnHookDefinitionGet(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorHookDefinitionGetDefaultImplementation(e, "/HookDefinition", uriBuilderLocalVar.Path);
                Events.ExecuteOnErrorHookDefinitionGet(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="IHookDefinitionClientHookDefinitionGetApiResponse"/>
        /// </summary>
        internal interface IHookDefinitionClientHookDefinitionGetApiResponse : Simplic.OxS.SDK.__IApiResponse, IOk<HookDefinitionResponse>
        {
            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            bool IsOk { get; }
        }

        /// <summary>
        /// The <see cref="HookDefinitionClientHookDefinitionGetApiResponse"/>
        /// </summary>
        internal partial class HookDefinitionClientHookDefinitionGetApiResponse : Simplic.OxS.SDK.__ApiResponse, IHookDefinitionClientHookDefinitionGetApiResponse
        {
            /// <summary>
            /// The <see cref="HookDefinitionClientHookDefinitionGetApiResponse"/>
            /// </summary>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public HookDefinitionClientHookDefinitionGetApiResponse(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
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
            public HookDefinitionResponse Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<HookDefinitionResponse>(RawContent, _jsonSerializerOptions)
                    : throw new ApiException((int)StatusCode, ReasonPhrase ?? "", StatusCode, Headers.ToMultimap());
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk(out HookDefinitionResponse result)
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
